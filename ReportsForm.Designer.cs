namespace FOT_BFMS
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelReportPreview = new System.Windows.Forms.Label();
            this.dgvReportsWithdraw = new System.Windows.Forms.DataGridView();
            this.withdrawIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNeededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bFMSDataSet11 = new FOT_BFMS.BFMSDataSet11();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dgvReportsDeposit = new System.Windows.Forms.DataGridView();
            this.transferIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bFMSDataSet10 = new FOT_BFMS.BFMSDataSet10();
            this.depositTableAdapter = new FOT_BFMS.BFMSDataSet10TableAdapters.DepositTableAdapter();
            this.withdrawTableAdapter = new FOT_BFMS.BFMSDataSet11TableAdapters.WithdrawTableAdapter();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.label9);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1348, 140);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1196, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(154, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 41);
            this.label9.TabIndex = 3;
            this.label9.Text = "Report Generation\n";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.btnGenerate);
            this.pnlFilter.Controls.Add(this.dtTo);
            this.pnlFilter.Controls.Add(this.dtFrom);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.cmbReportType);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Location = new System.Drawing.Point(-7, 127);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1650, 215);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(501, 173);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 37);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(482, 124);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 22);
            this.dtTo.TabIndex = 5;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(482, 75);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 22);
            this.dtFrom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "To Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Date :";
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Deposits",
            "Withdrawals"});
            this.cmbReportType.Location = new System.Drawing.Point(482, 21);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(200, 24);
            this.cmbReportType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Type :";
            // 
            // labelReportPreview
            // 
            this.labelReportPreview.AutoSize = true;
            this.labelReportPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportPreview.Location = new System.Drawing.Point(12, 345);
            this.labelReportPreview.Name = "labelReportPreview";
            this.labelReportPreview.Size = new System.Drawing.Size(164, 28);
            this.labelReportPreview.TabIndex = 3;
            this.labelReportPreview.Text = " Report Preview\n";
            // 
            // dgvReportsWithdraw
            // 
            this.dgvReportsWithdraw.AllowUserToAddRows = false;
            this.dgvReportsWithdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportsWithdraw.AutoGenerateColumns = false;
            this.dgvReportsWithdraw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportsWithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportsWithdraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.withdrawIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.dateNeededDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.createdAtDataGridViewTextBoxColumn});
            this.dgvReportsWithdraw.DataSource = this.withdrawBindingSource;
            this.dgvReportsWithdraw.Location = new System.Drawing.Point(12, 376);
            this.dgvReportsWithdraw.Name = "dgvReportsWithdraw";
            this.dgvReportsWithdraw.ReadOnly = true;
            this.dgvReportsWithdraw.RowHeadersVisible = false;
            this.dgvReportsWithdraw.RowHeadersWidth = 51;
            this.dgvReportsWithdraw.RowTemplate.Height = 24;
            this.dgvReportsWithdraw.Size = new System.Drawing.Size(1324, 268);
            this.dgvReportsWithdraw.TabIndex = 4;
            // 
            // withdrawIDDataGridViewTextBoxColumn
            // 
            this.withdrawIDDataGridViewTextBoxColumn.DataPropertyName = "WithdrawID";
            this.withdrawIDDataGridViewTextBoxColumn.HeaderText = "WithdrawID";
            this.withdrawIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.withdrawIDDataGridViewTextBoxColumn.Name = "withdrawIDDataGridViewTextBoxColumn";
            this.withdrawIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateNeededDataGridViewTextBoxColumn
            // 
            this.dateNeededDataGridViewTextBoxColumn.DataPropertyName = "DateNeeded";
            this.dateNeededDataGridViewTextBoxColumn.HeaderText = "DateNeeded";
            this.dateNeededDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateNeededDataGridViewTextBoxColumn.Name = "dateNeededDataGridViewTextBoxColumn";
            this.dateNeededDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // withdrawBindingSource
            // 
            this.withdrawBindingSource.DataMember = "Withdraw";
            this.withdrawBindingSource.DataSource = this.bFMSDataSet11;
            // 
            // bFMSDataSet11
            // 
            this.bFMSDataSet11.DataSetName = "BFMSDataSet11";
            this.bFMSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPdf
            // 
            this.buttonPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.buttonPdf.FlatAppearance.BorderSize = 0;
            this.buttonPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPdf.ForeColor = System.Drawing.Color.White;
            this.buttonPdf.Location = new System.Drawing.Point(12, 669);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(140, 40);
            this.buttonPdf.TabIndex = 5;
            this.buttonPdf.Text = "Export PDF";
            this.buttonPdf.UseVisualStyleBackColor = false;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(1196, 669);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 40);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = " Back\n";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dgvReportsDeposit
            // 
            this.dgvReportsDeposit.AllowUserToAddRows = false;
            this.dgvReportsDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportsDeposit.AutoGenerateColumns = false;
            this.dgvReportsDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportsDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportsDeposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transferIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.depositDateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvReportsDeposit.DataSource = this.depositBindingSource;
            this.dgvReportsDeposit.Location = new System.Drawing.Point(12, 376);
            this.dgvReportsDeposit.Name = "dgvReportsDeposit";
            this.dgvReportsDeposit.ReadOnly = true;
            this.dgvReportsDeposit.RowHeadersVisible = false;
            this.dgvReportsDeposit.RowHeadersWidth = 51;
            this.dgvReportsDeposit.RowTemplate.Height = 24;
            this.dgvReportsDeposit.Size = new System.Drawing.Size(1324, 268);
            this.dgvReportsDeposit.TabIndex = 9;
            // 
            // transferIDDataGridViewTextBoxColumn
            // 
            this.transferIDDataGridViewTextBoxColumn.DataPropertyName = "TransferID";
            this.transferIDDataGridViewTextBoxColumn.HeaderText = "TransferID";
            this.transferIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transferIDDataGridViewTextBoxColumn.Name = "transferIDDataGridViewTextBoxColumn";
            this.transferIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositDateDataGridViewTextBoxColumn
            // 
            this.depositDateDataGridViewTextBoxColumn.DataPropertyName = "DepositDate";
            this.depositDateDataGridViewTextBoxColumn.HeaderText = "DepositDate";
            this.depositDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depositDateDataGridViewTextBoxColumn.Name = "depositDateDataGridViewTextBoxColumn";
            this.depositDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataMember = "Deposit";
            this.depositBindingSource.DataSource = this.bFMSDataSet10;
            // 
            // bFMSDataSet10
            // 
            this.bFMSDataSet10.DataSetName = "BFMSDataSet10";
            this.bFMSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositTableAdapter
            // 
            this.depositTableAdapter.ClearBeforeFill = true;
            // 
            // withdrawTableAdapter
            // 
            this.withdrawTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.dgvReportsDeposit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.dgvReportsWithdraw);
            this.Controls.Add(this.labelReportPreview);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Report Generation";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labelReportPreview;
        private System.Windows.Forms.DataGridView dgvReportsWithdraw;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvReportsDeposit;
        private BFMSDataSet10 bFMSDataSet10;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private BFMSDataSet10TableAdapters.DepositTableAdapter depositTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BFMSDataSet11 bFMSDataSet11;
        private System.Windows.Forms.BindingSource withdrawBindingSource;
        private BFMSDataSet11TableAdapters.WithdrawTableAdapter withdrawTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn withdrawIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNeededDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
    }
}