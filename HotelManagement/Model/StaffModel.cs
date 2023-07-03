using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Model
{
    public class StaffModel
    {
        public StaffModel(int id, string name, string phone, string idNo, string account, string password, string address, string role)
        {
            Id = id;
            Name = name;
            Phone = phone;
            IdNo = idNo;
            Account = account;
            Password = password;
            Address = address;
            Role = role;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string IdNo { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
