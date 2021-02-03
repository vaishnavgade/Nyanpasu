using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyanpasu.Controllers
{
    [ApiController]
    [Route("api/nyan")]
    public class NyanController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllNyans()
        {
            try
            {
                return Ok("All Nyans");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
