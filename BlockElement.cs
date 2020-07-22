using ParsingBMXML.BasicClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    /// <summary>
    /// Блок Изделия
    /// </summary>
    [XmlRoot("Блок")]
    public class BlockElement : Element, IModelElements
    {
        /// <summary>
        /// Ширина
        /// </summary>
        [XmlElement("Ширина")]
        public double Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        [XmlElement("Высота")]
        public double Height { get; set; }

        /// <summary>
        /// Глубина
        /// </summary>
        [XmlElement("Глубина")]
        public double Depth { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [XmlElement("Цена")]
        public string Price { get; set; }

        /// <summary>
        /// Список элементов
        /// </summary>
        [XmlElement("СписокЭлементов")]
        public ModelElements ModelElements { get; set; }

        public ModelElements GetModelElements()
        {
            return ModelElements;
        }
    }
}
