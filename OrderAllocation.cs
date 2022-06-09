using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OrderingSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystem.API;
using System.Collections;
using System.Net.Http.Headers;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using OrderingSystem.Class;

namespace OrderingSystem
{
    public partial class OrderAllocation : Form
    {

        public OrderAllocation()
        {
            InitializeComponent();
            //UC_RepOrders uc = new UC_RepOrders();
            //addUserControl(uc);
        }

        PreloaderFunc preloader = new PreloaderFunc();

        private void OrderAllocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.AllocatedOrders' table. You can move, or remove it, as needed.
            this.allocatedOrdersTableAdapter.FillAllocatedOrders(this.dBDataSet.AllocatedOrders);

            //Make the other controls invisible
            this.dataGridAllocatedOrders.Visible = false;
            

        }

        private void addUserControl(UserControl userControl)
        {
            //userControl.Dock = DockStyle.Fill;
            //panelContainer.Controls.Clear();
            //panelContainer.Controls.Add(userControl);
            //userControl.BringToFront();


        }

        private void btnRepOrders_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btnAllocatedOrders_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrdersOnHold_Click(object sender, EventArgs e)
        {
            UC_OrdersOnHold uc = new UC_OrdersOnHold();
            addUserControl(uc);
        }

        private void btnReadyForDelivery_Click(object sender, EventArgs e)
        {
            UC_ReadyForDelivery uc = new UC_ReadyForDelivery();
            addUserControl(uc);
        }

        private void btnRequestFromFactory_Click(object sender, EventArgs e)
        {
            UC_RequestFromFactory uc = new UC_RequestFromFactory();
            addUserControl(uc);
        }

        private void lblMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private /*async*/ void btnRefresh_Click(object sender, EventArgs e)
        {
            //DataTable x = await LoadData();
            //datagridRepOrders.DataSource = x;

        }


