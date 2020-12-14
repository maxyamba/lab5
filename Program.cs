using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.IO;

using System.Data.SqlClient;
using System.Data;
using System.Data.Common;


namespace lab5
{

    public class Program : Function
    {

        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AddCountry("Angola");
            p.AddCountry("Canada");
            p.AddCountry("Zimbabve");
            p.AddCountry("Senegal");
            p.AddCity("Angola");
            p.AddCity("Toronto");
            p.AddCity("Kuku");
            p.AddCity("Mumu");
            p.AddCinema("Multik");
            p.AddCinema("5D");
            p.AddCinema("4D");
            p.AddCinema("Elephant0D");


        }
    }

    

}


            
