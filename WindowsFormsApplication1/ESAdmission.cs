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
    public partial class ESAdmission : Form
    {

        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;
      
        
        //------------------------------------------------------------------------
        private string Nm;

        public string Passvalueadms           //taga kuha ng value
        {
            get { return Nm; }
            set { Nm = value; }
        }

        //------------------------------------------------------------------------


        public ESAdmission()
        {
            InitializeComponent();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESMainMenu esmain = new ESMainMenu();
            esmain.Passvalue = valueholderadms.Text;
            esmain.Show();
        }




        private void ESAdmission_Load(object sender, EventArgs e)
        {


            valueholderadms.Text = Nm;

            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();

            selection();
            Disable();

        }


        //----------------------------------------------------------------------------------------- to display data in listview
        public void selection()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from studenttbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            listView1.Items.Clear();

            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(sqlreader.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(1)));
                lv.SubItems.Add(sqlreader.GetValue(2).ToString());
                lv.SubItems.Add(sqlreader.GetValue(3).ToString());
                lv.SubItems.Add(sqlreader.GetValue(4).ToString());
                lv.SubItems.Add(sqlreader.GetValue(5).ToString());
                lv.SubItems.Add(sqlreader.GetValue(6).ToString());
                lv.SubItems.Add(sqlreader.GetValue(7).ToString());
                lv.SubItems.Add(sqlreader.GetValue(8).ToString());
                lv.SubItems.Add(sqlreader.GetValue(9).ToString());
                lv.SubItems.Add(sqlreader.GetValue(10).ToString());
                lv.SubItems.Add(sqlreader.GetValue(11).ToString());
                lv.SubItems.Add(sqlreader.GetValue(12).ToString());
                lv.SubItems.Add(sqlreader.GetValue(13).ToString());
                lv.SubItems.Add(sqlreader.GetValue(14).ToString());
                lv.SubItems.Add(sqlreader.GetValue(15).ToString());
                lv.SubItems.Add(sqlreader.GetValue(16).ToString());
                lv.SubItems.Add(sqlreader.GetValue(17).ToString());
                lv.SubItems.Add(sqlreader.GetValue(18).ToString());





                listView1.Items.Add(lv);
            }
            sqlcon.Close();
        }

        //-----------------------------------------------------------------------------------------


        //-----------------------------------------  to clear
        public void clear()
    {
  
        studentfnametxtb.Clear();
        studentmnametxtb.Clear();
        studentlnametxtb.Clear();
        studentagetxtb.Clear();
        monthcmbx.SelectedIndex = -1;
        daycmbx.SelectedIndex = -1;
        yearcmbx.SelectedIndex = -1;
        gendercmbx.SelectedIndex = -1;
        religiontxtb.Clear();
        citizenshiptxtb.Clear();
        studentcontacttxtb.Clear();
        mothernametxtb.Clear();
        mothercontacttxtb.Clear();
        fathernametxtb.Clear();
        fathercontacttxtb.Clear();
        addresstxtb.Clear();




    }
    //-----------------------------------------------------------

        
        public void Enable()
        {
            listView1.Enabled = true;
            studentidtxtb.Enabled = true;
            studentfnametxtb.Enabled = true;
            studentmnametxtb.Enabled = true;
            studentlnametxtb.Enabled = true;
            studentagetxtb.Enabled = true;
            monthcmbx.Enabled = true;
            daycmbx.Enabled = true;
            yearcmbx.Enabled = true;
            gendercmbx.Enabled = true;
            religiontxtb.Enabled = true;
            citizenshiptxtb.Enabled = true;
            studentcontacttxtb.Enabled = true;
            mothernametxtb.Enabled = true;
            mothercontacttxtb.Enabled = true;
            fathernametxtb.Enabled = true;
            fathercontacttxtb.Enabled = true;
            addresstxtb.Enabled = true;
        }


        public void Disable()
        {
            listView1.Enabled = false;
            studentidtxtb.Enabled = false;
            studentfnametxtb.Enabled = false;
            studentmnametxtb.Enabled = false;
            studentlnametxtb.Enabled = false;
            studentagetxtb.Enabled = false;
            monthcmbx.Enabled = false;
            daycmbx.Enabled = false;
            yearcmbx.Enabled = false;
            gendercmbx.Enabled = false;
            religiontxtb.Enabled = false;
            citizenshiptxtb.Enabled = false;
            studentcontacttxtb.Enabled = false;
            mothernametxtb.Enabled = false;
            mothercontacttxtb.Enabled = false;
            fathernametxtb.Enabled = false;
            fathercontacttxtb.Enabled = false;
            addresstxtb.Enabled = false;
        }



       

        
            

        private void registerbtn_Click_1(object sender, EventArgs e)
        {
            

            //-----------------------------------------------------------  // to get the maximum ID of student
            sqlcon.Open();
            sqlcom = new MySqlCommand("SELECT MAX(studentid)as maxid FROM studenttbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();

            String id = sqlreader.GetString("maxid");
            String x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 10;
            String result = y.ToString().PadLeft(length, '0');
            studentidtxtb.Text = result;
            //--------------------------------------------------------------

            Enable();
            admissionclearbtn.Visible = true;
            admissionsavebtn.Visible = true;
            admissioncancelbtn.Visible = true;
            studentidtxtb.Enabled = false;
            registerbtn.Visible = false;


            
            sqlcon.Close(); 

        }

        //-----------------------------------------------------------------------------------------  to database
        private void admissionsavebtn_Click_1(object sender, EventArgs e)
        {

            sqlcon.Open();
            String nya = "NOT YET ASSESSED";
            String ps = "NOT YET PAID";
            sqlcom = new MySqlCommand("insert into studenttbl values ('" + studentidtxtb.Text + "' , '" + studentfnametxtb.Text + "','" + studentmnametxtb.Text + "' ,'" + studentlnametxtb.Text + "' ,'" + studentagetxtb.Text + "' ,'" + monthcmbx.Text + " " + daycmbx.Text + "," + yearcmbx.Text + "' ,'" + religiontxtb.Text + "' ,'" + gendercmbx.Text + "' ,'" + citizenshiptxtb.Text + "' ,'" + nya + "' ,'" + nya + "' ,'" + nya + "', '" + mothernametxtb.Text + "' ,'" + mothercontacttxtb.Text + "' ,'" + fathernametxtb.Text + "' , '" + fathercontacttxtb.Text + "' ,'" + studentcontacttxtb.Text + "' ,'" + addresstxtb.Text + "' ,'" + ps + "')", sqlcon);
            sqlcom.ExecuteNonQuery();
            MessageBox.Show("STUDENT ADDED");
            sqlcon.Close();

            selection();
            studentidtxtb.Clear();
            registerbtn.Visible = true;
            admissioncancelbtn.Visible = false;
            admissionclearbtn.Visible = false;
            admissionsavebtn.Visible = false;
            clear();
            Disable();

        }

        //-----------------------------------------------------------------------------------------

        private void admissionclearbtn_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void admissioncancelbtn_Click(object sender, EventArgs e)
        {
            studentidtxtb.Clear();
            registerbtn.Visible = true;
            admissioncancelbtn.Visible = false;
            admissionclearbtn.Visible = false;
            admissionsavebtn.Visible = false;
            clear();
            Disable();
        }



        
        private void studentfnametxtb_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text)|| string.IsNullOrWhiteSpace(mothernametxtb.Text)|| string.IsNullOrWhiteSpace(fathernametxtb.Text)|| string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void studentidtxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void studentmnametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void studentlnametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void studentagetxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void monthcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void daycmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void yearcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void gendercmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void religiontxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void citizenshiptxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void mothernametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void fathernametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

        private void addresstxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentidtxtb.Text) || string.IsNullOrWhiteSpace(studentfnametxtb.Text) || string.IsNullOrWhiteSpace(studentmnametxtb.Text) || string.IsNullOrWhiteSpace(studentlnametxtb.Text) || string.IsNullOrWhiteSpace(studentagetxtb.Text) || string.IsNullOrWhiteSpace(monthcmbx.Text) || string.IsNullOrWhiteSpace(daycmbx.Text) || string.IsNullOrWhiteSpace(yearcmbx.Text) || string.IsNullOrWhiteSpace(gendercmbx.Text) || string.IsNullOrWhiteSpace(religiontxtb.Text) || string.IsNullOrWhiteSpace(citizenshiptxtb.Text) || string.IsNullOrWhiteSpace(mothernametxtb.Text) || string.IsNullOrWhiteSpace(fathernametxtb.Text) || string.IsNullOrWhiteSpace(addresstxtb.Text))
            {
                admissionsavebtn.Enabled = false;
            }
            else
            {

                admissionsavebtn.Enabled = true;
            }
        }

           
       
    
    }



        }

        

      

        
    