        private void btnRepOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRepOrders.Checked)
            {
                this.footerPanelRepOrders.Visible = true;
                this.datagridRepOrders.Visible = true;
                this.datagridRepOrders.Enabled = true;
            }
            else if (!btnRepOrders.Checked)
            {
                this.footerPanelRepOrders.Visible = false;
                this.datagridRepOrders.Visible = false;
                this.datagridRepOrders.Enabled = false;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
     
            if (this.toDateTimePicker.Value.Date < this.fromDateTimePicker.Value.Date/* || this.toDateTimePicker.Value.TimeOfDay < this.fromDateTimePicker.Value.TimeOfDay*/)
            {
                MessageBox.Show("To date can't be greater than from date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DisableButtons();


            //Removes previous results
            datagridRepOrders.Rows.Clear();

            preloader.Show(this);
            datagridRepOrders.Visible = false;


            //DateTimePickers
            TimeSpan minus2Hours = new TimeSpan(2,0,0);
            
            string fromDate = string.Format("{0:yyyy-MM-dd}T{0:HH:mm:ss}.000Z", this.fromDateTimePicker.Value.Date.Subtract(minus2Hours));
            string toDate = string.Format("{0:yyyy-MM-dd}T{0:HH:mm:ss}.000Z", this.toDateTimePicker.Value.Date.AddHours(22));

            

            //Queries
            string receiptsQuery = "receipts?";
            string customersQuery = "customers/";
            string employeeQuery = "employees/";

            string storeId = "ff121aee-d463-4300-b69f-15f91034a047";
            int limitInt = 250;
            string limit = "&limit=" + limitInt.ToString();


            HttpClientHandler handler = new HttpClientHandler();
            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetToken());




            //Query Results


            string receiptResult = await client.GetStringAsync(GetApiUrl(receiptsQuery, limit, string.Empty, fromDate, toDate, storeId));
            string customerResult;
            string employeeResult;


            //JSON Object Convert
            var receiptsResultObject = JObject.Parse(receiptResult);
            JObject customerResultObject;
            JObject employeeResultObject;


            //Connect class with the api
            API.Receipt receipt = new Receipt();
            API.Customer customer = new Customer();
            API.Employee employee = new Employee();

            //Convert to JSON Array
            JArray receiptJArray = new JArray();

            foreach (var item in receiptsResultObject["receipts"])
            {
                receiptJArray.Add(item);
            }


            int receiptJArrayLength = receiptJArray.Count;



            //Connect receipts class to resultObject


            for (int i = 0; i < receiptJArrayLength; i++)
            {
                receipt.receipt_date = (DateTime)receiptsResultObject["receipts"][i]["created_at"];
                //Convert server UTC date and time to South African Time
                DateTime convertedReceiptDateTime = new DateTime();
                convertedReceiptDateTime = DateTime.Parse(receipt.receipt_date.ToString());

                receipt.receipt_date = convertedReceiptDateTime.ToLocalTime();
                string lt = string.Format("{0:dd MMM yyyy} {0:HH:mm tt}", receipt.receipt_date);
                //receipt.receipt_date = (DateTime)lt;

                receipt.receipt_number = receiptsResultObject["receipts"][i]["receipt_number"].ToString();
                receipt.receipt_type = receiptsResultObject["receipts"][i]["receipt_type"].ToString();
                receipt.total_money = (double)receiptsResultObject["receipts"][i]["total_money"];



                //Get customer id
                receipt.customer_id = receiptsResultObject["receipts"][i]["customer_id"].ToString();
                //Get employee id
                receipt.employee_id = receiptsResultObject["receipts"][i]["employee_id"].ToString();

                //Get customer name
                customerResult = await client.GetStringAsync(GetApiUrl(customersQuery + receipt.customer_id));
                customerResultObject = JObject.Parse(customerResult);
                customer.name = Convert.ToString(customerResultObject["name"]);

                //Get employee name
                employeeResult = await client.GetStringAsync(GetApiUrl(employeeQuery + receipt.employee_id));
                employeeResultObject = JObject.Parse(employeeResult);
                employee.name = Convert.ToString(employeeResultObject["name"]);

                //Add Receipt LineItemsTotal***********************************
                //Queries
                HttpClientHandler h = new HttpClientHandler();
                HttpClient c = new HttpClient(h);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetToken());

                //Query Results
                string singleReceiptResult = await client.GetStringAsync("https://api.loyverse.com/v1.0/receipts/" + receipt.receipt_number);

                //JSON Object Convert
                var singleReceiptResultObject = JObject.Parse(singleReceiptResult);

                //Convert to JSON Array
                JArray lineItemsJArray = new JArray();

                foreach (var item in singleReceiptResultObject["line_items"])
                {
                    lineItemsJArray.Add(item);
                }


                int lineItemsCount = lineItemsJArray.Count;
                //*****************************************************

                //Remove allocated orders from repordergridview

                if (!isAllocated(receipt.receipt_number) && receipt.receipt_type == "SALE")
                {
                    datagridRepOrders.Rows.Add(receipt.receipt_number, lt, employee.name, customer.name, receipt.receipt_type, receipt.total_money,false, receipt.customer_id, lineItemsCount);
                }

            }
            //gets the total rows in the grid
            this.lblTotalRows.Text = this.datagridRepOrders.Rows.Count.ToString();

            //Ends the preloader
            preloader.Close();
            datagridRepOrders.Visible = true;
            
            EnableButtons();
        }

        private string GetApiUrl(string query, [Optional]string limit, [Optional] string cursor, [Optional]string fromDate, [Optional]string toDate, [Optional] string storeId)
        {
            //API
            string baseUrl = "https://api.loyverse.com/v1.0/";
            string createdMin = "&created_at_min=" + fromDate;
            string createdMax = "&created_at_max=" + toDate;
            string storeQuery = "store_id=" + storeId;
            string url = string.Empty;

            if (limit == null && fromDate == null && toDate == null)
            {
                url = baseUrl + query;
            }
            else if (fromDate == null && toDate == null)
            {
                url = baseUrl + query + limit + "&cursor=" + cursor;
            }
            else
            {
                url = baseUrl + query + storeQuery + createdMin + createdMax + limit;
            }
            
            return url;
        }

        private string GetToken()
        {
            string token = "8370a60d10214f339959a1edb7ec3829";
            return token;
        }

        private void btnAllocateToRoute_Click(object sender, EventArgs e)
        {
            
            int totalAllocatedRows = datagridRepOrders.Rows.Cast<DataGridViewRow>().Where(ao => Convert.ToBoolean(ao.Cells["btnGridAllocateCustToRoute"].Value) == true).Count();
            int totalRows = datagridRepOrders.RowCount;

            if (this.cmdRoute.Text == string.Empty)
            {
                MessageBox.Show("No Route selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (totalAllocatedRows <= 0 || totalRows <= 0)
            {
                MessageBox.Show("No Customer selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }




            Receipt receipt = new Receipt();
            Customer customer = new Customer();
            Employee employee = new Employee();
            bool isAllocatedToRoute = false;
            string route = string.Empty;
            int lineItemTotal;

            //Add all allocated orders to ALLOCATED ORDERS TABLE IN DATABASE
            for (int i = datagridRepOrders.RowCount -1; i >= 0; i--)
            {
                DataGridViewRow row = datagridRepOrders.Rows[i];

                

                if (Convert.ToBoolean(row.Cells["btnGridAllocateCustToRoute"].Value) == true)
                {

                    receipt.receipt_number = row.Cells["receiptId"].Value.ToString();
                    receipt.receipt_date = DateTime.Parse(row.Cells["date"].Value.ToString());
                    receipt.receipt_type = row.Cells["type"].Value.ToString();
                    receipt.total_money = (double)row.Cells["total"].Value;
                    receipt.customer_id = row.Cells["customerId"].Value.ToString();

                    employee.name = row.Cells["employee"].Value.ToString();
                    customer.name = row.Cells["customerName"].Value.ToString();
                    lineItemTotal = (int)row.Cells["lineItemTotal"].Value;


                    isAllocatedToRoute = (bool)row.Cells["btnGridAllocateCustToRoute"].Value;
                    route = this.cmdRoute.SelectedItem.ToString();


                    this.allocatedOrdersBindingSource.EndEdit();
                    this.allocatedOrdersTableAdapter.Insert(receipt.receipt_number, customer.name, route, receipt.receipt_date.ToString(), isAllocatedToRoute,employee.name,receipt.receipt_type,(decimal)receipt.total_money, receipt.customer_id, lineItemTotal);
                    //this.allocatedOrdersTableAdapter.Update(dBDataSet);
                    this.allocatedOrdersTableAdapter.FillAllocatedOrders(this.dBDataSet.AllocatedOrders);


                    
                }
            }


            this.cmdRoute.SelectedIndex = -1;
            //remove allocated orders from the rep orders table
            btnSearch.PerformClick();
            






        }


        private bool isAllocated(string allocatedString)
        {
            //Remove allocated orders from repgridview
            bool isAllocated = true;
            allocatedString = allocatedOrdersIntTableAdapter.ScalarQueryAllocatedOrderInt(allocatedString);

            //if there is a value
            if (string.IsNullOrEmpty(allocatedString))
            {
                isAllocated = false;
                return isAllocated;
            }

            return isAllocated;
        }

        private void btnAllocatedOrders_CheckedChanged(object sender, EventArgs e)
        {
            int totalAllocatedRows = dataGridAllocatedOrders.Rows.Cast<DataGridViewRow>().Where(ao => Convert.ToBoolean(ao.Cells["isAllocatedToRouteDataGridViewCheckBoxColumn"].Value) == true).Count();
            this.lblTotalAllocatedOrders.Text = totalAllocatedRows.ToString();

            if (btnAllocatedOrders.Checked)
            {
                dataGridAllocatedOrders.Visible = true;
                this.dataGridAllocatedOrders.Enabled = true;
            }
            else if (!btnAllocatedOrders.Checked)
            {
                dataGridAllocatedOrders.Visible = false;
                this.dataGridAllocatedOrders.Enabled = false;

            }
        }

        private void DisableButtons()
        {
            
            this.btnSearch.Enabled = false;
            this.btnAllocateToRoute.Enabled = false;
            this.cmdRoute.Enabled = false;
            this.fromDateTimePicker.Enabled = false;
            this.toDateTimePicker.Enabled = false;
            this.txtSearch.Enabled = false;
        }

        private void EnableButtons()
        {
            
            this.btnSearch.Enabled = true;
            this.btnAllocateToRoute.Enabled = true;
            this.cmdRoute.Enabled = true;
            this.fromDateTimePicker.Enabled = true;
            this.toDateTimePicker.Enabled = true;
            this.txtSearch.Enabled = true;
        }

        private void btnRemoveFromRoute_Click(object sender, EventArgs e)
        {
            int totalAllocatedRows = dataGridAllocatedOrders.Rows.Cast<DataGridViewRow>().Where(ao => Convert.ToBoolean(ao.Cells["removeFromRoute"].Value) == true).Count();
            int totalRows = this.dataGridAllocatedOrders.Rows.Count;


            if (totalAllocatedRows <= 0 || totalRows <= 0)
            {
                MessageBox.Show("No Customer selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove these customer/s from the route?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            
            //Remove all allocated orders to ALLOCATED ORDERS TABLE IN DATABASE
            for (int i = dataGridAllocatedOrders.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridAllocatedOrders.Rows[i];



                if (Convert.ToBoolean(row.Cells["removeFromRoute"].Value) == true)
                {

                    //TO DO: remove the row from the database

                    this.allocatedOrdersBindingSource.EndEdit();
                    this.allocatedOrdersBindingSource.RemoveAt(i);
                    this.allocatedOrdersTableAdapter.Update(dBDataSet);




                }
            }

            this.allocatedOrdersTableAdapter.FillAllocatedOrders(this.dBDataSet.AllocatedOrders);

            //remove allocated orders from the rep orders table
            totalRows = dataGridAllocatedOrders.RowCount;
            this.lblTotalAllocatedOrders.Text = totalRows.ToString();
            btnSearch.PerformClick();

            

        }
    }
}
