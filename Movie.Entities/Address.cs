using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }

        public Actor Actor { get; set; } = new Actor();
    }


}
