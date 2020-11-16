using System;
using System.IO;
using System.Text;

class Task3
{
    //3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
    //Создайте структуру Account, содержащую Login и Password.

    internal struct Account
    {
        internal string Login { get; private set; }
        internal string Password { get; private set; }

        public void NewAccount(string login, string password)
        {
            if(!String.IsNullOrWhiteSpace(login) && !String.IsNullOrWhiteSpace(password))
            {
                Login = login.ToLower();
                Password = password;

                if (String.IsNullOrEmpty("account.txt")) return;

                StreamWriter sw = new StreamWriter("account.txt", false, Encoding.ASCII);
                sw.WriteLine(login);
                sw.WriteLine(password);

                sw.Flush();
                sw.Close();
            }
            else
            {
                Console.WriteLine($"Недопустимый логин или пароль");
            }
        }
    }


    internal static bool LogIn()
    {
        Console.WriteLine($"Введите ваш логин");
        string login = Console.ReadLine();
        login = login.ToLower();

        StreamReader sr = new StreamReader("account.txt");
        string[] account = new string[2];
        account[0] = sr.ReadLine();
        account[1] = sr.ReadLine();

        int currentTry = 1;
        int tryToLogIn = 3;
        string password;

        do
        {
            Console.WriteLine("Введите пароль");
            password = Console.ReadLine();

            if (login == account[0] && password == account[1])
            {
                return true;
            }
            else
            {
                Console.WriteLine("Неверный логин или пароль");
            }
            currentTry++;
        } while (currentTry <= tryToLogIn);
        return false;
    }
}
