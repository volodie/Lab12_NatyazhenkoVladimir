
using authorazation;

internal class Program
{
    private static void Main(string[] args)
    {
        (string lgn, string psw, string confirmpsw) input = AuthorizationClass.InputLoginAndPassword();
        string login = input.Item1, password = input.Item2, confirmpassword = input.Item3;

        PrintMessage writcons = new PrintMessage();

        try 
        {
            if (AuthorizationClass.Check(login, password, confirmpassword))
            {
                writcons.Print("Input login and password is correct!");
            }
        }
        catch (Exception ex)
        {
            writcons.Print(ex.Message);
        }
    }
}