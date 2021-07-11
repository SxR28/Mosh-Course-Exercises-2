using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stack
{
    public class StackMethods
    {
        public void Clear(Stack<object> stack)
        {
            Console.WriteLine($"Number of elements before clearing the stack : {stack.Count}");

            Console.WriteLine("Elements cleared [ ! ]");
            stack.Clear();

            Console.WriteLine($"Number of elements befefore clearing the stack : {stack.Count}");
        }

        public void Push(object objToPush, int size, Stack<object> stack)
        {
                 if (isNull(objToPush) == true)
                 {

                        Console.WriteLine($"{objToPush} was pushed to the stack");
                        Console.ReadLine();
                        Console.Clear();

                        stack.Push(objToPush);
                 }
                 else
                    throw new InvalidOperationException("The object you want to push is null");
            
       
        }

        public void Pop(int popLength, Stack<object> stack)
        {
            if (isEmpty(stack) == true)
                throw new InvalidOperationException("Stack is 0");
            else
            {
                for (int i = 0; i < popLength; i++)
                {
                    Console.WriteLine(stack.Pop());
                }
            }
        }

        private bool isEmpty(Stack<object> stack)
        {
            bool isZero;

            if (stack.Count == 0)
                isZero = true;
            else
                isZero = false;

            return isZero;
        }

        private bool isNull(object obj)
        {
            if (obj == null)
                return obj is null;
            else
                return obj is not null;
        }
    }
}
