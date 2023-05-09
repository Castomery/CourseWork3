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
    internal class DepartmentContactsViewModel : UserControlViewModel
    {
        private List<DepartmentContact> _departmentContacts;
        public List<DepartmentContact> DepartmentContactsList
        {
            get => _departmentContacts;
            set => Set(ref _departmentContacts, value);
        }

        private DepartmentContact _currDepartmentContact;
        public DepartmentContact CurrDepartmentContact
        {
            get => _currDepartmentContact;
            set => Set(ref _currDepartmentContact, value);
        }

        private List<Department> _departments;
        public List<Department> Departments
        {
            get => _departments;
            set => Set(ref _departments, value);
        }

        private Department _selectedDepartment;
        public Department SelectedDepartment
        {
            get => _selectedDepartment;
            set => Set(ref _selectedDepartment, value);
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

        public DepartmentContactsViewModel() : base()
        {
            DepartmentContactsList = _databaseService.GetAllDepartmentContacts();
            Contacts = _databaseService.GetAllContacts();
            Positions = _databaseService.GetAllPositions();
            Departments = _databaseService.GetAllDepartments();
            EditRecord = new LambdaCommand(OnEditRecordCommandExecute, CanEditRecordCommandExecute);
            SaveEditedRecord = new LambdaCommand(OnSaveEditedRecordCommandExecute, CanSaveEditedRecordCommandExecute);
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateDepartmentContact(SelectedDepartment.Id, SelectedPosition.Id, SelectedContact.Id);
            DepartmentContactsList = _databaseService.GetAllDepartmentContacts();
            EnterViewDataStateCommand.Execute(p);
        }

        public ICommand EditRecord { get; }
        protected bool CanEditRecordCommandExecute(object p) => true;
        protected void OnEditRecordCommandExecute(object p)
        {
            EnterEditFieldStateCommand.Execute(p);
            CurrDepartmentContact = p as DepartmentContact;
        }

        public ICommand SaveEditedRecord { get; }
        protected bool CanSaveEditedRecordCommandExecute(object p) => true;
        protected void OnSaveEditedRecordCommandExecute(object p)
        {
            _databaseService.EditDepartmentContact(CurrDepartmentContact.Id, SelectedDepartment.Id, SelectedPosition.Id, SelectedContact.Id);
            DepartmentContactsList = _databaseService.GetAllDepartmentContacts();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            DepartmentContact departmentContact = p as DepartmentContact;
            _databaseService.DeleteDepartmentContact(departmentContact.Id);
            DepartmentContactsList = _databaseService.GetAllDepartmentContacts();
        }
    }
}
