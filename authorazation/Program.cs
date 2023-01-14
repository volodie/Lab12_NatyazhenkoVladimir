
using authorazation;

internal class Program
{
    private static void Main(string[] args)
    {
        (string lgn, string psw, string confirmpsw) input = AuthorizationClass.InputLoginAndPassword();
        string login = input.Item1, password = input.Item2, confirmpassword = input.Item3;

        if (AuthorizationClass.Check(login, password, confirmpassword))
        {
            Console.WriteLine("Input login and password is correct!");
        }

    }
}