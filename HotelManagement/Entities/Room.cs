using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
     public class Room
    {
        public int Id { get; set; }
        public string status { get; set; }
        public Regulation Regulation { get; set; }
    }
}
