using System;

namespace testingLoginApp
{
    internal class Program
    {
        static string username;
        static string password;
        static bool failed = false;
        static void Main(string[] args)
        {
            Register();
            Login();

            Console.Read();

        }

        public static void Register()
        {
            Console.WriteLine("Register an account, please enter your Username and Password.");
            Console.Write("Username : ");
            username = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();

            Console.WriteLine("\nRegister Completed, lets move into login page.\n");
            Console.Clear();
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your Username and Password.");
            Console.Write("Username : ");
            if(username == Console.ReadLine()){
                Console.Write("password : ");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("\n======================================");
                    Console.WriteLine("Login success");
                    Console.WriteLine("======================================\n");
                    failed = false;
                    LoginFailed();
                }
                else 
                {
                    failed = true;
                    LoginFailed();

                }
            }
        }

        public static void LoginFailed()
        {
            if(failed == true)
            {
                while (failed == true)
                {
                    Console.WriteLine("\n======================================");
                    Console.WriteLine("Login failed, you input the wrong Username and Id. system reboot.");
                    Console.WriteLine("======================================\n");
                    Login();
                }
            } else
            {
                failed = false;
                Console.WriteLine("Welcome sir {0}, have a great day!", username);
            }
        }


    }
}
