using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastFood_Web.DataAccess.Configurations
{
    public class SuperAdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(new Admin()
            {
                FullName = "Jaloliddin",
                Email = "mebeluz555520@gmail.com",
                PasswordHash = "$2a$11$KLTFZLWfWWFzjDV3gOalguGtWtWIp0/o5DghEkD6HLz8wOuw.pBwO",
                Salt = "b2fa183d-18b4-4ebb-bd41-0eb77fcd044f",
                UserRole = UserRole.SuperAdmin,
            });
        }
    }
}
