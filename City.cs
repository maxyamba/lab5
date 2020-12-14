using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab5
{
    public class City
    {
        [Key]
        public int id_city { get; set; }

        [MaxLength(30)]
        [Required]
        public string city { get; set; }

        public List<Cinema> Cinema { get; set; }

    }
}
