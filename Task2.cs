using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Task2
{
    //2. а) Дописать класс для работы с одномерным массивом. 
    //Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
    //Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
    //В Main продемонстрировать работу класса.
    //б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

    //Часть А
    internal int[] TestArray { get; private set; }

    internal Task2 (int size, int startNum, int interval)
    {
        int[] array = new int[size];
        array[0] = startNum;

        int i = 1;
        while(i < size)
        {
            array[i] = array[i - 1] + interval;
            i++;
        }
        TestArray = array;
    }

    internal int Sum()
    {
        int sum = 0;
        int i = 0;
        while (i < TestArray.Length)
        {
            sum += TestArray[i];
            i++;
        }
        return sum;
    }

    internal void Inverse()
    {
        int i = 0;
        while (i < TestArray.Length)
        {
            TestArray[i] = - TestArray[i];
            i++;
        }
    }

    internal void Multi(int multiplier)
    {
        int i = 0;
        while (i < TestArray.Length)
        {
            TestArray[i] *= multiplier;
            i++;
        }
    }

    internal int MaxCount()
    {
        int maxNum = TestArray[0];
        int i = 0;
        while (i < TestArray.Length)
        {
            if(TestArray[i] > maxNum)
            {
                maxNum = TestArray[i];
            }
            i++;
        }

        int maxCount = 1;
        while (i < TestArray.Length)
        {
            if (TestArray[i] == maxNum)
            {
                maxCount++;
            }
            i++;
        }
        return maxCount;
    }

    //Часть Б
    internal void Write(string path)
    {
        if (String.IsNullOrEmpty(path)) return;

        StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII);

        int i = 0;
        while (i < TestArray.Length)
        {
            sw.WriteLine(TestArray[i]);
            i++;
        }

        sw.Flush();
        sw.Close();
    }

    internal void Reader(string path)
    {
        if (String.IsNullOrEmpty(path)) return;

        StreamReader sr = new StreamReader(path);
        List<int> list = new List<int>();
        int i = 0;
        while (!sr.EndOfStream)
        {
            list.Add(Int32.Parse(sr.ReadLine()));
            i++;
        }

        int[] testArray = new int[list.Count];
        i = 0;
        while (i < testArray.Length)
        {
            testArray[i] = list[i];
            i++;
        }

        TestArray = testArray;
    }
}
