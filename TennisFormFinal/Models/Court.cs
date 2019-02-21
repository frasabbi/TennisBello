using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisFormFinal.Models
{
    public class Court
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
