using System;

class Task1
{
    //1. Дан целочисленный массив из 20 элементов. 
    //Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
    //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
    //В данной задаче под парой подразумевается два подряд идущих элемента массива. 
    //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

    internal void Start()
    {
        int amountOfNumbers = 20;
        int[] nums = new int[amountOfNumbers];
        int i = 0;
        string test;
        int lowLimit = -10_000;
        int topLimit = 10_000;

        Console.WriteLine($"Вам нужно ввести 20 чисел от -10_000 до 10_000 включительно");

        while(i < 20)
        {
            do
            {
                Console.WriteLine($"Введите число под номером {i + 1}");
                test = Console.ReadLine();
            } while (!Int32.TryParse(test, out nums[i]) || !(nums[i] >= lowLimit && nums[i] <= topLimit));
            i++;
            Console.Clear();
        }

        i = 0;
        int pairsDivisibleByThree = 0;
        while (i < 19)
        {
            if((nums[i] != 0 && nums[i] % 3 == 0 ) || (nums[i+1] != 0 && nums[i+1] % 3 == 0 ))
            {
                pairsDivisibleByThree++;
            }
            i++;
        }

        Console.WriteLine($"Количество пар, в которых хотя бы одно число делится на 3 равно: {pairsDivisibleByThree}");
        Console.ReadKey();
    }
}
