using System;

namespace ConsoleApplication1
{
    public class Program
    {
       public class Movie        
       {
           public string Title 
           {
            get; 
            set; 
           }
       
           public string Genre {get; set; }

           public DateTime ReleaseDate {get; set; }

           public void Print()
           {
               Console.WriteLine(Title);
               Console.WriteLine(Genre);
               Console.WriteLine(ReleaseDate);
           }
        }
    }
}
