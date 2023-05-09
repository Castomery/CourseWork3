using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class Department
    {

        public Department(int id, string departmentName, int serviceId, int locationId)
        {
            Id = id;
            DepartmentName = departmentName;
            ServiceId = serviceId;
            LocationId = locationId;
        }

        public int Id { get; }
        public string DepartmentName { get; }
        public int ServiceId { get; }
        public int LocationId { get; }
    }
}
