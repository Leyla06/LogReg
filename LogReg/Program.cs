using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReg
{
    class Program
    {
        static void Main(string[] args)
        {
            Logreg lr = new Logreg();
            Console.WriteLine("Login");
            Console.WriteLine("Register");
            Console.WriteLine("Log Out");
            Console.Write("Secin => ");
            string secim = Console.ReadLine();
            switch(secim)
            {
                case "login": lr.Login(); break;
                case "register": lr.Register();break;
                case "logout": lr.LogOut();break;
            }
        }
    }
}
