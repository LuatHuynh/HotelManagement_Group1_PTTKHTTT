using HotelManagement.DbContexts;
using HotelManagement.Entities;
using HotelManagement.Services.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Services
{
    public class RegulationService : IRegulationService
    {
        private readonly HotelManagementDBContextFactory _dbContextFactory;

        public RegulationService(HotelManagementDBContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Regulation>> getAll()
        {
            using(HotelManagementDBContext context= _dbContextFactory.CreateDbContext())
            {
                return await context.Regulation.ToListAsync();
            }
        }

    }
}


