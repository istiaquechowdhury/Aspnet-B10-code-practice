using AssignmentSolution1;
using System;
using System.IO;

//Instructor IR = new Instructor()
//{
//    Id = 1,
//    Name = "A",
//    salary = 23334,
//    Expense = 232333,
//    IsLazy = true,
//    FirstLetterOFname = 'D',
//    ClassTime = DateTime.Now,

//    address = new Adress()
//    {
//        Street = "Street",
//        City = "City",
//        Country = "Country",
//    },

//    course = new Course()
//    {
//        Title = "Programmnig",
//        Fees = 2500,
//        Teacher = new Instructor()
//        {

//            Id = 1,
//            Name = "A",
//            salary = 23334,
//            Expense = 232333,
//            IsLazy = true,
//            FirstLetterOFname = 'D',
//            ClassTime = DateTime.Now,
//        },
//        address = new Adress()
//        {
//            Street = "Street",
//            City = "City",
//            Country = "Country",


//        },
//        Prerequisites = ["C# Basics","Web Development Basics"]



//    },
//    Courses = new List<Course>()
//    { 
//        new Course()
//        {
//            Title = "Programmnig",
//            Fees = 2500,
//            Teacher = new Instructor()
//            {

//               Id = 1,
//               Name = "A",
//               salary = 23334,
//               Expense = 232333,
//               IsLazy = true,
//               FirstLetterOFname = 'D',
//               ClassTime = DateTime.Now,
//            },
//            address = new Adress()
//            {
//               Street = "Street",
//               City = "City",
//               Country = "Country",
//            },
//            Prerequisites = new string[]
//            {
//               "C# Basics","Web Development Basics"
//            },

//        },
//        new Course()
//        {
//            Title = "Programmnig",
//            Fees = 2500,
//            Teacher = new Instructor()
//            {

//               Id = 1,
//               Name = "A",
//               salary = 23334,
//               Expense = 232333,
//               IsLazy = true,
//               FirstLetterOFname = 'D',
//               ClassTime = DateTime.Now,
//            },
//            address = new Adress()
//            {
//               Street = "Street",
//               City = "City",
//               Country = "Country",
//            },
//            Prerequisites = new string[]
//            {
//               "C# Basics","Web Development Basics"
//            },

//        },
//    },


//};

//Instructor instructor = new Instructor
//{
//    address = new Adress
//    {
//        Street = "street",
//        subject = new Subject
//        {
//            Name = "C#",
//            Car = new Car()
//            {
//                Name = "toyota",
//                Building = new Building()
//                {
//                    Name = "khondokar bhaban",
//                    Bus = new Bus
//                    {
//                        Name = "Mahindra",
//                        Country = new Country()
//                        {
//                            Name = "Bangladesh",
//                            Weapon = new Weapon()
//                            {
//                                name = "AK-47",
//                                coins = new Coins()
//                                {
//                                    Name = "1takacoins",
//                                    Note = new Note()
//                                    {
//                                        Name = "1takanote",
//                                        laptop = new laptop()
//                                        {
//                                            name = "DCL",
//                                            bag = new Bag()
//                                            {
//                                                Name = "dbl",
//                                                Bike = new Bike()
//                                                {
//                                                    name = "R15m",
//                                                    bags = new List<Bag>
//                                                {
//                                                    new Bag()
//                                                    {
//                                                        Name = "dcl",
//                                                    },

//                                                    new Bag()
//                                                    {
//                                                        Name ="Asus",
//                                                        bags = ["dcl,asus,scl"],
//                                                    },

//                                                },


//                                                },
//                                            },
//                                        },
//                                    },
//                                },
//                            },

//                        },
//                    },
//                },
//            },
//        },

//    },
//    course = new Course()
//    {
//        Title = "C#",
//        Fees = 8000
//    },



//};  //};
Instructor instructor = new Instructor()
{
    arr = ["sdfds", "sdfsf", "sdfsdf"];
};
  

    string json = JsonFormatter.Convert(instructor);
    Console.WriteLine(json);


