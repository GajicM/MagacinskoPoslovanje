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
    public class StavkaMagacina : CoreObject
    {
        [JsonIgnore]
        [XmlIgnore]
        public Magacin Magacin { get; set; }
        public long MagacinId { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public Proizvod Proizvod { get; set; }
        public long ProizvodId { get; set; }

        public int Kolicina { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<Promet> Prometi { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<StavkaRacuna> StavkeRacuna { get; set; }
        public StavkaMagacina()
        {
            this.Prometi = new List<Promet>();
            this.StavkeRacuna = new List<StavkaRacuna>();
        }
    }
}
