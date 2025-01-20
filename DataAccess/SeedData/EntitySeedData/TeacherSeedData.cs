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
    public class TeacherSeedData : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData
                (
                    new Teacher
                    {
                        Id = Guid.Parse("d6b125d9-7a07-4c84-b194-20da87df3bde"),
                        FirstName = "Sina Emre",
                        LastName = "Bekar",
                        BirthDate = new DateTime(1996, 01, 23),
                        Email = "sinaemre.bekar@edu.com",
                        HireDate = new DateTime(2022, 06, 20),
                        CourseId = Guid.Parse("5302c91d-6e2e-4596-956f-c673a83c462f")
                    }
                );
        }
    }
}
