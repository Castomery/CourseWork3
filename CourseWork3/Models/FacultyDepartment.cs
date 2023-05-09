using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class FacultyDepartment
    {
        public FacultyDepartment(int id, string facultyDepartmentName, int facultyId, int? contactId)
        {
            Id = id;
            FacultyDepartmentName = facultyDepartmentName;
            FacultyId = facultyId;
            ContactId = contactId;
        }

        public int Id { get; }
        public string FacultyDepartmentName { get; }
        public int FacultyId { get; }
        public int? ContactId { get; }

    }
}
