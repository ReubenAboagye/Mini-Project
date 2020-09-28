namespace LIVING_HOPE_BAPTIST_CHURCH
{
    partial class backup_and_restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backup_and_restore));
            this.txtBackUp = new System.Windows.Forms.TextBox();
            this.btnBackUPBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.btnRestoreBrowse = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.lblPercent1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBackUp
            // 
            this.txtBackUp.Enabled = false;
            this.txtBackUp.Location = new System.Drawing.Point(65, 191);
            this.txtBackUp.Name = "txtBackUp";
            this.txtBackUp.Size = new System.Drawing.Size(415, 20);
            this.txtBackUp.TabIndex = 211;
            this.txtBackUp.Text = "C:\\Data";
            this.txtBackUp.TextChanged += new System.EventHandler(this.txtBackUp_TextChanged);
            // 
            // btnBackUPBrowse
            // 
            this.btnBackUPBrowse.Enabled = false;
            this.btnBackUPBrowse.Location = new System.Drawing.Point(370, 224);
            this.btnBackUPBrowse.Name = "btnBackUPBrowse";
            this.btnBackUPBrowse.Size = new System.Drawing.Size(110, 23);
            this.btnBackUPBrowse.TabIndex = 212;
            this.btnBackUPBrowse.Text = "Browse";
            this.btnBackUPBrowse.UseVisualStyleBackColor = true;
            this.btnBackUPBrowse.Visible = false;
            this.btnBackUPBrowse.Click += new System.EventHandler(this.btnBackUPBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 213;
            this.label2.Text = "Location:";
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
            this.panel2.TabIndex = 217;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BACKUP AND RESTORE";
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackUp.FlatAppearance.BorderSize = 0;
            this.btnBackUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.Location = new System.Drawing.Point(65, 277);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(415, 80);
            this.btnBackUp.TabIndex = 210;
            this.btnBackUp.Text = "BACKUP\r\n\r\n\r\n";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.SpringGreen;
            this.progressBar.Location = new System.Drawing.Point(74, 389);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(415, 23);
            this.progressBar.TabIndex = 218;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(247, 415);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(24, 13);
            this.lblPercent.TabIndex = 213;
            this.lblPercent.Text = "0 %";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(62, 470);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 213;
            this.lblStatus.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 213;
            this.label4.Text = "Progress:";
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Location = new System.Drawing.Point(674, 447);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(40, 13);
            this.lblStatus1.TabIndex = 213;
            this.lblStatus1.Text = "Status:";
            // 
            // btnRestoreBrowse
            // 
            this.btnRestoreBrowse.Location = new System.Drawing.Point(986, 224);
            this.btnRestoreBrowse.Name = "btnRestoreBrowse";
            this.btnRestoreBrowse.Size = new System.Drawing.Size(110, 23);
            this.btnRestoreBrowse.TabIndex = 215;
            this.btnRestoreBrowse.Text = "Browse";
            this.btnRestoreBrowse.UseVisualStyleBackColor = true;
            this.btnRestoreBrowse.Click += new System.EventHandler(this.btnRestoreBrowse_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(677, 277);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(419, 80);
            this.btnRestore.TabIndex = 209;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 213;
            this.label6.Text = "Progress:";
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(677, 191);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(419, 20);
            this.txtRestore.TabIndex = 214;
            // 
            // lblPercent1
            // 
            this.lblPercent1.AutoSize = true;
            this.lblPercent1.Location = new System.Drawing.Point(863, 415);
            this.lblPercent1.Name = "lblPercent1";
            this.lblPercent1.Size = new System.Drawing.Size(24, 13);
            this.lblPercent1.TabIndex = 213;
            this.lblPercent1.Text = "0 %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 216;
            this.label3.Text = "Location:";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.SpringGreen;
            this.progressBar1.Location = new System.Drawing.Point(681, 389);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 23);
            this.progressBar1.TabIndex = 218;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(65, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 219;
            this.label5.Text = "Notice:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(121, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(467, 17);
            this.label7.TabIndex = 219;
            this.label7.Text = "Please create a folder in Local Disk C with name Data before making backup";
            // 
            // backup_and_restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRestoreBrowse);
            this.Controls.Add(this.lblPercent1);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBackUPBrowse);
            this.Controls.Add(this.txtBackUp);
            this.Controls.Add(this.btnRestore);
            this.Name = "backup_and_restore";
            this.Size = new System.Drawing.Size(1192, 706);
            this.Load += new System.EventHandler(this.backup_and_restore_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBackUp;
        private System.Windows.Forms.Button btnBackUPBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestoreBrowse;
        private System.Windows.Forms.Label lblPercent1;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}
