using Microsoft.AspNetCore.Identity;
using TequliasRestaurant.Models;

namespace TequilasRestaurant.Models
{
    public class ApplicationUser : IdentityUser
    {
         public ICollection<Order>? Orders { get; set;}
    }
}
