using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ParsingBMXML
{
    public abstract class BMMaterial : IValidatableObject
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("ID")]
        public long Id { get; set; }

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
        /// Количество
        /// </summary>
        [XmlElement("Количество")]
        public double Quantity { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [XmlElement("Цена")]
        public double Price { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        [XmlElement("Стоимость")]
        public double Cost { get; set; }

        /// <summary>
        /// Толщина
        /// </summary>
        [XmlElement("Толщина")]
        public double Thickness { get; set; }

        /// <summary>
        /// Коэффициент
        /// </summary>
        [XmlElement("Коэффициент")]
        public double Coefficient { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Name))
                errors.Add(new ValidationResult("Не указано наименование материала"));

            if (string.IsNullOrWhiteSpace(this.Artikul))
                errors.Add(new ValidationResult("Не указан артикул материала"));

            if (this.Id < 0)
                errors.Add(new ValidationResult("ID материала должен быть больше 0"));

            return errors;
        }
    }

    /// <summary>
    /// Основной материал
    /// </summary>
    [XmlRoot("ОсновнойМатериал")]
    public class BasicMaterial : BMMaterial
    {

    }

    /// <summary>
    /// Сопутствующий материал
    /// </summary>
    [XmlRoot("СопутствующиеМатериалы")]
    public class RelatedMaterials
    {
        /// <summary>
        /// Список сопутствующего материала
        /// </summary>
        [XmlElement("СопутствующийМатериал")]
        public List<RelatedMaterial> RelatedMaterialList { get; set; }
    }

    /// <summary>
    /// Сопутствующий Материал
    /// </summary>
    [XmlRoot("СопутствующийМатериал")]
    public class RelatedMaterial : BMMaterial
    {
    }
}
