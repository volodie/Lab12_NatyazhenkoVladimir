using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace authorazation
{
    public class AuthorizationClass
    {
        
        public static (string Login, string Password, string ConfirmPassword) InputLoginAndPassword()
        {
            PrintMessage writemess = new PrintMessage();
            writemess.Print("Enter login : ");
            
            string login = Console.ReadLine();
            writemess.Print("Enter password: ");
            string password = Console.ReadLine();
            writemess.Print("Enter password confirmation: ");
            string confirmPassword = Console.ReadLine();

            return (login, password, confirmPassword);
        }

        public static bool Check(string login, string pass, string confirmPassword)
        {
            if (login.Length >= 20 ) { throw new WrongLoginException("Login is too long! Max login length is 20 symbols"); }
            if (login.Contains(" ")) { throw new WrongLoginException(); }
            if (pass != confirmPassword) { throw new WrongPasswordException(); }

            bool isDigitPresent = pass.Any(c => char.IsDigit(c));

            if (!isDigitPresent)
            { 
                throw new WrongPasswordException("Password doesn't contains any number");
            }
            return true;
        }

        public class WrongLoginException : Exception
        {
            public WrongLoginException() : base("You type a wrong login")
            {

            }
            public WrongLoginException(string message) : base(message)
            {

            }
        }

        public class WrongPasswordException : Exception
        {
            public WrongPasswordException() : base("You type a wrong password")
            {

            }
            public WrongPasswordException(string message) : base(message)
            {

            }
        }

    }
}
