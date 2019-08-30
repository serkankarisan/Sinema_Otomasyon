using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Column(Order = 3)]
        public string Movie_Name { get => _movie_Name; set => _movie_Name = value; }
        [Column(Order = 4)]
        public string Movie_Type { get => _movie_Type; set => _movie_Type = value; }
        [Column(Order = 5)]
        public int Movie_Duration_InMinute { get => _movie_Duration_InMinute; set => _movie_Duration_InMinute = value; }
        [Column(Order = 6)]
        public string Director { get => _director; set => _director = value; }
        [Column(Order = 7)]
        public string Banner { get => _banner; set => _banner = value; }


        public virtual List<Seance> Seances { get; set; }

        public override string ToString()
        {
            return Movie_Name;
        }
    }
}
