using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MovieCollection;

string filePath = @"/Users/mltrelstad/Documents/dvdCollection.txt";
List<Movie> movieList = new List<Movie>();

while (true)
{
    Console.WriteLine("Select an option:");
    Console.WriteLine("1. Open");
    Console.WriteLine("2. New");
    Console.WriteLine("3. Modify");
    Console.WriteLine("4. Close");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Current movies:");


            string[] lines = File.ReadAllLines(filePath);
            int i = 1;
            foreach (var line in lines)
            {
                Console.WriteLine($"{i++}. {line}");
            }

            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine("Enter movie details:");

            Console.Write("Name: ");

            string name = Console.ReadLine();

            Console.Write("Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Rating: \r\n1: G\n2: PG\n3: PG-13\n4: R");
            double rating = double.Parse(Console.ReadLine());

            Movie newMovie = new Movie(name, genre, year, rating);
            movieList.Add(newMovie);

            Console.WriteLine("New movie added!");
            Console.WriteLine();
            break;

        case 3:
            Console.WriteLine("Enter movie name to modify:");

            string modifyName = Console.ReadLine();
            bool found = false;

            foreach (Movie movie in movieList)
            {
                if (movie.Name == modifyName)
                {
                    Console.Write("New rating: ");
                    double newRating = double.Parse(Console.ReadLine());

                    movie.Rating = newRating;

                    Console.WriteLine("Movie rating updated.");
                    Console.WriteLine();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Movie not found.");
                Console.WriteLine();
            }

            break;

        case 4:
            Console.WriteLine("Closing program.");
            return;

        default:
            Console.WriteLine("Invalid choice.");
            Console.WriteLine();
            break;
    }
}


namespace MovieCollection
{
    class Movie
    {
        public Movie(string? name, string? genre, int year, double rating)
        {
            Name = name;
            Genre = genre;
            Year = year;
            Rating = rating;
        }

        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }

        public void movie(string? name, string genre, int year, double rating)
        {
            Name = name;
            Genre = genre;
            Year = year;
            Rating = rating;
        }
    }
}
