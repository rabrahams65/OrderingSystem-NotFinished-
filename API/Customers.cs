using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.API
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string postal_code { get; set; }
        public string country_code { get; set; }
        public string customer_code { get; set; }
        public string note { get; set; }
        public object first_visit { get; set; }
        public object last_visit { get; set; }
        public int total_visits { get; set; }
        public double total_spent { get; set; }
        public int total_points { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
        public DateTime permanent_deletion_at { get; set; }
    }

    public class Customers
    {
        public List<Customer> customers { get; set; }
        public string cursor { get; set; }
    }


}
