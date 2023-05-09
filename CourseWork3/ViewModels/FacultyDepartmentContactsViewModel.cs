using CourseWork3.Commands;
using CourseWork3.Models;
using CourseWork3.ViewModels.Base;
using CourseWork3.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace CourseWork3.ViewModels
{
    internal class FacultyDepartmentContactsViewModel : UserControlViewModel
    {
        private List<FacultyDepartmentContact> _facultyDepartmentContacts;
        public List<FacultyDepartmentContact> FacultyDepartmentContactsList
        {
            get => _facultyDepartmentContacts;
            set => Set(ref _facultyDepartmentContacts, value);
        }

        private FacultyDepartmentContact _currfacultyDepartmentContact;
        public FacultyDepartmentContact CurrentFacultyDepartmentContact
        {
            get => _currfacultyDepartmentContact;
            set => Set(ref _currfacultyDepartmentContact, value);
        }

        private List<FacultyDepartment> _facultyDepartments;
        public List<FacultyDepartment> FacultyDepartments
        {
            get => _facultyDepartments;
            set => Set(ref _facultyDepartments, value);
        }

        private FacultyDepartment _selectedFacultyDepartment;
        public FacultyDepartment SelectedFacultyDepartment
        {
            get => _selectedFacultyDepartment;
            set => Set(ref _selectedFacultyDepartment, value);
        }

        private List<Position> _positions;
        public List<Position> Positions
        {
            get => _positions;
            set => Set(ref _positions, value);
        }

        private Position _selectedPosition;
        public Position SelectedPosition
        {
            get => _selectedPosition;
            set => Set(ref _selectedPosition, value);
        }

        private List<Contact> _contacts;
        public List<Contact> Contacts
        {
            get => _contacts;
            set => Set(ref _contacts, value);
        }

        private Contact _selectedContact;
        public Contact SelectedContact
        {
            get => _selectedContact;
            set => Set(ref _selectedContact, value);
        }

        public FacultyDepartmentContactsViewModel() : base()
        {
            FacultyDepartmentContactsList = _databaseService.GetAllFacultyDepartmentContacts();
            FacultyDepartments = _databaseService.GetAllFacultyDepartments();
            Positions= _databaseService.GetAllPositions();
            Contacts = _databaseService.GetAllContacts();
            EditRecord = new LambdaCommand(OnEditRecordCommandExecute, CanEditRecordCommandExecute);
            SaveEditedRecord = new LambdaCommand(OnSaveEditedRecordCommandExecute, CanSaveEditedRecordCommandExecute);
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateFacultyDepartmentContact(SelectedFacultyDepartment.Id, SelectedPosition.Id, SelectedContact.Id);
            FacultyDepartmentContactsList = _databaseService.GetAllFacultyDepartmentContacts();
            EnterViewDataStateCommand.Execute(p);
        }

        public ICommand EditRecord { get; }
        protected bool CanEditRecordCommandExecute(object p) => true;
        protected void OnEditRecordCommandExecute(object p)
        {
            EnterEditFieldStateCommand.Execute(p);
            CurrentFacultyDepartmentContact = p as FacultyDepartmentContact;
        }

        public ICommand SaveEditedRecord { get; }
        protected bool CanSaveEditedRecordCommandExecute(object p) => true;
        protected void OnSaveEditedRecordCommandExecute(object p)
        {
            _databaseService.EditFacultyDepartmentContact(CurrentFacultyDepartmentContact.Id, SelectedFacultyDepartment.Id, SelectedPosition.Id, SelectedContact.Id);
            FacultyDepartmentContactsList = _databaseService.GetAllFacultyDepartmentContacts();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            FacultyDepartmentContact facultyDepartmentContact = p as FacultyDepartmentContact;
            _databaseService.DeleteFacultyDepartmentContact(facultyDepartmentContact.Id);
            FacultyDepartmentContactsList = _databaseService.GetAllFacultyDepartmentContacts();
        }
    }
}
