using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    /// <summary>
    /// Отверстия в панели
    /// </summary>
    [XmlRoot("Отверстия")]
    public class PartsHoles
    {
        /// <summary>
        /// Список отверстий
        /// </summary>
        [XmlElement("Отверстие")]
        public List<PartsHole> PartsHoleList { get; set; }
    }

    /// <summary>
    /// Отверстие в панели
    /// </summary>
    [XmlRoot("Отверстие")]
    public class PartsHole
    {
        /// <summary>
        /// ПозицияX
        /// </summary>
        [XmlElement("ПозицияX")]
        public double XPosition
        {
            get; set;
        }

        /// <summary>
        /// ПозицияY
        /// </summary>
        [XmlElement("ПозицияY")]
        public double YPosition
        {
            get; set;
        }

        /// <summary>
        /// ПозицияZ
        /// </summary>
        [XmlElement("ПозицияZ")]
        public double ZPosition
        {
            get; set;
        }

        /// <summary>
        /// Диаметр
        /// </summary>
        [XmlElement("Диаметр")]
        public double Diameter
        {
            get; set;
        }

        /// <summary>
        /// Тип отверстия
        /// </summary>
        [XmlElement("Тип")]
        public string HoleType
        {
            get; set;
        }

        /// <summary>
        /// Глубина
        /// </summary>
        [XmlElement("Глубина")]
        public double Depth
        {
            get; set;
        }

        /// <summary>
        /// НаправлениеX
        /// </summary>
        [XmlElement("НаправлениеX")]
        public double XDirection
        {
            get; set;
        }

        /// <summary>
        /// НаправлениеY
        /// </summary>
        [XmlElement("НаправлениеY")]
        public double YDirection
        {
            get; set;
        }

        /// <summary>
        /// НаправлениеZ
        /// </summary>
        [XmlElement("НаправлениеZ")]
        public double ZDirection
        {
            get; set;
        }
    }
}
