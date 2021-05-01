using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_KAB_GROBOGAN.Models
{
    public class Vehicle
    {
        public string id { get; set; }
        public string vehicle_type_id { get; set; }
        public string member_id { get; set; }
        public string license_plate { get; set; }
        public string notes { get; set; }
        public string created_at { get; set; }
        public string last_updated_at { get; set; }
        public string deleted_at { get; set; }

    }
}
