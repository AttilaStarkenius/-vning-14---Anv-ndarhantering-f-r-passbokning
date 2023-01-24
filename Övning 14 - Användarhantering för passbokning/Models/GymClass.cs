using System.ComponentModel.DataAnnotations.Schema;

namespace Övning_14___Användarhantering_för_passbokning.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        [NotMapped]
        public DateTime EndTime { get { return StartTime + Duration; } }
        public String Description { get; set; }
        public ICollection<ApplicationUserGymClass> ApplicationUserGymClasses { get; set; }

    }
}
