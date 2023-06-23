using FastFood_Web.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood_Web.Domain.Entities
{
    public class ReceivingOperator : User
    {
        public UserRole UserRole { get; set; } = UserRole.ReceivingOperator;
    }
}
