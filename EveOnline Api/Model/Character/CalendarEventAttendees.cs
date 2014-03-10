﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Character {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class CalendarEventAttendees : XmlElement {
        [XmlElement("rowset")]
        public RowCollection<Attendee> Attendees { get; set; }


        [Serializable]
        [XmlRoot("row")]
        public class Attendee {
            [XmlAttribute("characterID")]
            public long CharacterId { get; set; }

            [XmlAttribute("characterName")]
            public string CharacterName { get; set; }

            [XmlAttribute("response")]
            public EventResponse Response { get; set; }
        }
    }
}