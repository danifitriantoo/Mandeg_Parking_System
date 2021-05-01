using PC_KAB_GROBOGAN.Models;
using PC_KAB_GROBOGAN.Setup;
using PC_KAB_GROBOGAN.Views.Home;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PC_KAB_GROBOGAN.ViewModels
{
    class PaymentViewModel : INotifyPropertyChanged
    {
        public PaymentViewModel()
        {
            dbconn = new DBConnection();
            model = new Vehicle();
            collection = new ObservableCollection<Vehicle>();

            //ASYNC TASK
            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
        }



        //COMMAND
        public RelayCommand InsertCommand { get; set; }


        //COLLECTION
        public ObservableCollection<Vehicle> Collection
        {
            get
            {
                return collection;
            }
            set
            {
                collection = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        //MODELS
        public Vehicle Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        //ADD-ON
        public event PropertyChangedEventHandler PropertyChanged;
        public event Action OnCallBack;

        //PRIVATE PRORS
        private readonly DBConnection dbconn;
        private Vehicle model;
        private ObservableCollection<Vehicle> collection;


        //CRUD
        private async Task InsertDataAsync()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"INSERT INTO Vehicle VALUES(" +
                $"'{model.vehicle_type_id}'," +
                $"'{model.member_id}'" +
                $"'{model.license_plate}'" +
                $"'{model.notes}'" +
                $"'{model.created_at}'" +
                $"'{model.last_updated_at}'" +
                $"'{model.deleted_at}'" +
                $")";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteNonQuery();
            MessageBox.Show("SUCCESS ADDED DATA");
            dbconn.conn.Close();

        }

    }
}
