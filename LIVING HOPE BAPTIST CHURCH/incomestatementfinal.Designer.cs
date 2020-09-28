namespace LIVING_HOPE_BAPTIST_CHURCH
{
    partial class incomestatementfinal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(incomestatementfinal));
            this.btnprint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.churchProjectDataSet1 = new LIVING_HOPE_BAPTIST_CHURCH.ChurchProjectDataSet1();
            this.incomeStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeStatementTableAdapter = new LIVING_HOPE_BAPTIST_CHURCH.ChurchProjectDataSet1TableAdapters.IncomeStatementTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.churchProjectDataSet2 = new LIVING_HOPE_BAPTIST_CHURCH.ChurchProjectDataSet2();
            this.expenditureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenditureTableAdapter = new LIVING_HOPE_BAPTIST_CHURCH.ChurchProjectDataSet2TableAdapters.ExpenditureTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeStatementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnprint.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(263, 86);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(123, 48);
            this.btnprint.TabIndex = 145;
            this.btnprint.Text = "PDF";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(608, 538);
            this.dataGridView1.TabIndex = 146;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // churchProjectDataSet1
            // 
            this.churchProjectDataSet1.DataSetName = "ChurchProjectDataSet1";
            this.churchProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeStatementBindingSource
            // 
            this.incomeStatementBindingSource.DataMember = "IncomeStatement";
            this.incomeStatementBindingSource.DataSource = this.churchProjectDataSet1;
            // 
            // incomeStatementTableAdapter
            // 
            this.incomeStatementTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(755, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 145;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // churchProjectDataSet2
            // 
            this.churchProjectDataSet2.DataSetName = "ChurchProjectDataSet2";
            this.churchProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenditureBindingSource
            // 
            this.expenditureBindingSource.DataMember = "Expenditure";
            this.expenditureBindingSource.DataSource = this.churchProjectDataSet2;
            // 
            // expenditureTableAdapter
            // 
            this.expenditureTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 62);
            this.panel2.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "INCOME STATEMENT FINAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomestatementfinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.panel2);
            this.Name = "incomestatementfinal";
            this.Size = new System.Drawing.Size(1192, 716);
            this.Load += new System.EventHandler(this.incomestatementfinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeStatementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource incomeStatementBindingSource;
        private ChurchProjectDataSet1 churchProjectDataSet1;
        private ChurchProjectDataSet1TableAdapters.IncomeStatementTableAdapter incomeStatementTableAdapter;
        private System.Windows.Forms.Button button1;
        private ChurchProjectDataSet2 churchProjectDataSet2;
        private System.Windows.Forms.BindingSource expenditureBindingSource;
        private ChurchProjectDataSet2TableAdapters.ExpenditureTableAdapter expenditureTableAdapter;
    }
}
