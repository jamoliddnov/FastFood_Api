using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities.Districts
{
    public class DistrictFilial : Base
    {
        public string DistrictFilialName { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public string DistrictId { get; set; } = string.Empty;
        public virtual District District { get; set; } = default!;
    }
}
