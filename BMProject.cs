using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    /// <summary>
    /// Проект
    /// </summary>
    [XmlRoot("Проект")]
    public class BMPrоject
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [XmlAttribute("Наименование")]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Номер
        /// </summary>
        [XmlAttribute("Номер")]
        public string Number
        {
            get; set;
        }

        /// <summary>
        /// Версия
        /// </summary>
        [XmlAttribute("Версия")]
        public string Version
        {
            get; set;
        }

        /// <summary>
        /// Список изделий
        /// </summary>
        [XmlElement("Изделие")]
        public List<BMModel> ModelList
        {
            get; set;
        }
    }
}
