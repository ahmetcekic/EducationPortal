using ApplicationCore.UserEntites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.IdentitySeedData
{
    public class RoleSeedData : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            var admin = new AppRole
            {
                Id = Guid.Parse("d56b0610-7157-4fca-b989-bfdabac1f4f5"),
                Name = "admin",
                NormalizedName = "ADMIN"
            };

            var customerManager = new AppRole
            {
                Id = Guid.Parse("fb230ada-67a9-40f3-96b2-c9c602ed7fee"),
                Name = "customerManager",
                NormalizedName = "CUSTOMERMANAGER"
            };

            var teacher = new AppRole
            {
                Id = Guid.Parse("7131d431-27c8-4b46-b7db-305cdbac3bef"),
                Name = "teacher",
                NormalizedName = "TEACHER"
            };

            var student = new AppRole
            {
                Id = Guid.Parse("499a3674-2aae-469a-8940-41893b636c00"),
                Name = "student",
                NormalizedName = "STUDENT"
            };

            builder.HasData(admin, customerManager, teacher, student);
        }
    }
}
