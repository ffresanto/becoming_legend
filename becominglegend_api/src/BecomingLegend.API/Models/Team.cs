using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BecomingLegend.API.Models;

public class Team
{
    
    public int Id { get ; set;}
    public string Name { get ; set;}
    public int FoundationYear {get ; set;}
    public string Country {get; set;}

    public Team (){

    }

    public Team (int Id, string Name, int FoundationYear, string Country){
        this.Id = Id;
        this.Name = Name;
        this.FoundationYear = FoundationYear;
        this.Country = Country;

    }
}
