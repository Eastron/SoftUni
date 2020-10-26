namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ListyIterator<string> collections = new ListyIterator<string>();
            while (input != "END")
            {
                string[] token = input.Split();
                switch (token[0])
                {
                    case "Create":
                        {
                            if (token.Length > 0)
                            {
                                for (int i = 1; i < token.Length; i++)
                                {
                                    collections.Collections.Add(token[i]);
                                }
                            }   
                        }
                        break;
                    case "Move":
                        {
                            Console.WriteLine(collections.Move(collections.Collections));
                        }
                        break;
                    case "Print":
                        {
                           collections.Print(collections.Collections);
                        }
                        break;
                    case "HasNext":
                        {
                            Console.WriteLine(collections.HasNext(collections.Collections));
                        }
                        break;
                }

                input = Console.ReadLine();
            }

        }
    }
}