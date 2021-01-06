using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Entities
{
    public class ProductionCode
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public Movie Movie { get; set; }
    }
}
