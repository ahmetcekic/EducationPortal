using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.IdentitySeedData
{
    public class UserRoleSeedData : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData
                (
                    new IdentityUserRole<Guid>
                    {
                        RoleId = Guid.Parse("d56b0610-7157-4fca-b989-bfdabac1f4f5"),
                        UserId = Guid.Parse("c2b28166-5def-49e5-bb0b-741a16f886d4")
                    },
                    new IdentityUserRole<Guid>
                    {
                        RoleId = Guid.Parse("fb230ada-67a9-40f3-96b2-c9c602ed7fee"),
                        UserId = Guid.Parse("89db9ff5-9f40-4c5e-a17d-1c1ec45636c0")
                    },
                    new IdentityUserRole<Guid>
                    {
                        RoleId = Guid.Parse("7131d431-27c8-4b46-b7db-305cdbac3bef"),
                        UserId = Guid.Parse("976e4111-519f-485f-a21b-186e30f07371")
                    },
                    new IdentityUserRole<Guid>
                    {
                        RoleId = Guid.Parse("499a3674-2aae-469a-8940-41893b636c00"),
                        UserId = Guid.Parse("d3a95b67-ce52-4c1d-835a-14df01e3501f")
                    },
                    new IdentityUserRole<Guid>
                    {
                        RoleId = Guid.Parse("499a3674-2aae-469a-8940-41893b636c00"),
                        UserId = Guid.Parse("43c10399-6734-42d1-91c5-838b551a066e")
                    },
                    new IdentityUserRole<Guid>
                    {
                        RoleId = Guid.Parse("499a3674-2aae-469a-8940-41893b636c00"),
                        UserId = Guid.Parse("8b12fe04-e7d8-4fe6-ba17-1283ac7abaa9")
                    }
                );
        }
    }
}
