using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class SetBooks
    {
        private Book[] books;
        private int quantity;

        public SetBooks(int quantity)
        {
            if (quantity > 0)
            {
                this.quantity = quantity;
            }else
            {
                this.quantity = 10;
            }
            books = new Book[quantity];
        }

        public bool setBooks(Book book)
        {
            bool isAddBook = false;
            int index = -1, i;
            for (i = 0; i < quantity; i++)
            {
                if (books[i] == null) {
                    books[i] = book;
                    return true;
                } 
                else index++;
            }
            return isAddBook;
        }

        public Book getBook(int index)
        {
            return index < quantity ? books[index] : null;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public Book[] getBooks()
        {
            return books;
        }

    }
}
