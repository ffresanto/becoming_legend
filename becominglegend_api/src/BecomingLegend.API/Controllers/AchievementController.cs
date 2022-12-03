using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BecomingLegend.API.Data;
using BecomingLegend.API.Models;
using BecomingLegend.API.Util;
using Microsoft.AspNetCore.Mvc;

namespace BecomingLegend.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchievementController : ControllerBase
    {
        private readonly MessageDefault message;
        private readonly DataContext _context;
        public AchievementController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Achievement> Get()
        {
            return _context.Achievements;
        }

        [HttpGet("{id}")]
        public Achievement Get(int id)
        {
            return _context.Achievements.FirstOrDefault(dados => dados.Id == id);
        }

        [HttpPost]
        public IEnumerable<Achievement> Post(Achievement achievement)
        {
            _context.Achievements.Add(achievement);

            if (_context.SaveChanges() > 0)
            {
                return _context.Achievements;
            }
            else
            {
                throw new Exception(message.apiError);
            }
        }

        [HttpPut("{id}")]
        public Achievement Put(int id, Achievement achievement){

            if (achievement.Id != id ) throw new Exception(message.apiError);

            _context.Update(achievement);

            if(_context.SaveChanges() > 0)
                return _context.Achievements.FirstOrDefault(dados => dados.Id == id);
            else
                return new Achievement();
            
        }

        [HttpDelete("{id}")]
        public bool Delete(int id){
            var achievement = _context.Achievements.FirstOrDefault(dados => dados.Id == id);

            if (achievement == null)
                throw new Exception(message.apiError);

            _context.Remove(achievement);

            return _context.SaveChanges() > 0;  

            
        }
    }
}