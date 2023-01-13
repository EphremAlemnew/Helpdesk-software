using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Helpers : Form
    {
        public string sex = "";
        string imageloc="";
        byte[] images = null;

        public Helpers()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void photo(object sender, EventArgs e)
        {
            OpenFileDialog D = new OpenFileDialog();
            D.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (D.ShowDialog() == DialogResult.OK)
            {
                imageloc = D.FileName.ToString();
                ExpertPhoto.ImageLocation = imageloc;
            }
            FileStream Streem = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
        }

        private void SearchBt(object sender, EventArgs e)
        {
            //For search Button
            con = ob.createconnection();
            string query = "Select * from Expert where Expert_ID='" + SearchE_ID.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader srd = com.ExecuteReader();
           
                while (srd.Read())
                {
                    Expert_ID.Text = srd.GetValue(0).ToString();
                    E_firstname.Text = srd.GetValue(1).ToString();
                    E_lastname.Text = srd.GetValue(2).ToString();
                    sex = srd.GetValue(3).ToString();
                    if (sex == "Male")
                    {
                        Male.Checked = true;
                    }
                    if (sex == "Female") { Female.Checked = true; }
                    E_birthDate.Text = srd.GetValue(4).ToString();
                    E_email.Text = srd.GetValue(5).ToString();
                    E_phoneNo.Text = srd.GetValue(6).ToString();
                    Experts_In.Text = srd.GetValue(7).ToString();
                    E_Edulevel.Text = srd.GetValue(8).ToString();
                    campus.Text = srd.GetValue(9).ToString();
                    E_buldingNo.Text = srd.GetValue(10).ToString();
                    E_RoomNo.Text = srd.GetValue(11).ToString();
                    images = ((byte[])srd.GetValue(13));
                    if (images == null) { ExpertPhoto.Image = null; }
                    else
                    {
                        MemoryStream str = new MemoryStream(images);
                        ExpertPhoto.Image = Image.FromStream(str);
                    }
                
            }
            con.Close();
        }
        // for Clear
        private void clear(object sender, EventArgs e)
        {


            Clear();
                    
                
            
        }

        private void AddNew(object sender, EventArgs e)
        {

            gender();
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if(Expert_ID.Text==""||E_firstname.Text==""||E_lastname.Text==""||sex==""||E_email.Text==""||E_phoneNo.Text==""||Experts_In.Text=="Select"||E_Edulevel.Text=="Select"||campus.Text=="Select"||E_buldingNo.Text==""||E_RoomNo.Text==""||imageloc==""){
                MessageBox.Show("Please Fill all the informations");}
            
            else{
             
            if (Regex.IsMatch(E_email.Text, pattern)) { 
                try
            {
                byte[] images = null;
                FileStream Streem = new FileStream(imageloc,FileMode.Open,FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);

                con = ob.createconnection();
                string query = "insert into Expert values('" + Expert_ID.Text + "','" + E_firstname.Text + "','" + E_lastname.Text + "','" + sex + "','" + E_birthDate.Text + "','" + E_email.Text + "','" + E_phoneNo.Text + "','" + Experts_In.Text + "','" + E_Edulevel.Text + "','" + campus.Text + "','" + E_buldingNo.Text + "','" + E_RoomNo.Text + "','" + AuthenticationNo.Text + "',@images)";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.Add("@images", images);
                com.ExecuteNonQuery();
                MessageBox.Show("Expert is add Successfuly!");
                con.Close();
                Clear();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            } }
            else { error.SetError(this.E_email,"Either Email Address or phone number is invalid");
            
            }}
            
           
        }

        private void Delete(object sender, EventArgs e)
        {
            if (Expert_ID.Text == "") { MessageBox.Show("Please Set the Expert's ID"); }
            else
            {
                try
                {
                    if (MessageBox.Show("Are You sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string query = "Delete Expert Where Expert_ID='" + Expert_ID.Text + "'";
                        ob1.commandonly(query);

                        MessageBox.Show("Expert is Deleted Successfuly!");
                        string query1 = "DELETE FROM [dbo].[SignUp] WHERE Expert_ID='" + Expert_ID.Text + "';";
                        ob1.commandonly(query1);
                        Clear();
                    }
                    
                }
                catch (Exception h) { MessageBox.Show(h.Message); }
            }
        }
        //For update
        private void Update(object sender, EventArgs e)
        {

            try
            {
                
                con = ob.createconnection();
                gender();
                if (Male.Checked) { sex = "Male"; }
                if (Female.Checked) { sex = "Female"; }
                if (images == null)
                {
                    FileStream Streem = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem);
                    images = brs.ReadBytes((int)Streem.Length);
                }
                else
                {
                   
                    string query = "update Expert set First_name='" + E_firstname.Text + "',Last_name='" + E_lastname.Text + "',Gender='" + sex + "',DoB='" + E_birthDate.Text + "',Email_Address='" + E_email.Text + "',Phone_No='" + E_phoneNo.Text + "',Experts_In='" + Experts_In.Text + "',Educational_level='" + E_Edulevel.Text + "',Campus='" + campus.Text + "',Building_No='" + E_buldingNo.Text + "',Room_No='" + E_RoomNo.Text + "',image=@images where Expert_ID='" + Expert_ID.Text + "'";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.Add("@images", images);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Expert is Updated Successfuly!");
                    con.Close();
                }
             
                
            }catch(Exception h){
                con.Close();
                MessageBox.Show(h.Message);
            }
        }
        private void gender() {
            if (Male.Checked) { sex = "Male"; }
            if (Female.Checked) { sex = "Female"; }
        }

        private void E_phoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) {
                e.Handled = true;
                error.SetError(this.E_phoneNo, "Numbers Only");
            }
            else { error.Clear(); }
        }

        private void E_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                error.SetError(this.E_firstname, "Letters Only");
            }
            else { error.Clear(); }
        }

        private void E_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                error.SetError(this.E_lastname, "Letters Only");
            }
            else { error.Clear(); }
        }

        private void AuthenticationNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
               error.SetError(this.AuthenticationNo, "Numbers Only");
            }
            else { error.Clear(); }
        }
        DateTime a = DateTime.Now;
      
        //Clear method
        public void Clear(){

            campus.Text = "Select";
            Experts_In.Text = "Select";
            E_Edulevel.Text = "Select";
            E_buldingNo.Text = "";
            E_email.Text = "";
            Expert_ID.Text = "";
            E_firstname.Text = "";
            E_lastname.Text = "";
            E_phoneNo.Text = "";
            E_RoomNo.Text = "";
            AuthenticationNo.Text = "";
            ExpertPhoto.ImageLocation = "";
            Male.Checked = false;
            Female.Checked = false;
            E_birthDate.Text = a.ToShortDateString();
            ExpertPhoto.Image = null;
        }

        private void Helpers_Load(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "Select * from Categories ";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                Experts_In.Items.Add(srd.GetValue(1).ToString());
            }
            
            con.Close();
            Clear();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Browse.Visible = false;
            Clear_bt.Visible = false;
            Search.Visible = false;
            printExpert.Document = printExpertDoc;
            DialogResult res = MessageBox.Show("Do you want Authentication Number to visible?", "Print", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                printExpertDoc.Print();
                AuthenticationNo.Visible = true;
                authent.Visible = true;
                Browse.Visible = true;
                Clear_bt.Visible = true;
                Search.Visible = true;

            }
            else if (res == DialogResult.No)
            {
                AuthenticationNo.Visible = false;
                authent.Visible = false;
                printExpertDoc.Print();
                Browse.Visible = true;
                Clear_bt.Visible = true;
                Search.Visible = true;
                AuthenticationNo.Visible = true;
                authent.Visible = true;

            }
            else
            {
                Browse.Visible = true;
                Clear_bt.Visible = true;
                Search.Visible = true;
                AuthenticationNo.Visible = true;
                authent.Visible = true;
            }
           
        }

        private void printExpertDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap memoryimg = new Bitmap(printPannel.Width, printPannel.Height);
            printPannel.DrawToBitmap(memoryimg, new Rectangle(0, 0, printPannel.Width, printPannel.Height));
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, pagearea);
        }
  
        }
    }

