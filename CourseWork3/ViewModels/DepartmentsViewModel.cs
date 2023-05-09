using CourseWork3.Models;
using CourseWork3.ViewModels.Base;
using CourseWork3.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.ViewModels
{
    internal class DepartmentsViewModel : UserControlViewModel
    {
        private List<Department> _departments;
        public List<Department> DepartmentsList
        {
            get => _departments;
            set => Set(ref _departments, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private List<TypeOfDepartment> _typeOfDepartments;
        public List<TypeOfDepartment> TypeOfDepartments
        {
            get => _typeOfDepartments;
            set => Set(ref _typeOfDepartments, value);
        }

        private TypeOfDepartment _selectedTypeOfDepartment;
        public TypeOfDepartment SelectedTypeOfDepartment
        {
            get => _selectedTypeOfDepartment; 
            set => Set(ref _selectedTypeOfDepartment, value);
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

        public DepartmentsViewModel() : base()
        {
            DepartmentsList = _databaseService.GetAllDepartments();
            TypeOfDepartments = _databaseService.GetAllTypesOfDepartment();
            LocationsList = _databaseService.GetAllLocations();
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateDepartment(Name, SelectedTypeOfDepartment.Id, SelectedLocation.Id);
            DepartmentsList = _databaseService.GetAllDepartments();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            Department department = p as Department;
            _databaseService.DeleteDepartment(department.Id);
            DepartmentsList = _databaseService.GetAllDepartments();
        }
    }
}
