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
    public class Racun : CoreObject
    {
        public DateTime Date { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public Firma Firma { get; set; }
        public long FirmaId { get; set; }

        public TipPrometa TipPrometa { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<StavkaRacuna> StavkeRacuna { get; set; }
        public Racun()
        {
            this.StavkeRacuna = new List<StavkaRacuna>();
        }
    }
}
