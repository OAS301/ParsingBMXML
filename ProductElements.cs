using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ParsingBMXML
{
    /// <summary>
    /// СписокЭлементов Изделия
    /// </summary>
    [XmlRoot("СписокЭлементов")]
    public class ProductElements
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
        public IEnumerable<object> AssemblyElements { get; internal set; }
    }
}
