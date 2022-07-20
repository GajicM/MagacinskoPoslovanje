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
    public class Firma : CoreObject
    {
        public bool Dobavljac { get; set; }
        public bool Proizvodjac { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<Promet> Prometi { get; set; }

        [JsonIgnore]
        [XmlIgnore]

        public List<Racun> Racuni { get; set; }
        public Firma()
        {
            this.Prometi = new List<Promet>();
            this.Racuni = new List<Racun>();
        }
    }
}
