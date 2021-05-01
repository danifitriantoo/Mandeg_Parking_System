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

namespace PC_KAB_GROBOGAN.Views.Transaction
{
    /// <summary>
    /// Interaction logic for ParkingPaymentView.xaml
    /// </summary>
    public partial class ParkingPaymentView : Window
    {
        public ParkingPaymentView()
        {
            InitializeComponent();
            vm = new PaymentViewModel();
            DataContext = vm;
        }

        private PaymentViewModel vm;
    }
}
