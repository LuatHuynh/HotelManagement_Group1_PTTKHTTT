using HotelManagement.Entities;
using HotelManagement.ViewModel.Admin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DbContexts
{
    class EntityConfiguration : IEntityTypeConfiguration<Regulation>,
                                IEntityTypeConfiguration<Role>,
                                IEntityTypeConfiguration<Room>,
                                IEntityTypeConfiguration<Staff>,
                                IEntityTypeConfiguration<RoleStaff>
    {
        public void Configure(EntityTypeBuilder<Regulation> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();

        }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
        }

        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
        }

        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
        }

        public void Configure(EntityTypeBuilder<RoleStaff> builder)
        {
            builder.HasKey(b => new { b.RoleID,   b.StaffID });
     
     
        }
    }
}
