using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Admin : User
    {
        public AdminRole AdminRole { get; set; }
        public int DistrictFilialId { get; set; } = 0;
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
        
    }
}
