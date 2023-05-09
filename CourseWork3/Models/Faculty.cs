using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class Faculty
    {

        public Faculty(int id, string facultyName, int locationId, int? contactId)
        {
            Id = id;
            FacultyName = facultyName;
            LocationId = locationId;
            ContactId = contactId;
        }

        public int Id { get; }
        public string FacultyName { get; }
        public int LocationId { get; }
        public int? ContactId { get; }
    }
}
