using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp.Models
{
    /// <summary>
    /// Represents a solution (worked-out answer) belonging to an example.
    /// </summary>
    public class Uitwerking
    {
        /// <summary>Primary key.</summary>
        public int Id { get; set; }
        /// <summary>Name of the person who owns this solution.</summary>
        public string Owner { get; set; } = null!;
        /// <summary>Number of attempts made.</summary>
        public int Tries { get; set; }
        /// <summary>Foreign key to the related example.</summary>
        public int? VoorbeeldId { get; set; }
        /// <summary>Navigation property to the related example.</summary>
        public Voorbeeld? Voorbeeld { get; set; }
    }
}
