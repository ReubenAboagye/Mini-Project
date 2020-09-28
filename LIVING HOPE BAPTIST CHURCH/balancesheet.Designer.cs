namespace LIVING_HOPE_BAPTIST_CHURCH
{
    partial class balancesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balancesheet));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBalanceSheet = new System.Windows.Forms.DataGridView();
            this.btnprint = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanceSheet)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(430, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BALANCE SHEET";
            // 
            // dgvBalanceSheet
            // 
            this.dgvBalanceSheet.AllowUserToAddRows = false;
            this.dgvBalanceSheet.AllowUserToDeleteRows = false;
            this.dgvBalanceSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBalanceSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBalanceSheet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBalanceSheet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBalanceSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalanceSheet.Location = new System.Drawing.Point(27, 145);
            this.dgvBalanceSheet.Name = "dgvBalanceSheet";
            this.dgvBalanceSheet.ReadOnly = true;
            this.dgvBalanceSheet.Size = new System.Drawing.Size(1130, 545);
            this.dgvBalanceSheet.TabIndex = 148;
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(1009, 76);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(148, 48);
            this.btnprint.TabIndex = 147;
            this.btnprint.Text = "Export to PDF";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // balancesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgvBalanceSheet);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.panel2);
            this.Name = "balancesheet";
            this.Size = new System.Drawing.Size(1192, 716);
            this.Load += new System.EventHandler(this.balancesheet_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanceSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBalanceSheet;
        private System.Windows.Forms.Button btnprint;
    }
}
