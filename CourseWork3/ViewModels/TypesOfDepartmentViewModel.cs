using CourseWork3.Models;
using CourseWork3.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWork3.ViewModels
{
    internal class TypesOfDepartmentViewModel : UserControlViewModel
    {
        private List<TypeOfDepartment> _typesOfDepartment;
        public List<TypeOfDepartment> TypesOfDepartment 
        {
            get => _typesOfDepartment;
            set => Set(ref _typesOfDepartment, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name,value);
        }

        public TypesOfDepartmentViewModel() : base()
        {
            TypesOfDepartment = _databaseService.GetAllTypesOfDepartment();
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateTypeOfDepartment(Name);
            TypesOfDepartment = _databaseService.GetAllTypesOfDepartment();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            TypeOfDepartment service = p as TypeOfDepartment;
            _databaseService.DeleteTypeOfDepartment(service.Id);
            TypesOfDepartment = _databaseService.GetAllTypesOfDepartment();
        }
    }
}
