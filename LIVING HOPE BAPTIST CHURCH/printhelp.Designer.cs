namespace LIVING_HOPE_BAPTIST_CHURCH
{
    partial class printhelp
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
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.churchNote = new LIVING_HOPE_BAPTIST_CHURCH.ChurchNote();
            this.noteTableAdapter = new LIVING_HOPE_BAPTIST_CHURCH.ChurchNoteTableAdapters.NoteTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginRecords = new LIVING_HOPE_BAPTIST_CHURCH.LoginRecords();
            this.loginRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginRecordsTableAdapter = new LIVING_HOPE_BAPTIST_CHURCH.LoginRecordsTableAdapters.LoginRecordsTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataMember = "Note";
            this.noteBindingSource.DataSource = this.churchNote;
            // 
            // churchNote
            // 
            this.churchNote.DataSetName = "ChurchNote";
            this.churchNote.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteTableAdapter
            // 
            this.noteTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(676, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(23, 27);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.accessedTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginRecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(739, 464);
            this.dataGridView1.TabIndex = 7;
            // 
            // loginRecords
            // 
            this.loginRecords.DataSetName = "LoginRecords";
            this.loginRecords.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginRecordsBindingSource
            // 
            this.loginRecordsBindingSource.DataMember = "LoginRecords";
            this.loginRecordsBindingSource.DataSource = this.loginRecords;
            // 
            // loginRecordsTableAdapter
            // 
            this.loginRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accessedTimeDataGridViewTextBoxColumn
            // 
            this.accessedTimeDataGridViewTextBoxColumn.DataPropertyName = "Accessed Time";
            this.accessedTimeDataGridViewTextBoxColumn.HeaderText = "Accessed Time";
            this.accessedTimeDataGridViewTextBoxColumn.Name = "accessedTimeDataGridViewTextBoxColumn";
            this.accessedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printhelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExcel);
            this.Name = "printhelp";
            this.Text = "printhelp";
            this.Load += new System.EventHandler(this.printhelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ChurchNote churchNote;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private ChurchNoteTableAdapters.NoteTableAdapter noteTableAdapter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LoginRecords loginRecords;
        private System.Windows.Forms.BindingSource loginRecordsBindingSource;
        private LoginRecordsTableAdapters.LoginRecordsTableAdapter loginRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessedTimeDataGridViewTextBoxColumn;
    }
}