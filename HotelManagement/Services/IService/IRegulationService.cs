using HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Services.IService
{
    public interface IRegulationService
    {

        Task<IEnumerable<Regulation>> getAll();

    }
}
