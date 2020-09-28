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
    public partial class WELFARE_FUNERAL : UserControl
    {
        public WELFARE_FUNERAL()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static WELFARE_FUNERAL desiguc;

        //funtion to activate department user control

        public static WELFARE_FUNERAL Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new WELFARE_FUNERAL();
                return desiguc;
            }
        }
        SqlConnection con;
        SqlCommand cmd;
        DialogResult dlg;
        private void WELFARE_FUNERAL_Load(object sender, EventArgs e)
        {
            loadWelfareRecords();
        }

        public void loadWelfareRecords()
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

            cmd = new SqlCommand("select * from Funeral", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            dt = new DataTable();
            sda.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvFuneral.DataSource = bs;
            sda.Update(dt);

        }

        private void dgvFuneral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;

                int var = Convert.ToInt32(dgvFuneral.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Funeral where ID ='" + var + "'", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["ID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtCategory.Text = dr["Category"].ToString();
                    txtAmt.Text = dr["Amount"].ToString();
                    dtpDate.Text = dr["Date"].ToString();

                    loadWelfareRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                con = new SqlConnection("Data Source = Localhost; Database = ChurchProject; Integrated Security= true");
                con.Open();

                cmd = new SqlCommand("Insert into Funeral (name,amount,category,date) values(@name,@amt,@cat,@date)", con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@amt", txtAmt.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                if (txtCategory.Text == "" && txtName.Text == "" && txtAmt.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Welfare Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    loadWelfareRecords();
                    MessageBox.Show("Welfare Records saved succesfully!", "Welfare Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = String.Empty;
                    txtCategory.Text = String.Empty;
                    txtAmt.Text = String.Empty;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = Localhost; Database = ChurchProject; Integrated Security= true");
                con.Open();

                cmd = new SqlCommand("Update Funeral set name=@name,amount=@amt,category=@cat,date=@date where ID=@id ", con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@amt", txtAmt.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtCategory.Text == "" && txtName.Text == "" && txtAmt.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Welfare Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    loadWelfareRecords();
                    MessageBox.Show("Welfare Records Updated succesfully!", "Welfare Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = String.Empty;
                    txtCategory.Text = String.Empty;
                    txtAmt.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = Localhost; Database = ChurchProject; Integrated Security= true");
                con.Open();

                cmd = new SqlCommand("Delete Funeral  where ID=@id ", con);
               
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtID.Text == "")
                {
                    MessageBox.Show("ID is required first!", "Welfare Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dlg = MessageBox.Show("Deleting records cannot be undone. Do you really want to delete this record?", "Welfare Status", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        loadWelfareRecords();
                        MessageBox.Show("Welfare Records Deleted succesfully!", "Welfare Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Text = String.Empty;
                        txtCategory.Text = String.Empty;
                        txtAmt.Text = String.Empty;
                    }
                    else
                    {
                        //do nothing!
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmt.Text = String.Empty;
            txtCategory.Text = String.Empty;
            txtID.Text = String.Empty;
            txtName.Text = String.Empty;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

            sda = new SqlDataAdapter("select * from Funeral where concat(Name,Category,Amount,Date) Like '%" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvFuneral.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con;


            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Funeral WHERE [Date]  between  '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "' and Category = 'Funeral'   ", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Funeral");
            dgvFuneral.DataSource = dt.Tables["Funeral"];
            con.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SqlConnection con;
           

            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Funeral WHERE [Date]  between  '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "' and Category = 'Welfare'   ", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Funeral");
            dgvFuneral.DataSource = dt.Tables["Funeral"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadWelfareRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print_Welfare pw = new Print_Welfare();
                pw.Show();
        }
    }
}
