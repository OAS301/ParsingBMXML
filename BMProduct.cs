using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using ParsingBMXML.BasicClass;

namespace ParsingBMXML
{
    /// <summary>
    /// Изделие проекта
    /// </summary>
    [XmlRoot("Изделие")]
    public class BMProduct : IProductElements
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [XmlElement("Наименование")]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Артикул
        /// </summary>
        [XmlElement("Артикул")]
        public string Artikul
        {
            get; set;
        }

        /// <summary>
        /// Количество
        /// </summary>
        [XmlElement("Количество")]
        public long Quantity
        {
            get; set;
        }

        /// <summary>
        /// Цена
        /// </summary>
        [XmlElement("Цена")]
        public string Price { get; set; }

        /// <summary>
        /// СписокЭлементов
        /// </summary>
        [XmlElement("СписокЭлементов")]
        public ProductElements ProductElementList
        {
            get; set;
        }

        /// <summary>
        /// Заказ
        /// </summary>
        [XmlElement("Заказ")]
        public string Order
        {
            get; set;
        }

        /// <summary>
        /// Разработчик
        /// </summary>
        [XmlElement("Разработчик")]
        public string Developer
        {
            get; set;
        }

        public ProductElements GetProductElements()
        {
            return ProductElementList;
        }
    }
}
