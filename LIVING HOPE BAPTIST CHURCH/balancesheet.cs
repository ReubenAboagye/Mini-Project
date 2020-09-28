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
    public partial class balancesheet : UserControl
    {
        public balancesheet()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static balancesheet desiguc;

        //funtion to activate department user control

        public static balancesheet Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new balancesheet();
                return desiguc;
            }
        }
        public void loadincomeStatement()
        {
            try
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

                cmd = new SqlCommand("SELECT  Category, SUM(Amount) as [Total Amount] from Expenditure WHERE Category IS NOT NULL"
                    + " AND Amount != 0.00 AND Category LIKE '%' GROUP BY Category ORDER BY Category;", con);


                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                dt = new DataTable();
                sda.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                dgvBalanceSheet.DataSource = bs;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void balancesheet_Load(object sender, EventArgs e)
        {

        }
    }
}
