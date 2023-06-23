using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class DistrictFilial : Location
    {
        public string DistrictFilialName { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
        public Guid DistrictId { get; set; }
        public virtual District District { get; set; } = default!;
        public DateTime DateTime { get; set; }
    }
}
