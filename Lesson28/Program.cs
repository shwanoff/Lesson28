using System;

namespace Lesson28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Изучить класс GC

            //GC.

            Console.WriteLine(GC.GetTotalMemory(false));

            for(int i = 0; i < 10000000; i++)
            {
                var obj = (object)i;
                int j = (int)obj;
            }

            Console.WriteLine(GC.GetTotalMemory(false));

            using (var c = new MyClass())
            {

            }

            Console.WriteLine(GC.GetTotalMemory(false));

            GC.Collect();

            Console.WriteLine(GC.GetTotalMemory(false));

            Console.ReadLine();
        }
    }
}
