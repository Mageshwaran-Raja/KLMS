using KLMS.Domain.Common;

namespace KLMS.Domain
{
    public class Users : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string BioDescription { get; set; }
        public string Email { get; set; }
        public int WorkExperience { get; set; }
        public Locations? Location { get; set; }
        public Guid LocationId { get; set; }
        public Roles? Role { get; set; }
        public Guid RoleId { get; set; }
        public Departments? Department { get; set; }
        public Guid DepartmentId { get; set; }
        public Users? User { get; set; }
        public Guid ManagerId { get; set; }

    }
}
