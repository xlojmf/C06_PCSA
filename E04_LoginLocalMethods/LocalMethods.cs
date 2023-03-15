using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_LoginLocalMethods
{
    internal class LocalMethods
    {


        public static string GetData(string message) 
        {
            Console.WriteLine(message);
            Console.Write(">");
            string data = Console.ReadLine();
            return data;
        }

        public static void ParentMethod(string username, string password)
        {
            bool isUsernameCorrect = ValidateUser(username);
            bool isPasswordCorrect = ValidatePassword(password);

            string message = isUsernameCorrect && isPasswordCorrect ? "User is Logged in"
                : !isUsernameCorrect && !isPasswordCorrect ? "Incorrect username and password"
                    : !isUsernameCorrect ? "Incorrect username\nCorrect password": "Valid username\nIncorrect password";

            Console.WriteLine(message);

            bool ValidateUser(string _)
            {
                string validUsername = "user1";
                bool isUsernameCorrect1 = username == validUsername;
                return isUsernameCorrect1;
            }

            bool ValidatePassword(string _)
            {
                string validPassword = "pass1";
                bool isPasswordCorrect1 = password == validPassword;
                return isPasswordCorrect1;
            }
        }

    }
}



