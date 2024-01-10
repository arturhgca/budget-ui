using System.Net;

namespace budget_ui
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Net;

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

        // TODO: button for new items in datagridview (another window/panel for input and POST request with contents)
        // TODO: button for editing selected item in datagridview (another window/panel for input and PUT request with contents)
        // TODO: button for removing selected item in datagridview (DELETE request for uid)

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = RestGet(GetUri(listBox1.SelectedItem.ToString()));
        }

        private static JArray RestGet(string uri)
        {
            var request = (HttpWebRequest) WebRequest.Create(GetUrl(uri));
            var response = (HttpWebResponse) request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            return JsonConvert.DeserializeObject<JArray>(reader.ReadToEnd());
        }

        private static string GetUrl(string uri)
        {
            return "http://localhost:5000" + uri;
        }

        private static string GetUri(string selectedItem)
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
