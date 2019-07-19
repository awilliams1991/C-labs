using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;//adding the custom functionality

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)//only do 1-4 8 objects total
        {
            //1) student
            Student transfer = new Student("Maria", "Sanchez", "3579", 3.9f);
            Student current = new Student();
            current.FirstName = "Larry";
            current.LastName = "Walters";
            current.Id = "0123";
            current.Gpa = 2.9f;

            Console.WriteLine($"{transfer}\n\n{current}\n\n");

            //2) vehicle
            Vehicle old = new Vehicle("Chevy", "Celebrity", 1984, 2.5f);
            Vehicle newModel = new Vehicle();
            newModel.Make = "Toyota";
            newModel.Model = "Prius";
            newModel.Year = 2005;
            newModel.Weight = 3;

            Console.WriteLine($"{old} compared to the new {newModel}\n\n");

            //3) Username
            Login currentPass = new Login("asdghkl", "1234asdf");
            Login previous = new Login();
            previous.UserName = "Password";
            previous.Password = "Username";

            Console.WriteLine($"{currentPass}\n\n");
            Console.WriteLine($"{previous}\n\n");

            //4) Contact Info

            ContactInfo info1 = new ContactInfo("413 Ranchero Pl", "Belton", "Missouri", "64012",
                "555-555-5555", "useremail@gmail.com");
            ContactInfo bigBird = new ContactInfo();
            bigBird.StreetAddress = "123 Sesame Street";
            bigBird.City = "New York City";
            bigBird.State = "New York";
            bigBird.Zip = "12345";
            bigBird.Phone = "(123) 456-7890";
            bigBird.Email = "bigbird@sesamestreet.org";
            Console.WriteLine($"{info1}\n\n{bigBird}");


            //Wednesday Homework 5-8

            Console.Clear();
            //List<ContactInfo> customerContact = new List<ContactInfo> { info1, bigBird };//list for customer info
            //5)Customer info

            Customer c1 = new Customer("13357", "Alysha", "Williams", info1);
            Customer c2 = new Customer();
            c2.CustomerId = "1234";
            c2.FirstName = "Big";
            c2.LastName = "Bird";
            c2.CustomerContact = bigBird;
            Console.WriteLine($"{c1}\n");
            Console.WriteLine($"{c2}\n");


            //6)Credit Card Account //giving me index errors how to fix them


            CreditCardAccount cc1 = new CreditCardAccount(768450, c1, 789596.98m, false, 15.3m);
            CreditCardAccount cc2 = new CreditCardAccount();
            cc2.AccountNumber = 02345;
            cc2.CustomerInfo = c2;
            cc2.Balance = 1345.2m;
            cc2.IsPastDue = true;
            cc2.AnnualInterstRate = 1.3m;
            Console.WriteLine($"{cc1}\n");
            Console.WriteLine($"{cc2}\n");

            //7)Book

            Book newb1 = new Book("How to Write Adventure Modules that Don't Suck", "Goodman Games", 156);
            Book newb2 = new Book();
            newb2.Title = "The Den of Shadows";
            newb2.Author = "Amelia Atwater-Rhoades";
            newb2.NumberOfPages = 595;
            Console.WriteLine($"{newb1}\n");
            Console.WriteLine($"{newb2}\n");

            //8) Library
            List<Book> books = new List<Book> { newb1, newb2 };

            Library library1 = new Library(books, "Peculiar Library", "123 Street", "Peculiar", "Missouri", "64080");
            Library library2 = new Library();
            library2.Books = books;
            library2.LibraryName = "Grandview Library";
            library2.StreetAddress = "123 Main";
            library2.City = "Grandview";
            library2.State = "Missouri";
            library2.Zip = "64012";
            Console.WriteLine($"{library1}\n");
            Console.WriteLine($"{library2}\n");

            //9)Songs parent of CD

            Songs ns1 = new Songs("Panic! At the Disco", "Saturday Night", 120);
            Songs ns2 = new Songs();
            ns2.Artist = "Panic! At the Disco";
            ns2.Title = "Amen";
            ns2.LengthInSeconds = 200;

            Console.WriteLine(ns1);
            Console.WriteLine(ns2);
            Console.Clear();
            //10) CD
            string[] Songs = new string[2];
            Songs[0] = Convert.ToString(ns1);
            Songs[1] = Convert.ToString(ns2);
            Console.WriteLine(Songs[1]);
            Console.WriteLine(Songs[0]);

            CDs ncd1 = new CDs("Panic! At the Disco", "Alternative", Songs);//last spot is printing System.String[]
            Console.WriteLine(ncd1);
            CDs ncd2 = new CDs();
            ncd2.Artist = "Little Mix";
            //ncd2.Title = "Hair";
            //ncd2.LengthInSeconds = 380;
            ncd2.Genre = "Pop";
            ncd2.Songs = Songs;
            Console.WriteLine(ncd2);

            //11)
            //11. MotorHome – extend Vehicle
            //a.numberOfBeds – int
            MotorHome mh1 = new MotorHome("Ford", "OffRoad", 1999, 3.4f, 1.5f);
            MotorHome mh2 = new MotorHome();
            mh2.Make = "Chevy";
            mh2.Model = "Forester";
            mh2.Year = 2003;
            mh2.Weight = 4;
            mh2.NumberOfBeds = 2.5f;
            Console.WriteLine(mh1);
            Console.WriteLine(mh2);

            //12)Truck ==loadCapacity
            Trucks nt1 = new Trucks("Jeep", "Jeep", 2015, 2.4f, 2.2f);
            Trucks nt2 = new Trucks();
            nt2.Make = "Toyota";
            nt2.Model = "Sienna";
            nt2.Year = 2019;
            nt2.Weight = 3;
            nt2.LoadCapacity = 4;
            Console.WriteLine(nt1);
            Console.WriteLine(nt2);

        }//end main()
    }//end class
}//end namespace
