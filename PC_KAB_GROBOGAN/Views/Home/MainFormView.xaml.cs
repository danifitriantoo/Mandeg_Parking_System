using PC_KAB_GROBOGAN.Views.Inventories;
using PC_KAB_GROBOGAN.Views.Transaction;
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

namespace PC_KAB_GROBOGAN.Views.Home
{
    /// <summary>
    /// Interaction logic for MainFormView.xaml
    /// </summary>
    public partial class MainFormView : Window
    {
        public MainFormView()
        {
            InitializeComponent();
            lblName.Content = App.UserName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MasterMemberView member = new MasterMemberView();
            member.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MasterVehicleView vehicle = new MasterVehicleView();
            vehicle.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ParkingPaymentView vehicle = new ParkingPaymentView();
            vehicle.Show();
        }
    }
}
