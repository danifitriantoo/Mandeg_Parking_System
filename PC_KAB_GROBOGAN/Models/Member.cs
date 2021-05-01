using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_KAB_GROBOGAN.Models
{
    public class Member
    {
        public string id { get; set; }
        public string membership_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string date_of_birth { get; set; }
        public string gender { get; set; }
        public string created_at { get; set; }
        public string last_updated_at { get; set; }
        public string deleted_at { get; set; }

    }
}
