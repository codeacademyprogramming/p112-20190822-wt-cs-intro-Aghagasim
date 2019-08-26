using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Project
{
    internal class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin { get; set; }

        public double Balans { get; set; }

        public void ShowBalans()
        {
            Console.WriteLine($"{Name} {Surname} balansiniz: {Balans}");
        }

        public void IncreaseBalans()
        {
            Console.Write("Mebleg daxil edin: ");
            double mebleg = Convert.ToDouble(Console.ReadLine());

            Balans += mebleg;
            ShowBalans();
        }


        public void DecreaseBalans()
        {
            if (Balans <= 0)
            {
                Console.WriteLine("Kifayet qeder mebleg yoxdur");
            }
            else
            {
                Console.Write("Mebleg daxil edin: ");
                double mebleg = Convert.ToDouble(Console.ReadLine());

                if (mebleg <= Balans)
                {
                    Balans -= mebleg;
                    ShowBalans();
                }
                else
                {
                    Console.WriteLine("Kifayet qeder mebleg yoxdur");
                }
            }
        }

        public void ShowProfile()
        {
            Console.WriteLine($"{Name} {Surname} - {Pin} | Balans: {Balans}");
        }


        public void EditProfile()
        {
            Console.WriteLine("\nSecim edin");
            Console.WriteLine("1 - Ad deyish");
            Console.WriteLine("2 - Soyad deyish");
            Console.WriteLine("3 - Pin deyish");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Adinizi daxil edin: ");
                    Name = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Soyadinizi daxil edin: ");
                    Surname = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Pin daxil edin: ");
                    Pin = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Duzgun secim etmediniz");
                    break;
            }
        }

    }
}