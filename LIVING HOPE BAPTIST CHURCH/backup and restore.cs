using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class backup_and_restore : UserControl
    {
        SqlConnection con = new SqlConnection();


        public backup_and_restore()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static backup_and_restore desiguc;

        //funtion to activate department user control

        public static backup_and_restore Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new backup_and_restore();
                return desiguc;
            }
        }

        private void backup_and_restore_Load(object sender, EventArgs e)
        {

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                DialogResult dlg = MessageBox.Show("BackUp will rewrite existing backup. Make a copy of existing backup file if possible before clicking OK", "Backup Suggestion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    con = new SqlConnection("Data Source = localhost; database = ChurchProject; Integrated Security= true");
                    con.Open();

                    Server dbServer = new Server(new ServerConnection());
                    Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = "ChurchProject" };
                    dbBackup.Devices.AddDevice(@"C:\Data\Living Hope Baptist BackUp "+ DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")+ ".bak", DeviceType.File);
                    dbBackup.Initialize = true;
                    dbBackup.PercentComplete += DbBackup_PercentComplete;
                    dbBackup.Complete += DbBackup_Complete;
                    dbBackup.SqlBackupAsync(dbServer);

                }

                else
                {
                    //do nothing!
                    progressBar.Value = 0;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });
        }

        private void DbBackup_Complete(object sender, Microsoft.SqlServer.Management.Common.ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

       // private void btnBackUPBrowse_Click(object sender, EventArgs e)
       // {
           // FolderBrowserDialog dlg = new FolderBrowserDialog();
          //  if (dlg.ShowDialog() == DialogResult.OK)
          //  {
           //     txtBackUp.Text = dlg.SelectedPath;
          //      btnBackUp.Enabled = true;
          //  }
       // }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER Database Backup Files|*.bak";
            dlg.Title = "Database Restore";
           
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = dlg.FileName;
                btnRestore.Enabled = true;
             
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                con = new SqlConnection("Data Source= localhost; Database= ChurchProject; Integrated Security = true");
                con.Open();
                
                string database = con.Database.ToString();
               
                    string sqlStmt2 = string.Format("Alter Database [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                    bu2.ExecuteNonQuery();

                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestore.Text + "'WITH REPLACE;";
                    SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                    bu3.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                    bu4.ExecuteNonQuery();

                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = 100;
                    progressBar1.Update();
                });
                lblPercent1.Invoke((MethodInvoker)delegate
                {
                    lblPercent1.Text = "100%";
                    lblPercent1.Update();
                }
                 );

                lblStatus1.Text ="RESTORE DATABASE has been processed and Succeeded. Restart Application";
                    con.Close();

                
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackUPBrowse_Click(object sender, EventArgs e)
        {

        }

        private void txtBackUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
