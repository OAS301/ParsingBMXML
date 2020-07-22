using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using ParsingBMXML.ObjectElements;

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
    
    public interface IBMEdge
    {
    	List<BMEdge> EdgeList { get; set; }
    }
    
    /// <summary>
    /// СписокКромок1
    /// </summary>
    [XmlRoot("СписокКромок1")]
    public class Edge1 : IBMEdge
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }

    /// <summary>
    /// СписокКромок2
    /// </summary>
    [XmlRoot("СписокКромок2")]
    public class Edge2 : IBMEdge
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }

    /// <summary>
    /// СписокКромок3
    /// </summary>
    [XmlRoot("СписокКромок3")]
    public class Edge3 : IBMEdge
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }

    /// <summary>
    /// СписокКромок4
    /// </summary>
    [XmlRoot("СписокКромок4")]
    public class Edge4 : IBMEdge
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }
    
    /// <summary>
    /// СписокКромокСМЧертеж
    /// </summary>
    [XmlRoot("СписокКромокСМЧертеж")]
    public class CurvedEdge : IBMEdge
    {
        [XmlElement("Кромка")]
        public List<BMEdge> EdgeList { get; set; }
    }
}
