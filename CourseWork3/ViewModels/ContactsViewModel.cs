using CourseWork3.Models;
using CourseWork3.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.ViewModels
{
    internal class ContactsViewModel : UserControlViewModel
    {
        private List<Contact> _contacts;
        public List<Contact> ContactsList {
            get => _contacts;
            set => Set(ref _contacts, value);
        }

        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set => Set(ref _fullName, value);
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => Set(ref _phoneNumber, value);
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => Set(ref _email, value);
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateContact(FullName,PhoneNumber,Email);
            ContactsList = _databaseService.GetAllContacts();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            Contact contact = p as Contact;
            _databaseService.DeleteContact(contact.Id);
            ContactsList = _databaseService.GetAllContacts();
        }

        public ContactsViewModel() : base() 
        {
            ContactsList = _databaseService.GetAllContacts();
        }
    }
}
