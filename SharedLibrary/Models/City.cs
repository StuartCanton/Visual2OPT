using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string Country { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public int Population { get; set; }
        public int Profit { get; set; }
        public int Identifier { get; set; }


    }
}
