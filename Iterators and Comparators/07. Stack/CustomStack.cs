namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics.X86;
    using System.Text;
    public class CustomStack<T> : IEnumerable<T>
    {

        public List<T> Collections { get; set; }

        public CustomStack()
        {
            this.Collections = new List<T>();
        }

        public void Push(params T[] elements)
        {
            for (int i = 1; i < elements.Length; i++)
            {
                this.Collections.Add(elements[i]);
            }
        }
        public void Pop()
        {
            if (this.Collections.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                this.Collections.RemoveAt(this.Collections.Count - 1);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.Collections)
            {
                yield return element;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
