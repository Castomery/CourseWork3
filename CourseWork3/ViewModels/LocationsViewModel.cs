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
    internal class LocationsViewModel : UserControlViewModel
    {
        private List<Location> _locations;
        public List<Location> LocationsList 
        {
            get => _locations;
            set => Set(ref _locations, value);
        }

        private string _address;
        public string Address
        {
            get => _address;
            set => Set(ref _address, value);
        }

        public LocationsViewModel() : base()
        {
            LocationsList = _databaseService.GetAllLocations();
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreateLocation(Address);
            LocationsList = _databaseService.GetAllLocations();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            Location location = p as Location;
            _databaseService.DeleteLocation(location.Id);
            LocationsList = _databaseService.GetAllLocations();
        }
    }
}
