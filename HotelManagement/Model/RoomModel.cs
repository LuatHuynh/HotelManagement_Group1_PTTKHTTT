using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Model
{
    public class RoomModel
    {
        public RoomModel(int id, string status, string regulation)
        {
            Id = id;
            this.status = status;
            Regulation = regulation;
        }

        public int Id { get; set; }
        public string status { get; set; }
        public string Regulation { get; set; }
    }
}
