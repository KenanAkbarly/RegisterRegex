
using System;
using System.Text.RegularExpressions;

namespace ht1
{
    class Program
    {
        static void Main(string[] args)
        {

            // name
            object[] Arr = new object[0];
            Console.Write("Enter your name1: ");
            string name = Console.ReadLine();
            //surname
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            // age
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            // email
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            //password
            Console.Write("Enter your Password: ");
            string Password = Console.ReadLine();
            //number
            Console.Write("Enter your Phonenumber: ");
            string phonenumber = Console.ReadLine();

            //string surname = "Akbarly";
            Regex regexname = new Regex(@"^[A-Z]{1}[a-z]{1,14}$");
            Match matchname = regexname.Match(name);
            // surname
            Regex regexsurname = new Regex(@"^[A-Z]{1}[a-z]{1,14}$");
            Match matchsurname = regexsurname.Match(surname);
            // age 
            Regex regexage = new Regex(@"^\d");
            Match matchage = regexage.Match(age);
            // email 
            Regex regexemil = new Regex(@" ^[a - zA - Z0 - 9_.+ -] +@[a - zA - Z0 - 9 -] +\.[a-zA-Z0-9-.] +$");
            Match matchmail = regexemil.Match(email);
            //password   fabio@disapproved.solutions
            Regex regexpassword = new Regex(@"\w");
            Match matchpassword = regexpassword.Match(Password);
            //number 
            Regex regexnumber = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");
            Match matchnumber = regexnumber.Match(phonenumber);

            if (matchname.Success && matchsurname.Success && matchage.Success && matchmail.Success && matchpassword.Success && matchnumber.Success)
            {
                var UserInfo = new { name = name, surname = surname, age = age, email = email, Password = Password, phonenumber = phonenumber };

                Array.Resize(ref Arr, Arr.Length + 1);
                Arr[Arr.Length - 1] = UserInfo;
                Console.WriteLine("User Creaated !");
            }
            else
            {
                Console.WriteLine("Melumatlari duzgun daxil edin!");
            }


        }
    }
}