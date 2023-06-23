using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Deliver : Base
    {
        public string FullName { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;
        public DateTime CreateAt { get; set; }
        public UserRole UserRole { get; set; } = UserRole.Deliver;
        public Guid DistrictFilialId { get; set; }
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
        public string CarModel { get; set; } = String.Empty;
        public string CarNumber { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
    }
}
