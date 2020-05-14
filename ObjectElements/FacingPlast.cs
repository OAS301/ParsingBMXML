using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML.ObjectElements
{
    /// <summary>
    /// ОблицовкаПласти1
    /// </summary>
    [XmlRoot("ОблицовкаПласти1")]
    public class FacingPlast1
    {
        /// <summary>
        /// Список пластей
        /// </summary>
        [XmlElement("Пласть")]
        public List<Plast> PlastList { get; set; }
    }

    /// <summary>
    /// ОблицовкаПласти2
    /// </summary>
    [XmlRoot("ОблицовкаПласти2")]
    public class FacingPlast2
    {
        /// <summary>
        /// Список пластей
        /// </summary>
        [XmlElement("Пласть")]
        public List<Plast> PlastList { get; set; }
    }

    /// <summary>
    /// ОблицовкаПласти2
    /// </summary>
    [XmlRoot("Пласть")]
    public class Plast 
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
        /// ОриентацияТекстуры
        /// </summary>
        [XmlElement("ОриентацияТекстуры")]
        public string Texture { get; set; }

        /// <summary>
        /// Толщина
        /// </summary>
        [XmlElement("Толщина")]
        public double Thickness { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [XmlElement("Количество")]
        public double Quantity { get; set; }
    }
}
