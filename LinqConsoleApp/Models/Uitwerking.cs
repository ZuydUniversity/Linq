using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp.Models
{
    public class Uitwerking
    {
        public int Id { get; set; }
        public string Owner { get; set; } = null!;
        public int Tries { get; set; }
        public int? VoorbeeldId { get; set; }
        public Voorbeeld? Voorbeeld { get; set; }
    }
}
