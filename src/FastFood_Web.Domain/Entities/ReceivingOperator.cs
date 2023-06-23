﻿using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class ReceivingOperator : Base
    {
        public UserRole UserRole { get; set; } = UserRole.ReceivingOperator;
        public Guid DistrictFilialId { get; set; }
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
        public string FullName { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;
        public DateTime CreateAt { get; set; }
    }
}
