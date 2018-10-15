using System;
namespace BUFFTEKS
{
    public class Student
    {
        public int StudentID{ get; set; }
        //Student id
        public string FirstName { get; set; }
        //First name
        public string LastName { get; set; }        
        //Last name
        public string PhoneNumber { get; set; }
        //Phone number
        public string Email {get; set; }
        //email a
        public string Role { get; set; }
        //role
        public override string ToString()
        {
             string output = $"{this.FirstName} {this.LastName}";
            return output;
        }
        
    }
}