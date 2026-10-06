using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp.Models
{
    /// <summary>
    /// Defines the access level of an example.
    /// </summary>
    public enum Role
    {
        /// <summary>Unauthenticated visitor with minimal access.</summary>
        Guest,
        /// <summary>Regular authenticated user.</summary>
        User,
        /// <summary>User who can moderate content.</summary>
        Moderator,
        /// <summary>User with administrative rights.</summary>
        Administrator,
        /// <summary>User with the highest level of rights.</summary>
        SuperAdministrator
    }
}
