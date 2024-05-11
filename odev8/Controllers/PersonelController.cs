using Microsoft.AspNetCore.Mvc;
using odev8.Models;

namespace odev8.Controllers
{
    [ApiController]
    [Route("controller")]
public class PersonelController : Controllerbase
{
    static List<Personel> personeller = new List<Personel>{
        new Personel{Id=1,AdSoyad="Yusuf Doğan"},
        new Personel{Id=2,AdSoyad="Halil Yildiz"},
        new Personel{Id=3,AdSoyad="Furkan Yilmaz"},
    };
    [HttpGet]
    public List<Personel> Get(){
        
    return personeller;
}
    [HttpGet("{id}")]
    public Personel Get (int id){
        return personeller.FirstOrDefault(o==>o.Id==id);
        }
        [HttpPost]
        public Personel Post(Personel personel){
            personel.Add(personel);
            return personel;
        }
}
}