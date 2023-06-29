using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class DistrictFilial : Base
    {
        public string DistrictFilialName { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
        public string Location { get; set; } = String.Empty;
        public DateTime DateTime { get; set; }
        public Guid DistrictId { get; set; }
        public virtual District District { get; set; } = default!;
    }
}
