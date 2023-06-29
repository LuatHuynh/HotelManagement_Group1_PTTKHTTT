using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DbContexts
{
    public class HotelManagementDBContextFactory
    { 
        private readonly string _connectionStr;

        public HotelManagementDBContextFactory(string connectionStr)
        {
            _connectionStr = connectionStr;
        }

        public HotelManagementDBContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<HotelManagementDBContext>();
            options.UseSqlServer(_connectionStr);

            return new HotelManagementDBContext(options.Options);
        }
    }
}
