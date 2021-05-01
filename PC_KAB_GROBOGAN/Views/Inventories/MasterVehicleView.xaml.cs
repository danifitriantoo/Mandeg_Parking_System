using PC_KAB_GROBOGAN.ViewModels;
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

namespace PC_KAB_GROBOGAN.Views.Inventories
{
    /// <summary>
    /// Interaction logic for MasterVehicleView.xaml
    /// </summary>
    public partial class MasterVehicleView : Window
    {
        public MasterVehicleView()
        {
            InitializeComponent();
            vm = new VehicleViewModel();
            DataContext = vm;



        }

        private VehicleViewModel vm;

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

            btnInsert.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            btnDelete.IsEnabled = false;
            btnSubmit.IsEnabled = true;
            btnCancle.IsEnabled = true;
            txtName.IsEnabled = true;
            txtNotes.IsEnabled = true;
            txtPlate.IsEnabled = true;
            btnSubmit.Command = vm.InsertCommand;

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            btnInsert.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            btnDelete.IsEnabled = false;
            btnSubmit.IsEnabled = true;
            btnCancle.IsEnabled = true;
            txtName.IsEnabled = true;
            txtNotes.IsEnabled = true;
            txtPlate.IsEnabled = true;
            btnSubmit.Command = vm.UpdateCommand;

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            btnInsert.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            btnDelete.IsEnabled = false;
            btnSubmit.IsEnabled = true;
            btnCancle.IsEnabled = true;
            btnSubmit.Command = vm.DeleteCommand;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancle_Click(object sender, RoutedEventArgs e)
        {
            btnInsert.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;
            btnSubmit.IsEnabled = false;
            btnCancle.IsEnabled = false;
        }
    }
}
