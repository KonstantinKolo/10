using System;
using System.Collections;
using System.Linq;

namespace _02 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack stack = new Stack();

            foreach(var item in input) { 
                stack.Push(item);
            }

            int count = stack.Count;
            string output = "";
            for (int i = 0; i < count; i++) {
                output += stack.Pop() + " ";
            }

            Console.WriteLine(output);
        }
    }
}
