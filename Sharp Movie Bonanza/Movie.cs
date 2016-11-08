using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Movie_Bonanza
{
    /// <summary>
    /// container class for movie information sent between forms
    /// </summary>
    public class Movie
    {
        public String title { get; set; }
        public String category { get; set; }
        public String cost { get; set; }
    }
}
