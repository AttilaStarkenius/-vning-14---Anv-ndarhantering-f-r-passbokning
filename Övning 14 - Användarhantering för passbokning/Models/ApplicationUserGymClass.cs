using System.ComponentModel.DataAnnotations;

namespace Övning_14___Användarhantering_för_passbokning.Models
{
    public class ApplicationUserGymClass
    {
        public int Id { get; set; }

        //[Required]
        //public string title { get; set; }

        //[Required]
        //[StringLength(255)]
        //public string message { get; set; }

        //public ApplicationUser ApplicationUserID { get; set; }
        public ApplicationUser applicationUser { get; set; }
        //public GymClass GymClassID { get; set; }
        public GymClass gymClass { get; set; }

        //public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        //public ICollection<GymClass> GymClasses { get; set; }


    }
}
