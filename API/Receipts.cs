using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.API
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class TotalDiscount
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int percentage { get; set; }
        public double money_amount { get; set; }
    }

    public class TotalTax
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public double rate { get; set; }
        public double money_amount { get; set; }
    }

    public class LineTax
    {
        public double money_amount { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public double rate { get; set; }
    }

    public class LineDiscount
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public double money_amount { get; set; }
    }

    public class LineModifier
    {
        public string id { get; set; }
        public string modifier_option_id { get; set; }
        public string name { get; set; }
        public string option { get; set; }
        public int price { get; set; }
        public int money_amount { get; set; }
    }

    public class LineItem
    {
        public string id { get; set; }
        public string item_id { get; set; }
        public string variant_id { get; set; }
        public string item_name { get; set; }
        public object variant_name { get; set; }
        public string sku { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int gross_total_money { get; set; }
        public double total_money { get; set; }
        public int cost { get; set; }
        public int cost_total { get; set; }
        public string line_note { get; set; }
        public List<LineTax> line_taxes { get; set; }
        public double total_discount { get; set; }
        public List<LineDiscount> line_discounts { get; set; }
        public List<LineModifier> line_modifiers { get; set; }
    }

    public class PaymentDetails
    {
        public string authorization_code { get; set; }
        public long reference_id { get; set; }
        public string entry_method { get; set; }
        public string card_company { get; set; }
        public string card_number { get; set; }
    }

    public class Payment
    {
        public string payment_type_id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double money_amount { get; set; }
        public DateTime paid_at { get; set; }
        public PaymentDetails payment_details { get; set; }
    }

    public class Receipt
    {
        public string receipt_number { get; set; }
        public object note { get; set; }
        public string receipt_type { get; set; }
        public object refund_for { get; set; }
        public object order { get; set; }
        public DateTime created_at { get; set; }
        public DateTime receipt_date { get; set; }
        public DateTime updated_at { get; set; }
        public object cancelled_at { get; set; }
        public string source { get; set; }
        public double total_money { get; set; }
        public double total_tax { get; set; }
        public double points_earned { get; set; }
        public int points_deducted { get; set; }
        public double points_balance { get; set; }
        public string customer_id { get; set; }
        public double total_discount { get; set; }
        public string employee_id { get; set; }
        public string store_id { get; set; }
        public string pos_device_id { get; set; }
        public string dining_option { get; set; }
        public List<TotalDiscount> total_discounts { get; set; }
        public List<TotalTax> total_taxes { get; set; }
        public int tip { get; set; }
        public int surcharge { get; set; }
        public List<LineItem> line_items { get; set; }
        public List<Payment> payments { get; set; }
    }

    public class Receipts
    {
        public List<Receipt> receipts { get; set; }
    }


}
