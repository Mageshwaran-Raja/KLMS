using KLMS.Domain.Common;

namespace KLMS.Domain
{
    public class UserLoginActivity : BaseEntity
    {
        public Users User { get; set; }
        public Guid UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
    }
}
