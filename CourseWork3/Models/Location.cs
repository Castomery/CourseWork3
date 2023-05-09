using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class Location
    {

        public Location(int id, string address)
        {
            Id = id;
            Address = address;
        }

        public int Id { get; }
        public string Address { get; }
    }
}
