using System;
using System.Collections;
using System.Collections.Generic;

namespace _03 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int s = n;
            Queue queue = new Queue();
            List<int> list = new List<int>();

            list.Add(s);
            for (int i = 0; i < 50; i++) {
                queue.Enqueue(s + 1);
                list.Add(s + 1);

                queue.Enqueue(2 * s + 1);
                list.Add(2 * s + 1);

                queue.Enqueue(s + 2);
                list.Add(s + 2);

                s = Convert.ToInt32(queue.Dequeue());
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
