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

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class ADD_OR_EDIT_USER : UserControl
    {
        public ADD_OR_EDIT_USER()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();

        // private variable for department user control
        private static ADD_OR_EDIT_USER desiguc;

        //funtion to activate department user control

        public static ADD_OR_EDIT_USER Instance
        {

            get
            {
                if (desiguc == null)
                    desiguc = new ADD_OR_EDIT_USER();
                return desiguc;
            }
        }

        public void loadUserRecords()
        {
            // declaring database variable for data grid view
            SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataTable dt;
            BindingSource bs;


            //Assigning valuse to declare database variables
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

            cmd = new SqlCommand("select ID,Username,FirstName,LastName,OperationalStatus from Users", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            dt = new DataTable();
            sda.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvUserRecord.DataSource = bs;
            sda.Update(dt);
            
        }

        private void ADD_OR_EDIT_USER_Load(object sender, EventArgs e)
        {
            loadUserRecords();
        }


        //codes for the save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating a connection to  the database
                con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated Security= true");
                con.Open();

                cmd = new SqlCommand("Insert into Users(Username,FirstName,LastName,Password,OperationalStatus)"
                                    + "values(@username,@fname,@lname,@pass,@operation)", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@operation", cmbOperational.Text);


                if (txtFirstName.Text == "" && txtLastName.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //do nothing!
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Records saved Succesfully!", "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUserRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //codes for the update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                //Creating a connection to  the database
                con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated Security= true");
                con.Open();

                cmd = new SqlCommand("Update Users set Username = @user, FirstName =@fname, LastName = @lname, Password = @pass, OperationalStatus = @operation where ID=@id", con);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@operation", cmbOperational.Text);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                if (txtConfirmPass.Text != txtPass.Text)
                {
                    MessageBox.Show("The Passwords do not match!", "Incorrect Passwords!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txtFirstName.Text == "" && txtLastName.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //do nothing!


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records saved Succesfully!", "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUserRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        //codes for the delete button
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source= localhost; Database = ChurchProject; Integrated Security= True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Users where ID =@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtID.Text == "" && txtUsername.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "")
                {
                    MessageBox.Show("Enter at least User ID and Username!", "User Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User records deleted Succcefully!", "User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadUserRecords();
        }

        //codes for clearing the textboxes
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtConfirmPass.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox1.Checked = false;
            loadUserRecords();
        }

        //datagrid view
        private void dgvUserRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;

                int var = Convert.ToInt32(dgvUserRecord.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Users where ID ='" + var + "'", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["ID"].ToString();
                    txtFirstName.Text = dr["FirstName"].ToString();
                    txtLastName.Text = dr["LastName"].ToString();
                    txtUsername.Text = dr["Username"].ToString();
                    cmbOperational.Text = dr["OperationalStatus"].ToString();

                    loadUserRecords();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


