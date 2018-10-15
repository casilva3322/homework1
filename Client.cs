using System;
namespace BUFFTEKS
{
    public class Client
    {
        public int ClientID {get;set;}
        //Client ID
        public string ClientFirstName {get;set;}
        //Client First name
        public string ClientLastName {get;set;}
        //Client Last name
        public string ClientPhoneNumber {get;set;}
        //Client Phone Number
        public string ClientEmail {get;set;}
        //Client email
         public override string ToString()
        {
            string output = $"{this.ClientFirstName} {this.ClientLastName}";
            return output;
}
    }
}