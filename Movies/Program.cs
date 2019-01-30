using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = false;
            bool isInputValid = false;
            string input = null;

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("");
            do
            {
                shouldContinue = false;

                Console.WriteLine("There are 10 movies in this list.");
                Console.Write("What category are you interested in?(Animated = 1, Drama = 2, Horror = 3, SciFi = 4) ");

                do
                {
                    isInputValid = true;
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        DisplayMoviesByCategory("Animated");
                    }
                    else if (input == "2")
                    {
                        DisplayMoviesByCategory("Drama");
                    }
                    else if (input == "3")
                    {
                        DisplayMoviesByCategory("Horror");
                    }
                    else if (input == "4")
                    {
                        DisplayMoviesByCategory("SciFi");
                    }//if the user types animated however they'd like display the movies by category. 
                    else
                    {
                        Console.WriteLine("Input is not valid. Please enter Animated, Drama, Horror, SciFi");
                        isInputValid = false;
                    }
                } while (!isInputValid);

                Console.Write("Continue? (y/n):");
                input = Console.ReadLine();//my continue statement
                if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    shouldContinue = true; //if the input is true or Y continue running
                }
            } while (shouldContinue);
        }


        public static void DisplayMoviesByCategory(string category)
        {
            foreach (Movie movie in movies)
            {
                if (movie.Category.Equals(category))
                {
                    Console.WriteLine(movie.Title);
                }
            }

        }

        static ArrayList movies = new ArrayList()
        {//arraylist of movies and their category
            new Movie("Spirted Away", "Animated"),
            new Movie("Zootopia", "Animated"),
            new Movie("Inside Out", "Animated"),
            new Movie("Cast Away", "Drama"),
            new Movie("Finding Forrester", "Drama"),
            new Movie("Halloween", "Horror"),
            new Movie("Mandy", "Horror"),
            new Movie("Climax", "Horror"),
            new Movie("Mad Max: Fury Road", "SciFi"),
            new Movie("Blade", "SciFi"),
        };
    }
}
