using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    public abstract class Element
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
    }
}
