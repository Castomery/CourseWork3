using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class TypeOfDepartment
    {
        public TypeOfDepartment(int id, string name)
        {
            Id = id;
            TypeOfDepartmentName = name;
        }

        public int Id { get; }
        public string TypeOfDepartmentName { get; }
    }
}
