using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Ivan Rivas
/// This is my own work. With the help of Ms. Fritz.
/// </summary>

namespace IvanRivas_Milestone2CST117
{
    class Program
    {
        static void Main(string[] args)
        {
            movieInventory movie = new movieInventory("Spiderman", 1, 15.00, "Fantasy/Action", 2002, 5);
            //Testing getters
            Console.WriteLine("The movie is " + movie.getTitle() + ". It's ID is " + movie.getID() + ". The price of the movie is " + movie.getPrice() +
               " dollars. The genre is " + movie.getGenre() + ". It was released " + movie.getreleaseDate() + ". We only have " + movie.getQnty() + " in stock.");

            //Testing setters
            Console.WriteLine("Changing movie name...");
            movie.setTitle("The Conjuring 2");
            Console.WriteLine("The name of the movie is now " + movie.getTitle() + ".");

            Console.WriteLine("Changing movie ID...");
            movie.setID(6);
            Console.WriteLine("The ID of the movie is now " + movie.getID() + ".");

            Console.WriteLine("Changing movie price...");
            movie.setPrice(60.00);
            Console.WriteLine("The price of the movie is now $" + movie.getPrice() + ".");

            Console.WriteLine("Changing movie genre...");
            movie.setGenre("Horror");
            Console.WriteLine("The genre of the movie is now " + movie.getGenre() + ".");

            Console.WriteLine("Changing movie release date...");
            movie.setreleaseDate(2016);
            Console.WriteLine("The release date of the movie is now " + movie.getreleaseDate() + ".");

            Console.WriteLine("Changing the stock quantity...");
            movie.setQnty(50);
            Console.WriteLine("We now have " + movie.getQnty() + " in stock.");

            Console.WriteLine("The movie is " + movie.getTitle() + ". It's ID is " + movie.getID() + ". The price of the movie is " + movie.getPrice() +
               " dollars. The genre is " + movie.getGenre() + ". It was released " + movie.getreleaseDate() + ". We only have " + movie.getQnty() + " in stock.");



        }
    }
}
