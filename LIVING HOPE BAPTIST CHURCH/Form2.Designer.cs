namespace LIVING_HOPE_BAPTIST_CHURCH
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalMaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFemaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.churchProjectDataSet4 = new LIVING_HOPE_BAPTIST_CHURCH.ChurchProjectDataSet4();
            this.auxiliary = new LIVING_HOPE_BAPTIST_CHURCH.Auxiliary();
            this.auxiliaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new LIVING_HOPE_BAPTIST_CHURCH.ChurchProjectDataSet4TableAdapters.AttendanceTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchProjectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxiliary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxiliaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalMaleDataGridViewTextBoxColumn,
            this.totalFemaleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(666, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // totalMaleDataGridViewTextBoxColumn
            // 
            this.totalMaleDataGridViewTextBoxColumn.DataPropertyName = "Total_Male";
            this.totalMaleDataGridViewTextBoxColumn.HeaderText = "Total Male";
            this.totalMaleDataGridViewTextBoxColumn.Name = "totalMaleDataGridViewTextBoxColumn";
            this.totalMaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalFemaleDataGridViewTextBoxColumn
            // 
            this.totalFemaleDataGridViewTextBoxColumn.DataPropertyName = "Total_Female";
            this.totalFemaleDataGridViewTextBoxColumn.HeaderText = "Total Female";
            this.totalFemaleDataGridViewTextBoxColumn.Name = "totalFemaleDataGridViewTextBoxColumn";
            this.totalFemaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.churchProjectDataSet4;
            // 
            // churchProjectDataSet4
            // 
            this.churchProjectDataSet4.DataSetName = "ChurchProjectDataSet4";
            this.churchProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auxiliary
            // 
            this.auxiliary.DataSetName = "Auxiliary";
            this.auxiliary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auxiliaryBindingSource
            // 
            this.auxiliaryBindingSource.DataSource = this.auxiliary;
            this.auxiliaryBindingSource.Position = 0;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(582, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 34);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(3, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(93, 34);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 501);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchProjectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxiliary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxiliaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource auxiliaryBindingSource;
        private Auxiliary auxiliary;
        private ChurchProjectDataSet4 churchProjectDataSet4;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private ChurchProjectDataSet4TableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFemaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExcel;
    }
}