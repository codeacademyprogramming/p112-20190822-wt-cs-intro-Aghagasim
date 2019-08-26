using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Account hesab = new Account()
            {
                Balans = 0
            };

            Console.Write("Adinizi daxil edin: ");
            hesab.Name = Console.ReadLine();

            Console.Write("Soyadinizi daxil edin: ");
            hesab.Surname = Console.ReadLine();

            Console.Write("Pin daxil edin: ");
            hesab.Pin = Console.ReadLine();

            int check = 100;
            while (check != 0)
            {
                check = Program.ShowMenu();
                if (check == -1)
                {
                    Console.WriteLine("Duzgun secim edin");
                }
                else
                {

                    switch (check)
                    {
                        case 1: 
                            hesab.ShowBalans();
                            break;
                        case 2:
                            hesab.IncreaseBalans();
                            break;

                        case 3:
                            hesab.DecreaseBalans();
                            break;

                        case 4:
                            hesab.ShowProfile();
                            break;
                        case 5:
                            hesab.EditProfile();
                            break;

                        default:
                            break;
                    }

                }

            }
        }


        public static int ShowMenu()
        {
            Console.WriteLine("\nSecim edin");
            Console.WriteLine("1 - Balansa bax");
            Console.WriteLine("2 - Balans artır");
            Console.WriteLine("3 - Balansdan çıxarış");
            Console.WriteLine("4 - Hesab məlumatlarına bax");
            Console.WriteLine("5 - Hesab məlumatlarını dəyiş");
            Console.WriteLine("0 - Çıxış");

            string input = Console.ReadLine();
            if (input != "1" &&
                input != "2" &&
                input != "3" &&
                input != "4" &&
                input != "5" &&
                input != "0")
            {
                return -1;
            }

            return Convert.ToInt32(input);
        }

    }
}