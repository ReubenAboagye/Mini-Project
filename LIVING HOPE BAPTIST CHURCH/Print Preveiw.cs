using System;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Globalization;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Diagnostics;
using DGVPrinterHelper;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class Print_Preveiw : Form
    {
        public Print_Preveiw()
        {
            InitializeComponent();
        }

        private void Print_Preveiw_Load(object sender, EventArgs e)
        {
            using(ChurchProjectEntities db = new ChurchProjectEntities())
            {
                memberBindingSource.DataSource = db.members.ToList();
            }
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
           
            printer.PrintDataGridView(dgvPrint);
        }

        private void dgvPrint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dgvPrint.RowHeadersVisible = false;
            dgvPrint.ColumnHeadersVisible = true;
            dgvPrint.SelectAll();
            DataObject dataObj = dgvPrint.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        
        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
               
               DialogResult dr = MessageBox.Show("You must have Microsoft Excel installed on your PC,"
                   + " Do you want to continue exporting?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(dr == DialogResult.Yes)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
