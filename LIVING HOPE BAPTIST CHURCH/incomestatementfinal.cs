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
using DGVPrinterHelper;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class incomestatementfinal : UserControl
    {
        public incomestatementfinal()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static incomestatementfinal desiguc;

        //funtion to activate department user control

        public static incomestatementfinal Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new incomestatementfinal();
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

                cmd = new SqlCommand("WITH tables_cte(Category,Amount) as"
                                    +" (select Category,Amount from Auxiliary"
                                    +" union all SELECT Category,Amount from Bulk_Contributions"
                                    +" union all SELECT Category,Amount from Expenditure)"
                                    +" select Category, sum(Amount)as Amount from tables_cte group by Category order by 1;", con);

                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                dt = new DataTable();
                sda.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                sda.Update(dt);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void incomestatementfinal_Load(object sender, EventArgs e)
        {
            loadincomeStatement();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadincomeStatement();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Living Hope Baptist Church"; //this is the HEADER
            printer.SubTitle = string.Format("Date {0}", DateTime.Now, DateTime.Now.Day);
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

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
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
