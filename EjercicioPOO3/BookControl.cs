using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class BookControl
    {
        private string title = null;
        private string author = null;
        private int pages = -1;
        private double points = -1;
        private SetBooks setBooks;

        public BookControl(int quantity) {
            setBooks = new SetBooks(quantity);
        }

        public bool AddBook()
        {
            Console.Clear();
            string number;
            do
            {
                Console.Write("Titulo del libro: ");
                title = Console.ReadLine();
                Console.WriteLine("");
            } while (String.IsNullOrWhiteSpace(title));

            do
            {
                Console.Write("Author: ");
                author = Console.ReadLine();
                Console.WriteLine("");
            } while (String.IsNullOrWhiteSpace(author));

            do
            {
                Console.Write("Numero de paginas: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                try
                {
                    pages = int.Parse(number);
                }
                catch (Exception e)
                {
                    number = null;
                }
            } while (String.IsNullOrWhiteSpace(number));

            do
            {
                Console.Write("Calificacion: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                try
                {
                    points = double.Parse(number);
                }
                catch (Exception e)
                {
                    number = null;
                }
            } while (String.IsNullOrWhiteSpace(number) || points<0 || points>10);
            bool successful = setBooks.setBooks(new Book(title, author, pages, points));
            title = null;
            author = null;
            pages = -1;
            points = -1;
            if (successful)
            {
                Console.WriteLine("INGRESO EXITOSO");
            }else
            {
                Console.WriteLine("NO SE PUEDE INGRESAR EL LIBRO, NO HAY ESPACIO");
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
            Console.ReadKey();
            return successful;
        }

        public Book[] getBooks()
        {
            return setBooks.getBooks();
        }

        public int getQuantity()
        {
            return setBooks.getQuantity();
        }

    }
}
