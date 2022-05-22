using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace Zad5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        async void OnLoad(object sender, EventArgs args)
        {
            using (var httpClient = new HttpClient())
            {
                var dataTask = await httpClient.GetFromJsonAsync<CurrencyData[]>(
                    "http://api.nbp.pl/api/exchangerates/tables/A?format=json") ?? new CurrencyData[]{};
                
                foreach (var data in dataTask)
                {
                    data.Rates.ForEach(rate => this.listBox1.Items.Add($"{rate.Code}:{rate.Mid:##.##}"));
                }
            }
        }
    }

    internal struct CurrencyData
    {
        public string Table { get; set; }
        public string No { get; set; }
        public string EffectiveDate { get; set; }
        public List<CurrencyRate> Rates { get; set; }
    }

    internal struct CurrencyRate
    {
        public string Currency { get; set; }
        public string Code { get; set; }
        public double Mid { get; set; }
    }
}