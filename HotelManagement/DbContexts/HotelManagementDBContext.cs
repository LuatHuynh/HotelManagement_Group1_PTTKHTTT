﻿using HotelManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelManagement.DbContexts
{
     public class HotelManagementDBContext:DbContext
    {
        public DbSet<Regulation> Regulation {get; set;}
        public DbSet<Role> Roles { get; set;}
        public DbSet<RoleStaff> RoleStaff { get; set;}
        public DbSet<Room> Rooms { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer()
            base.OnConfiguring(optionsBuilder);
        }
    }
}
