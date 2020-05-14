﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    /// <summary>
    /// Объект Изделия
    /// </summary>
    [XmlRoot("Объект")]
    public class ObjectElement : Element
    {
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
        /// Прямоугольная
        /// </summary>
        [XmlElement("Прямоугольная")]
        public string Rectangular { get; set; }

        /// <summary>
        /// СопутствующиеМатериалы
        /// </summary>
        [XmlElement("СопутствующиеМатериалы")]
        public RelatedMaterials RelatedMaterials { get; set; }

        /// <summary>
        /// ОсновнойМатериал
        /// </summary>
        [XmlElement("ОсновнойМатериал")]
        public BasicMaterial BasicMaterial { get; set; }

        /// <summary>
        /// СписокКромок1
        /// </summary>
        [XmlElement("СписокКромок1")]
        public Edge1 Edge1 { get; set; }

        /// <summary>
        /// СписокКромок2
        /// </summary>
        [XmlElement("СписокКромок2")]
        public Edge2 Edge2 { get; set; }

        /// <summary>
        /// СписокКромок3
        /// </summary>
        [XmlElement("СписокКромок3")]
        public Edge3 Edge3 { get; set; }

        /// <summary>
        /// СписокКромок4
        /// </summary>
        [XmlElement("СписокКромок4")]
        public Edge4 Edge4 { get; set; }

        /// <summary>
        /// Отверстия
        /// </summary>
        [XmlElement("Отверстия")]
        public PartsHoles PartsHoles
        {
            get; set;
        }

        /// <summary>
        /// ПользовательскиеСвойства
        /// </summary>
        [XmlElement("ПользовательскиеСвойства")]
        public UserProperties UserProperties
        {
            get; set;
        }
    }
}