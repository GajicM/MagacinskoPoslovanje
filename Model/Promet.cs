using MagacinskoPoslovanje.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MagacinskoPoslovanje
{
    [DataContract]
    public class Promet : CoreObject
    {
        [JsonIgnore]
        [XmlIgnore]
        public Firma Firma { get; set; }
        public long FirmaId { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public StavkaMagacina StavkaMagacina { get; set; }
        public long StavkaMagacinaId { get; set; }
        public long Kolicina { get; set; }
        public TipPrometa TipPrometa {get; set;}

    }
}
