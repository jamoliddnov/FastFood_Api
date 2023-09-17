using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class DistrictFilial : Base
    {
        public string DistrictFilialName { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string LocationId { get; set; } = string.Empty;
        public virtual Location Location { get; set; } = default!;
        public DateTime? DateTime { get; set; }
        public string DistrictId { get; set; } = string.Empty;
        public virtual District District { get; set; } = default!;
    }
}
