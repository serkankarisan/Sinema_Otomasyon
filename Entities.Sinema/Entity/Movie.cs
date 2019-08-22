using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Movie:EntityBase
    {
        private string _movie_Name;
        private string _movie_Type;
        private int _movie_Duration_InMinute;
        private string _director;
        private string _banner;

        public string Movie_Name { get => _movie_Name; set => _movie_Name = value; }
        public string Movie_Type { get => _movie_Type; set => _movie_Type = value; }
        public int Movie_Duration_InMinute { get => _movie_Duration_InMinute; set => _movie_Duration_InMinute = value; }
        public string Director { get => _director; set => _director = value; }
        public string Banner { get => _banner; set => _banner = value; }


        public virtual List<Seance> Seances { get; set; }
    }
}
