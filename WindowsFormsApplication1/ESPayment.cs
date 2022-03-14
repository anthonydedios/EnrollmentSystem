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
    public partial class ESPayment : Form
    {

        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;
        //------------------------------------------------------------------------
        private string Nm;

        public string Passvaluepay          //taga kuha ng value
        {
            get { return Nm; }
            set { Nm = value; }
        }

        //------------------------------------------------------------------------
        public ESPayment()
        {
            InitializeComponent();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESMainMenu esmain = new ESMainMenu();
            esmain.Passvalue = valueholderpay.Text;
            esmain.Show();
        }


        public void clear()
        {
            studentidtxtb.Clear();
            nametxtb.Clear();
            balancetxtb.Clear();
            discountcmbx.SelectedIndex = -1;
            discountholder.Clear();
            totaltuitionwithdiscounttxtb.Clear();
            balancelbl.Text = "XXXXX";
            amountofdiscountlbl.Text = "XXXXX";
            tuitiontxtb.Clear();
            tuitionlbl.Text = "XXXXX";
            paymentlbl.Text = "XXXXX";
            changetxtb.Clear();
            finaltotaltxtb.Clear();
            paymentstatustxtb.Clear();
            paymenttxtb.Clear();








        }

        public void discountitemcmbx()
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("Select * from discounttbl", sqlcon);
            sqlreader = sqlcom.ExecuteReader();

            while (sqlreader.Read())
            {
                string discountname = sqlreader.GetString("discountname");
                discountcmbx.Items.Add(discountname);
            }
            sqlcon.Close();
        }

        private void ESPayment_Load(object sender, EventArgs e)
        {
            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();
            
            valueholderpay.Text = Nm;
            discountitemcmbx();
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
                MessageBox.Show("PLEASE INPUT ID NUMBER");
                searchbtn.Visible = true;
                donebtn.Visible = false;
                searchtxtb.Clear();
                selection();
               
            }
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
                lv.SubItems.Add(sqlreader.GetValue(1).ToString());
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

        private void donebtn_Click(object sender, EventArgs e)
        {
            searchbtn.Visible = true;
            donebtn.Visible = false;
            searchtxtb.Clear();
            selection();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            string ps = listView1.Items[listView1.SelectedItems[0].Index].SubItems[18].Text;
            string nyp = "NOT YET PAID";
            string rb = "REMAINING BALANCE:";
            string fp = "FULLY PAID";


            if (ps.Contains(nyp))
            {

                studentidtxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
                string lblfname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                string lblmname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                string lbllname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                nametxtb.Text = lblfname + " " + lblmname + " " + lbllname;

                sqlcon.Open();
                sqlcom = new MySqlCommand("select * from tuitiontbl", sqlcon);

                sqlreader = sqlcom.ExecuteReader();
                sqlreader.Read();

                balancetxtb.Text = sqlreader.GetString(0);
                sqlcon.Close();




            }

            else if (ps.Contains(rb))
            {
                studentidtxtb.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
                string lblfname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                string lblmname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                string lbllname = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                nametxtb.Text = lblfname + " " + lblmname + " " + lbllname;

                tuitionlbl.Visible = false;
                remaingbalancelbl.Visible = true;
                discountcmbx.SelectedIndex = -1;
                discountcmbx.Enabled = false;

                int comma = ps.IndexOf(':');
                if (comma != -1)
                {
                    string remainingbalance = ps.Substring(comma + 1);
                    balancetxtb.Text = remainingbalance;

                }
                else
                {
                    
                }
            }

                else if (ps.Contains(fp))
                {

                    MessageBox.Show("STUDENT IS FULLY PAID");
                   
                    if (this.listView1.SelectedIndices.Count > 0)
                        for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                        {
                            this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                        }
                }




            }

        private void computebtn_Click(object sender, EventArgs e)
        {

           

            sqlcon.Open();
            sqlcom = new MySqlCommand("select * from discounttbl where discountname = '" + discountcmbx.Text + "'", sqlcon);


            sqlreader = sqlcom.ExecuteReader();
            sqlreader.Read();


            if (string.IsNullOrWhiteSpace(discountcmbx.Text))
            {
                string intdiscount = "0";
                discountholder.Text = intdiscount;
                sqlcon.Close();
            }
            else
            {
                string discount = sqlreader.GetString("discountpercentage");
                discountholder.Text = discount;
                sqlcon.Close();
            }


            double discounttoint = Double.Parse(discountholder.Text);
            double payment = Double.Parse(paymenttxtb.Text);
            double balance = Double.Parse(balancetxtb.Text);


            double discountpercentage = (discounttoint / 100) * balance;
            string discountpercentagestring = discountpercentage.ToString();
            totaltuitionwithdiscounttxtb.Text = discountpercentagestring;


           

            
            
            double total = balance - discountpercentage;
                 string discountedtuitiontostring = total.ToString();
                 tuitiontxtb.Text = discountedtuitiontostring;
            
            double finaltotal = total - payment;

         
            
            if (finaltotal >= 0)
            {
                string finaltotaltostring = finaltotal.ToString();
                finaltotaltxtb.Text = finaltotaltostring;
            }

            else if (finaltotal < 0)
            {
               string zero = "0";
                finaltotaltxtb.Text = zero;
            }





                 if (finaltotal > 0)
                 {
                     string finaltotalstring = finaltotal.ToString();
                     paymentstatustxtb.Text = "REMAINING BALANCE:" + finaltotalstring;

                     changetxtb.Text = "0";
                 }

                 else if (finaltotal <= 0)
                 {
                    
                     paymentstatustxtb.Text = "FULLY PAID";


                     string finaltotalstring = finaltotal.ToString();
                     int comma = finaltotalstring.IndexOf('-');

                     string x = finaltotalstring.Substring(comma + 1);
                     changetxtb.Text = x;

                    

                 }

                 string a = balancetxtb.Text;
                 string b = totaltuitionwithdiscounttxtb.Text;
                 string c = tuitiontxtb.Text;
                 string d = paymenttxtb.Text;



             balancelbl.Text = a;
               amountofdiscountlbl.Text = b;
               tuitionnnnlbl.Text = c;
               paymentlbl.Text = d; 



        }

        private void paymenttxtb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void paymenttxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paymenttxtb.Text))
            {
                computebtn.Enabled = false;
            }
            else
            {

                computebtn.Enabled = true;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }

            updatebtn.Visible = false;
            updatesavebtn.Visible = true;
            cancelbtn.Visible = true;
        }

        private void updatesavebtn_Click(object sender, EventArgs e)
        {


            sqlcon.Open();
            sqlcom = new MySqlCommand("update studenttbl set studentpaymentstatus = '" + paymentstatustxtb.Text + "' where studentid = " + studentidtxtb.Text + "", sqlcon);
            sqlcom.ExecuteNonQuery();
            MessageBox.Show("ITEM UPDATED");
            sqlcon.Close();
            selection();

            clear();
            
            updatebtn.Visible = true;
            updatesavebtn.Visible = false;
            cancelbtn.Visible = false;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            updatebtn.Visible = true;
            updatesavebtn.Visible = false;
            cancelbtn.Visible = false;
            clear();
        }

     

        private void paymentstatustxtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paymentstatustxtb.Text))
            {
                updatebtn.Enabled = false;
            }
            else
            {

                updatebtn.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cleardiscountcmbxbtn_Click(object sender, EventArgs e)
        {
            discountcmbx.SelectedIndex = -1;
        }

        private void discountcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(discountcmbx.Text))
            {
                cleardiscountcmbxbtn.Enabled = false;
            }
            else
            {

                cleardiscountcmbxbtn.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
    
    
    
    }
    }
