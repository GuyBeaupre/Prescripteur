using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prescripteur.Api.Models;

namespace Prescripteur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RubriqueController : ControllerBase 
    {
        [HttpGet]
        public List<Rubrique> GetRubriques()
        {
            return new List<Rubrique>()
            {
                new() {Id = 1, Libelle = "Une rubrique" },
                new() {Id = 2, Libelle = "Deuxième rubrique"}
            };
        }
    }
}
