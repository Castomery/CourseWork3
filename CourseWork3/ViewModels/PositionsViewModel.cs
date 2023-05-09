using CourseWork3.Models;
using CourseWork3.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.ViewModels
{
    internal class PositionsViewModel : UserControlViewModel
    {
        private List<Position> _positions;
        public List<Position> PositionsList {
            get => _positions;
            set => Set(ref _positions, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public PositionsViewModel() : base()
        {
            PositionsList = _databaseService.GetAllPositions();
        }

        protected override void OnCreateRecordCommandExecute(object p)
        {
            _databaseService.CreatePosition(Name);
            PositionsList = _databaseService.GetAllPositions();
            EnterViewDataStateCommand.Execute(p);
        }

        protected override void OnDeleteRecordCommandExecute(object p)
        {
            Position position = p as Position;
            _databaseService.DeletePosition(position.Id);
            PositionsList = _databaseService.GetAllPositions();
        }
    }
}
