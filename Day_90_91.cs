using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using System.Net;
using System.Text.Json;
//using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace C__Day90
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Temperature> temp = new List<Temperature>();
            string apiKey = "H4sWDkS8EsD2Go8gpnEs2iUMFwCjPBBa";
            string apiUrl = $"https://api.tomorrow.io/v4/weather/forecast?location=new%20york&apikey={apiKey}";
            HttpClient http = new HttpClient();

            http.BaseAddress = new Uri(apiUrl);
            //var x = await http.GetAsync(http.BaseAddress);
            HttpResponseMessage response = await http.GetAsync(http.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(content);
                //JsonSerializer json = new JsonSerializer.Deserialize<List<Temperature>>(content);
                //List<Temperature> tempt = JsonConvert.DeserializeObject<List<Temperature>>(content);
                //foreach(Temperature tem in tempt)
                //{
                  //  Debug.WriteLine(tem.locationName);
                  //  Debug.WriteLine(tem.temp);
                //}
            }
            //MethodExample();
        }

        async void MethodExample()
        {
            var http = new HttpClient();
            var result = await http.GetAsync("https://api.tomorrow.io/v4/weather/realtime?location=toronto&apikey=XXX");
            Debug.WriteLine($"-> {result}");
        }
    }

    public class Temperature
    {
        public string locationName { get; set; }
        public int temp { get; set; }
    }
}
