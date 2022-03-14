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
    public partial class ESFilemaintenance : Form
    {
        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;
        //------------------------------------------------------------------------
        private string Nm;

        public string Passvaluefm          //taga kuha ng value
        {
            get { return Nm; }
            set { Nm = value; }
        }

        //------------------------------------------------------------------------
        public ESFilemaintenance()
        {
            InitializeComponent();
        }

       
        //---------------------------------------------------------------------------------------- student
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


        public void FMStudDisable()
        {
            studentidtxtb.Enabled = false;
            studentfnametxtb.Enabled = false;
            studentmnametxtb.Enabled = false;
            studentlnametxtb.Enabled = false;
            studentagetxtb.Enabled = false;
            studentbdaytxtb.Enabled = false;
            studentgendertxtb.Enabled = false;
            religiontxtb.Enabled = false;
            citizenshiptxtb.Enabled = false;
            studentcontacttxtb.Enabled = false;
            mothernametxtb.Enabled = false;
            mothercontacttxtb.Enabled = false;
            fathernametxtb.Enabled = false;
            fathercontacttxtb.Enabled = false;
            addresstxtb.Enabled = false;
            coursetxtb.Enabled = false;
            paymentstatustxtb.Enabled = false;
            sectiontxtb.Enabled = false;
            yearleveltxtb.Enabled = false;

            listView1.Enabled = false;
            searchbtn.Enabled = false;
            searchtxtb.Enabled = false;
            donebtn.Enabled = false;


        }

        public void FMStudEnable()
        {
            studentidtxtb.Enabled = true;
            studentfnametxtb.Enabled = true;
            studentmnametxtb.Enabled = true;
            studentlnametxtb.Enabled = true;
            studentagetxtb.Enabled = true;
            studentbdaytxtb.Enabled = true;
            studentgendertxtb.Enabled = true;
            religiontxtb.Enabled = true;
            citizenshiptxtb.Enabled = true;
            studentcontacttxtb.Enabled = true;
            mothernametxtb.Enabled = true;
            mothercontacttxtb.Enabled = true;
            fathernametxtb.Enabled = true;
            fathercontacttxtb.Enabled = true;
            addresstxtb.Enabled = true;
            coursetxtb.Enabled = true;
            paymentstatustxtb.Enabled = true;
            sectiontxtb.Enabled = true;
            yearleveltxtb.Enabled = true;

            listView1.Enabled = true;
            searchbtn.Enabled = true;
            searchtxtb.Enabled = true;
            donebtn.Enabled = true;

        }

        public void FMStudClear()
        {
            studentidtxtb.Clear();
            studentfnametxtb.Clear();
            studentmnametxtb.Clear();
            studentlnametxtb.Clear();
            studentagetxtb.Clear();
            studentbdaytxtb.Clear();
            studentgendertxtb.Clear();
            religiontxtb.Clear();
            citizenshiptxtb.Clear();
            studentcontacttxtb.Clear();
            mothernametxtb.Clear();
            mothercontacttxtb.Clear();
            fathernametxtb.Clear();
            fathercontacttxtb.Clear();
            addresstxtb.Clear();
            coursetxtb.Clear();
            paymentstatustxtb.Clear();
            sectiontxtb.Clear();
            yearleveltxtb.Clear();

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
                MessageBox.Show("PLEASE INPUT ID NUMBER");
                searchbtn.Visible = true;
                donebtn.Visible = false;
                searchtxtb.Clear();
                selection();

            }

        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            searchbtn.Visible = true;
            donebtn.Visible = false;
            searchtxtb.Clear();
            selection();
        }





        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            studentidtxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
            studentfnametxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
            studentmnametxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
            studentlnametxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
            studentagetxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
            studentbdaytxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
            religiontxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;
            studentgendertxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[7].Text;
            citizenshiptxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
            sectiontxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[9].Text;
            yearleveltxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[10].Text;
            coursetxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[11].Text;
            mothernametxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[12].Text;
            mothercontacttxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[13].Text;
            fathernametxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[14].Text;
            fathercontacttxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[15].Text;
            studentcontacttxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[16].Text;
            addresstxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[17].Text;
            paymentstatustxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[18].Text;
        }



        private void updatebtn_Click(object sender, EventArgs e)
        {

            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }

            FMStudEnable();
            updatesavebtn.Visible = true;
            updatebtn.Visible = false;
            studentcancelbtn.Visible = true;
            updatesavebtn.Enabled = false;
            deletebtn.Visible = false;



        }


        private void updatesavebtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new MySqlCommand("update studenttbl set studentfname = '" + studentfnametxtb.Text + "', studentmname = '" + studentmnametxtb.Text + "',studentlname = '" + studentlnametxtb.Text + "',studentage = '" + studentagetxtb.Text + "',studentbay = '" + studentbdaytxtb.Text + "',studentreligion = '" + religiontxtb.Text + "',studentgender = '" + studentgendertxtb.Text + "',studentcitizenship = '" + citizenshiptxtb.Text + "',studentsection = '" + sectiontxtb.Text + "',studentyrlevel = '" + yearleveltxtb.Text + "',studentcourse = '" + coursetxtb.Text + "',studentmothername = '" + mothernametxtb.Text + "',studentmothercontact = '" + mothercontacttxtb.Text + "',studentfathername = '" + fathernametxtb.Text + "',studentfathercontact = '" + fathercontacttxtb.Text + "',studentcontactnumber = '" + studentcontacttxtb.Text + "',studentaddress = '" + addresstxtb.Text + "',studentpaymentstatus = '" + paymentstatustxtb.Text + "' where studentid = " + studentidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            selection();
            MessageBox.Show("ITEM UPDATED");
            updatesavebtn.Visible = false;
            updatesavebtn.Enabled = false;
            updatebtn.Visible = true;
            studentcancelbtn.Visible = false;
            deletebtn.Visible = true;
            FMStudClear();
            FMStudDisable();

        }



        private void studentcancelbtn_Click(object sender, EventArgs e)
        {
            FMStudDisable();
            FMStudClear();
            updatebtn.Visible = true;
            updatesavebtn.Visible = false;
            studentcancelbtn.Visible = false;
            deletebtn.Visible = true;
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }

            FMStudEnable();
            studentremovebtn.Visible = true;
            studentremovebtn.Enabled = false;
            deletebtn.Visible = false;
            deletecancelbtn.Visible = true;
            updatebtn.Visible = false;



        }

        private void studentremovebtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new MySqlCommand("delete from studenttbl where studentid = '" + studentidtxtb.Text + "'", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("ITEM DELETED");
            studentremovebtn.Visible = false;
            deletecancelbtn.Visible = false;
            deletebtn.Visible = true;
            updatebtn.Visible = true;
            FMStudDisable();
            FMStudClear();
            selection();
        }

        private void deletecancelbtn_Click(object sender, EventArgs e)
        {
            FMStudDisable();
            FMStudClear();
            studentremovebtn.Visible = false;
            studentremovebtn.Enabled = false;
            deletecancelbtn.Visible = false;
            deletebtn.Visible = true;
            updatebtn.Visible = true;

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            studentremovebtn.Enabled = (listView1.SelectedItems.Count > 0);
            updatesavebtn.Enabled = (listView1.SelectedItems.Count > 0);
        }





        //-----------------------------------------------------------------------------------------END OF STUDENT


