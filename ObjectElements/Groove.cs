using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML.ObjectElements
{
    /// <summary>
    /// СписокПазов
    /// </summary>
    [XmlRoot("СписокПазов")]
    public class Grooves
    {
        /// <summary>
        /// Паз
        /// </summary>
        [XmlElement("Паз")]
        public List<Grooves> GrooveList { get; set; }
    }

    /// <summary>
    /// Паз
    /// </summary>
    [XmlRoot("Паз")]
    public class Groove
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [XmlElement("Название")]
        public string Name { get; set; }

        /// <summary>
        /// Обозначение
        /// </summary>
        [XmlElement("Обозначение")]
        public string Designation { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [XmlElement("Количество")]
        public double Quantity { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        [XmlElement("Длина")]
        public double Length { get; set; }
    }
}
