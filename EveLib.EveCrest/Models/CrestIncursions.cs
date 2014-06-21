﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace eZet.EveLib.Modules.Models {
    [DataContract]
    public class CrestIncursions : CrestCollectionResponse {
        public enum IncursionState {
            [DataMember(Name = "Established")] Established,
            [DataMember(Name = "Mobilizing")] Mobilizing,
            [DataMember(Name = "Withdrawing")] Withdrawing,
        }

        [DataMember(Name = "items")]
        public IList<Incursion> Incursions { get; set; }

        public class Incursion {
            [DataMember(Name = "influence")]
            public double Influence { get; set; }

            [DataMember(Name = "hasBoss")]
            public bool HasBoss { get; set; }

            [DataMember(Name = "state")]
            public IncursionState State { get; set; }

            [DataMember(Name = "stagingSolarSystem")]
            public CrestNamedEntity StatingSolarSystem { get; set; }

            [DataMember(Name = "constellation")]
            public CrestNamedEntity Constellation { get; set; }
        }
    }
}