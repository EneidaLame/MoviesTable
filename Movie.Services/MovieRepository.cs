using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie.Entities;
using Movie.Database;

namespace Movie.Services
{
    public class MovieRepository
    {
        public List<Movie.Entities.Movie> GetMovies()
        {
            MyDatabase db = new MyDatabase();
            return db.Movies;  //m1 , m2 ,m3
        }

    }
}
