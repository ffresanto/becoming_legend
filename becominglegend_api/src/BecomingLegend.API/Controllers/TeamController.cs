using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BecomingLegend.API.Data;
using BecomingLegend.API.Models;
using BecomingLegend.API.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BecomingLegend.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamController : ControllerBase
{
    private readonly MessageDefault message;
    private readonly DataContext _context;

    public TeamController(DataContext context)
        {
            _context = context;
        }

    [HttpGet]

    public IEnumerable<Team> Get()
    {
        return _context.Team;
    }

    



}
