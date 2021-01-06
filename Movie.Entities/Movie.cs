using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Director Director { get; set; }
        public List<Actor> Actors { get; set; } = new List<Actor>();
        public ProductionCode ProductionCode { get; set; }
    }

}
