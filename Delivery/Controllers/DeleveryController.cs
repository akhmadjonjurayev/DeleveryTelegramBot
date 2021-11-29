using Delivery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Delivery.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeleveryController : ControllerBase
    {
        private readonly DeleveryDB _deleveryDB;
        public DeleveryController(DeleveryDB deleveryDB)
        {
            this._deleveryDB = deleveryDB;
        }

        [HttpPost]
        public IActionResult GetInformation([FromBody]Update update)
        {
            return Ok();
        }
    }
}
