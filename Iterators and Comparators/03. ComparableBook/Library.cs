namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                
                this.books = new List<Book>(books);
                this.Reset();
            }
            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return --this.currentIndex >= 0;
            }

            public void Reset()
            {
                this.currentIndex = this.books.Count;
            }
        }
    }
}
