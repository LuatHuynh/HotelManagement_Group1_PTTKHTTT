using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Model
{
    public class ServiceModel
    {
        public ServiceModel(int id, string name, string type,int unit, double price )

        {

            this.Price = price;
            Id = id;
            this.Name = name;
            this.Type = type;
            this.Unit =unit;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Unit { get; set; }
    }
}
