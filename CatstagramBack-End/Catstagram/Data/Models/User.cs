using Catstagram.Server.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Catstagram.Data.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Cat> Cats { get; private set; } = new HashSet<Cat>();
    }
}
