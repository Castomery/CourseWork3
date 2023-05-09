using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class FacultyContact
    {

        public FacultyContact(int id, int facultyId, int positionId, int contactId)
        {
            Id = id;
            FacultyId = facultyId;
            PositionId = positionId;
            ContactId = contactId;
        }

        public int Id { get; }
        public int FacultyId { get; }
        public int PositionId { get; }
        public int ContactId { get; }
    }
}
