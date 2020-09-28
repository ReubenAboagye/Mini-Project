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
    public partial class TITHE : UserControl
    {
        public TITHE()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static TITHE desiguc;

        //funtion to activate department user control

        public static TITHE Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new TITHE();
                return desiguc;
            }
        }
        SqlConnection con;
        SqlCommand cmd;
        DialogResult dlg;
        private void TITHE_Load(object sender, EventArgs e)
        {
            loadTitheRecords();
        }

        public void loadTitheRecords()
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

            cmd = new SqlCommand("select * from Tithe", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            dt = new DataTable();
            sda.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvTithe.DataSource = bs;
            sda.Update(dt);

        }


        private void dgvTithe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;

                int var = Convert.ToInt32(dgvTithe.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Tithe where ID ='" + var + "'", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["ID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtAmount.Text = dr["Amount"].ToString();
                    dtpDate.Text = dr["Date"].ToString();

                    loadTitheRecords();
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
                con = new SqlConnection("Data Source = Localhost; Initial catalog = ChurchProject; Integrated Security = True");
                con.Open();

                cmd = new SqlCommand("Insert into Tithe(Name,Amount,Date) values (@name,@amt,@date)", con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                if (txtName.Text == "" && txtAmount.Text == "")
                {
                    MessageBox.Show("All Fields are required", "Tithe Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    loadTitheRecords();
                    MessageBox.Show("Records saved succesfully!", "Tithe Records", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                con = new SqlConnection("Data Source = Localhost; Initial catalog = ChurchProject; Integrated Security = True");
                con.Open();

                cmd = new SqlCommand("Update Tithe set Name=@name,Amount=@amt,Date=@date where ID=@id", con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtID.Text == "")
                {
                    MessageBox.Show("All Fields are required", "Tithe Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    loadTitheRecords();
                    MessageBox.Show("Records Updated succesfully!", "Tithe Records", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                con = new SqlConnection("Data Source = Localhost; Initial catalog = ChurchProject; Integrated Security = True");
                con.Open();

                cmd = new SqlCommand("Delete Tithe where ID=@id", con);
                
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if (txtID.Text == "")
                {
                    MessageBox.Show("All Fields are required", "Tithe Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dlg = MessageBox.Show("Deleting Records cannot be undone. Do you really want to delete this record?", "Delete Tithe Records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        loadTitheRecords();
                        MessageBox.Show("Records Updated succesfully!", "Tithe Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAmount.Text = "";
                        txtID.Text = "";
                        txtName.Text = String.Empty;

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();

            sda = new SqlDataAdapter("select * from Tithe where concat(Name,Amount,Date) Like '%" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvTithe.DataSource = dt;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SqlConnection con;

            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Tithe where  Date between '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "Tithe");
            dgvTithe.DataSource = dt.Tables["Tithe"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadTitheRecords();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Tithe_Print tp = new Tithe_Print();
            tp.Show();
        }
    }
}