//-----------------------------------------------------------------------------------------------------------------   course
        public void courseselection()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from coursetbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            listView2.Items.Clear();

            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(sqlreader.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(1)));
               
                
                listView2.Items.Add(lv);
            }
            sqlcon.Close();
        }


        public void FMCourseDisable()
        {
            courseidtxtb.Enabled = false;
            coursenametxtb.Enabled = false;
            listView2.Enabled = false;


        }

        public void FMCourseEnabled()
        {

            coursenametxtb.Enabled = true;
            listView2.Enabled = true;


        }

        public void FMCourseClear()
        {
            courseidtxtb.Clear();
            coursenametxtb.Clear();



        }


        private void courseaddsavebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("insert into coursetbl values ('" + courseidtxtb.Text + "' ,'" + coursenametxtb.Text + "')", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("ITEM ADDED");
            courseselection();
            courseaddsavebtn.Visible = false;
            courseaddcancelbtn.Visible = false;
            addcoursebtn.Visible = true;
            updatecoursebtn.Visible = true;
            deletescoursebtn.Visible = true;


            FMCourseClear();


        }

        private void courseaddcancelbtn_Click(object sender, EventArgs e)
        {
            FMCourseDisable();
            addcoursebtn.Visible = true;
            updatecoursebtn.Visible = true;
            deletescoursebtn.Visible = true;
            courseaddcancelbtn.Visible = false;
            courseaddsavebtn.Visible = false;

            FMCourseClear();
        }

        private void courseupdatesavebtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new MySqlCommand("update coursetbl set coursename = '" + coursenametxtb.Text + "' where courseid = " + courseidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            courseidtxtb.Clear();
            coursenametxtb.Clear();
            MessageBox.Show("ITEM UPDATED");
            courseselection();

            coursesearchbtn.Visible = false;
            coursesearchdonebtn.Visible = false;
            coursesearchtxtb.Visible = false;
            entercourseidlbl.Visible = false;

            addcoursebtn.Visible = true;
            updatecoursebtn.Visible = true;
            deletescoursebtn.Visible = true;

            courseupdatecancelbtn.Visible = false;
            courseupdatesavebtn.Visible = false;
            FMCourseDisable();
            FMCourseClear();

        }

        private void courseupdatecancelbtn_Click(object sender, EventArgs e)
        {
            FMCourseDisable();
            addcoursebtn.Visible = true;
            updatecoursebtn.Visible = true;
            deletescoursebtn.Visible = true;
            courseupdatecancelbtn.Visible = false;
            courseupdatesavebtn.Visible = false;
            FMCourseClear();

            coursesearchbtn.Visible = false;
            coursesearchdonebtn.Visible = false;
            coursesearchtxtb.Visible = false;
            entercourseidlbl.Visible = false;
        }

        private void addcoursebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("SELECT MAX(courseid)as maxid FROM coursetbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();

            String id = sqlreader.GetString("maxid");
            String x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 4;
            String result = y.ToString().PadLeft(length, '0');



            courseidtxtb.Text = result;
            sqlcon.Close();



            courseaddcancelbtn.Visible = true;
            courseaddsavebtn.Visible = true;
            addcoursebtn.Visible = false;
            updatecoursebtn.Visible = false;
            deletescoursebtn.Visible = false;
            FMCourseEnabled();
        }

        private void updatecoursebtn_Click(object sender, EventArgs e)
        {

            if (this.listView2.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView2.SelectedIndices.Count; i++)
                {
                    this.listView2.Items[this.listView2.SelectedIndices[i]].Selected = false;
                }

            coursesearchbtn.Visible = true;
            coursesearchtxtb.Visible = true;
            entercourseidlbl.Visible = true;


            courseupdatecancelbtn.Visible = true;
            courseupdatesavebtn.Visible = true;

            addcoursebtn.Visible = false;
            updatecoursebtn.Visible = false;
            deletescoursebtn.Visible = false;


            FMCourseEnabled();
        }

        private void deletescoursebtn_Click(object sender, EventArgs e)
        {
            if (this.listView2.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView2.SelectedIndices.Count; i++)
                {
                    this.listView2.Items[this.listView2.SelectedIndices[i]].Selected = false;
                }

            coursesearchbtn.Visible = true;
            coursesearchtxtb.Visible = true;
            entercourseidlbl.Visible = true;

            addcoursebtn.Visible = false;
            updatecoursebtn.Visible = false;
            deletescoursebtn.Visible = false;

            coursedeleteremovebtn.Visible = true;
            coursedeletecancelbtn.Visible = true;

            FMCourseEnabled();

        }

        private void coursedeleteremovebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("delete from coursetbl where courseid = " + courseidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            courseidtxtb.Clear();
            coursenametxtb.Clear();
            MessageBox.Show("ITEM DELETED");
            courseselection();

            coursesearchbtn.Visible = false;
            coursesearchdonebtn.Visible = false;
            coursesearchtxtb.Visible = false;
            entercourseidlbl.Visible = false;

            addcoursebtn.Visible = true;
            updatecoursebtn.Visible = true;
            deletescoursebtn.Visible = true;

            coursedeleteremovebtn.Visible = false;
            coursedeletecancelbtn.Visible = false;

            FMCourseDisable();



        }

        private void coursedeletecancelbtn_Click(object sender, EventArgs e)
        {

            coursesearchbtn.Visible = false;
            coursesearchdonebtn.Visible = false;
            coursesearchtxtb.Visible = false;
            entercourseidlbl.Visible = false;

            addcoursebtn.Visible = true;
            updatecoursebtn.Visible = true;
            deletescoursebtn.Visible = true;

            coursedeleteremovebtn.Visible = false;
            coursedeletecancelbtn.Visible = false;
            FMCourseClear();

            FMCourseDisable();
        }


        private void coursesearchbtn_Click(object sender, EventArgs e)
        {
            coursesearchbtn.Visible = false;
            coursesearchdonebtn.Visible = true;


            if (coursesearchtxtb.Text != "")
            {
                for (int i = listView2.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView2.Items[i];
                    if (item.Text.ToLower().Contains(coursesearchtxtb.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView2.Items.Remove(item);
                    }
                }
                if (listView2.SelectedItems.Count == 1)
                {
                    listView2.Focus();
                }


            }
            else
            {
                MessageBox.Show("PLEASE INPUT ID NUMBER");
                coursesearchbtn.Visible = true;
                coursesearchdonebtn.Visible = false;
                coursesearchtxtb.Clear();
                courseselection();

            }
        }

        private void coursesearchdonebtn_Click(object sender, EventArgs e)
        {
            coursesearchbtn.Visible = true;
            coursesearchdonebtn.Visible = false;
            coursesearchtxtb.Clear();
            courseselection();

        }




        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            courseidtxtb.Text = listView2.Items[listView2.SelectedItems[0].Index].Text;
            coursenametxtb.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[1].Text;


        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            courseupdatesavebtn.Enabled = (listView2.SelectedItems.Count > 0);
            coursedeleteremovebtn.Enabled = (listView2.SelectedItems.Count > 0);

        }
 //----------------------------------------------------------------------------------------- end of course
