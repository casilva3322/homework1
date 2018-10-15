using System;
namespace BUFFTEKS
{
    public class Advisor
    {
       public int AdvisorID {get;set;}
       //advisor ID
       public string AdvisorFirstName {get;set;}
       //Advisor First Name
       public string AdvisorLastName {get;set;}
       //advisor last name
         public override string ToString()
        {
            string output = $"{this.AdvisorFirstName} {this.AdvisorLastName}";
            return output;
        }
    }
}