using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AircraftManagementApp.Menu
{
    public class Main
    {
        public void MainMenu()
        {
            Console.WriteLine("enter 1 to register\nenter 2 to login");
            int opt;
            bool a = int.TryParse(Console.ReadLine(), out opt);
            while(a)
            {
                if (opt == 1)
                {

                }
                else if (opt == 2)
                {

                }
                else
                {
                    Console.WriteLine("wrong input");
                    MainMenu();
                }
            }

        }

        public void RegisterMenu()
        {

        }
        public void LoginMenu()
        {
            Console.WriteLine("enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("enter your pin");
            int pin = int.Parse(Console.ReadLine());


        }

    }
}