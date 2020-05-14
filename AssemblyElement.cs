using ParsingBMXML.BasicClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    /// <summary>
    /// Сборка Изделия
    /// </summary>
    [XmlRoot("Сборка")]
    public class AssemblyElement : Element, IProductElements
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
        public ProductElements ProductElements
        {
            get; set;
        }

        public ProductElements GetProductElements()
        {
            return ProductElements;
        }
    }
}
