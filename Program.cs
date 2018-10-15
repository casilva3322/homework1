using System;
using System.Collections.Generic;
using System.Linq;

namespace BUFFTEKS
{
   class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {  //this will create a new record
                            new Student()
                            {
                                FirstName = "Bob",
                                LastName = "Dole",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Smith",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Karen",
                                LastName = "Doe",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudents@buffs.wtamu.edu",
                                Role = "Freshman"
                            },   
                            new Student()
                            {
                                FirstName = "George",
                                LastName = "Washington",
                                PhoneNumber = "555-684-2020",
                                Email = "freedomCrusader@yahoo.com",
                                Role = "Senior"
                            },                     
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Advisors.Any())
                    {
                        List<Advisor> advisors = new List<Advisor>()
                        {
                            new Advisor()
                            {
                                AdvisorFirstName = "June",
                                AdvisorLastName = "Bug",
                            },
                            new Advisor()
                            {
                                AdvisorFirstName = "Susan",
                                AdvisorLastName = "Smith",
                            },
                            new Advisor()
                            {
                                AdvisorFirstName = "David",
                                AdvisorLastName = "Washington",
                            },
                            new Advisor()
                            {
                                AdvisorFirstName = "Bob",
                                AdvisorLastName = "Lewinsky",
                            },
                        };
                        db.Advisors.AddRange(advisors);  

                        db.SaveChanges();
                        }
                        else
                        {
                        var advisors = db.Advisors.ToList();
                        foreach(Advisor a in advisors)
                        {
                            Console.WriteLine(a);
                        }
                        }
                        if(!db.Clients.Any())
                        {
                        List<Client> clients = new List<Client>()
                        {
                            new Client()
                            {
                                ClientFirstName = "Joe",
                                ClientLastName = "Rogan",
                                ClientPhoneNumber = "666-894-0574",
                                ClientEmail ="weirdGuyfromxfactor@gmail.com",
                            },
                            new Client()
                            {
                                ClientFirstName = "Hillary",
                                ClientLastName = "Hillton",
                                ClientPhoneNumber = "666-894-8898",
                                ClientEmail ="Lady889@gmail.com",
                            },
                            new Client()
                            {
                                ClientFirstName = "George",
                                ClientLastName = "Lush",
                                ClientPhoneNumber = "777-874-8898",
                                ClientEmail ="ThisGuy@gmail.com",
                            },
                            new Client()
                            {
                                ClientFirstName = "Sarah",
                                ClientLastName = "Lee",
                                ClientPhoneNumber = "555-364-7852",
                                ClientEmail ="BakedGoods@gmail.com",
                            },
                        
                        };
                        db.Clients.AddRange(clients);  

                        db.SaveChanges();
                        }
                        else
                        {
                        var clients = db.Clients.ToList();
                        foreach(Client c in clients)
                        {
                            Console.WriteLine(c);
                        }
                        }
                    if(!db.Organizations.Any())
                    {
                        List<Organization> organizations = new List<Organization>()
                        {
                            new Organization()
                            {
                                OrganizationName = "BankOfTexas",
                                OrganizationNumber = "555-784-1414",
                                OrganizationEmail = "BankofTexas@gmail.com",
                            },
                            new Organization()
                            {
                               OrganizationName = "BurgerJoint",
                               OrganizationNumber = "785-652-0451",
                               OrganizationEmail = "theBurgerJoint@yahoo.com",
                            },
                            new Organization()
                            {
                               OrganizationName = "AmarilloThing",
                               OrganizationNumber = "444-852-9847",
                               OrganizationEmail = "thisAmarillothing@gmail.com",
                            },
                            new Organization()
                            {
                               OrganizationName = "CanyonBuild",
                               OrganizationNumber = "888-987-2541",
                               OrganizationEmail = "canyonbuilds@gmail.com",
                            },
                        };
                        db.Organizations.AddRange(organizations);  

                        db.SaveChanges();
                        }
                        else
                        {
                        var organizations = db.Organizations.ToList();
                        foreach(Organization o in organizations)
                        {
                            Console.WriteLine(o);
                        }
                        }
                        if(!db.Projects.Any())//checks to see if theres any values if not creates them
                        {
                        List<Project> projects = new List<Project>()
                        {
                            new Project()
                            {
                                ProjectName = "ProjectOne",
                               
                            },
                            new Project()
                            {
                                ProjectName = "ProjectTwo",
                               
                            },
                            new Project()
                            {
                                ProjectName = "ProjectThree",
                                
                            },
                            new Project()
                            {
                                ProjectName = "PojectFournet",
                               
                            },
                        };
                        db.Projects.AddRange(projects);  

                        db.SaveChanges();
                        }
                        else
                        {
                        var projects = db.Projects.ToList();
                        foreach(Project p in projects)
                        {
                            Console.WriteLine(p);
                        }
                        }
                        if(!db.Teams.Any())
                        {
                        List<Team> teams = new List<Team>()
                        {
                            new Team()
                            {
                                TeamName = "Blue",
                               
                            },
                            new Team()
                            {
                                TeamName = "Red",
                               
                            },
                            new Team()
                            {
                                TeamName = "Purple",
                                
                            },
                            new Team()
                            {
                                TeamName = "Black",
                               
                            },
                        };
                        db.Teams.AddRange(teams);  //adding record

                        db.SaveChanges();
                        }
                        else
                        {
                        var teams = db.Teams.ToList();
                        foreach(Team t in teams)
                        {
                            Console.WriteLine(t);
                        }
                        }

                         
                         
                    
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }

            }
        }
    }
}

    

