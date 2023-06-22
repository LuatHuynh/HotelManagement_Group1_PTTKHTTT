using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DbContexts
{
    class DesignTimeDbContextOptionFactory : IDesignTimeDbContextFactory<HotelManagementDBContext>
    {
        public HotelManagementDBContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<HotelManagementDBContext>();
            options.UseSqlServer( "Server=localhost;Database=myDataBase;Encrypt=True; Trusted_Connection=True;TrustServerCertificate=True;");

            return new HotelManagementDBContext(options.Options);
        }
    }
}
