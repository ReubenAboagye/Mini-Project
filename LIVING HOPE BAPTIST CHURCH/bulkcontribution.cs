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
    public partial class bulkcontribution : UserControl
    {
        public bulkcontribution()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static bulkcontribution desiguc;

        //funtion to activate department user control

        public static bulkcontribution Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new bulkcontribution();
                return desiguc;
            }
        }


        SqlConnection con;
        
        SqlCommand cmd;
        

        private void bulkcontribution_Load(object sender, EventArgs e)
        {
            loadBulkContributions();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = localhost; Database=ChurchProject; Integrated Security = true");
                con.Open();

                cmd = new SqlCommand("Insert into Bulk_Contributions (Amount, Category, Date) values (@amt, @cat, @date)", con);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                if (txtAmount.Text == "" && cmbCategory.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records saved Succesfully!", "Save Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Text = "";
                    cmbCategory.Text = null;


                }
                loadBulkContributions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = localhost; Database=ChurchProject; Integrated Security = true");
                con.Open();

                cmd = new SqlCommand("Update Bulk_Contributions set Amount=@amt, Category=@cat, Date=@date where ID=@id" , con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                if (txtID.Text == "")
                {
                    MessageBox.Show("An ID is required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records saved Succesfully!", "Save Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Text = "";
                    cmbCategory.Text = null;
                    txtID.Text = "";

                }
                loadBulkContributions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = localhost; Database=ChurchProject; Integrated Security = true");
                con.Open();

                cmd = new SqlCommand("Delete Bulk_Contributions where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                

                if (txtID.Text == "")
                {
                    MessageBox.Show("An ID is required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {  
                    DialogResult dlg =  MessageBox.Show("Deleted Records cannot be recorvered. Do you really want to delete this record?", "Delete Option", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Records saved Succesfully!", "Save Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAmount.Text = "";
                        cmbCategory.Text = null;
                        txtID.Text = "";
                    }else
                    {
                        //nothing
                    }

                    loadBulkContributions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtAmount.Text = "";
            cmbCategory.Text = null;
            txtID.Text = "";
            
        }

        private void dgvBulk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;

                int var = Convert.ToInt32(dgvBulk.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Bulk_Contributions where ID ='" + var + "'", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["ID"].ToString();
                    txtAmount.Text = dr["Amount"].ToString();
                    cmbCategory.Text = dr["Category"].ToString();
                    dtpDate.Text = dr["Date"].ToString();

                    loadBulkContributions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadBulkContributions()
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

            cmd = new SqlCommand("select * from Bulk_Contributions", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            dt = new DataTable();
            sda.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvBulk.DataSource = bs;
            sda.Update(dt);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

            sda = new SqlDataAdapter("select * from Bulk_Contributions where concat(Category,Amount,Date) Like '%" + textBox9.Text + "%'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvBulk.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con;

            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Bulk_Contributions where Date between '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "' and '" + dateTimePicker3.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Bulk_Contributions");
            dgvBulk.DataSource = dt.Tables["Bulk_Contributions"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadBulkContributions();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BulkContributions bs = new BulkContributions();
            bs.Show();
        }
    }
}
