using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
            customizedesing();
          
        }
        private void customizedesing()
        {

            panelcc.Visible = false;
            panelothers.Visible = false;
            panelREPORT.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelcc.Visible == true)
                panelcc.Visible = false;
            if (panelothers.Visible == true)
                panelothers.Visible = false;
            if (panelREPORT.Visible == true)
                panelREPORT.Visible = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            showsubmenu(panelcc);
        }

    
        private void txtmember_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(addmembers.Instance);
            addmembers.Instance.Dock = DockStyle.Fill;
            addmembers.Instance.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexpenditure_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(expensis.Instance);
            expensis.Instance.Dock = DockStyle.Fill;
            expensis.Instance.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showsubmenu(panelothers);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)

            {
                Form1 lg = new Form1();
                lg.Show();

                this.Hide();

            }
            else if (result == DialogResult.No)
            {
               // do nothing!
            }
            else
            {
               // do nothing!
            }
        }

        private void UCpanel_Paint(object sender, PaintEventArgs e)
        {
            //dashboardcontrol.Instance.BringToFront();
        }


        


        private void button1_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(bulkcontribution.Instance);
            bulkcontribution.Instance.Dock = DockStyle.Fill;
            bulkcontribution.Instance.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(WELFARE_FUNERAL.Instance);
            WELFARE_FUNERAL.Instance.Dock = DockStyle.Fill;
            WELFARE_FUNERAL.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            UCpanel.Controls.Add(addmembers.Instance);
            addmembers.Instance.Dock = DockStyle.Fill;
            addmembers.Instance.BringToFront();
        }

        private void btntithes_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(TITHE.Instance);
            TITHE.Instance.Dock = DockStyle.Fill;
            TITHE.Instance.BringToFront();
        }

        private void btndayborn_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(AUXILIARY.Instance);
            AUXILIARY.Instance.Dock = DockStyle.Fill;
            AUXILIARY.Instance.BringToFront();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(ATTENDANCE.Instance);
            ATTENDANCE.Instance.Dock = DockStyle.Fill;
            ATTENDANCE.Instance.BringToFront();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(ADD_OR_EDIT_USER.Instance);
            ADD_OR_EDIT_USER.Instance.Dock = DockStyle.Fill;
            ADD_OR_EDIT_USER.Instance.BringToFront();
        }


        private void btnbackuprestore_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(backup_and_restore.Instance);
            backup_and_restore.Instance.Dock = DockStyle.Fill;
            backup_and_restore.Instance.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            UCpanel.Controls.Add(dashboardcontrol.Instance);
            dashboardcontrol.Instance.Dock = DockStyle.Fill;
            dashboardcontrol.Instance.BringToFront();
        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {
            try
            {
                rectxt.Text = Form1.FetchName;
                timer1.Start();
                SqlConnection con;
                SqlCommand cmd;
                if (Form1.FetchName == Form1.backdoor)
                {
                   
                   //if the username = my own backdoor name
                    //do nothing
                }
                else
                {
                    string Logger = $"[Logged in at {DateTime.Now}]";
                    con = new SqlConnection("Data Source = Localhost; Database = ChurchProject; Integrated Security = true");
                    con.Open();
                    cmd = new SqlCommand($"Insert into LoginRecords (Username,[Accessed Time]) values(@username,@time)", con);

                    cmd.Parameters.AddWithValue("@username", Form1.recby);
                    cmd.Parameters.AddWithValue("@time", Logger);
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnreport_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panelREPORT);
        }

        private void btnincomestatement_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(incomestatementfinal.Instance);
            incomestatementfinal.Instance.Dock = DockStyle.Fill;
            incomestatementfinal.Instance.BringToFront();
        }

        private void btnbalancesheet_Click(object sender, EventArgs e)
        {
            UCpanel.Controls.Add(balancesheet.Instance);
            balancesheet.Instance.Dock = DockStyle.Fill;
            balancesheet.Instance.BringToFront();
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

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You'll be logged out. Do you wish to continue?", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                SqlConnection con;
                SqlCommand cmd;

                string Logger = $"[logged out in at {DateTime.Now}]";
                con = new SqlConnection("Data Source = Localhost; Database = ChurchProject; Integrated Security = true");
                con.Open();
                cmd = new SqlCommand($"Insert into LoginRecords (Username,[Accessed Time]) values(@username,@time)", con);

                cmd.Parameters.AddWithValue("@username", Form1.recby);
                cmd.Parameters.AddWithValue("@time", Logger);
                cmd.ExecuteNonQuery();

                con.Close();

                new Form1().Show();
                this.Hide();
            }
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            
                WindowState = FormWindowState.Normal;
            
          
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelcc_Paint(object sender, PaintEventArgs e)
        {

        }

        //adding time to the main window
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label3.Text = datetime.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dashboardcontrol1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
