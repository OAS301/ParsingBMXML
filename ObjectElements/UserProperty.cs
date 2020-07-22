using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ParsingBMXML
{
    /// <summary>
    /// ПользовательскиеСвойства
    /// </summary>
    [XmlRoot("ПользовательскиеСвойства")]
    public class UserProperties
    {
        /// <summary>
        /// Список отверстий
        /// </summary>
        [XmlElement("Свойство")]
        public List<Property> PropertyList { get; set; }
    }

    /// <summary>
    /// Свойство
    /// </summary>
    [XmlRoot("Свойство")]
    public class Property
    {
        /// <summary>
        /// Имя
        /// </summary>
        [XmlElement("Имя")]
        public string Name { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        [XmlElement("Значение")]
        public string Value { get; set; }
    }
}
