using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class ESMainMenu : Form
    {
        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;

        
        //------------------------------------------------------------------------
        private string Nm;
        
        public string Passvalue           //taga kuha ng value
        {
            get { return Nm;  }
            set { Nm = value; }
        }

        //------------------------------------------------------------------------
         
        public ESMainMenu()
        {
            InitializeComponent();     
        }

        //------------------------------------------------------------------------- method for levels
        private void admindisable()
        {
            
        }

        private void registrardisable()
        {

            filemaintenancebtn.Enabled = false;
            paymentbtn.Enabled = false;
            settingsbtn.Enabled = false;

           
        }

        private void cashierdisable()
        {
            addmissionbtn.Enabled = false;
            filemaintenancebtn.Enabled = false;
            assessmentbtn.Enabled = false;
            settingsbtn.Enabled = false;

        }

        //------------------------------------------------------------------------- end method for levels
        private void addmissionbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESAdmission esadd = new ESAdmission();
            valueholder.Text = Nm;
            esadd.Passvalueadms = valueholder.Text;
            esadd.Show();  
        }

        private void filemaintenancebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESFilemaintenance esFilem = new ESFilemaintenance();
            valueholder.Text = Nm;
            esFilem.Passvaluefm = valueholder.Text;
            esFilem.Show();  
        }

        

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESPayment esPay = new ESPayment();
            valueholder.Text = Nm;
            esPay.Passvaluepay = valueholder.Text;
            esPay.Show();  
              
        }

        private void monitoringbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESInquiry esQuiry = new ESInquiry();
            valueholder.Text = Nm;
            esQuiry.Passvaluequiry = valueholder.Text;  
            esQuiry.Show();  
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESSettings esSet = new ESSettings();
            valueholder.Text = Nm;
            esSet.Passvalueset = valueholder.Text;  
            esSet.Show();  
        }

        private void assessmentbtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            ESAssessment esas = new ESAssessment();
            valueholder.Text = Nm;
            esas.PassvalueAs = valueholder.Text;
            esas.Show();  

        }

       

        private void ESMainMenu_Load(object sender, EventArgs e)
        {
            //---------------------------------------------------------------------------------------------  for menu text
            
            
            valueholder.Text = Nm;

            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();

            sqlcon.Open();
            sqlcom = new MySqlCommand("select * from usertbl where username = '"+valueholder.Text+"'" ,sqlcon);


            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();

            lblfname.Text = sqlreader.GetString("userfirstname");
            lblmname.Text = sqlreader.GetString("usermiddlname");
            lbllname.Text = sqlreader.GetString("userlastname");
             lbluserlevel.Text = sqlreader.GetString("userlevel");
             lblusercontact.Text = sqlreader.GetString("usercontactnum");
             lbladdress.Text = sqlreader.GetString("useraddress");
            //----------------------------------------------------------------------condition for user lvl
             string usrlvl;
             usrlvl = sqlreader.GetString("userlevel");
             string admin = "Admin";
             string cashier = "Cashier";
             string registrar = "Registrar";

             if (usrlvl.Equals(admin))
             {
             
                 admindisable();
    
             }

             else if (usrlvl.Equals(cashier))
             {
                 cashierdisable();
             }

             else if (usrlvl.Equals(registrar))
             {
                 registrardisable();
             }

            sqlcon.Close();

            //----------------------------------------------------------------------end condition for user lvl
            
             
           


              


        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            ESLogin eslog = new ESLogin();
            eslog.Show();
        }

        private void lblfname_Click(object sender, EventArgs e)
        {

        }

        private void lblmname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbllname_Click(object sender, EventArgs e)
        {

        }

        
        



        

       
    }
}
