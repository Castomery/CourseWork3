using CourseWork3.Commands;
using CourseWork3.Database;
using CourseWork3.ViewModels.Base;
using CourseWork3.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace CourseWork3.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        //private UserControl _currentContentInQueryPanel;
        //public UserControl CurrentContentInQueryPanel
        //{
        //    get => _currentContentInQueryPanel;
        //    set => Set(ref _currentContentInQueryPanel, value);
        //}

        private DatabaseService _databaseService;

        private string _currentCustomQuery;

        public string CurrentCustomQuery
        {
            get => _currentCustomQuery;
            set => Set(ref _currentCustomQuery, value);
        }

        private DataView _currentDataView;

        public  DataView CurrentDataView
        {
            get => _currentDataView;
            set => Set(ref _currentDataView, value);
        }


        private UserControl _currentContentInTables;
        public UserControl CurrentContentInTables
        {
            get => _currentContentInTables;
            set => Set(ref _currentContentInTables, value);
        }

        private ViewModel _currentViewModelInTables;
        public ViewModel CurrentViewModelInTables
        {
            get => _currentViewModelInTables;
            set => Set(ref _currentViewModelInTables, value);
        }

        #region COMMANDS
        public ICommand LoadContacts { get; }
        private bool CanLoadContactsCommandExecute(object p) => true;
        private void OnLoadContactsCommandExecute(object p)
        {
            CurrentViewModelInTables = new ContactsViewModel();
            CurrentContentInTables = new Contacts(CurrentViewModelInTables);
        }

        public ICommand LoadDepartments { get; }
        private bool CanLoadDepartmentsCommandExecute(object p) => true;
        private void OnLoadDepartmentsCommandExecute(object p)
        {
            CurrentViewModelInTables = new DepartmentsViewModel();
            CurrentContentInTables = new Departments(CurrentViewModelInTables);
        }
        public ICommand LoadLocations { get; }
        private bool CanLoadLocationsCommandExecute(object p) => true;
        private void OnLoadLocationsCommandExecute(object p)
        {
            CurrentViewModelInTables = new LocationsViewModel();
            CurrentContentInTables = new Locations(CurrentViewModelInTables);
        }


        public ICommand LoadTypesOfDepartment { get; }
        private bool CanLoadTypesOfDepartmentCommandExecute(object p) => true;
        private void OnLoadTypesOfDepartmentCommandExecute(object p)
        {
            CurrentViewModelInTables = new TypesOfDepartmentViewModel();
            CurrentContentInTables = new TypesOfDepartment(CurrentViewModelInTables);
        }

        public ICommand LoadPositions { get; }
        private bool CanLoadPositionsCommandExecute(object p) => true;
        private void OnLoadPositionsCommandExecute(object p)
        {
            CurrentViewModelInTables = new PositionsViewModel();
            CurrentContentInTables = new Positions(CurrentViewModelInTables);
        }
        public ICommand LoadFaculties { get; }
        private bool CanLoadFacultiesCommandExecute(object p) => true;
        private void OnLoadFacultiesCommandExecute(object p)
        {
            CurrentViewModelInTables = new FacultiesViewModel();
            CurrentContentInTables = new Faculties(CurrentViewModelInTables);
        }
        public ICommand LoadFacultyDepartments { get; }
        private bool CanLoadFacultyDepartmentsCommandExecute(object p) => true;
        private void OnLoadFacultyDepartmentsCommandExecute(object p)
        {
            CurrentViewModelInTables = new FacultyDepartmentsViewModel();
            CurrentContentInTables = new FacultyDepartments(CurrentViewModelInTables);
        }
        public ICommand LoadFacultyContacts { get; }
        private bool CanLoadFacultyContactsCommandExecute(object p) => true;
        private void OnLoadFacultyContactsCommandExecute(object p)
        {
            CurrentViewModelInTables = new FacultyContactsViewModel();
            CurrentContentInTables = new FacultyContacts(CurrentViewModelInTables);
        }
        public ICommand LoadDepartmentContacts { get; }
        private bool CanLoadDepartmentContactsCommandExecute(object p) => true;
        private void OnLoadDepartmentContactsCommandExecute(object p)
        {
            CurrentViewModelInTables = new DepartmentContactsViewModel();
            CurrentContentInTables = new DepartmentContacts(CurrentViewModelInTables);
        }
        public ICommand LoadFacultyDepartmentContacts { get; }
        private bool CanLoadFacultyDepartmentContactsCommandExecute(object p) => true;
        private void OnLoadFacultyDepartmentContactsCommandExecute(object p)
        {
            CurrentViewModelInTables = new FacultyDepartmentContactsViewModel();
            CurrentContentInTables = new FacultyDepartmentContacts(CurrentViewModelInTables);
        }

        public ICommand LoadCustomData { get; }
        private bool CanLoadCutomDataCommandExecute(object p) => true;
        private void OnLoadCustomDataCommandExecute(object p)
        {
            CurrentDataView = _databaseService.ExecuteCustomQuery(CurrentCustomQuery);
        }
        #endregion

        public MainWindowViewModel()
        {
            _databaseService = DatabaseService.Instance;

            LoadContacts = new LambdaCommand(OnLoadContactsCommandExecute, CanLoadContactsCommandExecute);
            LoadPositions = new LambdaCommand(OnLoadPositionsCommandExecute, CanLoadPositionsCommandExecute);
            LoadTypesOfDepartment = new LambdaCommand(OnLoadTypesOfDepartmentCommandExecute, CanLoadTypesOfDepartmentCommandExecute);
            LoadLocations = new LambdaCommand(OnLoadLocationsCommandExecute, CanLoadLocationsCommandExecute);
            LoadFaculties = new LambdaCommand(OnLoadFacultiesCommandExecute, CanLoadFacultiesCommandExecute);
            LoadFacultyDepartments = new LambdaCommand(OnLoadFacultyDepartmentsCommandExecute, CanLoadFacultyDepartmentsCommandExecute);
            LoadDepartments = new LambdaCommand(OnLoadDepartmentsCommandExecute, CanLoadDepartmentsCommandExecute);
            LoadFacultyContacts = new LambdaCommand(OnLoadFacultyContactsCommandExecute, CanLoadFacultyContactsCommandExecute);
            LoadFacultyDepartmentContacts = new LambdaCommand(OnLoadFacultyDepartmentContactsCommandExecute, CanLoadFacultyDepartmentContactsCommandExecute);
            LoadDepartmentContacts = new LambdaCommand(OnLoadDepartmentContactsCommandExecute, CanLoadDepartmentContactsCommandExecute);
            LoadCustomData = new LambdaCommand(OnLoadCustomDataCommandExecute, CanLoadCutomDataCommandExecute);
        }

    }
}
