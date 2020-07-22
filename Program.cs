using System;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using ParsingBMXML.BasicClass;
using System.ComponentModel.DataAnnotations;

namespace ParsingBMXML
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(BMPrоject));
                using (StreamReader sr = new StreamReader(@"C:\Users\VS\Desktop\0000000000002SR72_60002SR72_60.000_Спецификации2.xml")) {
                    BMPrоject project = (BMPrоject)xmlSerializer.Deserialize(sr);
                    foreach (BMModel product in project.ModelList) {
                        var results = new List<ValidationResult>();
                        var context = new ValidationContext(product);
                        if (!Validator.TryValidateObject(product, context, results, true)) {
                            foreach (var error in results) {
                                  Console.WriteLine(error.ErrorMessage);
                            }
                        }
                        List<ObjectElement> listObject = new List<ObjectElement>();
                        listObject.AddRange(GetObjects(product));
                        Console.WriteLine($"Количество деталей: {listObject.Count}");
                        foreach (var item in listObject) {
                            Console.WriteLine($"Позиция детали: {item.Position}");
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}: {e.GetBaseException()} ");
            }
            Console.ReadLine();
        }

        internal static List<ObjectElement> GetObjects(IModelElements element)
        {
            List<ObjectElement> listObject = new List<ObjectElement> ();
			var list = element.GetModelElements ();
			listObject.AddRange (list.ObjectElementList);
			//в сборках
			foreach (var item in list.AssemblyElementList) {
				listObject.AddRange (GetObjects (item));
			}
			//в блоках
			foreach (var item in list.BlockElementList) {
				listObject.AddRange (GetObjects (item));
			}
			return listObject;
        }
    }
}
