using ApplicationCore.UserEntites.Concrete;
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
    public class UserSeedData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            var admin = new AppUser
            {
                Id = Guid.Parse("c2b28166-5def-49e5-bb0b-741a16f886d4"),
                FirstName = "Administrator",
                LastName = "Admin",
                BirthDate = new DateTime(1985, 01, 01),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@edu.com",
                NormalizedEmail = "ADMIN@EDU.COM",
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                HasPasswordChanged = true
            };

            var customerManager = new AppUser
            {
                Id = Guid.Parse("89db9ff5-9f40-4c5e-a17d-1c1ec45636c0"),
                FirstName = "Ahmet",
                LastName = "Çekiç",
                BirthDate = new DateTime(1985, 03, 11),
                UserName = "ahmet.cekic",
                NormalizedUserName = "AHMET.CEKIC",
                Email = "ahmet.cekic@edu.com",
                NormalizedEmail = "AHMET.CEKIC@EDU.COM",
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                HasPasswordChanged = true
            };

            var teacher = new AppUser
            {
                Id = Guid.Parse("976e4111-519f-485f-a21b-186e30f07371"),
                FirstName = "Sina Emre",
                LastName = "Bekar",
                BirthDate = new DateTime(1996, 01, 23),
                UserName = "sinaemre.bekar",
                NormalizedUserName = "SINAEMRE.BEKAR",
                Email = "sinaemre.bekar@edu.com",
                NormalizedEmail = "SINAEMRE.BEKAR@EDU.COM",
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                HasPasswordChanged = true
            };

            var student1 = new AppUser
            {
                Id = Guid.Parse("d3a95b67-ce52-4c1d-835a-14df01e3501f"),
                FirstName = "Murat",
                LastName = "Yeler",
                BirthDate = new DateTime(1990, 01, 01),
                UserName = "murat.yeler",
                NormalizedUserName = "MURAT.YELER",
                Email = "murat.yeler@edu.com",
                NormalizedEmail = "MURAT.YELER@EDU.COM",
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                HasPasswordChanged = true
            };

            var student2 = new AppUser
            {
                Id = Guid.Parse("43c10399-6734-42d1-91c5-838b551a066e"),
                FirstName = "Miray",
                LastName = "Çekiç",
                BirthDate = new DateTime(2014, 06, 11),
                UserName = "miray.cekic",
                NormalizedUserName = "MIRAY.CEKIC",
                Email = "miray.cekic@edu.com",
                NormalizedEmail = "MIRAY.CEKIC@EDU.COM",
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                HasPasswordChanged = true
            };
            var student3 = new AppUser
            {
                Id = Guid.Parse("8b12fe04-e7d8-4fe6-ba17-1283ac7abaa9"),
                FirstName = "Danilo",
                LastName = "Zanna",
                BirthDate = new DateTime(1975, 10, 10),
                UserName = "danilo.zanna",
                NormalizedUserName = "DANILO.ZANNA",
                Email = "danilo.zanna@edu.com",
                NormalizedEmail = "DANILO.ZANNA@EDU.COM",
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                HasPasswordChanged = true
            };

            builder.HasData(admin, customerManager, teacher, student1, student2, student3);
        }
    }
}
