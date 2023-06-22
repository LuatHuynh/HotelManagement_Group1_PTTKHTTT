using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class RoleStaff
    {
        public int StaffID { get; set; }
        public int RoleID{ get; set; }
        public Staff Staff{ get; set; }

        public Role Role { get; set; }


    }
}
