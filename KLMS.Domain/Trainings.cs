using KLMS.Domain.Common;

namespace KLMS.Domain
{
    public class Trainings : BaseEntity
    {
        public string TrainingName { get; set; }
        public string TrainingDescription { get; set; }
        public Departments Department { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Locations Location { get; set; }
        public Guid LocationId { get; set; }
        public int ParticipantsCapacity { get; set; }
        public string MeetLink { get; set; } = null!;
        public Users User { get; set; }
        public int MentorId { get; set; }
        public bool IsNominationOpen { get; set; }
    }
}
