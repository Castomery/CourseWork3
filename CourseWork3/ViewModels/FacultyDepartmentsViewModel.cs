using CourseWork3.Commands;
using CourseWork3.Models;
using CourseWork3.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace CourseWork3.ViewModels
{
    internal class FacultyDepartmentsViewModel : UserControlViewModel
    {
        private List<FacultyDepartment> _facultyDepartments;
        public List<FacultyDepartment> FacultyDepartmentsList
        {
            get => _facultyDepartments;
            set => Set(ref _facultyDepartments, value);
        }

        private FacultyDepartment _currFacultyDepartment;
        public FacultyDepartment CurrFacultyDepartment
        {
            get => _currFacultyDepartment;
            set => Set(ref _currFacultyDepartment, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private List<Faculty> _faculties;
        public List<Faculty> FacultiesList
        {
            get => _faculties;
            set => Set(ref _faculties, value);
        }

        private Faculty _selectedfaculty;
        public Faculty SelectedFaculty
        {
            get => _selectedfaculty;
            set => Set(ref _selectedfaculty, value);
        }

        private List<Contact> _contacts;
        public List<Contact> ContactsList
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

        public FacultyDepartmentsViewModel() : base()
        {
            FacultyDepartmentsList = _databaseService.GetAllFacultyDepartments();
            FacultiesList = _databaseService.GetAllFaculties();
            ContactsList = _databaseService.GetAllContacts();
            EditRecord = new LambdaCommand(OnEditRecordCommandExecute, CanEditRecordCommandExecute);
            SaveEditedRecord = new LambdaCommand(OnSaveEditedRecordCommandExecute, CanSaveEditedRecordCommandExecute);
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateFacultyDepartment(Name, SelectedFaculty.Id, SelectedContact.Id);
            FacultyDepartmentsList = _databaseService.GetAllFacultyDepartments();
            EnterViewDataStateCommand.Execute(p);
        }

        public ICommand EditRecord { get; }
        protected bool CanEditRecordCommandExecute(object p) => true;
        protected void OnEditRecordCommandExecute(object p)
        {
            EnterEditFieldStateCommand.Execute(p);
            CurrFacultyDepartment = p as FacultyDepartment;
            Name = CurrFacultyDepartment.FacultyDepartmentName;
        }

        public ICommand SaveEditedRecord { get; }
        protected bool CanSaveEditedRecordCommandExecute(object p) => true;
        protected void OnSaveEditedRecordCommandExecute(object p)
        {
            _databaseService.EditFacultyDepartment(CurrFacultyDepartment.Id, Name, SelectedFaculty.Id, SelectedContact.Id);
            FacultyDepartmentsList = _databaseService.GetAllFacultyDepartments();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            FacultyDepartment facultyDepartment = p as FacultyDepartment;
            _databaseService.DeleteFacultyDepartment(facultyDepartment.Id);
            FacultyDepartmentsList = _databaseService.GetAllFacultyDepartments();
        }
    }
}
