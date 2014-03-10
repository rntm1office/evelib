﻿using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Core {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class FactionWarTopStats : XmlElement {
        [XmlElement("characters")]
        public CharacterStats Characters { get; set; }

        [XmlElement("corporations")]
        public CharacterStats Corporations { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class CharacterEntry {
            [XmlAttribute("characterID")]
            public long CharacterId { get; set; }

            [XmlAttribute("characterName")]
            public string CharacterName { get; set; }

            [XmlAttribute("kills")]
            public int Kills { get; set; }
        }

        public class CharacterStats : XmlElement, IXmlSerializable {
            [XmlElement("rowset")]
            public RowCollection<CharacterEntry> KillsYesterday { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CharacterEntry> KillsLastWeek { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CharacterEntry> KillsTotal { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CharacterEntry> VictoryPointsYesterday { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CharacterEntry> VictoryPointsLastWeek { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CharacterEntry> VictoryPointsTotal { get; set; }

            public XmlSchema GetSchema() {
                throw new NotImplementedException();
            }

            public void ReadXml(XmlReader reader) {
                setRoot(reader);
                KillsYesterday = deserializeRowSet(getRowSetReader("KillsYesterday"), new CharacterEntry());
                KillsLastWeek = deserializeRowSet(getRowSetReader("KillsLastWeek"), new CharacterEntry());
                KillsTotal = deserializeRowSet(getRowSetReader("KillsTotal"), new CharacterEntry());
                VictoryPointsYesterday = deserializeRowSet(getRowSetReader("VictoryPointsYesterday"),
                    new CharacterEntry());
                VictoryPointsLastWeek = deserializeRowSet(getRowSetReader("VictoryPointsLastWeek"), new CharacterEntry());
                VictoryPointsTotal = deserializeRowSet(getRowSetReader("VictoryPointsTotal"), new CharacterEntry());
            }

            public void WriteXml(XmlWriter writer) {
                throw new NotImplementedException();
            }
        }

        [Serializable]
        [XmlRoot("row")]
        public class CorporationEntry {
            [XmlAttribute("factionID")]
            public long FactionId { get; set; }

            [XmlAttribute("factionName")]
            public string FactionName { get; set; }

            [XmlAttribute("kills")]
            public string Kills { get; set; }
        }

        public class CorporationStats : XmlElement, IXmlSerializable {
            [XmlElement("rowset")]
            public RowCollection<CorporationEntry> KillsYesterday { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CorporationEntry> KillsLastWeek { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CorporationEntry> KillsTotal { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CorporationEntry> VictoryPointsYesterday { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CorporationEntry> VictoryPointsLastWeek { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CorporationEntry> VictoryPointsTotal { get; set; }

            public XmlSchema GetSchema() {
                throw new NotImplementedException();
            }

            public void ReadXml(XmlReader reader) {
                KillsYesterday = deserializeRowSet(getRowSetReader("KillsYesterday"), new CorporationEntry());
                KillsLastWeek = deserializeRowSet(getRowSetReader("KillsLastWeek"), new CorporationEntry());
                KillsTotal = deserializeRowSet(getRowSetReader("KillsTotal"), new CorporationEntry());
                VictoryPointsYesterday = deserializeRowSet(getRowSetReader("VictoryPointsYesterday"),
                    new CorporationEntry());
                VictoryPointsLastWeek = deserializeRowSet(getRowSetReader("VictoryPointsLastWeek"),
                    new CorporationEntry());
                VictoryPointsTotal = deserializeRowSet(getRowSetReader("VictoryPointsTotal"), new CorporationEntry());
            }

            public void WriteXml(XmlWriter writer) {
                throw new NotImplementedException();
            }
        }
    }
}