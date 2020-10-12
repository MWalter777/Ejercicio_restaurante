using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private double points;

        public Book(string title, string author, int pages, double points)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.points = points;
        }

        public string getTitle()
        {
            return title;
        }

        public string getAuthor()
        {
            return author;
        }

        public int getPages()
        {
            return pages;
        }

        public double getPoints()
        {
            return points;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public void setPages(int pages)
        {
            this.pages = pages;
        }

        public void setPoints(double points)
        {
            this.points = points;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", title, author, pages, points);
        }


    }
}
