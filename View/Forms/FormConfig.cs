using System;
using System.Windows.Forms;
using SyncView.Properties;

namespace SyncView.Forms
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            txtPort.Text = Settings.Default.ServerPort;
            txtDelayTime.Text = Settings.Default.DelayTime;
            txtServerName.Text = Settings.Default.ServerName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServerName.Text)) 
            {
                Settings.Default.ServerName = txtServerName.Text;
                Settings.Default.ServerPort = txtPort.Text;
                Settings.Default.DelayTime = txtDelayTime.Text;
                Settings.Default.Save();
                MessageBox.Show("Configurações salvas com sucesso !", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"Obrigatório preencher o campo '{lblServerName.Text}'", "Erro ao validar o formulário", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
