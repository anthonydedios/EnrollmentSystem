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
    public partial class ESInquiry : Form
    {

        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;

        //------------------------------------------------------------------------
        private string Nm;

        public string Passvaluequiry         //taga kuha ng value
        {
            get { return Nm; }
            set { Nm = value; }
        }

        //------------------------------------------------------------------------
        public ESInquiry()
        {
            InitializeComponent();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {

            this.Hide();
            ESMainMenu esmain = new ESMainMenu();
            esmain.Passvalue = valueholderquiry.Text;
            esmain.Show();
        }

        private void ESInquiry_Load(object sender, EventArgs e)
        {
            valueholderquiry.Text = Nm;

            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchbtn.Visible = false;
            donebtn.Visible = true;

            


                sqlcon.Open();
                sqlcom = new MySqlCommand("select * from studenttbl where studentid = '" + searchtxtb.Text + "'", sqlcon);


                sqlreader = sqlcom.ExecuteReader();
                 
            int count = 0;
             
            while (sqlreader.Read())
             {
                 count += 1;
             }

             if (count == 1)

            {

                studentidlbl.Text = sqlreader.GetString("studentid");
                string fname = sqlreader.GetString("studentfname");
                string mname = sqlreader.GetString("studentmname");
                string lname = sqlreader.GetString("studentlname");
                namelbl.Text = fname + " " + mname + "." + " " + lname;
                agelbl.Text = sqlreader.GetString("studentage");
                bdaylbl.Text = sqlreader.GetString("studentbay");
                religionlbl.Text = sqlreader.GetString("studentreligion");
                genderlbl.Text = sqlreader.GetString("studentgender");
                citizenshiplbl.Text = sqlreader.GetString("studentcitizenship");
                sectionlbl.Text = sqlreader.GetString("studentsection");
                yearlevellbl.Text = sqlreader.GetString("studentyrlevel");
                courselbl.Text = sqlreader.GetString("studentcourse");
                mothernamelbl.Text = sqlreader.GetString("studentmothername");
                mothercontactlbl.Text = sqlreader.GetString("studentmothercontact");
                fathernamelbl.Text = sqlreader.GetString("studentfathername");
                fathercontactlbl.Text = sqlreader.GetString("studentfathercontact");
                studentcontactlbl.Text = sqlreader.GetString("studentcontactnumber");
                addresslbl.Text = sqlreader.GetString("studentaddress");
                paymentstatuslbl.Text = sqlreader.GetString("studentpaymentstatus");


                sqlcon.Close();

            }

            else

            {
                 MessageBox.Show("Search Not Found");
                 donebtn.Visible = false;
                 searchbtn.Visible = true;
                 sqlcon.Close();

                
            }
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            string none = " ";
            studentidlbl.Text = none;
            namelbl.Text = none;
            agelbl.Text = none;
            bdaylbl.Text = none;
            religionlbl.Text = none;
            genderlbl.Text = none;
            citizenshiplbl.Text = none;
            sectionlbl.Text = none;
            yearlevellbl.Text = none;
            courselbl.Text = none;
            mothernamelbl.Text = none;
            mothercontactlbl.Text = none;
            fathernamelbl.Text = none;
            fathercontactlbl.Text = none;
            studentcontactlbl.Text = none;
            addresslbl.Text = none;
            paymentstatuslbl.Text = none;
            
            donebtn.Visible = false;
            searchbtn.Visible = true;
            searchtxtb.Clear();


        }

        private void searchtxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchtxtb.Text))
            {
                searchbtn.Enabled = false;
                
            }
            else
            {

                searchbtn.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}