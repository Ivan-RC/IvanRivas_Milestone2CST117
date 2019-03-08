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
    class movieInventory
    {
        //Fields 
        private string title;
        private int prodID;
        private double price;
        private string genre;
        private int releaseDate;
        private int stockQnty;

        //constructor
        public movieInventory(string movieName, int id, double moviePrice, string movieGenre, int movieReleaseDate, int moviesQnty)
        {
            this.title = movieName;
            this.prodID = id;
            this.price = moviePrice;
            this.genre = movieGenre;
            this.releaseDate = movieReleaseDate;
            this.stockQnty = moviesQnty;
        }

        //getters
        public string getTitle() { return title; }
        public int getID() { return prodID;  }
        public double getPrice() { return price; }
        public string getGenre() { return genre; }
        public int getreleaseDate() { return releaseDate; }
        public int getQnty() { return stockQnty; }

        //setters 
        public void setTitle(string newTitle) { title = newTitle; }
        public void setID(int newID) { prodID = newID;  }
        public void setPrice(double newPrice) { price = newPrice; }
        public void setGenre(string newGenre) { genre = newGenre;  }
        public void setreleaseDate(int newreleaseDate) { releaseDate = newreleaseDate; }
        public void setQnty(int newQnty) { stockQnty = newQnty;}
    }
}