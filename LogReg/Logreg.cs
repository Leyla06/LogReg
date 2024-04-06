using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReg
{
    class Logreg
    {
        string path = $@"C:\Users\{Environment.UserName}\Desktop\file.txt";
        public Logreg()
        {
            if(!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public void Login()
        {
            StreamReader sr = new StreamReader(path);

            Console.WriteLine("Istifadeci adi daxil edin:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sifreni daxil edin:");
            string sifre = Console.ReadLine();

            string line = "";
            int i = 0;
            bool isFound = false;
            while ((line = sr.ReadLine()) != null)
            {
                string[] rows = line.Split('#');

                if (rows[2] == userName && rows[3] == sifre)
                {
                    isFound = true;
                    Console.WriteLine($"Hormetli {rows[0]}, sisteme daxil oldunuz.");

                }
            }
            sr.Close();

            if (!isFound)
            {
                Console.WriteLine("Melumat tapilmadi.");
            }
        }
        public void Register()
        {
            StreamWriter sw = new StreamWriter(path, true);

            Console.WriteLine("Adi daxil edin:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadi daxil edin:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Istifadeci adi daxil edin:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sifre daxil edin:");
            string sifre = Console.ReadLine();

            string data = $"{ad}#{soyad}#{userName}#{sifre}";
            sw.WriteLine(data);
            sw.Close();
        }
        public void LogOut()
        {
            Console.WriteLine("Cixildi");
        }
    }
}
