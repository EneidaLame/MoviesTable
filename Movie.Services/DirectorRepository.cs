using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie.Database;
using Movie.Entities;


namespace Movie.Services
{
    public class DirectorRepository
    {

        public List<Director> GetDirectors()
        {
            MyDatabase db = new MyDatabase();
            return db.Directors;
        }

        public List<Director> GetDirectors(string name)
        {
            MyDatabase db = new MyDatabase();
            return db.Directors.Where(x => x.FirstName.Contains(name)).ToList();
        }
    }
}
