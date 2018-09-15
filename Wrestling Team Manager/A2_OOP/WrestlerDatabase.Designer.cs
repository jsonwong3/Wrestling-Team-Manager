namespace A2_OOP
{
    partial class Form1
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txb_searchlastname = new System.Windows.Forms.TextBox();
            this.ddb_sortoption = new System.Windows.Forms.ComboBox();
            this.ddb_sortmember = new System.Windows.Forms.ComboBox();
            this.lbl_sorttxt1 = new System.Windows.Forms.Label();
            this.lbx_sortedlist = new System.Windows.Forms.ListBox();
            this.ddb_addmember = new System.Windows.Forms.ComboBox();
            this.lbl_searchtxt2 = new System.Windows.Forms.Label();
            this.txb_searchfirstname = new System.Windows.Forms.TextBox();
            this.lbl_searchtxt1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txb_addfirstname = new System.Windows.Forms.TextBox();
            this.txb_addlastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txb_addyearofexp = new System.Windows.Forms.TextBox();
            this.lbl_yearofexp = new System.Windows.Forms.Label();
            this.txb_addwin = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txb_addlose = new System.Windows.Forms.TextBox();
            this.lbl_addtxt = new System.Windows.Forms.Label();
            this.ddb_addgender = new System.Windows.Forms.ComboBox();
            this.ddb_addstatus = new System.Windows.Forms.ComboBox();
            this.ddb_adduniform = new System.Windows.Forms.ComboBox();
            this.lbl_uniform = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.lbl_lose = new System.Windows.Forms.Label();
            this.lbl_pinwin = new System.Windows.Forms.Label();
            this.lbl_totalpoint = new System.Windows.Forms.Label();
            this.txb_addpinwin = new System.Windows.Forms.TextBox();
            this.txb_addtotalpoint = new System.Windows.Forms.TextBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txb_addweight = new System.Windows.Forms.TextBox();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.ddb_searchmember = new System.Windows.Forms.ComboBox();
            this.ddb_teamstat = new System.Windows.Forms.ComboBox();
            this.ddb_teamgender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_addbirthday = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_school = new System.Windows.Forms.Label();
            this.txb_addschool = new System.Windows.Forms.TextBox();
            this.ddb_addtype = new System.Windows.Forms.ComboBox();
            this.lbx_teamstat = new System.Windows.Forms.ListBox();
            this.lbx_searchmember = new System.Windows.Forms.ListBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(244, 278);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 21);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(246, 52);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(100, 21);
            this.btn_sort.TabIndex = 3;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(476, 52);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 21);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(476, 52);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(100, 21);
            this.btn_modify.TabIndex = 12;
            this.btn_modify.Text = "Modify";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Visible = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(242, 393);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 21);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txb_searchlastname
            // 
            this.txb_searchlastname.Location = new System.Drawing.Point(244, 305);
            this.txb_searchlastname.MaxLength = 13333;
            this.txb_searchlastname.Name = "txb_searchlastname";
            this.txb_searchlastname.Size = new System.Drawing.Size(100, 20);
            this.txb_searchlastname.TabIndex = 7;
            this.txb_searchlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_searchlastname_KeyPress);
            // 
            // ddb_sortoption
            // 
            this.ddb_sortoption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_sortoption.FormattingEnabled = true;
            this.ddb_sortoption.Location = new System.Drawing.Point(140, 52);
            this.ddb_sortoption.Name = "ddb_sortoption";
            this.ddb_sortoption.Size = new System.Drawing.Size(100, 21);
            this.ddb_sortoption.TabIndex = 2;
            // 
            // ddb_sortmember
            // 
            this.ddb_sortmember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_sortmember.FormattingEnabled = true;
            this.ddb_sortmember.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ddb_sortmember.Items.AddRange(new object[] {
            "Wrestler",
            "Coach"});
            this.ddb_sortmember.Location = new System.Drawing.Point(15, 52);
            this.ddb_sortmember.Name = "ddb_sortmember";
            this.ddb_sortmember.Size = new System.Drawing.Size(119, 21);
            this.ddb_sortmember.TabIndex = 1;
            this.ddb_sortmember.SelectedIndexChanged += new System.EventHandler(this.ddb_member_SelectedIndexChanged);
            // 
            // lbl_sorttxt1
            // 
            this.lbl_sorttxt1.AutoSize = true;
            this.lbl_sorttxt1.Location = new System.Drawing.Point(137, 35);
            this.lbl_sorttxt1.Name = "lbl_sorttxt1";
            this.lbl_sorttxt1.Size = new System.Drawing.Size(79, 13);
            this.lbl_sorttxt1.TabIndex = 11;
            this.lbl_sorttxt1.Text = "Sorting Method";
            this.lbl_sorttxt1.Visible = false;
            // 
            // lbx_sortedlist
            // 
            this.lbx_sortedlist.FormattingEnabled = true;
            this.lbx_sortedlist.HorizontalScrollbar = true;
            this.lbx_sortedlist.Items.AddRange(new object[] {
            "Wrestler/ Last Name/ First Name/ Gender/ School/ Years of Experiences/ Birthday/ " +
                "Weight/ Weight Category/ Wins/ Losses/ Total Points/ Total Pin Wins/ Status/ Uni" +
                "form Sign-out"});
            this.lbx_sortedlist.Location = new System.Drawing.Point(15, 79);
            this.lbx_sortedlist.Name = "lbx_sortedlist";
            this.lbx_sortedlist.Size = new System.Drawing.Size(331, 173);
            this.lbx_sortedlist.TabIndex = 4;
            // 
            // ddb_addmember
            // 
            this.ddb_addmember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_addmember.FormattingEnabled = true;
            this.ddb_addmember.Items.AddRange(new object[] {
            "Wrestler",
            "Coach"});
            this.ddb_addmember.Location = new System.Drawing.Point(352, 52);
            this.ddb_addmember.Name = "ddb_addmember";
            this.ddb_addmember.Size = new System.Drawing.Size(118, 21);
            this.ddb_addmember.TabIndex = 13;
            this.ddb_addmember.SelectedIndexChanged += new System.EventHandler(this.ddb_addtype_SelectedIndexChanged);
            // 
            // lbl_searchtxt2
            // 
            this.lbl_searchtxt2.AutoSize = true;
            this.lbl_searchtxt2.Location = new System.Drawing.Point(180, 308);
            this.lbl_searchtxt2.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_searchtxt2.Name = "lbl_searchtxt2";
            this.lbl_searchtxt2.Size = new System.Drawing.Size(58, 13);
            this.lbl_searchtxt2.TabIndex = 17;
            this.lbl_searchtxt2.Text = "Last Name";
            // 
            // txb_searchfirstname
            // 
            this.txb_searchfirstname.Location = new System.Drawing.Point(74, 305);
            this.txb_searchfirstname.MaxLength = 13333;
            this.txb_searchfirstname.Name = "txb_searchfirstname";
            this.txb_searchfirstname.Size = new System.Drawing.Size(101, 20);
            this.txb_searchfirstname.TabIndex = 6;
            this.txb_searchfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_searchfirstname_KeyPress);
            // 
            // lbl_searchtxt1
            // 
            this.lbl_searchtxt1.AutoSize = true;
            this.lbl_searchtxt1.Location = new System.Drawing.Point(11, 308);
            this.lbl_searchtxt1.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_searchtxt1.Name = "lbl_searchtxt1";
            this.lbl_searchtxt1.Size = new System.Drawing.Size(57, 13);
            this.lbl_searchtxt1.TabIndex = 20;
            this.lbl_searchtxt1.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add Catertories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sort Catergories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Search via Full Name";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(350, 82);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstname.TabIndex = 24;
            this.lbl_firstname.Text = "First Name";
            // 
            // txb_addfirstname
            // 
            this.txb_addfirstname.Location = new System.Drawing.Point(476, 79);
            this.txb_addfirstname.Name = "txb_addfirstname";
            this.txb_addfirstname.Size = new System.Drawing.Size(100, 20);
            this.txb_addfirstname.TabIndex = 16;
            this.txb_addfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addfirstname_KeyPress);
            // 
            // txb_addlastname
            // 
            this.txb_addlastname.Location = new System.Drawing.Point(476, 105);
            this.txb_addlastname.Name = "txb_addlastname";
            this.txb_addlastname.Size = new System.Drawing.Size(100, 20);
            this.txb_addlastname.TabIndex = 17;
            this.txb_addlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addlastname_KeyPress);
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(350, 108);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastname.TabIndex = 26;
            this.lbl_lastname.Text = "Last Name";
            // 
            // txb_addyearofexp
            // 
            this.txb_addyearofexp.Location = new System.Drawing.Point(476, 158);
            this.txb_addyearofexp.MaxLength = 2;
            this.txb_addyearofexp.Name = "txb_addyearofexp";
            this.txb_addyearofexp.Size = new System.Drawing.Size(100, 20);
            this.txb_addyearofexp.TabIndex = 19;
            this.txb_addyearofexp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addyearofexp_KeyPress);
            // 
            // lbl_yearofexp
            // 
            this.lbl_yearofexp.AutoSize = true;
            this.lbl_yearofexp.Location = new System.Drawing.Point(350, 161);
            this.lbl_yearofexp.Name = "lbl_yearofexp";
            this.lbl_yearofexp.Size = new System.Drawing.Size(102, 13);
            this.lbl_yearofexp.TabIndex = 28;
            this.lbl_yearofexp.Text = "Years of Experience";
            // 
            // txb_addwin
            // 
            this.txb_addwin.Location = new System.Drawing.Point(476, 289);
            this.txb_addwin.Name = "txb_addwin";
            this.txb_addwin.Size = new System.Drawing.Size(100, 20);
            this.txb_addwin.TabIndex = 25;
            this.txb_addwin.Visible = false;
            this.txb_addwin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addwin_KeyPress);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(350, 134);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 30;
            this.lbl_gender.Text = "Gender";
            // 
            // txb_addlose
            // 
            this.txb_addlose.Location = new System.Drawing.Point(476, 315);
            this.txb_addlose.Name = "txb_addlose";
            this.txb_addlose.Size = new System.Drawing.Size(100, 20);
            this.txb_addlose.TabIndex = 26;
            this.txb_addlose.Visible = false;
            this.txb_addlose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addlose_KeyPress);
            // 
            // lbl_addtxt
            // 
            this.lbl_addtxt.AutoSize = true;
            this.lbl_addtxt.Location = new System.Drawing.Point(350, 213);
            this.lbl_addtxt.Name = "lbl_addtxt";
            this.lbl_addtxt.Size = new System.Drawing.Size(35, 13);
            this.lbl_addtxt.TabIndex = 32;
            this.lbl_addtxt.Text = "label8";
            // 
            // ddb_addgender
            // 
            this.ddb_addgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_addgender.FormattingEnabled = true;
            this.ddb_addgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ddb_addgender.Location = new System.Drawing.Point(476, 131);
            this.ddb_addgender.Name = "ddb_addgender";
            this.ddb_addgender.Size = new System.Drawing.Size(100, 21);
            this.ddb_addgender.TabIndex = 18;
            // 
            // ddb_addstatus
            // 
            this.ddb_addstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_addstatus.FormattingEnabled = true;
            this.ddb_addstatus.Items.AddRange(new object[] {
            "Active",
            "Injured",
            "Quit/Cut"});
            this.ddb_addstatus.Location = new System.Drawing.Point(476, 210);
            this.ddb_addstatus.Name = "ddb_addstatus";
            this.ddb_addstatus.Size = new System.Drawing.Size(100, 21);
            this.ddb_addstatus.TabIndex = 22;
            // 
            // ddb_adduniform
            // 
            this.ddb_adduniform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_adduniform.FormattingEnabled = true;
            this.ddb_adduniform.Items.AddRange(new object[] {
            "True",
            "False"});
            this.ddb_adduniform.Location = new System.Drawing.Point(476, 393);
            this.ddb_adduniform.Name = "ddb_adduniform";
            this.ddb_adduniform.Size = new System.Drawing.Size(100, 21);
            this.ddb_adduniform.TabIndex = 29;
            this.ddb_adduniform.Visible = false;
            // 
            // lbl_uniform
            // 
            this.lbl_uniform.AutoSize = true;
            this.lbl_uniform.Location = new System.Drawing.Point(350, 396);
            this.lbl_uniform.Name = "lbl_uniform";
            this.lbl_uniform.Size = new System.Drawing.Size(99, 13);
            this.lbl_uniform.TabIndex = 38;
            this.lbl_uniform.Text = "Uniform Signed Out";
            this.lbl_uniform.Visible = false;
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Location = new System.Drawing.Point(349, 292);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(31, 13);
            this.lbl_win.TabIndex = 39;
            this.lbl_win.Text = "Wins";
            this.lbl_win.Visible = false;
            // 
            // lbl_lose
            // 
            this.lbl_lose.AutoSize = true;
            this.lbl_lose.Location = new System.Drawing.Point(349, 318);
            this.lbl_lose.Name = "lbl_lose";
            this.lbl_lose.Size = new System.Drawing.Size(40, 13);
            this.lbl_lose.TabIndex = 40;
            this.lbl_lose.Text = "Losses";
            this.lbl_lose.Visible = false;
            // 
            // lbl_pinwin
            // 
            this.lbl_pinwin.AutoSize = true;
            this.lbl_pinwin.Location = new System.Drawing.Point(350, 370);
            this.lbl_pinwin.Name = "lbl_pinwin";
            this.lbl_pinwin.Size = new System.Drawing.Size(115, 13);
            this.lbl_pinwin.TabIndex = 44;
            this.lbl_pinwin.Text = "Number of Wins by Pin";
            this.lbl_pinwin.Visible = false;
            // 
            // lbl_totalpoint
            // 
            this.lbl_totalpoint.AutoSize = true;
            this.lbl_totalpoint.Location = new System.Drawing.Point(350, 344);
            this.lbl_totalpoint.Name = "lbl_totalpoint";
            this.lbl_totalpoint.Size = new System.Drawing.Size(100, 13);
            this.lbl_totalpoint.TabIndex = 43;
            this.lbl_totalpoint.Text = "Total Points Scored";
            this.lbl_totalpoint.Visible = false;
            // 
            // txb_addpinwin
            // 
            this.txb_addpinwin.Location = new System.Drawing.Point(476, 367);
            this.txb_addpinwin.Name = "txb_addpinwin";
            this.txb_addpinwin.Size = new System.Drawing.Size(100, 20);
            this.txb_addpinwin.TabIndex = 28;
            this.txb_addpinwin.Visible = false;
            this.txb_addpinwin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addpinwin_KeyPress);
            // 
            // txb_addtotalpoint
            // 
            this.txb_addtotalpoint.Location = new System.Drawing.Point(476, 341);
            this.txb_addtotalpoint.Name = "txb_addtotalpoint";
            this.txb_addtotalpoint.Size = new System.Drawing.Size(100, 20);
            this.txb_addtotalpoint.TabIndex = 27;
            this.txb_addtotalpoint.Visible = false;
            this.txb_addtotalpoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addtotalpoint_KeyPress);
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(349, 266);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(62, 13);
            this.lbl_weight.TabIndex = 46;
            this.lbl_weight.Text = "Weight (kg)";
            this.lbl_weight.Visible = false;
            // 
            // txb_addweight
            // 
            this.txb_addweight.Location = new System.Drawing.Point(476, 263);
            this.txb_addweight.MaxLength = 6;
            this.txb_addweight.Name = "txb_addweight";
            this.txb_addweight.Size = new System.Drawing.Size(100, 20);
            this.txb_addweight.TabIndex = 24;
            this.txb_addweight.Visible = false;
            this.txb_addweight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addweight_KeyPress);
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Location = new System.Drawing.Point(350, 240);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(120, 13);
            this.lbl_birthday.TabIndex = 48;
            this.lbl_birthday.Text = "Birthday MM/DD/YYYY";
            this.lbl_birthday.Visible = false;
            // 
            // ddb_searchmember
            // 
            this.ddb_searchmember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_searchmember.FormattingEnabled = true;
            this.ddb_searchmember.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ddb_searchmember.Items.AddRange(new object[] {
            "Wrestler",
            "Coach"});
            this.ddb_searchmember.Location = new System.Drawing.Point(14, 277);
            this.ddb_searchmember.Name = "ddb_searchmember";
            this.ddb_searchmember.Size = new System.Drawing.Size(118, 21);
            this.ddb_searchmember.TabIndex = 5;
            this.ddb_searchmember.SelectedIndexChanged += new System.EventHandler(this.ddb_searchmember_SelectedIndexChanged);
            // 
            // ddb_teamstat
            // 
            this.ddb_teamstat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_teamstat.FormattingEnabled = true;
            this.ddb_teamstat.Items.AddRange(new object[] {
            "Team Stats",
            "Categories",
            "Sign-Out List",
            "Win/Lose Percentage"});
            this.ddb_teamstat.Location = new System.Drawing.Point(582, 52);
            this.ddb_teamstat.Name = "ddb_teamstat";
            this.ddb_teamstat.Size = new System.Drawing.Size(143, 21);
            this.ddb_teamstat.TabIndex = 30;
            this.ddb_teamstat.SelectedIndexChanged += new System.EventHandler(this.ddb_teamstat_SelectedIndexChanged);
            // 
            // ddb_teamgender
            // 
            this.ddb_teamgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_teamgender.FormattingEnabled = true;
            this.ddb_teamgender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.ddb_teamgender.Location = new System.Drawing.Point(731, 52);
            this.ddb_teamgender.Name = "ddb_teamgender";
            this.ddb_teamgender.Size = new System.Drawing.Size(110, 21);
            this.ddb_teamgender.TabIndex = 31;
            this.ddb_teamgender.Visible = false;
            this.ddb_teamgender.SelectedIndexChanged += new System.EventHandler(this.ddb_teamgender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Team Stats";
            // 
            // txb_addbirthday
            // 
            this.txb_addbirthday.Location = new System.Drawing.Point(476, 237);
            this.txb_addbirthday.MaxLength = 10;
            this.txb_addbirthday.Name = "txb_addbirthday";
            this.txb_addbirthday.Size = new System.Drawing.Size(100, 20);
            this.txb_addbirthday.TabIndex = 23;
            this.txb_addbirthday.Visible = false;
            this.txb_addbirthday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addbirthday_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTeamToolStripMenuItem,
            this.toolStripSeparator2,
            this.openTeamToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveTeamToolStripMenuItem,
            this.toolStripSeparator1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // newTeamToolStripMenuItem
            // 
            this.newTeamToolStripMenuItem.Name = "newTeamToolStripMenuItem";
            this.newTeamToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newTeamToolStripMenuItem.Text = "New Team";
            this.newTeamToolStripMenuItem.Click += new System.EventHandler(this.newTeamToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // openTeamToolStripMenuItem
            // 
            this.openTeamToolStripMenuItem.Name = "openTeamToolStripMenuItem";
            this.openTeamToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openTeamToolStripMenuItem.Text = "Open Team";
            this.openTeamToolStripMenuItem.Click += new System.EventHandler(this.openTeamToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // saveTeamToolStripMenuItem
            // 
            this.saveTeamToolStripMenuItem.Name = "saveTeamToolStripMenuItem";
            this.saveTeamToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveTeamToolStripMenuItem.Text = "Save Team";
            this.saveTeamToolStripMenuItem.Click += new System.EventHandler(this.saveTeamToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // lbl_school
            // 
            this.lbl_school.AutoSize = true;
            this.lbl_school.Location = new System.Drawing.Point(350, 188);
            this.lbl_school.Name = "lbl_school";
            this.lbl_school.Size = new System.Drawing.Size(40, 13);
            this.lbl_school.TabIndex = 69;
            this.lbl_school.Text = "School";
            // 
            // txb_addschool
            // 
            this.txb_addschool.Location = new System.Drawing.Point(476, 184);
            this.txb_addschool.MaxLength = 4;
            this.txb_addschool.Name = "txb_addschool";
            this.txb_addschool.Size = new System.Drawing.Size(100, 20);
            this.txb_addschool.TabIndex = 20;
            this.txb_addschool.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_addschool_KeyPress);
            // 
            // ddb_addtype
            // 
            this.ddb_addtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddb_addtype.FormattingEnabled = true;
            this.ddb_addtype.Items.AddRange(new object[] {
            "Support",
            "Hands-on"});
            this.ddb_addtype.Location = new System.Drawing.Point(476, 210);
            this.ddb_addtype.Name = "ddb_addtype";
            this.ddb_addtype.Size = new System.Drawing.Size(100, 21);
            this.ddb_addtype.TabIndex = 21;
            // 
            // lbx_teamstat
            // 
            this.lbx_teamstat.FormattingEnabled = true;
            this.lbx_teamstat.HorizontalScrollbar = true;
            this.lbx_teamstat.Location = new System.Drawing.Point(582, 79);
            this.lbx_teamstat.Name = "lbx_teamstat";
            this.lbx_teamstat.Size = new System.Drawing.Size(259, 329);
            this.lbx_teamstat.TabIndex = 32;
            // 
            // lbx_searchmember
            // 
            this.lbx_searchmember.FormattingEnabled = true;
            this.lbx_searchmember.HorizontalScrollbar = true;
            this.lbx_searchmember.Location = new System.Drawing.Point(13, 331);
            this.lbx_searchmember.Name = "lbx_searchmember";
            this.lbx_searchmember.Size = new System.Drawing.Size(331, 56);
            this.lbx_searchmember.TabIndex = 9;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(136, 393);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 21);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 428);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbx_searchmember);
            this.Controls.Add(this.lbx_teamstat);
            this.Controls.Add(this.ddb_addtype);
            this.Controls.Add(this.txb_addschool);
            this.Controls.Add(this.lbl_school);
            this.Controls.Add(this.txb_addbirthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddb_teamgender);
            this.Controls.Add(this.ddb_teamstat);
            this.Controls.Add(this.ddb_searchmember);
            this.Controls.Add(this.lbl_birthday);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.txb_addweight);
            this.Controls.Add(this.lbl_pinwin);
            this.Controls.Add(this.lbl_totalpoint);
            this.Controls.Add(this.txb_addpinwin);
            this.Controls.Add(this.txb_addtotalpoint);
            this.Controls.Add(this.lbl_lose);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.lbl_uniform);
            this.Controls.Add(this.ddb_adduniform);
            this.Controls.Add(this.ddb_addstatus);
            this.Controls.Add(this.ddb_addgender);
            this.Controls.Add(this.txb_addlose);
            this.Controls.Add(this.lbl_addtxt);
            this.Controls.Add(this.txb_addwin);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.txb_addyearofexp);
            this.Controls.Add(this.lbl_yearofexp);
            this.Controls.Add(this.txb_addlastname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.txb_addfirstname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_searchtxt1);
            this.Controls.Add(this.txb_searchfirstname);
            this.Controls.Add(this.lbl_searchtxt2);
            this.Controls.Add(this.ddb_addmember);
            this.Controls.Add(this.lbx_sortedlist);
            this.Controls.Add(this.lbl_sorttxt1);
            this.Controls.Add(this.ddb_sortmember);
            this.Controls.Add(this.ddb_sortoption);
            this.Controls.Add(this.txb_searchlastname);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txb_searchlastname;
        private System.Windows.Forms.ComboBox ddb_sortoption;
        private System.Windows.Forms.ComboBox ddb_sortmember;
        private System.Windows.Forms.Label lbl_sorttxt1;
        private System.Windows.Forms.ListBox lbx_sortedlist;
        private System.Windows.Forms.ComboBox ddb_addmember;
        private System.Windows.Forms.Label lbl_searchtxt2;
        private System.Windows.Forms.TextBox txb_searchfirstname;
        private System.Windows.Forms.Label lbl_searchtxt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox txb_addfirstname;
        private System.Windows.Forms.TextBox txb_addlastname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox txb_addyearofexp;
        private System.Windows.Forms.Label lbl_yearofexp;
        private System.Windows.Forms.TextBox txb_addwin;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox txb_addlose;
        private System.Windows.Forms.Label lbl_addtxt;
        private System.Windows.Forms.ComboBox ddb_addgender;
        private System.Windows.Forms.ComboBox ddb_addstatus;
        private System.Windows.Forms.ComboBox ddb_adduniform;
        private System.Windows.Forms.Label lbl_uniform;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_lose;
        private System.Windows.Forms.Label lbl_pinwin;
        private System.Windows.Forms.Label lbl_totalpoint;
        private System.Windows.Forms.TextBox txb_addpinwin;
        private System.Windows.Forms.TextBox txb_addtotalpoint;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txb_addweight;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.ComboBox ddb_searchmember;
        private System.Windows.Forms.ComboBox ddb_teamstat;
        private System.Windows.Forms.ComboBox ddb_teamgender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_addbirthday;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label lbl_school;
        private System.Windows.Forms.TextBox txb_addschool;
        private System.Windows.Forms.ComboBox ddb_addtype;
        private System.Windows.Forms.ToolStripMenuItem newTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox lbx_teamstat;
        private System.Windows.Forms.ListBox lbx_searchmember;
        private System.Windows.Forms.Button btn_cancel;
    }
}

