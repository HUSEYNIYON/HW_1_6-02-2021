using System;

namespace HW_1_06_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "C#", "JS", "C++", "Java", "Ruby" };
            Console.WriteLine("Наш массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write("\n");
            Console.WriteLine(@"Выберите команду:
                    1. Pop -----> 1   
                    2. Push ----> 2
                    3. Shift ---> 3   
                    4. Unshift--> 4
                    5. Slice----> 5  
                    6. Exit-----> 6");
            int myCommand = int.Parse(Console.ReadLine());
            while (myCommand != 6)
            {
                switch (myCommand)
                {
                    case 1:
                        Console.WriteLine($"Удаленный элемент: {ArrayHelper<string>.Pop(ref array)}");
                        Console.WriteLine("Наш изменённый массив:");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 2:
                        Console.Write("Добавляемый элемент = ");
                        string addElement = Console.ReadLine();
                        ArrayHelper<string>.Push(ref array, addElement);
                        Console.WriteLine("Наш изменённый массив:");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Удаленный элемент: {ArrayHelper<string>.Shift(ref array)}");
                        Console.WriteLine("Наш изменённый массив:");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 4:
                        Console.Write("добавляемый элемент = ");
                        addElement = Console.ReadLine();
                        ArrayHelper<string>.UnShift(ref array, addElement);
                        Console.WriteLine("Наш изменённый массив:");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case 5:
                        int? begin = null, end = null;
                        Console.WriteLine(@"Begin index:
                            1. Нужно указывать ---> 0
                            2. Не указывать    ---> 1");
                        int enterNumber = int.Parse(Console.ReadLine());
                        if (enterNumber == 0)
                        {
                            Console.Write("BeginIndex = ");
                            begin = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine(@"End index:
                            1. Нужно указывать ---> 0
                            2. Не указывать    ---> 1");
                        enterNumber = int.Parse(Console.ReadLine());
                        if (enterNumber == 0)
                        {
                            Console.Write("EndIndex = ");
                            end = int.Parse(Console.ReadLine());
                        }
                        string[] new_array = ArrayHelper<string>.Slice(ref array, begin, end);
                        Console.WriteLine("Mассив: ");
                        for (int i = 0; i < new_array.Length; i++)
                        {
                            Console.Write($"{new_array[i]} ");
                        }
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
                if (myCommand != 6)
                {
                    Console.Write("\n");
                    Console.WriteLine(@"Выберите команду:
                    1. Pop -----> 1   
                    2. Push ----> 2
                    3. Shift ---> 3   
                    4. Unshift--> 4
                    5. Slice----> 5  
                    6. Exit-----> 6");
                    myCommand = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
