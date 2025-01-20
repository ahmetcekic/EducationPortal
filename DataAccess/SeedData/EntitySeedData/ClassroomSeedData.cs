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
    public class ClassroomSeedData : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasData
                (
                    new Classroom
                    {
                        Id = Guid.Parse("fbb187bf-ec28-4524-a710-fae4f59c6d71"),
                        Name = "TEK-2024",
                        Description = "Teknoloji Sınıfı",
                        TeacherId = Guid.Parse("d6b125d9-7a07-4c84-b194-20da87df3bde")
                    }
                );
        }
    }
}
