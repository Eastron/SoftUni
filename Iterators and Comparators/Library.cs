namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class Library : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in this.Books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
