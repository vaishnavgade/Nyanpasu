using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Nyanpasu.Models;

namespace Nyanpasu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NyanController : ControllerBase
    {
        // TODO: Replace with database and extract this into a service
        private List<Nyan> _nyans;

        public NyanController()
        {
            this._nyans = new List<Nyan>
            {
                new Nyan(){Id = 1, Content= "Test Comment1", Likes= 3},
                new Nyan(){Id = 2, Content= "Test Comment2", Likes= 4},
                new Nyan(){Id = 3, Content= "Test Comment3", Likes= 5},
            };
        }

        /// <summary>
        /// GET api/Nyan
        /// </summary>
        /// <returns>All existing Nyans</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllNyans()
        {
            try
            {
                return Ok(this._nyans);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
