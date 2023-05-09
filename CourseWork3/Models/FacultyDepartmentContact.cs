using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class FacultyDepartmentContact
    {

        public FacultyDepartmentContact(int id, int facultyDepartmentId, int positionId, int contactId)
        {
            Id = id;
            FacultyDepartmentId = facultyDepartmentId;
            PositionId = positionId;
            ContactId = contactId;
        }

        public int Id { get; }
        public int FacultyDepartmentId { get; }
        public int PositionId { get; }
        public int ContactId { get; }
    }
}
