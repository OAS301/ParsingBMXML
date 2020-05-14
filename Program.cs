using System;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using ParsingBMXML.BasicClass;

namespace ParsingBMXML
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(BMPrоject));
                using (StreamReader sr = new StreamReader(@"C:\Users\VS\Desktop\0000000000002SR72_60002SR72_60.000_Спецификации2.xml"))
                {
                    BMPrоject project = (BMPrоject)xmlSerializer.Deserialize(sr);
                    foreach (BMProduct product in project.ProductList)
                    {
                        List<ObjectElement> listObject = new List<ObjectElement>();
                        listObject.AddRange(GetObjects(product));
                        Console.WriteLine($"Количество деталей: {listObject.Count}");
                        foreach (var item in listObject)
                        {
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

        internal static List<ObjectElement> GetObjects(IProductElements element)
        {
            var list = element.GetProductElements();
            List<ObjectElement> listObject = new List<ObjectElement>();
            foreach (var item in list.AssemblyElementList)
            {
                listObject.AddRange(item.ProductElements.ObjectElementList);
                if (item.ProductElements.BlockElementList.Any())
                {
                    listObject.AddRange(GetObjects(item));
                }
            }

            foreach (var item in list.BlockElementList)
            {
                listObject.AddRange(item.ProductElements.ObjectElementList);
                if (item.ProductElements.AssemblyElementList.Any())
                {
                    listObject.AddRange(GetObjects(item));
                }
            }
            return listObject;
        }
    }
}
