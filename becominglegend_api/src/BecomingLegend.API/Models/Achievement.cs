using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BecomingLegend.API.Models
{
    public class Achievement
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Achievement() {}

        public Achievement(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
    }
}