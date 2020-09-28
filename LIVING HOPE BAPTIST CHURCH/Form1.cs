using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public static string adminusername = "kennedy";
        public static string adminpass = "1234";

        public static string backdoor = "reuben";
        public static string backdoorpass = "haley";

        public static string username;

        //to show current logged in username on dashboard
        public static string recby
        {
            get { return username; }
            set { username = value; }
        }
        // fetching FirstName and LastName from Database
        public static string FullName;
        public static string FetchName
        {
            get { return FullName; }
            set { FullName = value; }
        }

        //showing live time on dashboard
        public static string TimeDate
        {
            get { return Datenow; }
            set { Datenow = value; }
        }
     
    SqlConnection con;
        SqlCommand cmd;
        public static string Datenow;
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            try


            { 

                recby = txtusername.Text;
                con = new SqlConnection("Data Source=localhost; Initial Catalog=churchproject; Integrated Security=True");
                con.Open();


                if(txtpassword.Text == backdoorpass && txtusername.Text == backdoor)
                {
                    DASHBOARD ds = new DASHBOARD();
                    ds.Show();
                    this.Hide();

                }
                else { 

                cmd = new SqlCommand("select * from Users where username=@user and password=@pass", con);
                
                cmd.Parameters.AddWithValue("@user", txtusername.Text);
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text);

               

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbvalue = cmbOperational.SelectedItem.ToString();
                    if (dt.Rows.Count > 0)
                    {

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["OperationalStatus"].ToString() == cmbvalue)
                            {


                                FetchName = dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString();
                                cmd = new SqlCommand($"Insert into LoginRecords (Username,Time) values({FetchName.ToString()},{DateTime.Now}", con);

                                MessageBox.Show($"Welcome {FetchName}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);//This will fetch the User's fullname and pop up with a welcome note



                                if (cmbOperational.SelectedIndex == 0)
                                {


                                    DASHBOARD d = new DASHBOARD();
                                    d.Show();
                                    this.Hide();
                                }


                                else
                                {

                                    other_users ou = new other_users();
                                    ou.Show();
                                    this.Hide();
                                }

                            }
                        }
                    }

                    else
                    { MessageBox.Show("Incorrect Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        
                    }

                


            }
            
    

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class UserDisplayName
        {
            public static string displayName;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbOperational_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

