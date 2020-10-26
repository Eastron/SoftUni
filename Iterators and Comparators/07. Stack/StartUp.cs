namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CustomStack<string> collections = new CustomStack<string>();
            while (input != "END")
            {
                string[] token = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (token[0])
                {
                    case "Push":
                        {
                            collections.Push(token);
                        }
                        break;
                    case "Pop":
                        {
                            collections.Pop();
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            collections.Collections.Reverse();
            foreach (var element in collections.Collections)
            {
                Console.WriteLine(element);
            }

            foreach (var element in collections.Collections)
            {
                Console.WriteLine(element);
            }
        }
    }
}