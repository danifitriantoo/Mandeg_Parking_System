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
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public EmployeeViewModel()
        {
            dbconn = new DBConnection();
            model = new Employee();
            collection = new ObservableCollection<Employee>();

            //ASYNC TASK
            LoginCommand = new RelayCommand(async () => await LoginDataAsync());
        }



        //COMMAND
        public RelayCommand LoginCommand { get; set; }

        //COLLECTION
        public ObservableCollection<Employee> Collection
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
        public Employee Model
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
        private Employee model;
        private ObservableCollection<Employee> collection;


        //CRUD-LOGIN
        private async Task LoginDataAsync()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"SELECT * FROM Employee WHERE id = '{model.id}' AND password = '{model.password}'";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                MainFormView main = new MainFormView();
                LoginAccess login = new LoginAccess();
                login.Hide();
                main.Show();
                while (dr.Read())
                {
                    App.Uid = dr[0].ToString();
                    App.UserName = dr[1].ToString();
                }
            }
            else
            {
                MessageBox.Show("DATA USER NOT FOUND","WARNING");
            }
        }
    }
}
