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
    public class CourseSeedData : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData
                (
                    
                    new Course
                    {
                        Id = Guid.Parse("5302c91d-6e2e-4596-956f-c673a83c462f"),
                        Name = ".NET Eğitim Programı"
                    },
                    new Course
                    {
                        Id = Guid.Parse("8e38ae94-455a-4269-8157-ac276238814a"),
                        Name = "Java Eğitim Programı"
                    },
                    new Course
                    {
                        Id = Guid.Parse("b213772c-2986-4204-afa3-7d68adf070bc"),
                        Name = "Python Eğitim Programı"
                    },
                    new Course
                    {
                        Id = Guid.Parse("70d1e658-6578-435d-98f3-db2b60e31bb9"),
                        Name = "Sistem ve Ağ Uzmanlığı Programı"
                    },
                    new Course
                    {
                        Id = Guid.Parse("2b3f0a6f-3888-4f2f-b091-2e6d48bfdfda"),
                        Name = "Siber Güvenlik Programı"
                    },
                    new Course
                    {
                        Id = Guid.Parse("d711fea2-e7bf-4d40-8598-e4a1174f9d91"),
                        Name = "Mobil Programlama Programı"
                    }
                );
        }
    }
}
