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
    public class Proizvod : CoreObject
    {
        public string Naziv { get; set; }
        public double Cena { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<StavkaMagacina> StavkeMagacina { get; set; }
        public Proizvod()
        {
            this.StavkeMagacina = new List<StavkaMagacina>();
        }
    }
}
