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
    public partial class ESSettings : Form
    {

        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;

        //------------------------------------------------------------------------
        private string Nm;

        public string Passvalueset          //taga kuha ng value
        {
            get { return Nm; }
            set { Nm = value; }
        }

        //------------------------------------------------------------------------
        public ESSettings()
        {
            InitializeComponent();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESMainMenu esmain = new ESMainMenu();
            esmain.Passvalue = valueholderset.Text;
            esmain.Show();  
        }

        public void enable()
        {
            
            discountnametxtb.Enabled = true;
            discountpercentagetxtb.Enabled = true;
            listView1.Enabled = true;
        }

        public void disable()
        {
            
            discountnametxtb.Enabled = false;
            discountpercentagetxtb.Enabled = false;
            listView1.Enabled = false;
        }


        public void clear()
        {
            discountidtxtb.Clear();
            discountnametxtb.Clear();
            discountpercentagetxtb.Clear();
            
        }
        public void selection()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from discounttbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            listView1.Items.Clear();

            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(sqlreader.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(sqlreader.GetValue(2)));




                listView1.Items.Add(lv);
            }
            sqlcon.Close();
        }

        private void ESSettings_Load(object sender, EventArgs e)
        {
            valueholderset.Text = Nm;
            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();

            tuition();
            disable();
            selection();

            
        }

        public void tuition()
        {
            sqlcon.Open();
            sqlcom = new MySqlCommand("select * from tuitiontbl", sqlcon);
          
            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();

            currenttuitiontxtb.Text = sqlreader.GetString(0);
            sqlcon.Close();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            discountidtxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
            discountnametxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
            discountpercentagetxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
        }

        private void discountaddbtn_Click(object sender, EventArgs e)
        {

            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }

            sqlcon.Open();
            sqlcom = new MySqlCommand("SELECT MAX(discountid)as maxid FROM discounttbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();

            String id = sqlreader.GetString("maxid");
            String x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 4;
            String result = y.ToString().PadLeft(length, '0');



            discountidtxtb.Text = result;
            sqlcon.Close();
            
            enable();
            discountaddbtn.Visible = false;
            discountupdatebtn.Visible = false;
            discountdeletebtn.Visible = false;

            discountaddsavebtn.Visible = true;
            discountaddcancelbtn.Visible = true;
        }

        private void discountaddsavebtn_Click(object sender, EventArgs e)
        {


            sqlcon.Open();
            sqlcom = new MySqlCommand("insert into discounttbl values ('" + discountidtxtb.Text + "' ,'" + discountnametxtb.Text + "' ,'" + discountpercentagetxtb.Text + "')", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("ITEM ADDED");
            selection();
            
            disable();
            clear();
            discountaddbtn.Visible = true;
            discountupdatebtn.Visible = true;
            discountdeletebtn.Visible = true;

            discountaddsavebtn.Visible = false;
            discountaddcancelbtn.Visible = false;
        }

        private void discountupdatebtn_Click(object sender, EventArgs e)
        {

            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }

            enable();
            discountaddbtn.Visible = false;
            discountupdatebtn.Visible = false;
            discountdeletebtn.Visible = false;

            discountupdatesavebtn.Visible = true;
            discountupdatecancelbtn.Visible = true;
        }

        private void discountdeletebtn_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }
            
            enable();
            discountaddbtn.Visible = false;
            discountupdatebtn.Visible = false;
            discountdeletebtn.Visible = false;

            discountdeleteremovebtn.Visible = true;
            discountdeletecancelbtn.Visible = true;
        }

        private void discountaddcancelbtn_Click(object sender, EventArgs e)
        {
            clear();
            disable();
            discountaddbtn.Visible = true;
            discountupdatebtn.Visible = true;
            discountdeletebtn.Visible = true;

            discountaddsavebtn.Visible = false;
            discountaddcancelbtn.Visible = false;
        }

        private void discountupdatesavebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("update discounttbl set discountname = '" + discountnametxtb.Text + "', discountpercentage = '" + discountpercentagetxtb.Text + "' where discountid = " + discountidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("ITEM UPDATED");
            selection();

            clear();
            disable();
            discountaddbtn.Visible = true;
            discountupdatebtn.Visible = true;
            discountdeletebtn.Visible = true;

            discountupdatesavebtn.Visible = false;
            discountupdatecancelbtn.Visible = false;
        }

        private void discountupdatecancelbtn_Click(object sender, EventArgs e)
        {
            clear();
            disable();
            discountaddbtn.Visible = true;
            discountupdatebtn.Visible = true;
            discountdeletebtn.Visible = true;

            discountupdatesavebtn.Visible = false;
            discountupdatecancelbtn.Visible = false;
        }

        private void discountdeleteremovebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("delete from discounttbl where discountid = " + discountidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            selection();
            MessageBox.Show(" ITEM DELETED ");
            clear();
            disable();
            discountaddbtn.Visible = true;
            discountupdatebtn.Visible = true;
            discountdeletebtn.Visible = true;

            discountdeleteremovebtn.Visible = false;
            discountdeletecancelbtn.Visible = false;
        }

        private void discountdeletecancelbtn_Click(object sender, EventArgs e)
        {
            clear(); 
            disable();
            discountaddbtn.Visible = true;
            discountupdatebtn.Visible = true;
            discountdeletebtn.Visible = true;

            discountdeleteremovebtn.Visible = false;
            discountdeletecancelbtn.Visible = false;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            discountupdatesavebtn.Enabled = (listView1.SelectedItems.Count > 0);
            discountdeleteremovebtn.Enabled = (listView1.SelectedItems.Count > 0);
        }

        private void discountnametxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(discountnametxtb.Text) || string.IsNullOrWhiteSpace(discountpercentagetxtb.Text))
            {
                discountaddsavebtn.Enabled = false;
            }
            else
            {

                discountaddsavebtn.Enabled = true;
            }
        }

        private void discountpercentagetxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(discountnametxtb.Text) || string.IsNullOrWhiteSpace(discountpercentagetxtb.Text))
            {
                discountaddsavebtn.Enabled = false;
            }
            else
            {

                discountaddsavebtn.Enabled = true;
            }
        }

        private void tuitionsetbtn_Click(object sender, EventArgs e)
        {
            tuitionsetbtn.Visible = false;
            tuitionsetsavebtn.Visible = true;
            tuitionsetcancel.Visible = true;
            newtutiontxtb.Enabled = true;
            tuition();
            newtutiontxtb.Clear();
        }

        private void tuitionsetsavebtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("update tuitiontbl set tuitionprice = '" + newtutiontxtb.Text + "'", sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("TUITION UPDATED");

            

            tuitionsetbtn.Visible = true;
            tuitionsetsavebtn.Visible = false;
            tuitionsetcancel.Visible = false;
            newtutiontxtb.Enabled = false;
            tuition();
            newtutiontxtb.Clear();
        }

        private void tuitionsetcancel_Click(object sender, EventArgs e)
        {
            tuitionsetbtn.Visible = true;
            tuitionsetsavebtn.Visible = false;
            tuitionsetcancel.Visible = false;
            newtutiontxtb.Enabled = false;
            newtutiontxtb.Clear();
            tuition();
        }

        private void valueholderset_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void discountidtxtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void discountpercentagetxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

       
    }
}
