using Microsoft.AspNetCore.Identity;

namespace Övning_14___Användarhantering_för_passbokning.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public ICollection<ApplicationUserGymClass> ApplicationUserGymClasses { get; set; }
    }
}
