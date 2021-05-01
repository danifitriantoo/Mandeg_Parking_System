using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_KAB_GROBOGAN.Models
{
    public class HourlyRates
    {
        public string id { get; set; }
        public string membership_id { get; set; }
        public string vehicle_type_id { get; set; }
        public string value { get; set; }
        public string last_updated_at { get; set; }
        public string deleted_at { get; set; }

    }
}
