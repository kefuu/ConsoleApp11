using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Piece
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Piece(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Назва п'єси: {0}", Title);
            Console.WriteLine("Автор: {0}", Author);
            Console.WriteLine("Жанр: {0}", Genre);
            Console.WriteLine("Рік: {0}", Year);
        }

        ~Piece()
        {
            Console.WriteLine("Об'єкт п'єси {0} видалено", Title);
        }
    }
}
