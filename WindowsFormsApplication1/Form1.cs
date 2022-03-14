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
    public partial class ESLogin : Form
    {

        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataReader sqlreader;




        public ESLogin()
        {
            InitializeComponent();

        }





        private void Form1_Load(object sender, EventArgs e)
        {

            sqlcon = new MySqlConnection("Server = localhost; database = dbenrollment; UID = root");
            sqlcon.Open();
            sqlcon.Close();


        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            sqlcom = new MySqlCommand("select * from usertbl where username = '" + usertxtb.Text + "'and userpass = '" + passtxtb.Text + "'", sqlcon);

            sqlreader = sqlcom.ExecuteReader();

            int count = 0;
            while (sqlreader.Read())
            {
                count += 1;
            }

            if (count == 1)
            {


                this.Hide();
                ESMainMenu f2 = new ESMainMenu();
                //------------------------------------------------------------------------
                f2.Passvalue = usertxtb.Text;
                f2.Show();
                //------------------------------------------------------------------------

            }






        }








    }
}
