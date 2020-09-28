using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class ATTENDANCE : UserControl
    {
       

        public ATTENDANCE()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static ATTENDANCE desiguc;

        //funtion to activate department user control

        public static ATTENDANCE Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new ATTENDANCE();
                return desiguc;
            }
        }

        SqlConnection con;
        SqlCommand cmd;
       
        private void ATTENDANCE_Load(object sender, EventArgs e)
        {
            loadAttendanceRecords();
            txtTotal.Text = txtMale.ToString() +   txtFemale.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = localhost; database = ChurchProject; Integrated Security= True");

                con.Open();

                cmd = new SqlCommand("Insert into Attendance (Category,Total_Male,Total_Female,Date) values (@cat,@male,@female,@date)",con);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@male", txtMale.Text);
                cmd.Parameters.AddWithValue("@female", txtFemale.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                if(txtFemale.Text == "" && txtMale.Text ==" " && cmbCategory.Text == "" )
                {
                    MessageBox.Show("All fields are required!", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // do nothing!
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance Records saved Succesfully!", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadAttendanceRecords();
            }
            catch( Exception ay)
            {
                MessageBox.Show(ay.Message);
            }
            cmbCategory.Text = null;
            txtFemale.Text = null;
            txtMale.Text = null;
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source= localhost; Database= ChurchProject; Integrated Security= True");
                con.Open();

                cmd = new SqlCommand("Update Attendance set Category=@cat,Total_Male=@male,Total_Female=@female,Date=@date where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@male",txtMale.Text);
                cmd.Parameters.AddWithValue("@female", txtFemale.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                if (txtID.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // do nothing!
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance Records Updated Succesfully!", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadAttendanceRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbCategory.Text = null;
            txtFemale.Text = null;
            txtMale.Text = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source= localhost; Database= ChurchProject; Integrated Security= True");
                con.Open();

                cmd = new SqlCommand("Delete from  Attendance where (ID= @id)", con);

                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtID.Text == "" )
                {
                    MessageBox.Show("ID is required to delete records", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // do nothing!
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete was Succesful!", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadAttendanceRecords();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbCategory.Text = null;
            txtFemale.Text = null;
            txtMale.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" && txtMale.Text == "" && txtFemale.Text == "" && cmbCategory.Text == "" && dtpDate.Text == "")
                {
                    // do nothing
                }
                else
                {
                    cmbCategory.Text = "";
                    txtMale.Text = "";
                    txtID.Text = "";
                    txtFemale.Text = "";
                    dtpDate.Text = "";
                    txtID.Text = "";
                    txtTotal.Text = "";
                    loadAttendanceRecords();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        public void loadAttendanceRecords()
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

            cmd = new SqlCommand("select * from Attendance", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            dt = new DataTable();
            sda.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvAttendance.DataSource = bs;
            sda.Update(dt);

        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;

                int var = Convert.ToInt32(dgvAttendance.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Attendance where ID ='" + var + "'", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["ID"].ToString();
                    txtMale.Text = dr["Total_Male"].ToString();
                    txtFemale.Text = dr["Total_Female"].ToString();
                    cmbCategory.Text = dr["Category"].ToString();
                    txtTotal.Text = dr["total"].ToString();
                    dtpDate.Text = dr["Date"].ToString();

                    loadAttendanceRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            loadAttendanceRecords();
            txtTotal.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

            sda = new SqlDataAdapter("select * from Attendance where concat(Category,Date) Like '%" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvAttendance.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con;


            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Attendance WHERE [Date]  between  '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "' and Category = 'Adult'   ", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Attendance");
            dgvAttendance.DataSource = dt.Tables["Attendance"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con;


            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Attendance WHERE [Date]  between  '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "' and Category = 'Teens'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Attendance");
            dgvAttendance.DataSource = dt.Tables["Attendance"];
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            SqlConnection con;


            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Attendance WHERE [Date]  between  '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "' and Category = 'Children'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Attendance");
            dgvAttendance.DataSource = dt.Tables["Attendance"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadAttendanceRecords();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }

}
