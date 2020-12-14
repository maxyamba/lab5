using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Function : SuperType
    {
        public void ShowDB()
        {

            Console.WriteLine("\n   Country");
            foreach (var i in this.Context.Countryy)
            {
                Console.WriteLine(i.id_country + "\t" + i.country);
            }

            Console.WriteLine("\n   City");
            foreach (var i in this.Context.Cityy)
            {
                Console.WriteLine(i.id_city + "\t" + i.city);
            }

            Console.WriteLine("\n   Cinema");
            foreach (var i in this.Context.Cinemaa)
            {
                Console.WriteLine(i.id_cinema + "\t" + i.cinema);
            }
            
        }

        public void AddCountry(String Coun)
        {
            this.Context.Countryy.Add(new Country { country = Coun });
            this.Context.SaveChanges();
        }

        public void AddCity(String Cit)
        {
            this.Context.Cityy.Add(new City { city = Cit });
            this.Context.SaveChanges();
        }

        public void AddCinema(String Cin)
        {
            this.Context.Cinemaa.Add(new Cinema { cinema = Cin });
            this.Context.SaveChanges();
        }
        
       


    }

}

