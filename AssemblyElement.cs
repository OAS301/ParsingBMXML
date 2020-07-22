using ParsingBMXML.BasicClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ParsingBMXML
{
    /// <summary>
    /// Сборка Изделия
    /// </summary>
    [XmlRoot("Сборка")]
    public class AssemblyElement : Element, IModelElements
    {
        /// <summary>
        /// Цена
        /// </summary>
        [XmlElement("Цена")]
        public string Price { get; set; }

        /// <summary>
        /// Список элементов
        /// </summary>
        [XmlElement("СписокЭлементов")]
        public ModelElements ModelElements
        {
            get; set;
        }

        public ModelElements GetModelElements()
        {
            return ModelElements;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (this.ModelElements == null)
                errors.Add(new ValidationResult(string.Format("У сборки {0} отсутствует список элементов", this.Name)));

            return errors;
        }
    }
}
