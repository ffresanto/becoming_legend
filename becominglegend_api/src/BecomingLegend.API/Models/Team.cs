using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BecomingLegend.API.Models
{

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearFounded { get; set; }
        public string CountryLocation { get; set; }

        public Team() { }

        public Team(int Id, string Name, int YearFounded, string CountryLocation)
        {
            this.Id = Id;
            this.Name = Name;
            this.YearFounded = YearFounded;
            this.CountryLocation = CountryLocation;

        }
    }
}