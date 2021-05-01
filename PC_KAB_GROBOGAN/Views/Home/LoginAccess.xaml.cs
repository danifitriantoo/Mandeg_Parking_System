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
using System.Windows.Shapes;
using PC_KAB_GROBOGAN.ViewModels;

namespace PC_KAB_GROBOGAN.Views.Home
{
    /// <summary>
    /// Interaction logic for LoginAccess.xaml
    /// </summary>
    public partial class LoginAccess : Window
    {
        public LoginAccess()
        {
            InitializeComponent();
            vm = new EmployeeViewModel();
            DataContext = vm;
        }

        private EmployeeViewModel vm;
    }
}
