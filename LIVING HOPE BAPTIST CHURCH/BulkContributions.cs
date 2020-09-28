using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class BulkContributions : Form
    {
        public BulkContributions()
        {
            InitializeComponent();
        }

        private void BulkContributions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bulkContribution.Bulk_Contributions' table. You can move, or remove it, as needed.
            this.bulk_ContributionsTableAdapter.Fill(this.bulkContribution.Bulk_Contributions);

        }

        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            balancesheet.RowHeadersVisible = false;
            balancesheet.ColumnHeadersVisible = true;
            balancesheet.SelectAll();
            DataObject dataObj = balancesheet.GetClipboardContent();
            if (dataObj != null)
            Clipboard.SetDataObject(dataObj);
            
        }

        private void btnPdf_Click(object sender, EventArgs e)
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

            printer.PrintDataGridView(balancesheet);
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
