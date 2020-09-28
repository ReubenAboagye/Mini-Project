using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class addmembers : UserControl
    {
        string ImgLoc = "";
      
        public addmembers()
        {
            InitializeComponent();
        }
        // private variable for department user control
        private static addmembers desiguc;

        //funtion to activate department user control

        //creating a global variable for gender and dalification
        string gender = "";

       
       
        public static addmembers Instance
        {
            get
            {
                if (desiguc == null)
                    desiguc = new addmembers();
                return desiguc;
            }
        }
     
        private void addmembers_Load(object sender, EventArgs e)
        {
            loadMemberRecords(); 
        }


        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            ImgLoc = "";
            try
            {



                byte[] img = null;
                if (!string.IsNullOrWhiteSpace(ImgLoc))
                { 
                    FileStream fs = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }
                //if the image is null, do nothing

                //uploading image from file dialog display

                //Declaring sql database variable
                SqlConnection con;
                SqlCommand cmd;


                con = new SqlConnection("Data Source = Localhost; Initial Catalog = ChurchProject; Integrated Security = True");

                con.Open();

                // using commands to get member records when input
                cmd = new SqlCommand("insert into members(FullName,Gender,DateOfBirth,Auxiliary,Location,Address,"
                    + "Telephone,WhatsApp,Email,[Membership Status],"
                    + "[Marital Status],[Baptismal Status],Occupation,[Baptismal Year],[Admission Year],[Prev Church],"
                    + "Prev_Position,MemberPic)"
                    + "values(@name,@sex,@dob,@aux,@loc,@address,@tel,@whatsapp,@email,@memberstat,@marital,@baptismStat,"
                    + "@occup,@baptYear,@admission,@prev,@post,@img)",con);



                // assigning textboxes to database values
                   cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@aux", cmbAuxiliary.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.Parameters["@img"].Value = System.Data.SqlTypes.SqlBinary.Null;
               

                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@loc", txtLocation.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelNumber.Text);
                cmd.Parameters.AddWithValue("@whatsapp", txtWhatsApp.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@memberstat", cmbMembershipstat.Text);
                cmd.Parameters.AddWithValue("@marital", cmbMarital.Text);
                cmd.Parameters.AddWithValue("@baptismStat", cmbBaptism.Text);
                cmd.Parameters.AddWithValue("@occup", txtOccupation.Text);
                cmd.Parameters.AddWithValue("@baptYear", dtpBaptism.Value);
                cmd.Parameters.AddWithValue("@admission", dtpAdmission.Value);
                cmd.Parameters.AddWithValue("@prev", txtPrevChurch.Text);
                cmd.Parameters.AddWithValue("@post", txtPosition.Text);


                //this will either ignore or add image if absent or present respectively

                if (txtName.Text == "" && dtpDOB.Text == "" && dtpDOB.Text == "" && gender == null)
                {
                    MessageBox.Show("All Fields Required!", "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Saved Succesfully!", "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    string Logger = $"[Inserted a new record with name {txtName.Text} at {DateTime.Now}]";

                    cmd = new SqlCommand($"Insert into LoginRecords (Username,[Accessed Time]) values(@username,@time)", con);

                    cmd.Parameters.AddWithValue("@username", Form1.recby);
                    cmd.Parameters.AddWithValue("@time", Logger);
                    cmd.ExecuteNonQuery();
                    
                    //clearing textboxes
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtID.Text = "";
                    txtLocation.Text = "";
                    txtName.Text = "";
                    txtOccupation.Text = "";
                    txtPosition.Text = "";
                    txtPrevChurch.Text = "";
                    txtTelNumber.Text = "";
                    txtWhatsApp.Text = "";
                    cmbAuxiliary.Text = null;
                    cmbBaptism.Text = null;
                    cmbMarital.Text = null;
                    cmbMembershipstat.Text = null;
                    picMember.Image = null;
                    if (rbMale.Checked)
                    {
                        rbMale.Checked = false;
                    }
                    else
                    {
                        rbFemale.Checked = false;

                        
                    }
                }
                loadMemberRecords();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }


        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlDataAdapter sda;
                DataTable dt;
                int var = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //Assigning values to Declared variables
                con = new SqlConnection("Data Source=localhost;Initial Catalog=ChurchProject;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Members where ID ='" + var + "' " , con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["ID"].ToString();
                    txtName.Text = dr["FullName"].ToString();
                    gender = dr["Gender"].ToString();
                    dtpDOB.Text = dr["DateOfBirth"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    cmbAuxiliary.Text = dr["Auxiliary"].ToString();

                    txtLocation.Text = dr["Location"].ToString();
                    txtWhatsApp.Text = dr["WhatsApp"].ToString();
                    cmbMarital.Text = dr["Marital Status"].ToString();
                    byte[] img = (Byte[])(dr["MemberPic"]);
                    if (img == null)
                    {
                        picMember.Image = null; 
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picMember.Image = Image.FromStream(ms);
                    }
                    txtEmail.Text = dr["Email"].ToString();
                    txtTelNumber.Text = dr["Telephone"].ToString();
                    cmbMembershipstat.Text = dr["Membership Status"].ToString();

                    txtOccupation.Text = dr["Occupation"].ToString();
                    cmbBaptism.Text = dr["Baptismal Status"].ToString();
                    dtpBaptism.Text = dr["Baptismal Year"].ToString();

                    dtpAdmission.Text = dr["Admission Year"].ToString();
                    txtPrevChurch.Text = dr["Prev Church"].ToString();
                    txtPosition.Text = dr["Prev_Position"].ToString();

                    loadMemberRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated Security= true");
                con.Open();

                cmd = new SqlCommand("Delete from Members where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                if(txtID.Text == "" )
                {
                    MessageBox.Show("ID is required to a delete record!", "Member Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Deleted Records cannot be recovered. Do you want to continue?", "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Records Deleted Succesfuly!", "Member Status", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        string Logger = $"[successfully deleted a member with name {txtName.Text} and ID : {txtID.Text} at {DateTime.Now}]";

                        cmd = new SqlCommand($"Insert into LoginRecords (Username,[Accessed Time]) values(@username,@time)", con);

                        cmd.Parameters.AddWithValue("@username", Form1.recby);
                        cmd.Parameters.AddWithValue("@time", Logger);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        //do nothing
                    }

                }
                if (rbMale.Checked)
                {
                    rbMale.Checked = false;
                }
                else
                {
                    rbFemale.Checked = false;
                }

                txtAddress.Text = "";
                txtEmail.Text = "";
                txtID.Text = "";
                txtLocation.Text = "";
                txtName.Text = "";
                txtOccupation.Text = "";
                txtPosition.Text = "";
                txtPrevChurch.Text = "";
                txtTelNumber.Text = "";
                txtWhatsApp.Text = "";
                cmbAuxiliary.Text = null;
                cmbBaptism.Text = null;
                cmbMarital.Text = null;
                cmbMembershipstat.Text = null;
                picMember.Image = null;
                loadMemberRecords();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|TIF Files (*.tif)|*.tif";
                dlg.Title = "Select Member Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ImgLoc = dlg.FileName.ToString();
                    picMember.ImageLocation = ImgLoc;
                }else
                {
                    ImgLoc = null;
                    picMember.ImageLocation = ImgLoc;
                }
                loadMemberRecords();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        public void loadMemberRecords()
        {try
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

               

                cmd = new SqlCommand("select * from Members", con);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                dt = new DataTable();
                sda.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                dgvMembers.DataSource = bs;
                sda.Update(dt);
            }
            catch(Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source= localhost; database = ChurchProject; Integrated Security= true");
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadMemberRecords();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtLocation.Text = "";
            txtName.Text = "";
            txtOccupation.Text = "";
            txtPosition.Text = "";
            txtPrevChurch.Text = "";
            txtTelNumber.Text = "";
            txtWhatsApp.Text = "";
            cmbAuxiliary.Text = null;
            cmbBaptism.Text = null;
            cmbMarital.Text = null;
            cmbMembershipstat.Text = null;
            picMember.Image = null;

            loadMemberRecords();

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;

                if (!string.IsNullOrWhiteSpace(ImgLoc))
                {
                    FileStream fs = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }

                // setting up connection string
                con = new SqlConnection("Data Source = Localhost; Initial Catalog = ChurchProject; Integrated Security = True");
                con.Open();

                // using commands to get update member records when input

                string sql = string.Format("update members set FullName=@name,Gender=@sex,DateOfBirth=@dob,Auxiliary=@aux,Location=@loc,Address=@address,Telephone=@tel,"
                + "WhatsApp=@whatsapp,Email=@email,[Membership Status]=@memberstat,[Marital Status]=@marital,[Baptismal Status]=@baptismStat,Occupation=@occup,[Baptismal Year]=@baptYear,"
                + "[Admission Year]=@admission,[Prev Church]=@prev,Prev_Position=@prevpost{0} where ID = @id", string.IsNullOrWhiteSpace(ImgLoc) ? "" : ", MemberPic=@img");

                cmd = new SqlCommand(sql, con);

                // assigning textboxes to database values
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@aux", cmbAuxiliary.Text);
                cmd.Parameters.AddWithValue("@loc", txtLocation.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelNumber.Text);
                cmd.Parameters.AddWithValue("@whatsapp", txtWhatsApp.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@memberstat", cmbMembershipstat.Text);
                cmd.Parameters.AddWithValue("@marital", cmbMarital.Text);
                cmd.Parameters.AddWithValue("@baptismStat", cmbBaptism.Text);
                cmd.Parameters.AddWithValue("@occup", txtOccupation.Text);
                cmd.Parameters.AddWithValue("@baptYear", dtpBaptism.Value);
                cmd.Parameters.AddWithValue("@admission", dtpAdmission.Value);
                cmd.Parameters.AddWithValue("@prev", txtPrevChurch.Text);
                cmd.Parameters.AddWithValue("@prevpost", txtPosition.Text);

                if (!string.IsNullOrWhiteSpace(ImgLoc))
                {
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                }
              
                    if (txtName.Text == "" && txtOccupation.Text == "" && gender == null &&cmbBaptism.Text == "" && cmbMembershipstat.Text == "")
                    {
                    MessageBox.Show("All fields are required !");
                    }
                else { 
                    DialogResult dr = MessageBox.Show("Do you want to Update the Records? This cannot be undone!", "Membership Update Status", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Records Updated Successfully", "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Do nothing!
                    }
                    if (rbMale.Checked)
                    {
                        rbMale.Checked = false;
                    }
                    else
                    {
                        rbFemale.Checked = false;
                    }
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtID.Text = "";
                    txtLocation.Text = "";
                    txtName.Text = "";
                    txtOccupation.Text = "";
                    txtPosition.Text = "";
                    txtPrevChurch.Text = "";
                    txtTelNumber.Text = "";
                    txtWhatsApp.Text = "";
                    cmbAuxiliary.Text = null;
                    cmbBaptism.Text = null;
                    cmbMarital.Text = null;
                    cmbMembershipstat.Text = null;
                    picMember.Image = null;
                    loadMemberRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

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

            sda = new SqlDataAdapter("select * from members where concat(FullName,Auxiliary,Address,Location,Telephone,WhatsApp,[Baptismal Status],[Marital Status]) Like '%" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvMembers.DataSource = dt;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

            Print_Preveiw pp = new Print_Preveiw();
            pp.Show();
        }

        private void picMember_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con;
            
            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from members where DateOfBirth between '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "members");
            dgvMembers.DataSource = dt.Tables["members"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con;

            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from members where [Baptismal Year] between '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "members");
            dgvMembers.DataSource = dt.Tables["members"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con;

            con = new SqlConnection("Data Source = localhost; Database = ChurchProject; Integrated security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from members where [Admission Year] between '" + dtpStartDate.Value.ToString("MM/dd/yyyy") + "' and '" + dtpEndDate.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dt = new DataSet();
            sda.Fill(dt, "members");
            dgvMembers.DataSource = dt.Tables["members"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMemberRecords();
        }
    }
}
