using CourseWork3.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork3.Views.UserControls
{
    /// <summary>
    /// Interaction logic for FacultyDepartmentContacts.xaml
    /// </summary>
    public partial class FacultyDepartmentContacts : UserControl
    {
        public FacultyDepartmentContacts(ViewModel dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
        }
    }
}
