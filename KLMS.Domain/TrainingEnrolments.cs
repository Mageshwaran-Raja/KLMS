using KLMS.Domain.Common;

namespace KLMS.Domain
{
    public class TrainingEnrolments : BaseEntity
    {
        public Trainings Training { get; set; }
        public Guid TrainingId { get; set; }
        public Users User { get; set; }
        public Guid UserId { get; set; }
        public Status Status { get; set; }
        public Guid StatusId { get; set; }
    }
}
