using System;
namespace BUFFTEKS
{
    public class Team
    {
        public int TeamID {get;set;}
        //Team ID
        public string TeamName {get;set;}
        //Team name
         public override string ToString()
        {
            string output = $"{this.TeamName}";
            return output;
}

    }
}