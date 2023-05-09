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

namespace CourseWork3.ViewModels
{
    internal class FacultiesViewModel : UserControlViewModel
    {
        private List<Faculty> _faculties;
        public List<Faculty> FacultiesList
        {
            get => _faculties;
            set => Set(ref _faculties, value);
        }

        private Faculty _currFaculty;
        public Faculty CurrFaculty
        {
            get => _currFaculty;
            set => Set(ref _currFaculty, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private List<Location> _locations;
        public List<Location> LocationsList
        {
            get => _locations;
            set => Set(ref _locations, value);
        }

        private Location _selectedLocation;
        public Location SelectedLocation
        {
            get => _selectedLocation;
            set => Set(ref _selectedLocation, value);
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

        public FacultiesViewModel() : base()
        {
            FacultiesList = _databaseService.GetAllFaculties();
            LocationsList = _databaseService.GetAllLocations();
            Contacts = _databaseService.GetAllContacts();
            EditRecord = new LambdaCommand(OnEditRecordCommandExecute, CanEditRecordCommandExecute);
            SaveEditedRecord = new LambdaCommand(OnSaveEditedRecordCommandExecute, CanSaveEditedRecordCommandExecute);
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateFaculty(Name, SelectedLocation.Id, SelectedContact.Id);
            FacultiesList = _databaseService.GetAllFaculties();
            EnterViewDataStateCommand.Execute(p);
        }

        public ICommand EditRecord { get; }
        protected bool CanEditRecordCommandExecute(object p) => true;
        protected void OnEditRecordCommandExecute(object p)
        {
            EnterEditFieldStateCommand.Execute(p);
            CurrFaculty = p as Faculty;
            Name = CurrFaculty.FacultyName;
        }

        public ICommand SaveEditedRecord { get; }
        protected bool CanSaveEditedRecordCommandExecute(object p) => true;
        protected void OnSaveEditedRecordCommandExecute(object p)
        {
            _databaseService.EditFaculty(CurrFaculty.Id, Name, SelectedLocation.Id, SelectedContact.Id);
            FacultiesList = _databaseService.GetAllFaculties();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            Faculty faculty = p as Faculty;
            _databaseService.DeleteFaculty(faculty.Id);
            FacultiesList = _databaseService.GetAllFaculties();
        }
    }
}
