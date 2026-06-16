namespace FOT_BFMS
{
    partial class RequestApprovalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestApprovalForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.bFMSDataSet1 = new FOT_BFMS.BFMSDataSet1();
            this.requestTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableTableAdapter = new FOT_BFMS.BFMSDataSet1TableAdapters.RequestTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bFMSDataSet2 = new FOT_BFMS.BFMSDataSet2();
            this.requestTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableTableAdapter1 = new FOT_BFMS.BFMSDataSet2TableAdapters.RequestTableTableAdapter();
            this.requestTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNeededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTableBindingSource1)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1348, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1236, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(136, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(464, 41);
            this.label9.TabIndex = 4;
            this.label9.Text = "Request Approval Management\n";
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApprove.BackColor = System.Drawing.Color.Green;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(65, 636);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(248, 57);
            this.btnApprove.TabIndex = 13;
            this.btnApprove.Text = "Approve Request";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(554, 636);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(248, 57);
            this.btnReject.TabIndex = 14;
            this.btnReject.Text = "Reject Request";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1060, 636);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(248, 57);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bFMSDataSet1
            // 
            this.bFMSDataSet1.DataSetName = "BFMSDataSet1";
            this.bFMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestTableBindingSource
            // 
            this.requestTableBindingSource.DataMember = "RequestTable";
            this.requestTableBindingSource.DataSource = this.bFMSDataSet1;
            // 
            // requestTableTableAdapter
            // 
            this.requestTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestTitleDataGridViewTextBoxColumn,
            this.requestAmountDataGridViewTextBoxColumn,
            this.dataNeededDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(199, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 416);
            this.dataGridView1.TabIndex = 16;
            // 
            // bFMSDataSet2
            // 
            this.bFMSDataSet2.DataSetName = "BFMSDataSet2";
            this.bFMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestTableBindingSource1
            // 
            this.requestTableBindingSource1.DataMember = "RequestTable";
            this.requestTableBindingSource1.DataSource = this.bFMSDataSet2;
            // 
            // requestTableTableAdapter1
            // 
            this.requestTableTableAdapter1.ClearBeforeFill = true;
            // 
            // requestTitleDataGridViewTextBoxColumn
            // 
            this.requestTitleDataGridViewTextBoxColumn.DataPropertyName = "RequestTitle";
            this.requestTitleDataGridViewTextBoxColumn.HeaderText = "RequestTitle";
            this.requestTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestTitleDataGridViewTextBoxColumn.Name = "requestTitleDataGridViewTextBoxColumn";
            this.requestTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestAmountDataGridViewTextBoxColumn
            // 
            this.requestAmountDataGridViewTextBoxColumn.DataPropertyName = "RequestAmount";
            this.requestAmountDataGridViewTextBoxColumn.HeaderText = "RequestAmount";
            this.requestAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestAmountDataGridViewTextBoxColumn.Name = "requestAmountDataGridViewTextBoxColumn";
            this.requestAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataNeededDataGridViewTextBoxColumn
            // 
            this.dataNeededDataGridViewTextBoxColumn.DataPropertyName = "DataNeeded";
            this.dataNeededDataGridViewTextBoxColumn.HeaderText = "DataNeeded";
            this.dataNeededDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNeededDataGridViewTextBoxColumn.Name = "dataNeededDataGridViewTextBoxColumn";
            this.dataNeededDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // RequestApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.pnlHeader);
            this.Name = "RequestApprovalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Approval";
            this.Load += new System.EventHandler(this.RequestApprovalForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnBack;
        private BFMSDataSet1 bFMSDataSet1;
        private System.Windows.Forms.BindingSource requestTableBindingSource;
        private BFMSDataSet1TableAdapters.RequestTableTableAdapter requestTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BFMSDataSet2 bFMSDataSet2;
        private System.Windows.Forms.BindingSource requestTableBindingSource1;
        private BFMSDataSet2TableAdapters.RequestTableTableAdapter requestTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNeededDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}