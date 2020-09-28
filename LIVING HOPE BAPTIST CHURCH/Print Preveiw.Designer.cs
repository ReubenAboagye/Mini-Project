namespace LIVING_HOPE_BAPTIST_CHURCH
{
    partial class Print_Preveiw
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvPrint = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auxiliaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatsAppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baptismalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcel = new System.Windows.Forms.Button();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(988, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvPrint
            // 
            this.dgvPrint.AllowUserToAddRows = false;
            this.dgvPrint.AllowUserToDeleteRows = false;
            this.dgvPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrint.AutoGenerateColumns = false;
            this.dgvPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvPrint.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPrint.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.auxiliaryDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.whatsAppDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.membershipStatusDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.baptismalStatusDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn});
            this.dgvPrint.DataSource = this.memberBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrint.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrint.Location = new System.Drawing.Point(12, 43);
            this.dgvPrint.Name = "dgvPrint";
            this.dgvPrint.ReadOnly = true;
            this.dgvPrint.Size = new System.Drawing.Size(1051, 575);
            this.dgvPrint.TabIndex = 1;
            this.dgvPrint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrint_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auxiliaryDataGridViewTextBoxColumn
            // 
            this.auxiliaryDataGridViewTextBoxColumn.DataPropertyName = "Auxiliary";
            this.auxiliaryDataGridViewTextBoxColumn.HeaderText = "Auxiliary";
            this.auxiliaryDataGridViewTextBoxColumn.Name = "auxiliaryDataGridViewTextBoxColumn";
            this.auxiliaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Mobile No.";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // whatsAppDataGridViewTextBoxColumn
            // 
            this.whatsAppDataGridViewTextBoxColumn.DataPropertyName = "WhatsApp";
            this.whatsAppDataGridViewTextBoxColumn.HeaderText = "WhatsApp No.";
            this.whatsAppDataGridViewTextBoxColumn.Name = "whatsAppDataGridViewTextBoxColumn";
            this.whatsAppDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipStatusDataGridViewTextBoxColumn
            // 
            this.membershipStatusDataGridViewTextBoxColumn.DataPropertyName = "Membership_Status";
            this.membershipStatusDataGridViewTextBoxColumn.HeaderText = "Membership Status";
            this.membershipStatusDataGridViewTextBoxColumn.Name = "membershipStatusDataGridViewTextBoxColumn";
            this.membershipStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital_Status";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baptismalStatusDataGridViewTextBoxColumn
            // 
            this.baptismalStatusDataGridViewTextBoxColumn.DataPropertyName = "Baptismal_Status";
            this.baptismalStatusDataGridViewTextBoxColumn.HeaderText = "Baptismal Status";
            this.baptismalStatusDataGridViewTextBoxColumn.Name = "baptismalStatusDataGridViewTextBoxColumn";
            this.baptismalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "Occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            this.occupationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(LIVING_HOPE_BAPTIST_CHURCH.member);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(12, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataSource = typeof(LIVING_HOPE_BAPTIST_CHURCH.member);
            // 
            // Print_Preveiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 630);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvPrint);
            this.Controls.Add(this.btnPrint);
            this.Name = "Print_Preveiw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print_Preveiw";
            this.Load += new System.EventHandler(this.Print_Preveiw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.DataGridView dgvPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auxiliaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatsAppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baptismalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcel;
    }
}