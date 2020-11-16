using System;


class Program
{
    static void Main(string[] args)
    {
        //Test Task1

        //Task1 task1 = new Task1();
        //task1.Start();
        //Consol.Clear();


        //Test Task2
        //Часть А

        //string testString;
        //int size;
        //do
        //{
        //    Console.WriteLine($"Введите размер массива");
        //    testString = Console.ReadLine();
        //} while (!Int32.TryParse(testString, out size) || String.IsNullOrWhiteSpace(testString));

        //int startNum;
        //do
        //{
        //    Console.WriteLine($"Введите начальное число");
        //    testString = Console.ReadLine();
        //} while (!Int32.TryParse(testString, out startNum) && !String.IsNullOrWhiteSpace(testString));

        //int interval;
        //do
        //{
        //    Console.WriteLine($"Введите интервал между числами");
        //    testString = Console.ReadLine();
        //} while (!Int32.TryParse(testString, out interval) && !String.IsNullOrWhiteSpace(testString));

        //Task2 task2 = new Task2(size, startNum, interval);

        //int i = 0;
        //while (i < task2.TestArray.Length)
        //{
        //    Console.WriteLine(task2.TestArray[i]);
        //    i++;
        //}
        //Console.ReadKey();
        //Console.Clear();

        //Console.WriteLine($"Сумма всех чисел равна: {task2.Sum()}");
        //Console.ReadKey();
        //Console.Clear();

        //Console.WriteLine($"Смена знаков чисел");
        //task2.Inverse();
        //i = 0;
        //while (i < task2.TestArray.Length)
        //{
        //    Console.WriteLine(task2.TestArray[i]);
        //    i++;
        //}
        //Console.ReadKey();
        //Console.Clear();

        //Console.WriteLine($"На какое число умножить все числа?");
        //string teststring;
        //int multiplier;
        //do
        //{
        //    teststring = Console.ReadLine();
        //} while (!Int32.TryParse(teststring, out multiplier) && String.IsNullOrWhiteSpace(teststring));
        //task2.Multi(multiplier);
        //i = 0;
        //while (i < task2.TestArray.Length)
        //{
        //    Console.WriteLine(task2.TestArray[i]);
        //    i++;
        //}
        //Console.ReadKey();
        //Console.Clear();

        //Console.WriteLine($"Количество максимальных чисел: {task2.MaxCount()}");
        //Console.ReadKey();
        //Console.Clear();

        ////Часть Б

        //task2.Write("text.txt");
        //task2.Reader("text.txt");
        //Console.ReadKey();
        //Consol.Clear():

        //Task3

        Task3.Account root = new Task3.Account();
        root.NewAccount("root", "GeekBrains");

        bool test = Task3.LogIn();
        Console.WriteLine(test);

        Console.ReadKey();
    }
}
