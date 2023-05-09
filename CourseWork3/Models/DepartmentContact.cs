using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class DepartmentContact
    {

        public DepartmentContact(int id, int departmentId, int positionId, int contactId)
        {
            Id = id;
            DepartmentId = departmentId;
            PositionId = positionId;
            ContactId = contactId;
        }

        public int Id { get; }
        public int DepartmentId { get; }
        public int PositionId { get; }
        public int ContactId { get; }
    }
}
