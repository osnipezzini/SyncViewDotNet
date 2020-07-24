using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncView.Generics;
using SyncView.Models;
using SyncView.Properties;

namespace SyncView.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(Settings.Default.ServerName))
            {
                timerGetSync.Enabled = false;
                statusConfig.Text = "Você deve criar as configurações para usar esse sistema.";
                statusConfig.ForeColor = Color.Red;
            }
            else
            {
                timerGetSync_Tick(null, null);
            }
            txtDelayRefresh.Text = Settings.Default.DelayTime;
        }

        async Task<List<Sync>> GetSyncs()
        {
            List<Sync> syncs = new List<Sync>();
            string url;
            if (!string.IsNullOrEmpty(Settings.Default.ServerName))
            {
                string port = string.IsNullOrEmpty(Settings.Default.ServerPort) ? "54323" : Settings.Default.ServerPort;
                url = $"http://{Settings.Default.ServerName}:{port}/api/sync";
                try
                {
                    var httpClient = new HttpClient();

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string conteudo =
                            response.Content.ReadAsStringAsync().Result;

                        syncs = JsonConvert.DeserializeObject<List<Sync>>(conteudo);
                    }
                    httpClient.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("erro" + ex.Message);
                }
            }
            return syncs;
        }
        private async void timerGetSync_Tick(object sender, EventArgs e)
        {
            syncDataGrid.SaveColumnOrder();
            SortableBindingList<Sync> syncs = new SortableBindingList<Sync>(await GetSyncs());
            syncDataGrid.DataSource = null;
            syncDataGrid.DataSource = syncs;
            syncDataGrid.Sort();
        }

        private void txtDelayRefresh_Leave(object sender, EventArgs e)
        {
            int refreshDelay;
            if (int.TryParse(txtDelayRefresh.Text, out refreshDelay))
            {
                timerGetSync.Interval = (int)TimeSpan.FromSeconds(refreshDelay).TotalMilliseconds;
            }
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormConfig config = new FormConfig();
            if (config.ShowDialog() == DialogResult.OK)
            {
                timerGetSync.Enabled = true;
                statusConfig.Text = "Configurações carregadas.";
                statusConfig.ForeColor = Color.Green;
                timerGetSync_Tick(null, null);
            }
        }
    }
}
