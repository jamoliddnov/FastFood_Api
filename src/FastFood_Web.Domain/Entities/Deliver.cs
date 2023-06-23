using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Deliver : User
    {
        public UserRole UserRole { get; set; } = UserRole.Deliver;
        public Guid DistrictFilialId { get; set; }
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
        public string CarModel { get; set; } = String.Empty;
        public string CarNumber { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
    }
}
