using AssignmentSolution1Practice;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        //Course course = new Course
        //{
        //    Id = 1,
        //    Name = "Test",
        //    Teacher = new Teacher
        //    {
        //        Id = 1,
        //        Name = "Test",
        //        Address = new Address
        //        {
        //            Teachers = new List<Teacher>()
        //            {
        //                new Teacher
        //                {
        //                    Name = "Test",

        //                },
        //                new Teacher
        //                {
        //                    Name = "Test",

        //                }

        //            },
        //            Street = "test",
        //            city = ["dhaka,Rangpur,Barishal"]



        //        }
        //    }
        //};

        //Address address = new Address()
        //{
        //    Teachers = new List<Teacher>
        //    {
        //        new Teacher
        //        {
        //            Name = "Test",
        //        },
        //        new Teacher
        //        {
        //            Id = 1,
        //        }

        //    }
        //};
        Teacher teacher = new Teacher()
        {
            Id = 1,
            number = 1.3,
            number2 = 24,
            islazy = true,
            Name = "test",
            dateTime = DateTime.Now,
            c = 'C',

            houses = ["parkourvilla", "khandakarbahban", "skdjfl"],


            salary = new string[,]
            {
                { "sdfsdf", "sdfsdf" },
                { "sdfdsfsd", "sdfdsf" },
                { "sdfsd", "sdfsdf" }
            } , 
            salary2 = new string[,,] // 3D array initialization
            {
                {
                    { "1000", "2000", "3000" },
                    { "4000", "5000", "6000" },
                    { "7000", "8000", "9000" }
                },
                {
                    { "10000", "11000", "12000" },
                    { "13000", "14000", "15000" },
                    { "16000", "17000", "18000" }
                }
            },
            jaggedarray = new int[][] // Jagged array initialization
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 8, 9 }
            },


            Address = new List<Address>()
            {
               new Address()
               {
                   id = 1,
                   Name = "Test",
               },
               new Address()
               {
                   id = 1,
                   Name = "Test",
               }
            },
           
         
          
            Course = new Course()
            {
                Id = 2,
                Name = "Course",
                Address = new Address()
                {
                    id = 2,
                    Name = "Course",
                    Country = new Country()
                    {
                        id = 2,
                        Name = "Course",
                        building = new building()
                        {
                            id = 2,
                            Name = "Course",
                            Cartoon = new Cartoon()
                            {
                                id = 2,
                                Name = "Course",
                                A = new A()
                                {
                                    id = 2,
                                    Name = "Course",
                                    B = new B()
                                    {
                                        id = 2,
                                        Name = "Course",
                                        C = new C()
                                        {
                                            id = 2,
                                            Name = "Course",
                                            D = new D()
                                            {
                                                id = 2,
                                                Name = "Course",
                                                E = new E()
                                                {
                                                    id = 2,
                                                    Name = "Course",
                                                    F = new F()
                                                    {
                                                        id = 2,
                                                        Name = "Course",
                                                        G = new G()
                                                        {
                                                            id = 2,
                                                            Name = "Course",
                                                            H = new H()
                                                            {
                                                                id = 2,
                                                                Name = "Course",
                                                                I = new I()
                                                                {
                                                                    id = 2,
                                                                    Name = "Course",
                                                                    J = new J()
                                                                    {
                                                                        id = 2,
                                                                        Name = "Course",
                                                                        K = new K()
                                                                        {
                                                                            id = 2,
                                                                            Name = "Course",
                                                                            L = new L()
                                                                            {
                                                                                id = 2,
                                                                                Name = "Course",
                                                                                M = new M()
                                                                                {
                                                                                    id = 2,
                                                                                    Name = "Course",
                                                                                  
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }

                                                        }
                                                    }
                                                }
                                            }


                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            },


        };
        
          string json = JsonFormatter.Convert(teacher);
          Console.WriteLine(json);  

    }
}