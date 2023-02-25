using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace IteratorsAndComparators;

public class Library : IEnumerable<Book>
{
    public Library(params Book[] books)
    {
        Books = books.ToList();
    }
    public List<Book> Books { get; set; }
    public IEnumerator<Book> GetEnumerator()
    {
        return Books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
//Create a class Library, which should store a collection of books and implement the
//IEnumerable<Book> interface. 
//List<Book> books
//A Library could be initialized without books or with any number of books and should have only
//one constructor.