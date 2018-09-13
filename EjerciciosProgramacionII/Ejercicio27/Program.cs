using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Queue<int> posQueue = new Queue<int>();
            Queue<int> negQueue = new Queue<int>();
            Random randomizer = new Random();
            int auxRandom = 0;
            for (int i = 0; i < 20; i++)
            {
                while (auxRandom == 0)
                {
                    auxRandom = randomizer.Next(-300, 300);
                }
                queue.Enqueue(auxRandom);
                auxRandom = 0;
            }

            for(int i = 0; i<20; i++)
            {
                if (queue.Peek() > 0)
                {
                    posQueue.Enqueue(queue.Dequeue());
                }
                else
                    negQueue.Enqueue(queue.Dequeue());
            }

            Queue<int> orderedPosQueue = new Queue<int>(posQueue.OrderByDescending(a=>a));
            Queue<int> orderedNegQueue = new Queue<int>(negQueue.OrderBy(a => a));

            Console.WriteLine("Queue Positiva.");
            foreach ( var item in orderedPosQueue )
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Queue Negativa.");
            foreach (var item in orderedNegQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("STACKS!!!");

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 20; i++)
            {
                while (auxRandom == 0)
                {
                    auxRandom = randomizer.Next(-300, 300);
                }
                stack.Push(auxRandom);
                auxRandom = 0;
            }

            Stack<int> posStack = new Stack<int>( stack.OrderByDescending(a => a) );
            Stack<int> negStack = new Stack<int>(stack.OrderBy(a => a));
            

        }
    }
}
