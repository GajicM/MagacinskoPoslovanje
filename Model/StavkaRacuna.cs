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
    public class StavkaRacuna : CoreObject
    {
        public int Kolicina { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public StavkaMagacina StavkaMagacina {get; set; }
        public long StavkaMagacinaId { get; set; }
    
        [JsonIgnore]
        [XmlIgnore]
        public Racun Racun { get; set; }
        public long RacunId { get; set; }

    }
}
