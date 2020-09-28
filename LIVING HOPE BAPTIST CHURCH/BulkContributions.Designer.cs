namespace LIVING_HOPE_BAPTIST_CHURCH
{
    partial class BulkContributions
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.balancesheet = new System.Windows.Forms.DataGridView();
            this.bulkContribution = new LIVING_HOPE_BAPTIST_CHURCH.BulkContribution();
            this.bulkContributionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bulk_ContributionsTableAdapter = new LIVING_HOPE_BAPTIST_CHURCH.BulkContributionTableAdapters.Bulk_ContributionsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.balancesheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulkContribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulkContributionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(12, 22);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(81, 26);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(623, 22);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 26);
            this.btnPdf.TabIndex = 0;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // balancesheet
            // 
            this.balancesheet.AllowUserToAddRows = false;
            this.balancesheet.AllowUserToDeleteRows = false;
            this.balancesheet.AllowUserToOrderColumns = true;
            this.balancesheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balancesheet.AutoGenerateColumns = false;
            this.balancesheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.balancesheet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.balancesheet.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.balancesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balancesheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.balancesheet.DataSource = this.bulkContributionsBindingSource;
            this.balancesheet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.balancesheet.Location = new System.Drawing.Point(12, 68);
            this.balancesheet.Name = "balancesheet";
            this.balancesheet.ReadOnly = true;
            this.balancesheet.Size = new System.Drawing.Size(692, 493);
            this.balancesheet.TabIndex = 3;
            // 
            // bulkContribution
            // 
            this.bulkContribution.DataSetName = "BulkContribution";
            this.bulkContribution.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bulkContributionsBindingSource
            // 
            this.bulkContributionsBindingSource.DataMember = "Bulk_Contributions";
            this.bulkContributionsBindingSource.DataSource = this.bulkContribution;
            // 
            // bulk_ContributionsTableAdapter
            // 
            this.bulk_ContributionsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // BulkContributions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 588);
            this.Controls.Add(this.balancesheet);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnExcel);
            this.Name = "BulkContributions";
            this.Text = "BulkContributions";
            this.Load += new System.EventHandler(this.BulkContributions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balancesheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulkContribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulkContributionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.DataGridView balancesheet;
        private BulkContribution bulkContribution;
        private System.Windows.Forms.BindingSource bulkContributionsBindingSource;
        private BulkContributionTableAdapters.Bulk_ContributionsTableAdapter bulk_ContributionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}