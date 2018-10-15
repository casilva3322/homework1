using System;
namespace BUFFTEKS
{
    public class Project
    {
        public int ProjectID {get;set;}
        //project ID
        public string ProjectName {get;set;}
        //Project name
         public override string ToString()
        {
            string output = $"{this.ProjectName}";
            return output;
}
    }
}