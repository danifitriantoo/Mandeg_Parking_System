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
    public class MemberViewModel : INotifyPropertyChanged
    {
        public MemberViewModel()
        {
            dbconn = new DBConnection();
            model = new Member();
            model2 = new Membership();
            collection = new ObservableCollection<Member>();
            collection2 = new ObservableCollection<Membership>();

            //ASYNC TASK
            ReadCommand = new RelayCommand(async () => await ReadDataAsync());
            ReadCommandX = new RelayCommand(async () => await ReadDataMembership());
            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
            UpdateCommand = new RelayCommand(async () => await UpdateDataAsync());
            DeleteCommand = new RelayCommand(async () => await DeleteDataAsync());
            ReadCommand.Execute(null);
            ReadCommandX.Execute(null);
        }



        //COMMAND
        public RelayCommand ReadCommand { get; set; }
        public RelayCommand ReadCommandX { get; set; }
        public RelayCommand InsertCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        //COLLECTION
        public ObservableCollection<Member> Collection
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

        //COLLECTION 2
        public ObservableCollection<Membership> Collection2
        {
            get
            {
                return collection2;
            }
            set
            {
                collection2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        //MODELS
        public Member Model
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

        //MODEL 2
        public Membership Model2
        {
            get
            {
                return model2;
            }
            set
            {
                model2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        //ADD-ON
        public event PropertyChangedEventHandler PropertyChanged;
        public event Action OnCallBack;

        //PRIVATE PRORS
        private readonly DBConnection dbconn;
        private Member model;
        private Membership model2;
        private ObservableCollection<Member> collection;
        private ObservableCollection<Membership> collection2;


        //CRUD
        private async Task ReadDataMembership()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"SELECT * FROM Membership";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    while (dr.Read())
                    {
                        collection2.Add(new Membership   
                        {
                            id = dr[0].ToString(),
                            name = dr[1].ToString(),

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


        private async Task ReadDataAsync()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"SELECT * FROM Member";
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
                    while(dr.Read())
                    {
                        collection.Add(new Member
                        {
                            id = dr[0].ToString(),
                            membership_id = dr[1].ToString(),
                            name = dr[2].ToString(),
                            email = dr[3].ToString(),
                            phone_number = dr[4].ToString(),
                            address = dr[5].ToString(),
                            date_of_birth = dr[6].ToString(),
                            gender = dr[7].ToString(),
                            created_at = dr[8].ToString(),
                            last_updated_at = dr[9].ToString(),
                            deleted_at = dr[10].ToString(),

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
            var query = $"INSERT INTO Member VALUES(" +
                $"'{model.membership_id}'," +
                $"'{model.name}'" +
                $"'{model.email}'" +
                $"'{model.phone_number}'" +
                $"'{model.address}'" +
                $"'{model.date_of_birth}'" +
                $"'{model.gender}'" +
                $"'{model.created_at}'" +
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
            var query = $"UPDATE Member SET " +
                $"name = '{model.name}', " +
                $"membership_id = '{model.membership_id}'" +
                $"name = '{model.name}'" +
                $"phone_number = ''{model.phone_number}''" +
                $"address = '{model.address}'" +
                $"date_of_birth'{model.date_of_birth}'" +
                $"gender = '{model.gender}'";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteNonQuery();
            MessageBox.Show("SUCCESS UPDATE DATA");
            dbconn.conn.Close();

        }

        private async Task DeleteDataAsync()
        {
            await Task.Delay(0);
            dbconn.conn.Open();
            var query = $"DELETE Member WHERE name = '{model.name}'";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteNonQuery();
            MessageBox.Show("SUCCESS DELETE DATA");
            dbconn.conn.Close();

        }
    }
}

