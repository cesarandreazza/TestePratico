namespace Configurador
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.groupBoxCurrentConfiguration = new System.Windows.Forms.GroupBox();
            this.lblCurValueMaxDistanceReinforcedBase = new System.Windows.Forms.Label();
            this.lblCurValueMinTotalDistance = new System.Windows.Forms.Label();
            this.lblCurValueMaxSpansDistance = new System.Windows.Forms.Label();
            this.lblCurrentMaxSpansDistance = new System.Windows.Forms.Label();
            this.lblCurrentMinTotalDistance = new System.Windows.Forms.Label();
            this.lblCurrentMaxDistanceReinforcedBase = new System.Windows.Forms.Label();
            this.groupBoxNewConfiguration = new System.Windows.Forms.GroupBox();
            this.lblMaxSpansDistance = new System.Windows.Forms.Label();
            this.txbMaxSpansDistance = new System.Windows.Forms.TextBox();
            this.btnSaveConfiguration = new System.Windows.Forms.Button();
            this.txbMinTotalDistance = new System.Windows.Forms.TextBox();
            this.lblMinTotalDistance = new System.Windows.Forms.Label();
            this.txbMaxDistanceReinforcedBase = new System.Windows.Forms.TextBox();
            this.lblMaxDistanceReinforcedBase = new System.Windows.Forms.Label();
            this.tabPageProcessingQueue = new System.Windows.Forms.TabPage();
            this.btnDeleteProcessing = new System.Windows.Forms.Button();
            this.lblTotalDistance = new System.Windows.Forms.Label();
            this.txbTotalDistance = new System.Windows.Forms.TextBox();
            this.btnAddProcessing = new System.Windows.Forms.Button();
            this.dgvProcessing = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.btnMarkAsRead = new System.Windows.Forms.Button();
            this.checkBoxViewAll = new System.Windows.Forms.CheckBox();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.groupBoxCurrentConfiguration.SuspendLayout();
            this.groupBoxNewConfiguration.SuspendLayout();
            this.tabPageProcessingQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.tabPageResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConfiguration);
            this.tabControl.Controls.Add(this.tabPageProcessingQueue);
            this.tabControl.Controls.Add(this.tabPageResults);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(606, 437);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.groupBoxCurrentConfiguration);
            this.tabPageConfiguration.Controls.Add(this.groupBoxNewConfiguration);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(598, 411);
            this.tabPageConfiguration.TabIndex = 0;
            this.tabPageConfiguration.Text = "Configuração de cálculo";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // groupBoxCurrentConfiguration
            // 
            this.groupBoxCurrentConfiguration.Controls.Add(this.lblCurValueMaxDistanceReinforcedBase);
            this.groupBoxCurrentConfiguration.Controls.Add(this.lblCurValueMinTotalDistance);
            this.groupBoxCurrentConfiguration.Controls.Add(this.lblCurValueMaxSpansDistance);
            this.groupBoxCurrentConfiguration.Controls.Add(this.lblCurrentMaxSpansDistance);
            this.groupBoxCurrentConfiguration.Controls.Add(this.lblCurrentMinTotalDistance);
            this.groupBoxCurrentConfiguration.Controls.Add(this.lblCurrentMaxDistanceReinforcedBase);
            this.groupBoxCurrentConfiguration.Location = new System.Drawing.Point(19, 20);
            this.groupBoxCurrentConfiguration.Name = "groupBoxCurrentConfiguration";
            this.groupBoxCurrentConfiguration.Size = new System.Drawing.Size(573, 129);
            this.groupBoxCurrentConfiguration.TabIndex = 13;
            this.groupBoxCurrentConfiguration.TabStop = false;
            this.groupBoxCurrentConfiguration.Text = "Configuração atual";
            // 
            // lblCurValueMaxDistanceReinforcedBase
            // 
            this.lblCurValueMaxDistanceReinforcedBase.AutoSize = true;
            this.lblCurValueMaxDistanceReinforcedBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurValueMaxDistanceReinforcedBase.Location = new System.Drawing.Point(192, 90);
            this.lblCurValueMaxDistanceReinforcedBase.Name = "lblCurValueMaxDistanceReinforcedBase";
            this.lblCurValueMaxDistanceReinforcedBase.Size = new System.Drawing.Size(0, 16);
            this.lblCurValueMaxDistanceReinforcedBase.TabIndex = 16;
            // 
            // lblCurValueMinTotalDistance
            // 
            this.lblCurValueMinTotalDistance.AutoSize = true;
            this.lblCurValueMinTotalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurValueMinTotalDistance.Location = new System.Drawing.Point(192, 55);
            this.lblCurValueMinTotalDistance.Name = "lblCurValueMinTotalDistance";
            this.lblCurValueMinTotalDistance.Size = new System.Drawing.Size(0, 16);
            this.lblCurValueMinTotalDistance.TabIndex = 15;
            // 
            // lblCurValueMaxSpansDistance
            // 
            this.lblCurValueMaxSpansDistance.AutoSize = true;
            this.lblCurValueMaxSpansDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurValueMaxSpansDistance.Location = new System.Drawing.Point(192, 22);
            this.lblCurValueMaxSpansDistance.Name = "lblCurValueMaxSpansDistance";
            this.lblCurValueMaxSpansDistance.Size = new System.Drawing.Size(0, 16);
            this.lblCurValueMaxSpansDistance.TabIndex = 14;
            // 
            // lblCurrentMaxSpansDistance
            // 
            this.lblCurrentMaxSpansDistance.AutoSize = true;
            this.lblCurrentMaxSpansDistance.Location = new System.Drawing.Point(6, 25);
            this.lblCurrentMaxSpansDistance.Name = "lblCurrentMaxSpansDistance";
            this.lblCurrentMaxSpansDistance.Size = new System.Drawing.Size(166, 13);
            this.lblCurrentMaxSpansDistance.TabIndex = 11;
            this.lblCurrentMaxSpansDistance.Text = "Distância máxima entre vãos (m)*:";
            // 
            // lblCurrentMinTotalDistance
            // 
            this.lblCurrentMinTotalDistance.AutoSize = true;
            this.lblCurrentMinTotalDistance.Location = new System.Drawing.Point(6, 58);
            this.lblCurrentMinTotalDistance.Name = "lblCurrentMinTotalDistance";
            this.lblCurrentMinTotalDistance.Size = new System.Drawing.Size(135, 13);
            this.lblCurrentMinTotalDistance.TabIndex = 12;
            this.lblCurrentMinTotalDistance.Text = "Distância mínima total (m)*:";
            // 
            // lblCurrentMaxDistanceReinforcedBase
            // 
            this.lblCurrentMaxDistanceReinforcedBase.AutoSize = true;
            this.lblCurrentMaxDistanceReinforcedBase.Location = new System.Drawing.Point(6, 93);
            this.lblCurrentMaxDistanceReinforcedBase.Name = "lblCurrentMaxDistanceReinforcedBase";
            this.lblCurrentMaxDistanceReinforcedBase.Size = new System.Drawing.Size(187, 13);
            this.lblCurrentMaxDistanceReinforcedBase.TabIndex = 13;
            this.lblCurrentMaxDistanceReinforcedBase.Text = "Distância máxima base reforçada (m)*:";
            // 
            // groupBoxNewConfiguration
            // 
            this.groupBoxNewConfiguration.Controls.Add(this.lblMaxSpansDistance);
            this.groupBoxNewConfiguration.Controls.Add(this.txbMaxSpansDistance);
            this.groupBoxNewConfiguration.Controls.Add(this.btnSaveConfiguration);
            this.groupBoxNewConfiguration.Controls.Add(this.txbMinTotalDistance);
            this.groupBoxNewConfiguration.Controls.Add(this.lblMinTotalDistance);
            this.groupBoxNewConfiguration.Controls.Add(this.txbMaxDistanceReinforcedBase);
            this.groupBoxNewConfiguration.Controls.Add(this.lblMaxDistanceReinforcedBase);
            this.groupBoxNewConfiguration.Location = new System.Drawing.Point(19, 189);
            this.groupBoxNewConfiguration.Name = "groupBoxNewConfiguration";
            this.groupBoxNewConfiguration.Size = new System.Drawing.Size(573, 192);
            this.groupBoxNewConfiguration.TabIndex = 12;
            this.groupBoxNewConfiguration.TabStop = false;
            this.groupBoxNewConfiguration.Text = "Nova configuração";
            // 
            // lblMaxSpansDistance
            // 
            this.lblMaxSpansDistance.AutoSize = true;
            this.lblMaxSpansDistance.Location = new System.Drawing.Point(6, 26);
            this.lblMaxSpansDistance.Name = "lblMaxSpansDistance";
            this.lblMaxSpansDistance.Size = new System.Drawing.Size(166, 13);
            this.lblMaxSpansDistance.TabIndex = 6;
            this.lblMaxSpansDistance.Text = "Distância máxima entre vãos (m)*:";
            // 
            // txbMaxSpansDistance
            // 
            this.txbMaxSpansDistance.Location = new System.Drawing.Point(204, 20);
            this.txbMaxSpansDistance.Name = "txbMaxSpansDistance";
            this.txbMaxSpansDistance.Size = new System.Drawing.Size(100, 20);
            this.txbMaxSpansDistance.TabIndex = 5;
            this.txbMaxSpansDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMParam_KeyPress);
            // 
            // btnSaveConfiguration
            // 
            this.btnSaveConfiguration.Location = new System.Drawing.Point(157, 135);
            this.btnSaveConfiguration.Name = "btnSaveConfiguration";
            this.btnSaveConfiguration.Size = new System.Drawing.Size(147, 37);
            this.btnSaveConfiguration.TabIndex = 11;
            this.btnSaveConfiguration.Text = "&Salvar configuração";
            this.btnSaveConfiguration.UseVisualStyleBackColor = true;
            this.btnSaveConfiguration.Click += new System.EventHandler(this.btnSaveConfiguration_Click);
            // 
            // txbMinTotalDistance
            // 
            this.txbMinTotalDistance.Location = new System.Drawing.Point(204, 56);
            this.txbMinTotalDistance.Name = "txbMinTotalDistance";
            this.txbMinTotalDistance.Size = new System.Drawing.Size(100, 20);
            this.txbMinTotalDistance.TabIndex = 7;
            this.txbMinTotalDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMParam_KeyPress);
            // 
            // lblMinTotalDistance
            // 
            this.lblMinTotalDistance.AutoSize = true;
            this.lblMinTotalDistance.Location = new System.Drawing.Point(6, 59);
            this.lblMinTotalDistance.Name = "lblMinTotalDistance";
            this.lblMinTotalDistance.Size = new System.Drawing.Size(135, 13);
            this.lblMinTotalDistance.TabIndex = 8;
            this.lblMinTotalDistance.Text = "Distância mínima total (m)*:";
            // 
            // txbMaxDistanceReinforcedBase
            // 
            this.txbMaxDistanceReinforcedBase.Location = new System.Drawing.Point(204, 91);
            this.txbMaxDistanceReinforcedBase.Name = "txbMaxDistanceReinforcedBase";
            this.txbMaxDistanceReinforcedBase.Size = new System.Drawing.Size(100, 20);
            this.txbMaxDistanceReinforcedBase.TabIndex = 9;
            this.txbMaxDistanceReinforcedBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMParam_KeyPress);
            // 
            // lblMaxDistanceReinforcedBase
            // 
            this.lblMaxDistanceReinforcedBase.AutoSize = true;
            this.lblMaxDistanceReinforcedBase.Location = new System.Drawing.Point(6, 94);
            this.lblMaxDistanceReinforcedBase.Name = "lblMaxDistanceReinforcedBase";
            this.lblMaxDistanceReinforcedBase.Size = new System.Drawing.Size(187, 13);
            this.lblMaxDistanceReinforcedBase.TabIndex = 10;
            this.lblMaxDistanceReinforcedBase.Text = "Distância máxima base reforçada (m)*:";
            // 
            // tabPageProcessingQueue
            // 
            this.tabPageProcessingQueue.Controls.Add(this.btnDeleteProcessing);
            this.tabPageProcessingQueue.Controls.Add(this.lblTotalDistance);
            this.tabPageProcessingQueue.Controls.Add(this.txbTotalDistance);
            this.tabPageProcessingQueue.Controls.Add(this.btnAddProcessing);
            this.tabPageProcessingQueue.Controls.Add(this.dgvProcessing);
            this.tabPageProcessingQueue.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcessingQueue.Name = "tabPageProcessingQueue";
            this.tabPageProcessingQueue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessingQueue.Size = new System.Drawing.Size(598, 411);
            this.tabPageProcessingQueue.TabIndex = 1;
            this.tabPageProcessingQueue.Text = "Fila de processamento";
            this.tabPageProcessingQueue.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProcessing
            // 
            this.btnDeleteProcessing.Enabled = false;
            this.btnDeleteProcessing.Location = new System.Drawing.Point(465, 374);
            this.btnDeleteProcessing.Name = "btnDeleteProcessing";
            this.btnDeleteProcessing.Size = new System.Drawing.Size(127, 23);
            this.btnDeleteProcessing.TabIndex = 4;
            this.btnDeleteProcessing.Text = "&Excluir processamento";
            this.btnDeleteProcessing.UseVisualStyleBackColor = true;
            this.btnDeleteProcessing.Click += new System.EventHandler(this.btnDeleteProcessing_Click);
            // 
            // lblTotalDistance
            // 
            this.lblTotalDistance.AutoSize = true;
            this.lblTotalDistance.Location = new System.Drawing.Point(6, 379);
            this.lblTotalDistance.Name = "lblTotalDistance";
            this.lblTotalDistance.Size = new System.Drawing.Size(77, 13);
            this.lblTotalDistance.TabIndex = 3;
            this.lblTotalDistance.Text = "Distância total:";
            // 
            // txbTotalDistance
            // 
            this.txbTotalDistance.Location = new System.Drawing.Point(89, 376);
            this.txbTotalDistance.Name = "txbTotalDistance";
            this.txbTotalDistance.Size = new System.Drawing.Size(100, 20);
            this.txbTotalDistance.TabIndex = 2;
            this.txbTotalDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMParam_KeyPress);
            // 
            // btnAddProcessing
            // 
            this.btnAddProcessing.Location = new System.Drawing.Point(209, 374);
            this.btnAddProcessing.Name = "btnAddProcessing";
            this.btnAddProcessing.Size = new System.Drawing.Size(145, 23);
            this.btnAddProcessing.TabIndex = 1;
            this.btnAddProcessing.Text = "&Adicionar distância";
            this.btnAddProcessing.UseVisualStyleBackColor = true;
            this.btnAddProcessing.Click += new System.EventHandler(this.btnAddProcessing_Click);
            // 
            // dgvProcessing
            // 
            this.dgvProcessing.AllowUserToAddRows = false;
            this.dgvProcessing.AllowUserToDeleteRows = false;
            this.dgvProcessing.AllowUserToOrderColumns = true;
            this.dgvProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProcessing.Location = new System.Drawing.Point(6, 6);
            this.dgvProcessing.MultiSelect = false;
            this.dgvProcessing.Name = "dgvProcessing";
            this.dgvProcessing.Size = new System.Drawing.Size(586, 347);
            this.dgvProcessing.TabIndex = 0;
            this.dgvProcessing.SelectionChanged += new System.EventHandler(this.dgvProcessing_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "total_distance";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Distância";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "max_spans_distance";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Config. vão máx.";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "min_total_distance";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Distância mín.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "max_distance_reinforced_base";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Distância base refor.";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.btnMarkAsRead);
            this.tabPageResults.Controls.Add(this.checkBoxViewAll);
            this.tabPageResults.Controls.Add(this.richTextBoxResults);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(598, 411);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Resultados";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // btnMarkAsRead
            // 
            this.btnMarkAsRead.Location = new System.Drawing.Point(384, 377);
            this.btnMarkAsRead.Name = "btnMarkAsRead";
            this.btnMarkAsRead.Size = new System.Drawing.Size(205, 23);
            this.btnMarkAsRead.TabIndex = 3;
            this.btnMarkAsRead.Text = "Arquivar resultados com visualizados";
            this.btnMarkAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAsRead.Click += new System.EventHandler(this.btnMarkAsRead_Click);
            // 
            // checkBoxViewAll
            // 
            this.checkBoxViewAll.AutoSize = true;
            this.checkBoxViewAll.Location = new System.Drawing.Point(6, 377);
            this.checkBoxViewAll.Name = "checkBoxViewAll";
            this.checkBoxViewAll.Size = new System.Drawing.Size(71, 17);
            this.checkBoxViewAll.TabIndex = 2;
            this.checkBoxViewAll.Text = "Ver todos";
            this.checkBoxViewAll.UseVisualStyleBackColor = true;
            this.checkBoxViewAll.Click += new System.EventHandler(this.checkBoxViewAll_Click);
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Location = new System.Drawing.Point(3, 6);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(586, 365);
            this.richTextBoxResults.TabIndex = 1;
            this.richTextBoxResults.Text = "";
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.Location = new System.Drawing.Point(481, 466);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(127, 23);
            this.btnCloseApplication.TabIndex = 3;
            this.btnCloseApplication.Text = "&Fechar";
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 510);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurador";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageConfiguration.ResumeLayout(false);
            this.groupBoxCurrentConfiguration.ResumeLayout(false);
            this.groupBoxCurrentConfiguration.PerformLayout();
            this.groupBoxNewConfiguration.ResumeLayout(false);
            this.groupBoxNewConfiguration.PerformLayout();
            this.tabPageProcessingQueue.ResumeLayout(false);
            this.tabPageProcessingQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.tabPageResults.ResumeLayout(false);
            this.tabPageResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TextBox txbMaxSpansDistance;
        private System.Windows.Forms.TextBox txbMinTotalDistance;
        private System.Windows.Forms.TextBox txbMaxDistanceReinforcedBase;
        private System.Windows.Forms.Label lblMaxDistanceReinforcedBase;
        private System.Windows.Forms.Label lblMinTotalDistance;
        private System.Windows.Forms.Label lblMaxSpansDistance;
        private System.Windows.Forms.Button btnSaveConfiguration;
        private System.Windows.Forms.TabPage tabPageProcessingQueue;
        private System.Windows.Forms.DataGridView dgvProcessing;
        private System.Windows.Forms.TextBox txbTotalDistance;
        private System.Windows.Forms.Button btnAddProcessing;
        private System.Windows.Forms.GroupBox groupBoxCurrentConfiguration;
        private System.Windows.Forms.Label lblCurValueMaxDistanceReinforcedBase;
        private System.Windows.Forms.Label lblCurValueMinTotalDistance;
        private System.Windows.Forms.Label lblCurValueMaxSpansDistance;
        private System.Windows.Forms.Label lblCurrentMaxSpansDistance;
        private System.Windows.Forms.Label lblCurrentMinTotalDistance;
        private System.Windows.Forms.Label lblCurrentMaxDistanceReinforcedBase;
        private System.Windows.Forms.GroupBox groupBoxNewConfiguration;
        private System.Windows.Forms.Label lblTotalDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDeleteProcessing;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.Button btnCloseApplication;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.CheckBox checkBoxViewAll;
        private System.Windows.Forms.Button btnMarkAsRead;
    }
}

