using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp.Models
{
    /// <summary>
    /// Represents an example that can have multiple solutions.
    /// </summary>
    public class Voorbeeld
    {
        /// <summary>Primary key.</summary>
        public int Id { get; set; }
        /// <summary>Name of the example.</summary>
        public string Name { get; set; } = null!;
        /// <summary>Description of the example.</summary>
        public string Description { get; set; } = null!;
        /// <summary>Counter value of the example.</summary>
        public  int Count { get; set; }
        /// <summary>Role associated with the example.</summary>
        public Role Role { get; set; }

        /// <summary>Solutions that belong to this example.</summary>
        public ICollection<Uitwerking>? Uitwerkingen { get; set; } = new List<Uitwerking>();
    }
}