//--------------------------------------------------------------------------------------------user
        public void userselection()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from usertbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            listView3.Items.Clear();

            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(sqlreader.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(4)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(5)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(6)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(7)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(8)));


                listView3.Items.Add(lv);
            }
            sqlcon.Close();
        }


        public void FMUserDisable()
        {
            listView3.Enabled = false;
            userfirstnametxtb.Enabled = false;
            usermiddlenametxtb.Enabled = false;
            userlastnametxtb.Enabled = false;
            usercontacttxtb.Enabled = false;
            useraddresstxtb.Enabled = false;
            useridtxtb.Enabled = false;

            usernametxtb.Enabled = false;
            generateusername.Enabled = false;
            userpasswordtxtb.Enabled = false;
            userlevelcmbx.Enabled = false;
            usersearchbtn.Enabled = false;
            usersearchtxtb.Enabled = false;
            userdonebtn.Enabled = false;


        }

        public void FMUserEnable()
        {
            listView3.Enabled = true;
            userfirstnametxtb.Enabled = true;
            usermiddlenametxtb.Enabled = true;
            userlastnametxtb.Enabled = true;
            usercontacttxtb.Enabled = true;
            useraddresstxtb.Enabled = true;


            usernametxtb.Enabled = true;
            generateusername.Enabled = true;
            userpasswordtxtb.Enabled = true;
            userlevelcmbx.Enabled = true;
            usersearchbtn.Enabled = true;
            usersearchtxtb.Enabled = true;
            userdonebtn.Enabled = true;


        }


        public void FMUserClear()
        {
            usersearchtxtb.Clear();
            userfirstnametxtb.Clear();
            usermiddlenametxtb.Clear();
            userlastnametxtb.Clear();
            usercontacttxtb.Clear();
            useraddresstxtb.Clear();
            useridtxtb.Clear();
            usernametxtb.Clear();
            userpasswordtxtb.Clear();
            userlevelcmbx.SelectedIndex = -1;

        }


        private void useraddbtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("SELECT MAX(userid)as maxid FROM usertbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();

            String id = sqlreader.GetString("maxid");
            String x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 4;
            String result = y.ToString().PadLeft(length, '0');



            useridtxtb.Text = result;
            sqlcon.Close();

            optionallbl.Visible = true;
            fmuserclearbtn.Visible = true;
            userupdatebtn.Visible = false;
            userdeletebtn.Visible = false;

            generateusername.Visible = true;
            useraddsavebtn.Visible = true;
            useraddcancelbtn.Visible = true;
            FMUserEnable();
            usernametxtb.Enabled = false;
            generateusername.Enabled = false;









        }





        private void userupdatebtn_Click(object sender, EventArgs e)
        {

            if (this.listView3.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView3.SelectedIndices.Count; i++)
                {
                    this.listView3.Items[this.listView3.SelectedIndices[i]].Selected = false;
                }



            useraddbtn.Visible = false;
            userdeletebtn.Visible = false;
            userupdatesavebtn.Visible = true;
            userupdatecancelbtn.Visible = true;

            enteruseridlbl.Visible = true;
            usersearchbtn.Visible = true;
            usersearchtxtb.Visible = true;

            FMUserEnable();



        }

        private void userdeletebtn_Click(object sender, EventArgs e)
        {

            if (this.listView3.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView3.SelectedIndices.Count; i++)
                {
                    this.listView3.Items[this.listView3.SelectedIndices[i]].Selected = false;
                }


            useraddbtn.Visible = false;
            userupdatebtn.Visible = false;
            userdeleteremovebtn.Visible = true;
            userdeletcancelbtn.Visible = true;

            FMUserEnable();

            enteruseridlbl.Visible = true;
            usersearchbtn.Visible = true;
            usersearchtxtb.Visible = true;


        }



        private void listView3_ItemActivate(object sender, EventArgs e)
        {
            useridtxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].Text;
            usernametxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[1].Text;
            userpasswordtxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[2].Text;
            userfirstnametxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[3].Text;
            usermiddlenametxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[4].Text;
            userlastnametxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[5].Text;
            userlevelcmbx.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[6].Text;
            usercontacttxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[7].Text;
            useraddresstxtb.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[8].Text;
        }


        private void useraddsavebtn_Click(object sender, EventArgs e)
        {


            sqlcon.Open();
            sqlcom = new MySqlCommand("insert into usertbl values ('" + useridtxtb.Text + "' ,'" + usernametxtb.Text + "' , '" + userpasswordtxtb.Text + "' , '" + userfirstnametxtb.Text + "', '" + usermiddlenametxtb.Text + "', '" + userlastnametxtb.Text + "', '" + userlevelcmbx.Text + "', '" + usercontacttxtb.Text + "', '" + useraddresstxtb.Text + "')", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            userselection();
            MessageBox.Show(" ITEM ADDED");

            optionallbl.Visible = false;
            userupdatebtn.Visible = true;
            userdeletebtn.Visible = true;
            fmuserclearbtn.Visible = false;

            generateusername.Visible = false;
            useraddsavebtn.Visible = false;
            useraddcancelbtn.Visible = false;

            FMUserDisable();
            FMUserClear();


        }

        private void useraddcancelbtn_Click(object sender, EventArgs e)
        {

            optionallbl.Visible = false;
            userupdatebtn.Visible = true;
            userdeletebtn.Visible = true;
            fmuserclearbtn.Visible = false;

            generateusername.Visible = false;
            useraddsavebtn.Visible = false;
            useraddcancelbtn.Visible = false;


            FMUserDisable();
            FMUserClear();

            enteruseridlbl.Visible = false;
            userdonebtn.Visible = false;
            usersearchbtn.Visible = false;
            usersearchtxtb.Visible = false;
        }







        private void useridtxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text))
            {
                usernametxtb.Enabled = false;
                generateusername.Enabled = false;
            }
            else
            {

                usernametxtb.Enabled = true;
                generateusername.Enabled = true;
            }
        }

        private void generateusername_Click(object sender, EventArgs e)
        {
            string createdusername = userlastnametxtb.Text + useridtxtb.Text;
            usernametxtb.Text = createdusername;
        }

        private void userupdatesavebtn_Click(object sender, EventArgs e)
        {


            sqlcon.Open();
            sqlcom = new MySqlCommand("update usertbl set username = '" + usernametxtb.Text + "', userpass = '" + userpasswordtxtb.Text + "', userfirstname = '" + userfirstnametxtb.Text + "', usermiddlname = '" + usermiddlenametxtb.Text + "', userlastname = '" + userlastnametxtb.Text + "', userlevel = '" + userlevelcmbx.Text + "', usercontactnum = '" + usercontacttxtb.Text + "', useraddress = '" + useraddresstxtb.Text + "' where userid = " + useridtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            userselection();
            MessageBox.Show(" ITEM UPDATED");

            useraddbtn.Visible = true;
            deletebtn.Visible = true;

            userupdatesavebtn.Visible = false;
            userupdatecancelbtn.Visible = false;

            FMUserClear();
            FMUserDisable();

            enteruseridlbl.Visible = false;
            userdonebtn.Visible = false;
            usersearchbtn.Visible = false;
            usersearchtxtb.Visible = false;




        }

        private void userupdatecancelbtn_Click(object sender, EventArgs e)
        {
            useraddbtn.Visible = true;
            userdeletebtn.Visible = true;
            userupdatesavebtn.Visible = false;
            userupdatecancelbtn.Visible = false;

            FMUserClear();
            FMUserDisable();

            enteruseridlbl.Visible = false;
            userdonebtn.Visible = false;
            usersearchbtn.Visible = false;
            usersearchtxtb.Visible = false;
        }

        private void listView3_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            userupdatesavebtn.Enabled = (listView3.SelectedItems.Count > 0);
            userdeleteremovebtn.Enabled = (listView3.SelectedItems.Count > 0);

        }

        private void userdeleteremovebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("delete from usertbl where userid = " + useridtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            userselection();
            MessageBox.Show(" ITEM DELETED ");

            useraddbtn.Visible = true;
            userupdatebtn.Visible = true;

            userdeleteremovebtn.Visible = false;
            userdeletcancelbtn.Visible = false;

            FMUserClear();
            FMUserDisable();

            enteruseridlbl.Visible = false;
            userdonebtn.Visible = false;
            usersearchbtn.Visible = false;
            usersearchtxtb.Visible = false;


           
        }

        private void userdeletcancelbtn_Click(object sender, EventArgs e)
        {
            useraddbtn.Visible = true;
            userupdatebtn.Visible = true;

            userdeleteremovebtn.Visible = false;
            userdeletcancelbtn.Visible = false;

            FMUserClear();
            FMUserDisable();

            enteruseridlbl.Visible = false;
            userdonebtn.Visible = false;
            usersearchbtn.Visible = false;
            usersearchtxtb.Visible = false;
        }



        private void usersearchbtn_Click(object sender, EventArgs e)
        {
            usersearchbtn.Visible = false;
            userdonebtn.Visible = true;


            if (usersearchtxtb.Text != "")
            {
                for (int i = listView3.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView3.Items[i];
                    if (item.Text.ToLower().Contains(usersearchtxtb.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView3.Items.Remove(item);

                    }
                }
                if (listView3.SelectedItems.Count == 1)
                {
                    listView3.Focus();


                }


            }
            else
            {
                MessageBox.Show("PLEASE INPUT ID NUMBER");
                usersearchbtn.Visible = true;
                userdonebtn.Visible = false;
                usersearchtxtb.Clear();
                userselection();



            }
        }

        private void userdonebtn_Click(object sender, EventArgs e)
        {
            usersearchbtn.Visible = true;
            userdonebtn.Visible = false;
            usersearchtxtb.Clear();
            userselection();
        }
        //---------------------------------------------------------------------------------------------end of user

       //--------------------------------------------------------------------------------------------- section
        public void sectionselection()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from sectiontbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            listView4.Items.Clear();

            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(sqlreader.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(1)));
               
                


                listView4.Items.Add(lv);
            }
            sqlcon.Close();
        }


      


       public void FMSectionEnable()
        {
            
            sectionnametxtb.Enabled = true;
            listView4.Enabled = true;
        }

        public void FMSectionDisable()
        {
            sectionidtxtb.Enabled = false;
            sectionnametxtb.Enabled = false;
            listView4.Enabled = false;
        }

        public void FMSectionClear()
        {
            sectionidtxtb.Clear();
            sectionnametxtb.Clear();
        }

        private void listView4_ItemActivate(object sender, EventArgs e)
        {

            sectionidtxtb.Text = listView4.Items[listView4.SelectedItems[0].Index].Text;
            sectionnametxtb.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[1].Text;

        }

        private void sectionaddbtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("SELECT MAX(sectionid)as maxid FROM sectiontbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();

            String id = sqlreader.GetString("maxid");
            String x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 4;
            String result = y.ToString().PadLeft(length, '0');



            sectionidtxtb.Text = result;
            sqlcon.Close();


            sectionaddbtn.Visible = false;
            sectionupdatebtn.Visible = false;
            sectiondeletebtn.Visible = false;

            sectionaddsavebtn.Visible = true;
            sectionaddcancelbtn.Visible = true;

            FMSectionEnable();

        }

        private void sectionaddsavebtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new MySqlCommand("insert into sectiontbl values ('" + sectionidtxtb.Text + "' ,'" + sectionnametxtb.Text + "')", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("ITEM ADDED");
            sectionselection();

            sectionaddbtn.Visible = true;
            sectionupdatebtn.Visible = true;
            sectiondeletebtn.Visible = true;

            sectionaddsavebtn.Visible = false;
            sectionaddcancelbtn.Visible = false;

            FMSectionClear();
            FMSectionDisable();
        }

        private void sectionaddcancelbtn_Click(object sender, EventArgs e)
        {
            sectionaddbtn.Visible = true;
            sectionupdatebtn.Visible = true;
            sectiondeletebtn.Visible = true;

            sectionaddsavebtn.Visible = false;
            sectionaddcancelbtn.Visible = false;

            FMSectionClear();
            FMSectionDisable();
        }

        private void sectionupdatebtn_Click(object sender, EventArgs e)
        {

            if (this.listView4.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView4.SelectedIndices.Count; i++)
                {
                    this.listView4.Items[this.listView4.SelectedIndices[i]].Selected = false;
                }

            sectionsearchbtn.Visible = true;
            sectionsearchtxtb.Visible = true;
            entersectionidlbl.Visible = true;



            sectionupdatebtn.Visible = false;
            sectionaddbtn.Visible = false;
            sectiondeletebtn.Visible = false;

            sectionupdatesavebtn.Visible = true;
            sectionupdatecancelbtn.Visible = true;



            FMSectionEnable();


        }

        private void sectionupdatesavebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("update sectiontbl set sectionname = '" + sectionnametxtb.Text + "' where sectionid = " + sectionidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("ITEM UPDATED");


            sectionsearchbtn.Visible = false;
            sectionsearchtxtb.Visible = false;
            entersectionidlbl.Visible = false;

            sectionaddbtn.Visible = true;
            sectionupdatebtn.Visible = true;
            sectiondeletebtn.Visible = true;

            sectionupdatesavebtn.Visible = false;
            sectionupdatecancelbtn.Visible = false;

            sectionselection();
            FMSectionClear();
            FMSectionDisable();

        }

        private void sectionupdatecancelbtn_Click(object sender, EventArgs e)
        {
            sectionsearchbtn.Visible = false;
            sectionsearchtxtb.Visible = false;
            entersectionidlbl.Visible = false;

            sectionaddbtn.Visible = true;
            sectionupdatebtn.Visible = true;
            sectiondeletebtn.Visible = true;

            sectionupdatesavebtn.Visible = false;
            sectionupdatecancelbtn.Visible = false;

            FMSectionClear();
            FMSectionDisable();
        }

        private void sectiondeletebtn_Click(object sender, EventArgs e)
        {


            if (this.listView4.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView4.SelectedIndices.Count; i++)
                {
                    this.listView4.Items[this.listView4.SelectedIndices[i]].Selected = false;
                }

            sectionsearchbtn.Visible = true;
            sectionsearchtxtb.Visible = true;
            entersectionidlbl.Visible = true;

            sectionaddbtn.Visible = false;
            sectionupdatebtn.Visible = false;
            sectiondeletebtn.Visible = false;

            sectiondeleteremovebtn.Visible = true;
            sectiondeletecancelbtn.Visible = true;

            FMSectionEnable();



        }

        private void sectiondeleteremovebtn_Click(object sender, EventArgs e)
        {


            sqlcon.Open();
            sqlcom = new MySqlCommand("delete from sectiontbl where sectionid = " + sectionidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            sectionselection();
            MessageBox.Show(" ITEM DELETED ");

            sectionsearchbtn.Visible = false;
            sectionsearchtxtb.Visible = false;
            entersectionidlbl.Visible = false;

            sectionaddbtn.Visible = true;
            sectiondeletebtn.Visible = true;
            sectionupdatebtn.Visible = true;

            sectiondeleteremovebtn.Visible = false;
            sectiondeletecancelbtn.Visible = false;

            FMSectionClear();
            FMSectionDisable();





        }

        private void sectiondeletecancelbtn_Click(object sender, EventArgs e)
        {


            sectionsearchbtn.Visible = false;
            sectionsearchtxtb.Visible = false;
            entersectionidlbl.Visible = false;

            sectionaddbtn.Visible = true;
            sectiondeletebtn.Visible = true;
            sectionupdatebtn.Visible = true;

            sectiondeleteremovebtn.Visible = false;
            sectiondeletecancelbtn.Visible = false;

            FMSectionClear();
            FMSectionDisable();

        }



        private void fmuserclearbtn_Click(object sender, EventArgs e)
        {
            FMUserClear();
            optionallbl.Visible = false;
            fmuserclearbtn.Visible = false;
        }

        private void sectionsearchbtn_Click(object sender, EventArgs e)
        {
            sectionsearchbtn.Visible = false;
            sectionsearchdonebtn.Visible = true;


            if (sectionsearchtxtb.Text != "")
            {
                for (int i = listView4.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView4.Items[i];
                    if (item.Text.ToLower().Contains(sectionsearchtxtb.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView4.Items.Remove(item);
                    }
                }
                if (listView4.SelectedItems.Count == 1)
                {
                    listView4.Focus();
                }

            }
            else
            {
                MessageBox.Show("PLEASE INPUT ID NUMBER");
                sectionsearchbtn.Visible = true;
                sectionsearchdonebtn.Visible = false;
                sectionsearchtxtb.Clear();
                sectionselection();

            }
        }

        private void sectionsearchdonebtn_Click(object sender, EventArgs e)
        {
            sectionsearchbtn.Visible = true;
            sectionsearchdonebtn.Visible = false;
            sectionsearchtxtb.Clear();
            sectionselection();

        }

        private void listView4_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            sectionupdatesavebtn.Enabled = (listView4.SelectedItems.Count > 0);
            sectiondeleteremovebtn.Enabled = (listView4.SelectedItems.Count > 0);
        }

       //---------------------------------------------------------------------------------------------------------end of section
        private void mainmenu_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            ESMainMenu esmain = new ESMainMenu();
            esmain.Passvalue = valueholderfm.Text;
            esmain.Show();  
        }

        private void ESFilemaintenance_Load(object sender, EventArgs e)
        {
           
            
          
 
            
            valueholderfm.Text = Nm;
            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();

            selection();
            courseselection();
            userselection();
            FMStudDisable();
            FMCourseDisable();
            FMUserDisable();
            sectionselection();
            FMSectionDisable();


        }




        private void userlastnametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text))
            {
                usernametxtb.Enabled = false;
                generateusername.Enabled = false;
            }
            else
            {

                usernametxtb.Enabled = true;
                generateusername.Enabled = true;
            }
        }

       

        private void userfirstnametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userfirstnametxtb.Text) || string.IsNullOrWhiteSpace(usermiddlenametxtb.Text) || string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useraddresstxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text) || string.IsNullOrWhiteSpace(usernametxtb.Text) || string.IsNullOrWhiteSpace(userpasswordtxtb.Text) || string.IsNullOrWhiteSpace(userlevelcmbx.Text))
            {
                useraddsavebtn.Enabled = false;
            }
            else
            {

                useraddsavebtn.Enabled = true;
            }
        }

        private void usermiddlenametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userfirstnametxtb.Text) || string.IsNullOrWhiteSpace(usermiddlenametxtb.Text) || string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useraddresstxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text) || string.IsNullOrWhiteSpace(usernametxtb.Text) || string.IsNullOrWhiteSpace(userpasswordtxtb.Text) || string.IsNullOrWhiteSpace(userlevelcmbx.Text))
            {
                useraddsavebtn.Enabled = false;
            }
            else
            {

                useraddsavebtn.Enabled = true;
            }
        }

        private void usercontacttxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userfirstnametxtb.Text) || string.IsNullOrWhiteSpace(usermiddlenametxtb.Text) || string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useraddresstxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text) || string.IsNullOrWhiteSpace(usernametxtb.Text) || string.IsNullOrWhiteSpace(userpasswordtxtb.Text) || string.IsNullOrWhiteSpace(userlevelcmbx.Text))
            {
                useraddsavebtn.Enabled = false;
            }
            else
            {

                useraddsavebtn.Enabled = true;
            }
        }

        private void useraddresstxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userfirstnametxtb.Text) || string.IsNullOrWhiteSpace(usermiddlenametxtb.Text) || string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useraddresstxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text) || string.IsNullOrWhiteSpace(usernametxtb.Text) || string.IsNullOrWhiteSpace(userpasswordtxtb.Text) || string.IsNullOrWhiteSpace(userlevelcmbx.Text))
            {
                useraddsavebtn.Enabled = false;
            }
            else
            {

                useraddsavebtn.Enabled = true;
            }
        }

        private void usernametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userfirstnametxtb.Text) || string.IsNullOrWhiteSpace(usermiddlenametxtb.Text) || string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useraddresstxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text) || string.IsNullOrWhiteSpace(usernametxtb.Text) || string.IsNullOrWhiteSpace(userpasswordtxtb.Text) || string.IsNullOrWhiteSpace(userlevelcmbx.Text))
            {
                useraddsavebtn.Enabled = false;
            }
            else
            {

                useraddsavebtn.Enabled = true;
            }
        }

        private void userpasswordtxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userfirstnametxtb.Text) || string.IsNullOrWhiteSpace(usermiddlenametxtb.Text) || string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useraddresstxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text) || string.IsNullOrWhiteSpace(usernametxtb.Text) || string.IsNullOrWhiteSpace(userpasswordtxtb.Text) || string.IsNullOrWhiteSpace(userlevelcmbx.Text))
            {
                useraddsavebtn.Enabled = false;
            }
            else
            {

                useraddsavebtn.Enabled = true;
            }
        }

        private void userlevelcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userfirstnametxtb.Text) || string.IsNullOrWhiteSpace(usermiddlenametxtb.Text) || string.IsNullOrWhiteSpace(userlastnametxtb.Text) || string.IsNullOrWhiteSpace(useraddresstxtb.Text) || string.IsNullOrWhiteSpace(useridtxtb.Text) || string.IsNullOrWhiteSpace(usernametxtb.Text) || string.IsNullOrWhiteSpace(userpasswordtxtb.Text) || string.IsNullOrWhiteSpace(userlevelcmbx.Text))
            {
                useraddsavebtn.Enabled = false;
            }
            else
            {

                useraddsavebtn.Enabled = true;
            }
        }

        private void courseidtxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(courseidtxtb.Text) || string.IsNullOrWhiteSpace(coursenametxtb.Text))
            {
                courseaddsavebtn.Enabled = false;
            }
            else
            {

                courseaddsavebtn.Enabled = true;
            }
        }

        private void coursenametxtb_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(courseidtxtb.Text) || string.IsNullOrWhiteSpace(coursenametxtb.Text))
            {
                courseaddsavebtn.Enabled = false;
            }
            else
            {

                courseaddsavebtn.Enabled = true;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    
    
    }
        }

