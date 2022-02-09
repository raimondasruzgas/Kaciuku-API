using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/")]
    public class SuniukuController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public Suniukas GautiSuniuka()
        {
            int RamdomNr = new Random().Next(0, DB.Suniukai.Count);
            return DB.Suniukai[RamdomNr];
        }
    }
}