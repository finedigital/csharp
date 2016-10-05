
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    static void Main(string[] args) {

        static string DoSomething(bool s)
        {
            if(s)
            {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Foregroundcolor = ConsoleColor.Red;
            return DateTime.Now.AddDays(-1).ToString();

            }
            else
            {
                return DateTime.Now.ToString;
            }
            }
        }

        static void Main (string[] args)
        {
            Product fruit = new Product();
            fruit.Name = "fruit";
            fruit.Price = 1.8;
            fruit.IsPerishable - true;
            fruit.ItemNumber = "FRT-001"
            Fruit.Weight = 0.1;

            Console.ReadLine();

        }

        class Product 
        {
            public string Name;
            public double Price;
            public string ItemNumber;
            public double weight
            public bool IsPerishable;
        }
}
        Class MovieService
        {
            public Movie []MovieList;

            public Movie[] SearchByTitle (string title)
            {
                return null;
            }
        
            public void AddToSchedule(Movie movie, Datetime time)
            {

            }

            public int RoomCount()
            {
                return Rooms.Length;
            }

            public int Count(string thing)
            {
                if(thing == "Movie")
                {
                    return MovieList.Length;
                }
                if(thing == "Rooms")
                {
                    return Rooms.Length;
                }
                else return 0 
            }



        }
        
        class Movie
        {
            public double Rating;
            public string Title;
            public string[] Cast;
            public double Runtime;
            public string genre;
            public bool Seen;

        }

}


