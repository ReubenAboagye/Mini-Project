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
    public partial class dashboardcontrol : UserControl
    {
        public dashboardcontrol()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static dashboardcontrol desiguc;

        //funtion to activate department user control

        public static dashboardcontrol Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new dashboardcontrol();
                return desiguc;
            }
        }

        private void dashboardcontrol_Load(object sender, EventArgs e)
        {
            loadNoteRecords();
            loadtext();
            SqlConnection Con;

            // setting up connection string
            Con = new SqlConnection("Data Source = Localhost; Initial Catalog = ChurchProject; Integrated Security = True");
            Con.Open();

            ////counting members in the men fellowship
            SqlCommand Cmd = new SqlCommand("select * from members WHERE Auxiliary ='Men Fellowship'; ", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();



            adapter.Fill(dt);

            int i, count = 0;
            if (dt.Rows.Count > 0)
            {
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    count = i;

                }
                lblstudent.Text = " ";
                lblstudent.Text = Convert.ToString(count + 1);
                count = 0;
            }


            //////counting the total members saved in the database

            SqlCommand Cmmd = new SqlCommand("select * from members ;", Con);
            SqlDataAdapter adapterr = new SqlDataAdapter(Cmmd);
            DataTable dat = new DataTable();



            adapterr.Fill(dat);

            int j, ct = 0;
            if (dat.Rows.Count > 0)
            {
                for (j = 0; j < dat.Rows.Count; j++)
                {
                    ct = j;

                }
                label4.Text = "";
                label4.Text = Convert.ToString(ct + 1);
                count = 0;
            }

            /////counting members in the Youth Fellowship
            SqlCommand Cmmmd = new SqlCommand("select * from members WHERE Auxiliary ='Youth Fellowship';", Con);
            SqlDataAdapter adapterrr = new SqlDataAdapter(Cmmmd);
            DataTable daat = new DataTable();



            adapterrr.Fill(daat);

            int o, oo = 0;
            if (daat.Rows.Count > 0)
            {
                for (o = 0; o < daat.Rows.Count; o++)
                {
                    oo = o;

                }
                lblthree.Text = "";
                lblthree.Text = Convert.ToString(oo + 1);
                count = 0;
            }
            ////counting members in the Teen's Fellowship
            SqlCommand Cmmmmd = new SqlCommand("select * from members WHERE Auxiliary ='Teens Fellowship';", Con);
            SqlDataAdapter adapterrrr = new SqlDataAdapter(Cmmmmd);
            DataTable daaat = new DataTable();



            adapterrrr.Fill(daaat);

            int t, tw = 0;
            if (daaat.Rows.Count > 0)
            {
                for (t = 0; t < daaat.Rows.Count; t++)
                {
                    tw = t;

                }
                lbltwo.Text = "";
                lbltwo.Text = Convert.ToString(tw + 1);
                count = 0;
            }

            ///counting members in the children fellowship
            SqlCommand Cmmmmmd = new SqlCommand("select * from members WHERE Auxiliary ='Children Felllowship';", Con);
            SqlDataAdapter qadapterrrrr = new SqlDataAdapter(Cmmmmmd);
            DataTable daaqaat = new DataTable();



            qadapterrrrr.Fill(daaqaat);

            int qth, qthr = 0;
            if (daaqaat.Rows.Count >= 0)
            {
                for (qth = 0; qth < daaqaat.Rows.Count; qth++)
                {
                    qthr = qth;

                }
                lblone.Text = "";
                lblone.Text = Convert.ToString(qthr + 1);
                count = 0;
            }

            //counting members in the Women Fellowship
            SqlCommand Cmmmmmmd = new SqlCommand("select * from members WHERE Auxiliary ='Women Fellowship'; ", Con);
            SqlDataAdapter adapterrrrrr = new SqlDataAdapter(Cmmmmmmd);
            DataTable daaaaat = new DataTable();



            adapterrrrrr.Fill(daaaaat);

            int w, wo = 0;
            if (daaaaat.Rows.Count > 0)
            {
                for (w = 0; w < daaaaat.Rows.Count; w++)
                {
                    wo = w;

                }
                lblworkers.Text = "";
                lblworkers.Text = Convert.ToString(wo + 1);

                count = 0;

               
            }
            loadNoteRecords();
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadNoteRecords()
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



                cmd = new SqlCommand("select * from Note", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                dt = new DataTable();
                sda.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                Notes.DataSource = bs;
                sda.Update(dt);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
            
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            
            if(txtAdd.TextLength > 0)
            {
                btnDone.Visible = true;
            }
           else
            {
                btnDone.Visible = false;
            }
        }
        private void btnNote_Click(object sender, EventArgs e)
        {
            if(txtAdd.Visible == false)
            {
                txtAdd.Visible = true;
                          
            }
            else
            {
                txtAdd.Name = "Add Note";
            }
            if(txtAdd.ReadOnly == true)
            {
                txtAdd.ReadOnly = false;

            }
            if(btnHide.Visible == false)
            {
               
                btnHide.Visible = true;
            }
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

            txtAdd.Text = "";
            if (txtAdd.Visible == true)
            {
                txtAdd.Visible = false;
            }
            if (btnHide.Visible == true)
            {
                btnHide.Visible = false;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = localhost; Database=ChurchProject; Integrated Security =true");
                SqlCommand cmd = new SqlCommand("INSERT INTO Note(Note,Time) VALUES(@note,@time)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@note", txtAdd.Text);
                cmd.Parameters.AddWithValue("@time", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Succesfully", "Make a Note", MessageBoxButtons.OK);
                txtAdd.Text = null;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadNoteRecords();
        }
        public void loadtext()
        {
            if (txtAdd.TextLength > 0)
            { btnDone.Visible = true; }
            else
            {
                btnDone.Visible = false;
            }
        }

        private void Notes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadNoteRecords();
        }
    }
}
