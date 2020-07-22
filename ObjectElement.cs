using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using ParsingBMXML.ObjectElements;
using System.ComponentModel.DataAnnotations;

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
        /// ОбщаяТолщина
        /// </summary>
        [XmlElement("ОбщаяТолщина")]
        public double Thickness { get; set; }

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
        /// СписокКромокСМЧертеж
        /// </summary>
        [XmlElement("СписокКромокСМЧертеж")]
        public CurvedEdge CurvedEdge { get; set; }

        /// <summary>
        /// Отверстия
        /// </summary>
        [XmlElement("Отверстия")]
        public PartsHoles PartsHoles
        {
            get; set;
        }

        /// <summary>
        /// СписокПазов
        /// </summary>
        [XmlElement("СписокПазов")]
        public Grooves Grooves
        {
            get; set;
        }

        /// <summary>
        /// ОблицовкаПласти1
        /// </summary>
        [XmlElement("ОблицовкаПласти1")]
        public FacingPlast1 FacingPlast1 { get; set; }

        /// <summary>
        /// ОблицовкаПласти1
        /// </summary>
        [XmlElement("ОблицовкаПласти2")]
        public FacingPlast2 FacingPlast2 { get; set; }

        /// <summary>
        /// ПользовательскиеСвойства
        /// </summary>
        [XmlElement("ПользовательскиеСвойства")]
        public UserProperties UserProperties
        {
            get; set;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (this.BasicMaterial == null)
                errors.Add(new ValidationResult(string.Format("Не указан основной материал объекта {0}", this.Artikul)));

            if (string.IsNullOrEmpty(this.Name))
                errors.Add(new ValidationResult(string.Format("Не указано наименование объекта {0}", this.Artikul)));

            return errors;
        }
    }
}
