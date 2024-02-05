﻿namespace Generics
{
    public class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> list = new();
            for (int i = 0; i < lines; i++)
            {
                list.Add(Console.ReadLine());
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            GenericSwap(list, indexes[0], indexes[1]);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        private static void GemericBoxInts()
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(box);
        }

        public static void GenericSwap<T>(List<T> list,int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}