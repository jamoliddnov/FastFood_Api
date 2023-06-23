using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Empolyee : User
    {
        public UserRole UserRole { get; set; }
        public Guid DistrictFilialId { get; set; }
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
        
    }
}
