using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int tries = 0;
            bool locked;

            Console.Write("\n\nCheck username and password :\n");
            Console.Write("Note: Default username and password is : username and password\n");
            Console.Write("---------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username == "username" && password == "password")
                {
                    locked = false;
                    tries = 3;
                }
                else
                {
                    locked = true;
                    tries++;
                }
            }
            while ((username != "username" || password != "password") && (tries != 3));


            if (locked)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }

            Console.ReadKey();
        }
    }
}
