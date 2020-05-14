using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    /// <summary>
    /// Параметры кромки
    /// </summary>
    [XmlRoot("Кромка")]
    public class BMEdge
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [XmlElement("Наименование")]
        public string Name { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        [XmlElement("Код")]
        public string Artikul { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        [XmlElement("Длина")]
        public double Length { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        [XmlElement("Ширина")]
        public double Width { get; set; }

        /// <summary>
        /// Толщина
        /// </summary>
        [XmlElement("Толщина")]
        public double Thickness { get; set; }

        /// <summary>
        /// Обозначение
        /// </summary>
        [XmlElement("Обозначение")]
        public string Designation { get; set; }
    }

    /// <summary>
    /// СписокКромок1
    /// </summary>
    [XmlRoot("СписокКромок1")]
    public class Edge1
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }

    /// <summary>
    /// СписокКромок2
    /// </summary>
    [XmlRoot("СписокКромок2")]
    public class Edge2
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }

    /// <summary>
    /// СписокКромок3
    /// </summary>
    [XmlRoot("СписокКромок3")]
    public class Edge3
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }

    /// <summary>
    /// СписокКромок4
    /// </summary>
    [XmlRoot("СписокКромок4")]
    public class Edge4
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }
}
