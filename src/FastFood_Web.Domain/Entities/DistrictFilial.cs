using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class DistrictFilial : Location
    {
        public string DistrictFilialName { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
        public int DistrictId { get; set; }
        public virtual District District { get; set; } = default!;
    }
}
