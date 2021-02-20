using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Proyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmotionsController : ControllerBase
    {
        [HttpGet]
        [Route("Con Numero")]
        public string Emocion(int suerte)
        {
            if (suerte == 0)
            {
                return "Sos una persona indiferente";
            }
            if (suerte == 1)
            {
                return "Sos una persona Feliz :)";
            }
            if (suerte == 3)
            {
                return "Sos una persona Aburrida";
            }
            return "Estoy muy ocupado, no te puedo atender este momento";
        }
        [HttpPost]
        [Route("Con Numero")]
        public string Emocion2([FromHeader] int suerte)
        {
            if (suerte == 0)
            {
                return "Sos una persona indiferente";
            }
            if (suerte == 1)
            {
                return "Sos una persona Feliz :)";
            }
            if (suerte == 3)
            {
                return "Sos una persona Aburrida";
            }
            return "Estoy muy ocupado, no te puedo atender este momento";
        }
        [HttpPost]
        [Route ("Con modelo")]
        public string Emocion3([FromBody] Luck luck)
    }
}
