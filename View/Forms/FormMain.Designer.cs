using SyncView.Models;

namespace SyncView.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtDelayRefresh = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timerGetSync = new System.Windows.Forms.Timer(this.components);
            this.syncDataGrid = new gfoidl.Windows.Forms.gfDataGridView();
            this.statusDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.statusConfig = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConfig = new System.Windows.Forms.ToolStripButton();
            this.conexaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atrasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncDataGrid)).BeginInit();
            this.statusbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDelayRefresh,
            this.toolStripLabel1,
            this.btnConfig});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolbar";
            // 
            // txtDelayRefresh
            // 
            this.txtDelayRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDelayRefresh.Name = "txtDelayRefresh";
            this.txtDelayRefresh.Size = new System.Drawing.Size(100, 25);
            this.txtDelayRefresh.Text = "1";
            this.txtDelayRefresh.Leave += new System.EventHandler(this.txtDelayRefresh_Leave);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(199, 22);
            this.toolStripLabel1.Text = "Tempo para atualização ( segundos )";
            // 
            // timerGetSync
            // 
            this.timerGetSync.Enabled = true;
            this.timerGetSync.Interval = 5000;
            this.timerGetSync.Tick += new System.EventHandler(this.timerGetSync_Tick);
            // 
            // syncDataGrid
            // 
            this.syncDataGrid.AllowUserToAddRows = false;
            this.syncDataGrid.AllowUserToDeleteRows = false;
            this.syncDataGrid.AllowUserToOrderColumns = true;
            this.syncDataGrid.AutoGenerateColumns = false;
            this.syncDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.syncDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewImageColumn,
            this.conexaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.atrasoDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn});
            this.syncDataGrid.DataSource = this.syncBindingSource;
            this.syncDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncDataGrid.Location = new System.Drawing.Point(0, 25);
            this.syncDataGrid.Name = "syncDataGrid";
            this.syncDataGrid.RowHeadersVisible = false;
            this.syncDataGrid.Setting = null;
            this.syncDataGrid.Size = new System.Drawing.Size(800, 425);
            this.syncDataGrid.TabIndex = 1;
            // 
            // statusDataGridViewImageColumn
            // 
            this.statusDataGridViewImageColumn.HeaderText = "Status";
            this.statusDataGridViewImageColumn.Image = ((System.Drawing.Image)(resources.GetObject("statusDataGridViewImageColumn.Image")));
            this.statusDataGridViewImageColumn.Name = "statusDataGridViewImageColumn";
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusConfig});
            this.statusbar.Location = new System.Drawing.Point(0, 425);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(800, 25);
            this.statusbar.TabIndex = 2;
            this.statusbar.Text = "statusStrip1";
            // 
            // statusConfig
            // 
            this.statusConfig.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConfig.ForeColor = System.Drawing.Color.ForestGreen;
            this.statusConfig.Name = "statusConfig";
            this.statusConfig.Size = new System.Drawing.Size(192, 20);
            this.statusConfig.Text = "Configurações carregadas !";
            // 
            // btnConfig
            // 
            this.btnConfig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(104, 22);
            this.btnConfig.Text = "Configurações";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // conexaoDataGridViewTextBoxColumn
            // 
            this.conexaoDataGridViewTextBoxColumn.DataPropertyName = "Conexao";
            this.conexaoDataGridViewTextBoxColumn.HeaderText = "Conexao";
            this.conexaoDataGridViewTextBoxColumn.Name = "conexaoDataGridViewTextBoxColumn";
            this.conexaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            // 
            // atrasoDataGridViewTextBoxColumn
            // 
            this.atrasoDataGridViewTextBoxColumn.DataPropertyName = "Atraso";
            this.atrasoDataGridViewTextBoxColumn.HeaderText = "Atraso";
            this.atrasoDataGridViewTextBoxColumn.Name = "atrasoDataGridViewTextBoxColumn";
            // 
            // lastUpdateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDataGridViewTextBoxColumn.DataPropertyName = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.HeaderText = "Ultima atualização";
            this.lastUpdateDataGridViewTextBoxColumn.Name = "lastUpdateDataGridViewTextBoxColumn";
            // 
            // syncBindingSource
            // 
            this.syncBindingSource.DataSource = typeof(SyncView.Models.Sync);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.syncDataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "SyncView - Visualizador de sincronias";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncDataGrid)).EndInit();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private gfoidl.Windows.Forms.gfDataGridView syncDataGrid;
        private System.Windows.Forms.BindingSource syncBindingSource;
        protected System.Windows.Forms.Timer timerGetSync;
        private System.Windows.Forms.DataGridViewImageColumn statusDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conexaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atrasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripTextBox txtDelayRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel statusConfig;
        private System.Windows.Forms.ToolStripButton btnConfig;
    }
}