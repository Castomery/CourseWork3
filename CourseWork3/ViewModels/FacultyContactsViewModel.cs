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
    internal class FacultyContactsViewModel : UserControlViewModel
    {
        private List<FacultyContact> _facultyContacts;
        public List<FacultyContact> FacultyContactsList
        {
            get => _facultyContacts;
            set => Set(ref _facultyContacts, value);
        }

        private FacultyContact _currfacultyContact;
        public FacultyContact CurrentFacultyContact
        {
            get => _currfacultyContact;
            set => Set(ref _currfacultyContact, value);
        }

        private List<Faculty> _faculties;
        public List<Faculty> Faculties
        {
            get => _faculties;
            set => Set(ref _faculties, value);
        }

        private Faculty _selectedFaculty;
        public Faculty SelectedFaculty
        {
            get => _selectedFaculty;
            set => Set(ref _selectedFaculty, value);
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
        public FacultyContactsViewModel() : base()
        {
            FacultyContactsList = _databaseService.GetAllFacultyContacts();
            Faculties = _databaseService.GetAllFaculties();
            Positions = _databaseService.GetAllPositions();
            Contacts = _databaseService.GetAllContacts();
            EditRecord = new LambdaCommand(OnEditRecordCommandExecute, CanEditRecordCommandExecute);
            SaveEditedRecord = new LambdaCommand(OnSaveEditedRecordCommandExecute, CanSaveEditedRecordCommandExecute);
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateFacultyContact(SelectedFaculty.Id, SelectedPosition.Id, SelectedContact.Id);
            FacultyContactsList = _databaseService.GetAllFacultyContacts();
            EnterViewDataStateCommand.Execute(p);
        }

        public ICommand EditRecord { get; }
        protected bool CanEditRecordCommandExecute(object p) => true;
        protected void OnEditRecordCommandExecute(object p)
        {
            EnterEditFieldStateCommand.Execute(p);
            CurrentFacultyContact = p as FacultyContact;
        }

        public ICommand SaveEditedRecord { get; }
        protected bool CanSaveEditedRecordCommandExecute(object p) => true;
        protected void OnSaveEditedRecordCommandExecute(object p)
        {
            _databaseService.EditFacultyContact(CurrentFacultyContact.Id, SelectedFaculty.Id, SelectedPosition.Id, SelectedContact.Id);
            FacultyContactsList = _databaseService.GetAllFacultyContacts();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            FacultyContact facultyDepartmentContact = p as FacultyContact;
            _databaseService.DeleteFacultyContact(facultyDepartmentContact.Id);
            FacultyContactsList = _databaseService.GetAllFacultyContacts();
        }
    }
}
