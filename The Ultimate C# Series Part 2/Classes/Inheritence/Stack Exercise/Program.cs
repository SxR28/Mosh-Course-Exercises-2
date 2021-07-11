using System;

namespace Stack
{
    class Program : Stack
    {
        static Stack stackClass = new Stack();

        static void Main(string[] args)
        {
            Console.Write("How many elements you want to add in the stack : ");
            int size = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Insert the {i} element in the stack : ");
                object objToPush = Console.ReadLine();

                stackClass.Push(objToPush, size, stackClass.stack);

                if (i == size)
                    Console.WriteLine("Every element was added succsefully");
            }

            Console.Write("Choose one : \n 1. Print elements \n 2. Clear Elements \n ");
            char option = char.Parse(Console.ReadLine());

            switch (option)
            {
                case '1':
                    Console.Clear();

                    stackClass.Pop(size, stackClass.stack);
                    break;

                case '2':
                    Console.Clear();

                    stackClass.Clear(stackClass.stack);
                    break;
            }
        }
    }
}
