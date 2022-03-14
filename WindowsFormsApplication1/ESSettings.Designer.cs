namespace WindowsFormsApplication1
{
    partial class ESSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainmenu = new System.Windows.Forms.Button();
            this.valueholderset = new System.Windows.Forms.TextBox();
            this.discountpercentagetxtb = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountnametxtb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tuitionsetbtn = new System.Windows.Forms.Button();
            this.currenttuitiontxtb = new System.Windows.Forms.TextBox();
            this.tuitionsetcancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tuitionsetsavebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newtutiontxtb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.discountidtxtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discountdeleteremovebtn = new System.Windows.Forms.Button();
            this.discountdeletecancelbtn = new System.Windows.Forms.Button();
            this.discountupdatesavebtn = new System.Windows.Forms.Button();
            this.discountupdatecancelbtn = new System.Windows.Forms.Button();
            this.discountaddsavebtn = new System.Windows.Forms.Button();
            this.discountaddcancelbtn = new System.Windows.Forms.Button();
            this.discountupdatebtn = new System.Windows.Forms.Button();
            this.discountdeletebtn = new System.Windows.Forms.Button();
            this.discountaddbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.BackColor = System.Drawing.Color.SteelBlue;
            this.mainmenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenu.ForeColor = System.Drawing.Color.White;
            this.mainmenu.Location = new System.Drawing.Point(74, 36);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(122, 23);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "MAIN MENU";
            this.mainmenu.UseVisualStyleBackColor = false;
            this.mainmenu.Click += new System.EventHandler(this.mainmenu_Click);
            // 
            // valueholderset
            // 
            this.valueholderset.Location = new System.Drawing.Point(849, 37);
            this.valueholderset.Name = "valueholderset";
            this.valueholderset.Size = new System.Drawing.Size(100, 20);
            this.valueholderset.TabIndex = 1;
            this.valueholderset.Visible = false;
            this.valueholderset.TextChanged += new System.EventHandler(this.valueholderset_TextChanged);
            // 
            // discountpercentagetxtb
            // 
            this.discountpercentagetxtb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountpercentagetxtb.Location = new System.Drawing.Point(192, 86);
            this.discountpercentagetxtb.Name = "discountpercentagetxtb";
            this.discountpercentagetxtb.Size = new System.Drawing.Size(120, 20);
            this.discountpercentagetxtb.TabIndex = 4;
            this.discountpercentagetxtb.TextChanged += new System.EventHandler(this.discountpercentagetxtb_TextChanged);
            this.discountpercentagetxtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountpercentagetxtb_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(350, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(312, 87);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DISCOUNT ID";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DISCOUNT";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PERCENTAGE";
            this.columnHeader2.Width = 125;
            // 
            // discountnametxtb
            // 
            this.discountnametxtb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountnametxtb.Location = new System.Drawing.Point(192, 51);
            this.discountnametxtb.Name = "discountnametxtb";
            this.discountnametxtb.Size = new System.Drawing.Size(120, 20);
            this.discountnametxtb.TabIndex = 5;
            this.discountnametxtb.TextChanged += new System.EventHandler(this.discountnametxtb_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tuitionsetbtn);
            this.groupBox2.Controls.Add(this.currenttuitiontxtb);
            this.groupBox2.Controls.Add(this.tuitionsetcancel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tuitionsetsavebtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.newtutiontxtb);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(155, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 148);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TUITION FORM";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tuitionsetbtn
            // 
            this.tuitionsetbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.tuitionsetbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionsetbtn.ForeColor = System.Drawing.Color.White;
            this.tuitionsetbtn.Location = new System.Drawing.Point(299, 87);
            this.tuitionsetbtn.Name = "tuitionsetbtn";
            this.tuitionsetbtn.Size = new System.Drawing.Size(75, 23);
            this.tuitionsetbtn.TabIndex = 30;
            this.tuitionsetbtn.Text = "SET";
            this.tuitionsetbtn.UseVisualStyleBackColor = false;
            this.tuitionsetbtn.Click += new System.EventHandler(this.tuitionsetbtn_Click);
            // 
            // currenttuitiontxtb
            // 
            this.currenttuitiontxtb.Enabled = false;
            this.currenttuitiontxtb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currenttuitiontxtb.Location = new System.Drawing.Point(350, 29);
            this.currenttuitiontxtb.Name = "currenttuitiontxtb";
            this.currenttuitiontxtb.Size = new System.Drawing.Size(100, 20);
            this.currenttuitiontxtb.TabIndex = 11;
            // 
            // tuitionsetcancel
            // 
            this.tuitionsetcancel.BackColor = System.Drawing.Color.SteelBlue;
            this.tuitionsetcancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionsetcancel.ForeColor = System.Drawing.Color.White;
            this.tuitionsetcancel.Location = new System.Drawing.Point(299, 116);
            this.tuitionsetcancel.Name = "tuitionsetcancel";
            this.tuitionsetcancel.Size = new System.Drawing.Size(75, 23);
            this.tuitionsetcancel.TabIndex = 29;
            this.tuitionsetcancel.Text = "CANCEL";
            this.tuitionsetcancel.UseVisualStyleBackColor = false;
            this.tuitionsetcancel.Visible = false;
            this.tuitionsetcancel.Click += new System.EventHandler(this.tuitionsetcancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "CURRENT TUITION:";
            // 
            // tuitionsetsavebtn
            // 
            this.tuitionsetsavebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.tuitionsetsavebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionsetsavebtn.ForeColor = System.Drawing.Color.White;
            this.tuitionsetsavebtn.Location = new System.Drawing.Point(299, 87);
            this.tuitionsetsavebtn.Name = "tuitionsetsavebtn";
            this.tuitionsetsavebtn.Size = new System.Drawing.Size(75, 23);
            this.tuitionsetsavebtn.TabIndex = 28;
            this.tuitionsetsavebtn.Text = "SAVE";
            this.tuitionsetsavebtn.UseVisualStyleBackColor = false;
            this.tuitionsetsavebtn.Visible = false;
            this.tuitionsetsavebtn.Click += new System.EventHandler(this.tuitionsetsavebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "SET NEW TUITION:";
            // 
            // newtutiontxtb
            // 
            this.newtutiontxtb.Enabled = false;
            this.newtutiontxtb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtutiontxtb.Location = new System.Drawing.Point(350, 61);
            this.newtutiontxtb.Name = "newtutiontxtb";
            this.newtutiontxtb.Size = new System.Drawing.Size(100, 20);
            this.newtutiontxtb.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.discountidtxtb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.discountdeleteremovebtn);
            this.groupBox3.Controls.Add(this.discountdeletecancelbtn);
            this.groupBox3.Controls.Add(this.discountupdatesavebtn);
            this.groupBox3.Controls.Add(this.discountupdatecancelbtn);
            this.groupBox3.Controls.Add(this.discountaddsavebtn);
            this.groupBox3.Controls.Add(this.discountaddcancelbtn);
            this.groupBox3.Controls.Add(this.discountupdatebtn);
            this.groupBox3.Controls.Add(this.discountdeletebtn);
            this.groupBox3.Controls.Add(this.discountaddbtn);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.discountpercentagetxtb);
            this.groupBox3.Controls.Add(this.discountnametxtb);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(155, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 192);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DISCOUNT FORM";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // discountidtxtb
            // 
            this.discountidtxtb.Enabled = false;
            this.discountidtxtb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountidtxtb.Location = new System.Drawing.Point(192, 19);
            this.discountidtxtb.Name = "discountidtxtb";
            this.discountidtxtb.Size = new System.Drawing.Size(120, 20);
            this.discountidtxtb.TabIndex = 27;
            this.discountidtxtb.TextChanged += new System.EventHandler(this.discountidtxtb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "DISCOUNT ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // discountdeleteremovebtn
            // 
            this.discountdeleteremovebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountdeleteremovebtn.Enabled = false;
            this.discountdeleteremovebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountdeleteremovebtn.ForeColor = System.Drawing.Color.White;
            this.discountdeleteremovebtn.Location = new System.Drawing.Point(434, 131);
            this.discountdeleteremovebtn.Name = "discountdeleteremovebtn";
            this.discountdeleteremovebtn.Size = new System.Drawing.Size(75, 23);
            this.discountdeleteremovebtn.TabIndex = 25;
            this.discountdeleteremovebtn.Text = "REMOVE";
            this.discountdeleteremovebtn.UseVisualStyleBackColor = false;
            this.discountdeleteremovebtn.Visible = false;
            this.discountdeleteremovebtn.Click += new System.EventHandler(this.discountdeleteremovebtn_Click);
            // 
            // discountdeletecancelbtn
            // 
            this.discountdeletecancelbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountdeletecancelbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountdeletecancelbtn.ForeColor = System.Drawing.Color.White;
            this.discountdeletecancelbtn.Location = new System.Drawing.Point(434, 160);
            this.discountdeletecancelbtn.Name = "discountdeletecancelbtn";
            this.discountdeletecancelbtn.Size = new System.Drawing.Size(75, 23);
            this.discountdeletecancelbtn.TabIndex = 24;
            this.discountdeletecancelbtn.Text = "CANCEL";
            this.discountdeletecancelbtn.UseVisualStyleBackColor = false;
            this.discountdeletecancelbtn.Visible = false;
            this.discountdeletecancelbtn.Click += new System.EventHandler(this.discountdeletecancelbtn_Click);
            // 
            // discountupdatesavebtn
            // 
            this.discountupdatesavebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountupdatesavebtn.Enabled = false;
            this.discountupdatesavebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountupdatesavebtn.ForeColor = System.Drawing.Color.White;
            this.discountupdatesavebtn.Location = new System.Drawing.Point(299, 131);
            this.discountupdatesavebtn.Name = "discountupdatesavebtn";
            this.discountupdatesavebtn.Size = new System.Drawing.Size(75, 23);
            this.discountupdatesavebtn.TabIndex = 23;
            this.discountupdatesavebtn.Text = "SAVE";
            this.discountupdatesavebtn.UseVisualStyleBackColor = false;
            this.discountupdatesavebtn.Visible = false;
            this.discountupdatesavebtn.Click += new System.EventHandler(this.discountupdatesavebtn_Click);
            // 
            // discountupdatecancelbtn
            // 
            this.discountupdatecancelbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountupdatecancelbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountupdatecancelbtn.ForeColor = System.Drawing.Color.White;
            this.discountupdatecancelbtn.Location = new System.Drawing.Point(299, 160);
            this.discountupdatecancelbtn.Name = "discountupdatecancelbtn";
            this.discountupdatecancelbtn.Size = new System.Drawing.Size(75, 23);
            this.discountupdatecancelbtn.TabIndex = 22;
            this.discountupdatecancelbtn.Text = "CANCEL";
            this.discountupdatecancelbtn.UseVisualStyleBackColor = false;
            this.discountupdatecancelbtn.Visible = false;
            this.discountupdatecancelbtn.Click += new System.EventHandler(this.discountupdatecancelbtn_Click);
            // 
            // discountaddsavebtn
            // 
            this.discountaddsavebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountaddsavebtn.Enabled = false;
            this.discountaddsavebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountaddsavebtn.ForeColor = System.Drawing.Color.White;
            this.discountaddsavebtn.Location = new System.Drawing.Point(172, 131);
            this.discountaddsavebtn.Name = "discountaddsavebtn";
            this.discountaddsavebtn.Size = new System.Drawing.Size(75, 23);
            this.discountaddsavebtn.TabIndex = 21;
            this.discountaddsavebtn.Text = "SAVE";
            this.discountaddsavebtn.UseVisualStyleBackColor = false;
            this.discountaddsavebtn.Visible = false;
            this.discountaddsavebtn.Click += new System.EventHandler(this.discountaddsavebtn_Click);
            // 
            // discountaddcancelbtn
            // 
            this.discountaddcancelbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountaddcancelbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountaddcancelbtn.ForeColor = System.Drawing.Color.White;
            this.discountaddcancelbtn.Location = new System.Drawing.Point(172, 160);
            this.discountaddcancelbtn.Name = "discountaddcancelbtn";
            this.discountaddcancelbtn.Size = new System.Drawing.Size(75, 23);
            this.discountaddcancelbtn.TabIndex = 20;
            this.discountaddcancelbtn.Text = "CANCEL";
            this.discountaddcancelbtn.UseVisualStyleBackColor = false;
            this.discountaddcancelbtn.Visible = false;
            this.discountaddcancelbtn.Click += new System.EventHandler(this.discountaddcancelbtn_Click);
            // 
            // discountupdatebtn
            // 
            this.discountupdatebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountupdatebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountupdatebtn.ForeColor = System.Drawing.Color.White;
            this.discountupdatebtn.Location = new System.Drawing.Point(299, 131);
            this.discountupdatebtn.Name = "discountupdatebtn";
            this.discountupdatebtn.Size = new System.Drawing.Size(75, 23);
            this.discountupdatebtn.TabIndex = 19;
            this.discountupdatebtn.Text = "UPDATE";
            this.discountupdatebtn.UseVisualStyleBackColor = false;
            this.discountupdatebtn.Click += new System.EventHandler(this.discountupdatebtn_Click);
            // 
            // discountdeletebtn
            // 
            this.discountdeletebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountdeletebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountdeletebtn.ForeColor = System.Drawing.Color.White;
            this.discountdeletebtn.Location = new System.Drawing.Point(434, 131);
            this.discountdeletebtn.Name = "discountdeletebtn";
            this.discountdeletebtn.Size = new System.Drawing.Size(75, 23);
            this.discountdeletebtn.TabIndex = 18;
            this.discountdeletebtn.Text = "DELETE";
            this.discountdeletebtn.UseVisualStyleBackColor = false;
            this.discountdeletebtn.Click += new System.EventHandler(this.discountdeletebtn_Click);
            // 
            // discountaddbtn
            // 
            this.discountaddbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.discountaddbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountaddbtn.ForeColor = System.Drawing.Color.White;
            this.discountaddbtn.Location = new System.Drawing.Point(172, 131);
            this.discountaddbtn.Name = "discountaddbtn";
            this.discountaddbtn.Size = new System.Drawing.Size(75, 23);
            this.discountaddbtn.TabIndex = 17;
            this.discountaddbtn.Text = "ADD";
            this.discountaddbtn.UseVisualStyleBackColor = false;
            this.discountaddbtn.Click += new System.EventHandler(this.discountaddbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "DISCOUNT PERCENTAGE:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "DISCOUNT NAME:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ESSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.settingbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.valueholderset);
            this.Controls.Add(this.mainmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ESSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SETTINGS";
            this.Load += new System.EventHandler(this.ESSettings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainmenu;
        private System.Windows.Forms.TextBox valueholderset;
        private System.Windows.Forms.TextBox discountpercentagetxtb;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox discountnametxtb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button discountdeleteremovebtn;
        private System.Windows.Forms.Button discountdeletecancelbtn;
        private System.Windows.Forms.Button discountupdatesavebtn;
        private System.Windows.Forms.Button discountupdatecancelbtn;
        private System.Windows.Forms.Button discountaddsavebtn;
        private System.Windows.Forms.Button discountaddcancelbtn;
        private System.Windows.Forms.Button discountupdatebtn;
        private System.Windows.Forms.Button discountdeletebtn;
        private System.Windows.Forms.Button discountaddbtn;
        private System.Windows.Forms.TextBox discountidtxtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button tuitionsetbtn;
        private System.Windows.Forms.TextBox currenttuitiontxtb;
        private System.Windows.Forms.Button tuitionsetcancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tuitionsetsavebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newtutiontxtb;
    }
}