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
    public partial class AUXILIARY : UserControl
    {
        public AUXILIARY()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static AUXILIARY desiguc;

        //funtion to activate department user control

        public static AUXILIARY Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new AUXILIARY();
                return desiguc;
            }
        }

        SqlConnection con;
        SqlCommand cmd;
        DialogResult drg;

        private void AUXILIARY_Load(object sender, EventArgs e)
        {
            loadAuxiliary();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = Localhost; database = ChurchProject; Integrated Security=true");
                con.Open();
                cmd = new SqlCommand("Insert into Auxiliary (Amount,Category,Date) values (@amt,@cat,@date) ", con);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                if (txtAmount.Text == "" && dtpDate.Text == "" && cmbCategory.Text == "")
                {
                    MessageBox.Show("All Fields are required!", "Auxiliary Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Auxiliary Records saved Succesfully!", "Auxiliary Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Text = String.Empty;
                    dtpDate.Text = null;
                    txtID.Text = string.Empty;
                    cmbCategory.Text = null;

                }
                loadAuxiliary();
            }
            catch (Exception bra)
            {
                MessageBox.Show(bra.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = Localhost; database = ChurchProject; Integrated Security=true");
                con.Open();
                cmd = new SqlCommand("Update Auxiliary set Amount=@amt,Category=@cat,Date=@date where ID = @id ", con);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtAmount.Text == "" && dtpDate.Text == "" && cmbCategory.Text == "")
                {
                    MessageBox.Show("All Fields are required!", "Auxiliary Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Auxiliary Records Updated Succesfully!", "Auxiliary Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Text = String.Empty;
                    dtpDate.Text= null;
                    txtID.Text = string.Empty;
                    cmbCategory.Text = null;

                }
                loadAuxiliary();
            }
            catch (Exception bra)
            {
                MessageBox.Show(bra.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                
               con = new SqlConnection("Data Source = Localhost; database = ChurchProject; Integrated Security=true");
                con.Open();
                cmd = new SqlCommand("Delete Auxiliary where ID =@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);


                if (txtID.Text == string.Empty)
                {
                    MessageBox.Show("All Fields are required!", "Auxiliary Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                 drg = MessageBox.Show("Deleting Records cannot be undone. Do you really want to delete this record?", "Delete Auxiliary Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (drg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Auxiliary Records saved Succesfully!", "Auxiliary Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAmount.Text = String.Empty;
                        dtpDate.Text = String.Empty;
                        txtID.Text = string.Empty;
                        cmbCategory.Text = string.Empty;
                    }
                    else
                    {
                        //do nothing!
                    }
                   

                }
                loadAuxiliary();
            }
            catch (Exception bra)
            {
                MessageBox.Show(bra.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = String.Empty;
            dtpDate.Text = String.Empty;
            txtID.Text = string.Empty;
            cmbCategory.Text = "   ";
        }


        public void loadAuxiliary()
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

            cmd = new SqlCommand("select * from Auxiliary", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            dt = new DataTable();
            sda.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvAuxiliary.DataSource = bs;
            sda.Update(dt);

        }

        private void dgvAuxiliary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;

                int var = Convert.ToInt32(dgvAuxiliary.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Auxiliary where ID ='" + var + "'", con);
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

                    loadAuxiliary();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

            sda = new SqlDataAdapter("select * from auxiliary where concat(Category,Amount,Date) Like '%" + textBox9.Text + "%'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvAuxiliary.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con;

            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from auxiliary where Date between '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "' and '" + dateTimePicker3.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "auxiliary");
            dgvAuxiliary.DataSource = dt.Tables["auxiliary"];
            con.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

            _Print_Auxiliary_ Aux = new _Print_Auxiliary_();
            Aux.Show();

        }
    }
}
