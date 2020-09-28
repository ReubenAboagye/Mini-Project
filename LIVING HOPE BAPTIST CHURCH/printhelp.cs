using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class printhelp : Form
    {
        public printhelp()
        {
            InitializeComponent();
        }

        private void printhelp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginRecords._LoginRecords' table. You can move, or remove it, as needed.
            this.loginRecordsTableAdapter.Fill(this.loginRecords._LoginRecords);
            // TODO: This line of code loads data into the 'churchNote.Note' table. You can move, or remove it, as needed.
            this.noteTableAdapter.Fill(this.churchNote.Note);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Gym Management System"; //this is the HEADER
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
