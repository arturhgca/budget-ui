using System.Net;

namespace budget_ui
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Net;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            string selectedItem = listBox1.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Incomes":
                    dataGridView1.DataSource = restGet("/transactions/incomes");
                    break;
                case "Expenses":
                    dataGridView1.DataSource = restGet("/transactions/expenses");
                    break;
                case "Transfers":
                    dataGridView1.DataSource = restGet("/transactions/transfers");
                    break;
                case "Exchanges":
                    dataGridView1.DataSource = restGet("/transactions/exchanges");
                    break;
                case "Allocations":
                    dataGridView1.DataSource = restGet("/transactions/allocations");
                    break;
                default:
                    break;
            }
        }

        private JArray restGet(string uri)
        {
            string url = "http://localhost:5000" + uri;
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }
    }
}
