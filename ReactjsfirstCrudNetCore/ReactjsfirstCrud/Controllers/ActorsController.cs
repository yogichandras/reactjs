using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactjsfirstCrud.Models;
using static ReactjsfirstCrud.Models.Mainmodels;

namespace ReactjsfirstCrud.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {

            _context = context;
        }

        //[HttpGet]
        //public IEnumerable<actor><Actor> GetActors()
        [HttpGet("[action]")]
        public IEnumerable<ActorModel> Index()

        {
            return _context.Actors;
        }
    }
}
