using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Models
{
    public class Voorbeeld
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public  int Count { get; set; }
        public Role Role { get; set; }

        public ICollection<Uitwerking>? Uitwerkingen { get; set; } = new List<Uitwerking>();
    }
}
