using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Book
    {
        private string title;
        private string Description;
        private string Author;
        private int Pages;
        public Book(string atitle, string description, string author, int pages, string name)
        {
            this.title = atitle;
            this.Description = description;
            this.Author = author;
            this.Pages = pages;
            Console.WriteLine("My name is: " + name);
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value == "one")
                {
                    title = "one";
                }
                else
                {
                    title = "league";
                }
            }
        }

    }
}
