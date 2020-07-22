using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ParsingBMXML
{
    public abstract class Element : IValidatableObject
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [XmlElement("Наименование")]
        public string Name { get; set; }

        /// <summary>
        /// Тип Объекта
        /// </summary>
        [XmlElement("ТипОбъекта")]
        public string ElementType { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [XmlElement("Количество")]
        public double Quantity { get; set; }

        /// <summary>
        /// Позиция
        /// </summary>
        [XmlElement("Позиция")]
        public string Position { get; set; }

        public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}
