using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class Contact
    {
        public Contact(int id, string fullName, string phoneNumber, string email)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public int Id { get; }
        public string FullName { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
    }
}
