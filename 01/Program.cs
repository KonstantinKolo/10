using System;
using System.Collections.Generic;
using System.Linq;

namespace _01 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Replace(",","").Split(' ').ToArray();
            Dictionary<int,int> dict = new Dictionary<int,int>();
            
            foreach(var item in input) {
                if (int.Parse(item) < 0 || int.Parse(item) > 1000) {
                    throw new ArgumentOutOfRangeException();
                }
                if (dict.ContainsKey(int.Parse(item)))
                    continue;

                int counter = 0;
                foreach(var item2 in input) {
                    if (item == item2)
                        counter++;
                }

                dict.Add(int.Parse(item), counter);
            }

            foreach(var pair in dict) {
                Console.Write($"{pair.Key}-->{pair.Value}TIMES ");
            }
        }
    }
}
