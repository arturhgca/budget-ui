using System.Net;

namespace budget_ui
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Net;
    using System.Security.Policy;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private JArray RestGet(string uri)
        {
            string url = "http://localhost:5000" + uri;
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }

        //private JArray RestPut(string uri, object body)
        //{
        //    string url = "http://localhost:5000" + uri;
        //    var request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "PUT";
        //    request.ContentType = "application/json";
        //    request.ContentLength = Size(body);
        //}

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dataGridView1.Rows[e.RowIndex];
            var body = JsonConvert.SerializeObject(currentRow);
            var uid = currentRow.Cells["uid"].Value;
            string selectedItem = listBox1.SelectedItem.ToString();
            RestPut(GetUri(selectedItem), body);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            string selectedItem = listBox1.SelectedItem.ToString();
            
            dataGridView1.DataSource = RestGet(GetUri(selectedItem));
        }

        private string GetUri(string selectedItem)
        {
            string uri;
            switch (selectedItem)
            {
                case "Incomes":
                    uri = "/transactions/incomes";
                    break;
                case "Expenses":
                    uri = "/transactions/expenses";
                    break;
                case "Transfers":
                    uri = "/transactions/transfers";
                    break;
                case "Exchanges":
                    uri = "/transactions/exchanges";
                    break;
                case "Allocations":
                    uri = "/transactions/allocations";
                    break;
                default:
                    throw new ArgumentException("Invalid item selected");
            }
            return uri;
        }
    }
}
