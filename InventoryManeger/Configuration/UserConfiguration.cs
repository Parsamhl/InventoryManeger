using InventoryManeger.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManeger.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.BorrowedProduct)
                .WithOne(x => x.BorrowedBy);

            builder.HasData(new List<User>()
            {
                new User() {Id = 1 ,Name = "Ali" , LastName = "rezayi" , UserName = "ali1234" , Passwrod = "123456"},
                new User() {Id = 2 , Name = " parsa" , LastName = " mousavi" , UserName = "parsa1383" , Passwrod = "123456"}


            });

        }

    }
}

