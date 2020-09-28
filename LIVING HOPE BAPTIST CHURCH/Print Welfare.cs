using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class Print_Welfare : Form
    {
        public Print_Welfare()
        {
            InitializeComponent();
        }

        public void loadWelfare()
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



                cmd = new SqlCommand("select * from Funeral where Category = 'Welfare';", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                dt = new DataTable();
                sda.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                sda.Update(dt);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }
        public void loadFuneral()
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



                cmd = new SqlCommand("select * from Funeral where Category = 'Funeral' ;", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                dt = new DataTable();
                sda.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                sda.Update(dt);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }
        public void LoadAll()
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



                cmd = new SqlCommand("select * from Funeral", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                dt = new DataTable();
                sda.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                sda.Update(dt);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }
        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // declaring database variable for data grid view
            SqlConnection con;
         
            SqlDataAdapter sda;
            DataTable dt;
            BindingSource bs;
            con = new SqlConnection("Data Source= localhost; Database= ChurchProject; Integrated Security= true;");
            con.Open();
            sda = new SqlDataAdapter("select * from Funeral where Category= '" +cmbMode.Text + "';", con);
            dt = new DataTable();
            bs = new BindingSource();
            bs.DataSource = dt;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Print_Welfare_Load(object sender, EventArgs e)
        {
             if (cmbMode.Text == "Welfare")
            {
                loadWelfare();
            }
            if (cmbMode.Text == "Funeral")
            {
                loadFuneral();
            }
            else
            {
                //show all datagrid

            }
            loadFuneral();
            loadWelfare();

            
                LoadAll();

                //show all datagrid

            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Living Hope Baptist Church"; //this is the HEADER
            printer.SubTitle = string.Format("Date {0}", DateTime.Now, DateTime.Now.Day);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Living Hope Baptist";

            printer.PrintDataGridView(dataGridView1);
        }

        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("You must have Microsoft Excel installed on your PC,"
                    + " Do you want to continue exporting?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    copyAlltoClipboard();
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Microsoft.Office.Interop.Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                }
                else
                {
                    //do nothing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
