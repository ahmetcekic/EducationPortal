using ApplicationCore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.EntitySeedData
{
    public class StudentSeedData : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
                (
                    new Student
                    {
                        Id = Guid.Parse("d3a95b67-ce52-4c1d-835a-14df01e3501f"),
                        FirstName = "Murat",
                        LastName = "Yeler",
                        BirthDate = new DateTime(1990, 01, 01),
                        Email = "murat.yeler@edu.com",
                        ClassroomId = Guid.Parse("fbb187bf-ec28-4524-a710-fae4f59c6d71")
                    },
                    new Student
                    {
                        Id = Guid.Parse("43c10399-6734-42d1-91c5-838b551a066e"),
                        FirstName = "Miray",
                        LastName = "Çekiç",
                        BirthDate = new DateTime(2014, 06, 11),
                        Email = "miray.cekic@edu.com",
                        ClassroomId = Guid.Parse("fbb187bf-ec28-4524-a710-fae4f59c6d71")
                    },
                     new Student
                     {
                         Id = Guid.Parse("8b12fe04-e7d8-4fe6-ba17-1283ac7abaa9"),
                         FirstName = "Danilo",
                         LastName = "Zanna",
                         BirthDate = new DateTime(1975, 10, 10),
                         Email = "danilo.zanna@edu.com",
                         ClassroomId = Guid.Parse("fbb187bf-ec28-4524-a710-fae4f59c6d71")
                     }
                );

        }
    }
}
