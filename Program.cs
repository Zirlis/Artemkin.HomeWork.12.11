using System;


class Program
{
    static void Main(string[] args)
    {
        //Test Task1

        //Task1 task1 = new Task1();
        //task1.Start();


        //Test Task2

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
        Task2 task2 = new Task2(4, 10, 5);

        int i = 0;
        while( i < task2.TestArray.Length)
        {
            Console.WriteLine(task2.TestArray);
            i++;
        }
        Console.ReadKey();
    }
}
