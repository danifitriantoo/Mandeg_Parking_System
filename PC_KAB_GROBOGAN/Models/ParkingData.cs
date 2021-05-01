using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_KAB_GROBOGAN.Models
{
    public class ParkingData
    {
        public string id { get; set; }
        public string license_plate { get; set; }
        public string vehicle_id { get; set; }
        public string employee_id { get; set; }
        public string hourly_rates_id { get; set; }
        public string datetime_in { get; set; }
        public string datetime_out { get; set; }
        public string amount_to_pay { get; set; }
        public string created_at { get; set; }
        public string last_updated_at{ get; set; }
        public string deleted_at { get; set; }

    }
}
