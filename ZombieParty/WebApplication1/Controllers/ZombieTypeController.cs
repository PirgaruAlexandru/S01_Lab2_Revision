using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ZombieTypeController : Controller
    {
        public IActionResult Index()
        {



            this.ViewBag.MaListe = new List<ZombieType>()
            {

                new ZombieType(){TypeName= "Virus", Id= 1},
                new ZombieType(){TypeName= "Contact", Id= 2}


            };





            return View();
        }
    }
}
