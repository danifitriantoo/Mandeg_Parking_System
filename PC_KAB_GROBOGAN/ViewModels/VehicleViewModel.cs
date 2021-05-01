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
    public class VehicleViewModel : INotifyPropertyChanged
    {
        public VehicleViewModel()
        {
            dbconn = new DBConnection();
            model = new Vehicle();
            collection = new ObservableCollection<Vehicle>();

            //ASYNC TASK
            ReadCommand = new RelayCommand(async () => await ReadDataAsync());
            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
            UpdateCommand = new RelayCommand(async () => await UpdateDataAsync());
            DeleteCommand = new RelayCommand(async () => await DeleteDataAsync());
            ReadCommand.Execute(null);
        }



        //COMMAND
        public RelayCommand ReadCommand { get; set; }
        public RelayCommand InsertCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

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
        private async Task ReadDataAsync()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"SELECT * FROM Vehicle";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    while (dr.Read())
                    {
                        collection.Add(new Vehicle
                        {
                            id = dr[0].ToString(),
                            vehicle_type_id = dr[1].ToString(),
                            member_id = dr[2].ToString(),
                            license_plate = dr[3].ToString(),
                            notes = dr[4].ToString()

                        });
                    }
                }
            }
            else
            {
                MessageBox.Show("DATA USER NOT FOUND", "WARNING");
            }
            dbconn.conn.Close();
        }

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

        private async Task UpdateDataAsync()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"UPDATE Vehicle SET " +
                $"license_plate = '{model.license_plate}'" +
                $"member_id = '{model.member_id}'" +
                $"notes = '{model.notes}'" +
                $"last_update_at = '{model.last_updated_at}'";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteNonQuery();
            MessageBox.Show("SUCCESS UPDATE DATA");
            dbconn.conn.Close();

        }

        private async Task DeleteDataAsync()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"DELETE Vehicle WHERE license_plate = '{model.license_plate}'";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteNonQuery();
            MessageBox.Show("SUCCESS DELETE DATA");
            dbconn.conn.Close();

        }
    }
}
