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
    public class CustomerManagerSeedData : IEntityTypeConfiguration<CustomerManager>
    {
        public void Configure(EntityTypeBuilder<CustomerManager> builder)
        {
            builder.HasData
               (
                   new CustomerManager
                   {
                       Id = Guid.Parse("1ab0efab-65f6-4006-ba57-cb4278626936"),
                       FirstName = "Ahmet",
                       LastName = "Çekiç",
                       BirthDate = new DateTime(1994, 05, 06),
                       Email = "ahmet.cekic@edu.com",
                       HireDate = new DateTime(2023, 05, 05)
                   }
               );
        }
    }
}
