using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab5
{
    public class Cinema
    {
        [Key]
        public int id_cinema { get; set; }

        [MaxLength(30)]
        [Required]
        public string cinema { get; set; }
        public List<City> City { get; set; }

    }
}
