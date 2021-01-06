using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Entities
{
    public class Director
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public List<Movie> Movies { get; set; } = new List<Movie>();
    }

}
