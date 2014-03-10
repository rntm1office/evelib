﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Core {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class TypeName : XmlElement {
        [XmlElement("rowset")]
        public RowCollection<TypeData> Types { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class TypeData {
            [XmlAttribute("typeID")]
            public long TypeId { get; set; }

            [XmlAttribute("typeName")]
            public string TypeName { get; set; }
        }
    }
}