namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public class ListyIterator<T>
    {
        private int position = 0;
        public int Position { get; set; }
        public List<T> Collections { get; set; }

        public ListyIterator()
        {
            this.Position = position;
            this.Collections = new List<T>();
        }

        public bool Move(List<T> collections)
        {
            if (position + 1 < collections.Count )
            {
                position++;
                return true;
            }
            return false;
        }

        public bool HasNext(List<T> collections)
        {
            if (position + 1 == collections.Count)
            {
                return false;
            }

            return true;
        }

        public void Print(List<T> collections)
        {
            if (collections.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(collections[position]);
            }
        }
    }
}
