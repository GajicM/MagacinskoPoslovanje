
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagacinController
    {
        private readonly ILogger<MagacinController> _logger;
        private Context context;
        public MagacinController(ILogger<MagacinController> logger)
        {
            _logger = logger;
            context = new Context();
        }
        [HttpGet]
        public List<Magacin> Get()
        {
            var rng = new Random();
            return GetAllMagacins();
        }

        private List<Magacin> GetAllMagacins()
        {
            return context.Magacin.ToList<Magacin>();
        }
        [HttpPost]
        public string New(string lokacija,string naziv)
        {
            try
            {
            
                Magacin magacin = new Magacin
                {
                    Naziv = naziv,
                    Lokacija = lokacija
                };
                context.Magacin.Add(magacin);
                context.SaveChanges();
            }
            catch(Exception e )
            {
                return e.Message;
            }
            return "Succesfully added";

        }
        [HttpDelete]
        public string DeleteById(long id)
        {
            try
            {
                var magacin=context.Magacin.Find(id);  
               
               context.Remove(magacin);
                context.SaveChanges();

            }
            catch (Exception e)
            {
                return e.Message;
            }


            return "Deleted magacin w/ id= " +id;
        }

        [HttpPut]
        public string UpdateById(long id,string novaLokacija,string novNaziv) {
            try
            {
                var magacin = context.Magacin.Find(id);
                if (novaLokacija == null)
                {
                    novaLokacija = magacin.Lokacija;
                }
                if(novNaziv== null)
                {
                    novNaziv = magacin.Naziv;
                }
                magacin.Naziv = novNaziv;
                magacin.Lokacija = novaLokacija;
                context.SaveChanges();
            }catch(Exception e){
                return e.Message;
            }
            return "id=" + id + "updated";
        
        
        
        
        
        }
    }
}
