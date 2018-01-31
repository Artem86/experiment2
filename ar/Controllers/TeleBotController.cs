using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ar.Services;
using Telegram.Bot.Types;

namespace ar.Controllers
{
    public class TeleBotController : Controller
    {
        private readonly IUpdateService _updateService;

        public TeleBotController(IUpdateService updateService)
        {
            _updateService = updateService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update([FromBody]Update message)
        {
            _updateService.EchoAsync(message);
            return Ok();
        }
    }
}