using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using CourseWork3.Commands;
using CourseWork3.Database;

namespace CourseWork3.ViewModels.Base
{
    internal abstract class UserControlViewModel : ViewModel
    {
        #region Visibility

        private Visibility _viewDataVisibility = Visibility.Visible;
        private Visibility _creatingVisibility = Visibility.Collapsed;
        private Visibility _editFieldVisibility = Visibility.Collapsed;

        public Visibility ViewDataVisibility
        {
            get => _viewDataVisibility;
            set => Set(ref _viewDataVisibility, value);
        }

        public Visibility CreatingDataVisibility
        {
            get => _creatingVisibility;
            set => Set(ref _creatingVisibility, value);
        }

        public Visibility EditDataVisibility
        {
            get => _editFieldVisibility;
            set => Set(ref _editFieldVisibility, value);
        }

        #endregion

        protected DatabaseService _databaseService;

        #region Commands

        public ICommand EnterViewDataStateCommand { get; }

        private bool CanEnterViewDataStateCommandExecute(object p) => true;
        private void OnEnterViewDataStateCommandExecute(object p)
        {
            CreatingDataVisibility = Visibility.Collapsed;
            ViewDataVisibility = Visibility.Visible;
            EditDataVisibility = Visibility.Collapsed;
        }

        public ICommand EnterCreatingDataStateCommand { get; }

        private bool CanEnterCreatingDataStateCommandExecute(object p) => true;
        private void OnEnterCreatingDataStateCommandExecute(object p)
        {
            CreatingDataVisibility = Visibility.Visible;
            ViewDataVisibility = Visibility.Collapsed;
            EditDataVisibility = Visibility.Collapsed;
        }

        public ICommand EnterEditFieldStateCommand { get; }

        private bool CanEnterEditFieldStateCommandExecute(object p) => true;
        private void OnEnterEditFieldStateCommandExecute(object p)
        {
            CreatingDataVisibility = Visibility.Collapsed;
            ViewDataVisibility = Visibility.Collapsed;
            EditDataVisibility = Visibility.Visible;
        }

        #region Creat-Edit Records

        public ICommand CreateRecord { get; }
        protected bool CanCreateRecordCommandExecute(object p) => true;

        protected abstract void OnCreateRecordCommandExecute(object p);

        public ICommand DeleteRecord { get; }
        protected bool CanDeleteRecordCommandExecute(object p) => true;

        protected abstract void OnDeleteRecordCommandExecute(object p);

        #endregion

        #endregion

        protected UserControlViewModel()
        {
            EnterViewDataStateCommand = new LambdaCommand(OnEnterViewDataStateCommandExecute, CanEnterViewDataStateCommandExecute);
            EnterCreatingDataStateCommand = new LambdaCommand(OnEnterCreatingDataStateCommandExecute,CanEnterCreatingDataStateCommandExecute);
            EnterEditFieldStateCommand = new LambdaCommand(OnEnterEditFieldStateCommandExecute, CanEnterEditFieldStateCommandExecute);
            CreateRecord = new LambdaCommand(OnCreateRecordCommandExecute, CanCreateRecordCommandExecute);
            DeleteRecord = new LambdaCommand(OnDeleteRecordCommandExecute, CanDeleteRecordCommandExecute);

            _databaseService = DatabaseService.Instance;
        }
    }
}
