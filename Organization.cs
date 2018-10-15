using System;
namespace BUFFTEKS
{
    public class Organization
    {
         public int OrganizationID {get;set;}
        //Organization ID
        public string OrganizationName {get;set;}
        //organization name
        public string OrganizationNumber {get;set;}
        //Organization Phone Number
        public string OrganizationEmail {get;set;}
        //Organization email
         public override string ToString()
        {
            string output = $"{this.OrganizationName}";
            return output;
}
    }
}