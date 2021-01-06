using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie.Services;

namespace RelationShips
{
    class Program
    {
        static void Main(string[] args)
        {

            App.PrintDirectorPerMovie();
            Console.WriteLine("==================");
            App.PrintMoviesPerDirector();


            //Database!!    Synthetic Data
            //Entities!!    Models or classes  Buiseness Logic
            //Services!!    Repository Services
            //Application!! Desktop! mobile! Web!

            //Project Class library

        }
    }

    public class App
    {

        public static void PrintDirectorPerMovie()
        {
            MovieRepository service = new MovieRepository();
            var movies = service.GetMovies();

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
                Console.WriteLine("\t{0}",movie.Director.FirstName);
            }

        }

        public static void PrintMoviesPerDirector()
        {
            DirectorRepository service = new DirectorRepository();
            var directors = service.GetDirectors();
            foreach (var director in directors)
            {
                Console.WriteLine(director.FirstName);
                foreach (var movie in director.Movies)
                {
                    Console.WriteLine("\t{0}", movie.Title);
                }
            }
        }



        public static void PrintAllMovies()
        {
            MovieRepository service = new MovieRepository();
            var movies = service.GetMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
            }
        }



        public static void PrintAllDirectors()
        {
            DirectorRepository service = new DirectorRepository();
            var directors = service.GetDirectors();
            foreach (var director in directors)
            {
                Console.WriteLine(director.FirstName);
            }
        }



        public static void PrintAllDirectors(string name)
        {
            DirectorRepository service = new DirectorRepository();
            var directors = service.GetDirectors(name);
            foreach (var director in directors)
            {
                Console.WriteLine(director.FirstName);
            }
        }

    }





   







}