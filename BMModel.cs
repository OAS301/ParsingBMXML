using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using ParsingBMXML.BasicClass;
using System.ComponentModel.DataAnnotations;

namespace ParsingBMXML
{
    /// <summary>
    /// Модель проекта
    /// </summary>
    [XmlRoot("Изделие")]
    public class BMModel : IModelElements, IValidatableObject
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
        public ModelElements ModelElementList
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

        public ModelElements GetModelElements()
        {
            return ModelElementList;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Name))
                errors.Add(new ValidationResult("Не указано наименование модели"));

            if (string.IsNullOrWhiteSpace(this.Artikul))
                errors.Add(new ValidationResult("Не указан артикул модели"));

            return errors;
        }
    }

    /// <summary>
    /// СписокЭлементов модели
    /// </summary>
    [XmlRoot("СписокЭлементов")]
    public class ModelElements
    {
        /// <summary>
        /// Список объектов изделия
        /// </summary>
        [XmlElement("Объект")]
        public List<ObjectElement> ObjectElementList { get; set; }

        /// <summary>
        /// Список сборок
        /// </summary>
        [XmlElement("Сборка")]
        public List<AssemblyElement> AssemblyElementList { get; set; }

        /// <summary>
        /// Список блоков
        /// </summary>
        [XmlElement("Блок")]
        public List<BlockElement> BlockElementList { get; set; }
    }
}
