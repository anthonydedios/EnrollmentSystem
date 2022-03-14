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
    public partial class ESAssessment : Form
    {
        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;

        //------------------------------------------------------------------------
        private string Nm;

        public string PassvalueAs          //taga kuha ng value
        {
            get { return Nm; }
            set { Nm = value; }
        }

        //------------------------------------------------------------------------
        public ESAssessment()
        {
            InitializeComponent();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESMainMenu esmain = new ESMainMenu();
            esmain.Passvalue = valueholderAs.Text;
            esmain.Show();

        }

        private void ESAssessment_Load(object sender, EventArgs e)
        {

            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();
           
            valueholderAs.Text = Nm;
            selection();
            sectionitemcmbx();
            courseitemcmbx();
            assessmentdisable();
        

        }

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



        private void listView1_ItemActivate(object sender, EventArgs e)
        {
  

            string yearlevel = listView1.Items[listView1.SelectedItems[0].Index].SubItems[10].Text;
            string course = listView1.Items[listView1.SelectedItems[0].Index].SubItems[11].Text;
            string section = listView1.Items[listView1.SelectedItems[0].Index].SubItems[9].Text;
            String nya = "NOT YET ASSESSED";


            if (yearlevel.Equals(nya) || course.Equals(nya) || section.Equals(nya))
            {
                studentidtxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
                string lblfname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                string lblmname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                string lbllname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                nametxtb.Text = lblfname + " " + lblmname + " " + lbllname;
            }

            else
            {
                MessageBox.Show("Student is Already Assessed");
            }




        }

        public void assessmentenable()
        {
            listView1.Enabled = true;
            searchbtn.Enabled = true;
            donebtn.Enabled = true;
            searchtxtb.Enabled = true;
            assessemntcoursecmbx.Enabled = true;
            assessmentsectioncmbx.Enabled = true;
            assessmentyearlevelcmbx.Enabled = true;
        }

        public void assessmentdisable()
        {
            listView1.Enabled = false;
            searchbtn.Enabled = false;
            donebtn.Enabled = false;
            searchtxtb.Enabled = false;
            assessemntcoursecmbx.Enabled = false;
            assessmentsectioncmbx.Enabled = false;
            assessmentyearlevelcmbx.Enabled = false;
        }

        public void assessmentClear()
        {
            

            searchtxtb.Clear();
            studentidtxtb.Clear();
            nametxtb.Clear();
            assessemntcoursecmbx.SelectedIndex = -1;
            assessmentsectioncmbx.SelectedIndex = -1;
            assessmentyearlevelcmbx.SelectedIndex = -1;
        }


//------------------------------------------------------------------------------ item for section combobox fromdatabase

        public void sectionitemcmbx()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from sectiontbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
           
            while (sqlreader.Read())
            {
                string sectionname = sqlreader.GetString("sectionname");
                assessmentsectioncmbx.Items.Add(sectionname);
            }
            sqlcon.Close();
        }

        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------item for course combo box from data base

        public void courseitemcmbx()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from coursetbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();

            while (sqlreader.Read())
            {
                string coursename = sqlreader.GetString("coursename");
                assessemntcoursecmbx.Items.Add(coursename);
            }
            sqlcon.Close();
        }





        private void assessbtn_Click_1(object sender, EventArgs e)
        {

            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }
            assessmentenable();
            assessbtn.Visible = false;
            assesssavebtn.Visible = true;
            assesscancelbtn.Visible = true;
            assessclearbtn.Visible = true;
        }

        private void assesssavebtn_Click_1(object sender, EventArgs e)
        {

             sqlcon.Open();
             sqlcom = new MySqlCommand("update studenttbl set studentsection = '" + assessmentsectioncmbx.Text + "',studentyrlevel = '" + assessmentyearlevelcmbx.Text + "',studentcourse = '" + assessemntcoursecmbx.Text + "' where studentid = " + studentidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            selection();
            MessageBox.Show("ITEM UPDATED");

            assessmentdisable();
            assessmentClear();
            assessbtn.Visible = true;
            assesssavebtn.Visible = false;
            assesscancelbtn.Visible = false;
            assessclearbtn.Visible = false;

        }

        private void assesscancelbtn_Click_1(object sender, EventArgs e)
        {

            assessmentdisable();
            assessmentClear();
            assessbtn.Visible = true;
            assesssavebtn.Visible = false;
            assesscancelbtn.Visible = false;
            assessclearbtn.Visible = false;

        }

        private void assessclearbtn_Click_1(object sender, EventArgs e)
        {
            assessmentdisable();
            assessmentClear();
            assessbtn.Visible = true;
            assesssavebtn.Visible = false;
            assesscancelbtn.Visible = false;
            assessclearbtn.Visible = false;
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            searchbtn.Visible = true;
            donebtn.Visible = false;
            selection();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchbtn.Visible = false;
            donebtn.Visible = true;


            if (searchtxtb.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(searchtxtb.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Search Not Found");
                searchbtn.Visible = true;
                donebtn.Visible = false;

            }
        }

        private void assessemntcoursecmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(assessemntcoursecmbx.Text) || string.IsNullOrWhiteSpace(assessmentsectioncmbx.Text) || string.IsNullOrWhiteSpace(assessmentyearlevelcmbx.Text))
            {
                assesssavebtn.Enabled = false;
            }
            
            else
            {

                assesssavebtn.Enabled = true;
            }
        }

        private void assessmentsectioncmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(assessemntcoursecmbx.Text) || string.IsNullOrWhiteSpace(assessmentsectioncmbx.Text) || string.IsNullOrWhiteSpace(assessmentyearlevelcmbx.Text))
            {
                assesssavebtn.Enabled = false;
            }

            else
            {

                assesssavebtn.Enabled = true;
            }
        }

        private void assessmentyearlevelcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(assessemntcoursecmbx.Text) || string.IsNullOrWhiteSpace(assessmentsectioncmbx.Text) || string.IsNullOrWhiteSpace(assessmentyearlevelcmbx.Text))
            {
                assesssavebtn.Enabled = false;
            }

            else
            {

                assesssavebtn.Enabled = true;
            }
        }

       



    }




}
