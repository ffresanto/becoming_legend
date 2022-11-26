using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BecomingLegend.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BecomingLegend.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchievementController : ControllerBase
    {
        [HttpGet]
        public Achievement get(){
            return new Achievement();
        }
    }
}