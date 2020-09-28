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
    public partial class expensis : UserControl
    {
        public expensis()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static expensis desiguc;

        //funtion to activate department user control

        public static expensis Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new expensis();
                return desiguc;
            }
        }
        public void loadExpenditureRecords()
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

            cmd = new SqlCommand("select * from Expenditure", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            dt = new DataTable();
            sda.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvExpenditure.DataSource = bs;
            sda.Update(dt);

        }
        private void expensis_Load(object sender, EventArgs e)
        {
            loadExpenditureRecords();
        }

        private void dgvExpenditure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;

                int var = Convert.ToInt32(dgvExpenditure.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Expenditure where ID ='" + var + "'", con);
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
                    txtReason.Text = dr["Reason"].ToString();

                    loadExpenditureRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source = localhost; Database = ChurchProject; Integrated Security = True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into Expenditure (Amount, Category, Date, Reason) values (@amt, @cat, @date, @reason)", con);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@reason", txtReason.Text);

                if(txtAmount.Text == "" && cmbCategory.Text == null && txtReason.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records saved succesfully!", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Text = "";
                    txtReason.Text = "";
                    cmbCategory.Text = null;

                }
                loadExpenditureRecords();
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
                SqlConnection con = new SqlConnection("data source = localhost; Database = ChurchProject; Integrated Security = True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Update Expenditure set Amount=@amt, Category=@cat, Date=@date, Reason=@reason where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@reason", txtReason.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);


                if (txtID.Text == "")
                {
                    MessageBox.Show("An ID is required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Updating record rewrites existing record and cannot be undone. Do you want to Update this record?", "Update Status", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record updated succesfully!", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAmount.Text = "";
                        txtReason.Text = "";
                        cmbCategory.Text = null;
                    }else
                    {
                        //nothing
                    }
                }
                loadExpenditureRecords();
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
                SqlConnection con = new SqlConnection("data source = localhost; Database = ChurchProject; Integrated Security = True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Delete from Expenditure where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtID.Text == "")
                {
                    MessageBox.Show("An ID is required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Deleting records cannot be undone. Do you want to delete this record?", "Delete Status", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted succesfully!", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAmount.Text = "";
                        txtReason.Text = "";
                        cmbCategory.Text = null;
                    }
                    else
                    {
                        //nothing
                    }
                }
                loadExpenditureRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtReason.Text = "";
            cmbCategory.Text = null;
            txtID.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

            sda = new SqlDataAdapter("select * from Expenditure where concat(Category,Amount,Reason,Date) Like '%" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvExpenditure.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadExpenditureRecords();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            //SqlDataAdapter sda;
            //DataTable dt;
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

           
            SqlDataAdapter sda = new SqlDataAdapter("select * from Expenditure where  Date between '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Expenditure");
            dgvExpenditure.DataSource = dt.Tables["Expenditure"];
            con.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Expenditure_Print ep = new Expenditure_Print();
            ep.Show();
        }
    }
}
