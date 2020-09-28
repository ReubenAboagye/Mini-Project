using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class other_users : Form
    {
        public other_users()
        {
            InitializeComponent();
        }
        private void customizedesing()
        {

            panelcc.Visible = false;
            panelothers.Visible = false;
            
        }
        public static string FullName;
        public static string FetchName
        {
            get { return FullName; }
            set { FullName = value; }
        }


        private void hidesubmenu()
        {
            if (panelcc.Visible == true)
                panelcc.Visible = false;
            if (panelothers.Visible == true)
                panelothers.Visible = false;
            
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btncc_Click(object sender, EventArgs e)
        {

        }

        private void other_users_Load(object sender, EventArgs e)
        {
            rectxt.Text = Form1.FetchName;
            timer1.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You'll be logged out. Do you wish to continue?", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                new Form1().Show();
                this.Hide();
            }
        }

        private void btncc_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panelcc);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showsubmenu(panelothers);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)

            {
                Application.Exit();

            }
            else if (result == DialogResult.No)
            {

                //

            }
            else
            {

                //
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            UCpanel.Controls.Add(addmembers.Instance);
            addmembers.Instance.Dock = DockStyle.Fill;
            addmembers.Instance.BringToFront();
        }

        private void btnbulkcontribution_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(bulkcontribution.Instance);
            bulkcontribution.Instance.Dock = DockStyle.Fill;
            bulkcontribution.Instance.BringToFront();
        }

        private void btntithes_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(bulkcontribution.Instance);
            bulkcontribution.Instance.Dock = DockStyle.Fill;
            bulkcontribution.Instance.BringToFront();
        }

        private void btnwalfareandfuneral_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(WELFARE_FUNERAL.Instance);
            WELFARE_FUNERAL.Instance.Dock = DockStyle.Fill;
            WELFARE_FUNERAL.Instance.BringToFront();
        }

        private void btndayborn_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(AUXILIARY.Instance);
            AUXILIARY.Instance.Dock = DockStyle.Fill;
            AUXILIARY.Instance.BringToFront();
            
        }

        private void btnexpenditure_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(expensis.Instance);
            expensis.Instance.Dock = DockStyle.Fill;
            expensis.Instance.BringToFront();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(ATTENDANCE.Instance);
            ATTENDANCE.Instance.Dock = DockStyle.Fill;
            ATTENDANCE.Instance.BringToFront();
        }

        private void btnbackuprestore_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(backup_and_restore.Instance);
            backup_and_restore.Instance.Dock = DockStyle.Fill;
            backup_and_restore.Instance.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label3.Text = datetime.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
