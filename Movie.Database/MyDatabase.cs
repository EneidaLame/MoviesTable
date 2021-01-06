using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie.Entities;

namespace Movie.Database
{
    public class MyDatabase
    {
        
        public List<Entities.Movie> Movies { get; set; } = new List<Entities.Movie>();
        public List<Director> Directors { get; set; } = new List<Director>();
        public List<Actor> Actors { get; set; } = new List<Actor>();
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<ProductionCode> ProductionCodes { get; set; } = new List<ProductionCode>();


        public MyDatabase()
        {
            Entities.Movie m1 = new Entities.Movie() { Id = 1, Title = "Godfather" };
            Entities.Movie m2 = new Movie.Entities.Movie() { Id = 2, Title = "Finding Nemo" };
            Entities.Movie m3 = new Entities.Movie() { Id = 3, Title = "28 days later" };
            Entities.Movie m4 = new Entities.Movie() { Id = 4, Title = "Scarface" };

            Director d1 = new Director() { Id = 1, FirstName = "Spielberg" };
            Director d2 = new Director() { Id = 2, FirstName = "Danny Boyle" };
            Director d3 = new Director() { Id = 3, FirstName = "De Palma" };

            Actor a1 = new Actor() { Id = 1, FirstName = "Tom Hardy" };
            Actor a2 = new Actor() { Id = 2, FirstName = "Megan Fox" };
            Actor a3 = new Actor() { Id = 3, FirstName = "Robert Doonie Junie" };
            Actor a4 = new Actor() { Id = 4, FirstName = "Jonny Depp" };
            Actor a5 = new Actor() { Id = 5, FirstName = "De Vito" };
            Actor a6 = new Actor() { Id = 6, FirstName = "Fillipidis" };

            Address ad1 = new Address() { Id = 1, StreetName = "Malibu" };
            Address ad2 = new Address() { Id = 2, StreetName = "Miami" };
            Address ad3 = new Address() { Id = 3, StreetName = "Los Angeles" };
            Address ad4 = new Address() { Id = 4, StreetName = "Santa Barbara" };
            Address ad5 = new Address() { Id = 5, StreetName = "Stavrokopidou 43" };
            Address ad6 = new Address() { Id = 6, StreetName = "Omonoia" };
            Address ad7 = new Address() { Id = 7, StreetName = "Biktoria" };
            Address ad8 = new Address() { Id = 8, StreetName = "Monastiraki" };

            ProductionCode p1 = new ProductionCode() { Id = 1, Code = "AT-23482764" };
            ProductionCode p2 = new ProductionCode() { Id = 2, Code = "FR-56456SDF" };
            ProductionCode p3 = new ProductionCode() { Id = 3, Code = "GF-344543DD" };
            ProductionCode p4 = new ProductionCode() { Id = 4, Code = "FG-45645564" };

            //============Assign Directors to Movies
            m1.Director = d1;
            d1.Movies.Add(m1);
            m2.Director = d1;
            d1.Movies.Add(m2);
            m3.Director = d2;
            d2.Movies.Add(m3);
            m4.Director = d3;
            d3.Movies.Add(m4);

            //============Assign Actors to Movies
            m1.Actors.Add(a1);
            m1.Actors.Add(a2);
            m1.Actors.Add(a3);
            a1.Movies.Add(m1);
            a1.Movies.Add(m2);
            a1.Movies.Add(m3);
            m2.Actors.Add(a4);
            m2.Actors.Add(a5);
            m2.Actors.Add(a6);
            a4.Movies.Add(m2);
            a5.Movies.Add(m2);
            a6.Movies.Add(m2);

            //============Assign ProductionCode to Movie
            m1.ProductionCode = p1;
            p1.Movie = m1;

            m2.ProductionCode = p2;
            p2.Movie = m2;

            m3.ProductionCode = p3;
            p3.Movie = m3;

            m4.ProductionCode = p4;
            p4.Movie = m4;

            //============Assign Addresses to Actors
            a1.Addresses.Add(ad1);
            a1.Addresses.Add(ad2);
            a1.Addresses.Add(ad3);
            ad1.Actor = a1;
            ad2.Actor = a2;
            ad3.Actor = a3;
            a2.Addresses.Add(ad4);
            ad4.Actor = a2;
            a3.Addresses.Add(ad5);
            ad5.Actor = a3;

            a4.Addresses.Add(ad6);
            ad6.Actor = a4;

            a5.Addresses.Add(ad7);
            ad7.Actor = a5;

            a6.Addresses.Add(ad8);
            ad8.Actor = a6;

            Movies.Add(m1);
            Movies.Add(m2);
            Movies.Add(m3);
            Movies.Add(m4);

            Directors.Add(d1);
            Directors.Add(d2);
            Directors.Add(d3);

            Actors.Add(a1);
            Actors.Add(a2);
            Actors.Add(a3);
            Actors.Add(a4);
            Actors.Add(a5);
            Actors.Add(a6);

            Addresses.Add(ad1);
            Addresses.Add(ad2);
            Addresses.Add(ad3);
            Addresses.Add(ad4);
            Addresses.Add(ad5);
            Addresses.Add(ad6);
            Addresses.Add(ad7);
            Addresses.Add(ad8);

            ProductionCodes.Add(p1);
            ProductionCodes.Add(p2);
            ProductionCodes.Add(p3);
            ProductionCodes.Add(p4);

        }
    }

}
