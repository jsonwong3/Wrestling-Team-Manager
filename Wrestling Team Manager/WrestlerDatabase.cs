//Project Name	: A2_OOP
//File Name		: WrestlerDatabase
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 22 2017
//Description	: Wrestler Team Management Program
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace A2_OOP
{
    public partial class Form1 : Form
    {
        //Access to sorting categories and list box labels
        SharedData data = new SharedData();
        Team team = new Team();

        //Access to file manipulation
        FileIO file = new FileIO();

        //Access to systems text files and documents
        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();

        //Tracks current team being used
        string currentTeam;

        //Path of the debug folder
        string debugLocation;

        //Loop variable
        int i;

        //Constants used to refresh program
        const int ADDSECTION = 1;
        const int SORTSECTION = 2;
        const int TEAMSECTION = 3;
        const int SEARCHSECTION = 4;

        //Variables used to hold modify member information
        string modifyFirstName;
        string modifyLastName;
        int resultIndex;

        //Initialize components of the program
        public Form1()
        {
            debugLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            save.InitialDirectory = debugLocation;
            open.InitialDirectory = debugLocation;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Current Team: Untitled Team";
            InitializeComponent();
        }

        //Set drop down boxes to their first option
        private void Form1_Load(object sender, EventArgs e)
        {
            ddb_addmember.SelectedIndex = 0;
            ddb_searchmember.SelectedIndex = 0;
            ddb_sortmember.SelectedIndex = 0;
            ddb_teamstat.SelectedIndex = 0;
        }
        
        //Prevents user from false inputs
        #region Key Limitations
        private void txb_searchfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsLetterOrDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_searchlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsLetterOrDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsLetterOrDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsLetterOrDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addyearofexp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addschool_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addwin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addlose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addtotalpoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addpinwin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txb_addbirthday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsDigit(e.KeyChar) == false && Convert.ToString(e.KeyChar) != "/")
            {
                e.Handled = true;
            }
        }

        private void txb_addweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Char.IsDigit(e.KeyChar) == false && Convert.ToString(e.KeyChar) != ".")
            {
                e.Handled = true;
            }
        }
        #endregion

        //Manages File interfact and functions
        #region File Manipulation
        //Executes creating file function
        private void newTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.FileName = "";
            save.Filter = "txt files (*.txt)|*.txt";
            save.Title = "Please create a text file";
            save.ShowDialog();

            if (save.FileName != "")
            {
                //Only executes if the file name is unique
                if (!File.Exists(save.FileName))
                {
                    var newFile = File.Create(save.FileName);
                    currentTeam = Path.GetFileName(save.FileName);
                    newFile.Close();

                    file.openTeam(currentTeam, team);

                    UpdateScreen(SORTSECTION);
                    UpdateScreen(ADDSECTION);
                    UpdateScreen(SEARCHSECTION);
                    UpdateScreen(TEAMSECTION);
                    this.Text = "Current Team: " + currentTeam.Substring(0, (currentTeam.Length - 4));
                }
            }
        }

        //Executes opening file function
        private void openTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.Filter = "txt files (*.txt)|*.txt";
            open.Title = "Please select a text file";
            open.ShowDialog();

            if (open.FileName != "")
            {
                currentTeam = Path.GetFileName(open.FileName);

                team.resetTeam();
                file.openTeam(currentTeam, team);

                UpdateScreen(SORTSECTION);
                UpdateScreen(ADDSECTION);
                UpdateScreen(SEARCHSECTION);
                UpdateScreen(TEAMSECTION);
                this.Text = "Current Team: " + currentTeam.Substring(0, (currentTeam.Length - 4));
            }
        }
       
        //Executes saving file function
        private void saveTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Checks if the user hasn't openned an existing text file yet
            if (currentTeam == null)
            {
                newTeamToolStripMenuItem.PerformClick();
            }

            //Only saves if a currrent team has been assigned
            if (currentTeam != null)
            {
                file.saveTeam(currentTeam, team);
            }
        }
        #endregion

        //Manages Sorting interface and fucntions
        #region Sorting Interface and Function
        //Refreshes sort options whenever the member option is toggled
        private void ddb_member_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddb_sortoption.Items.Clear();

            if (ddb_sortmember.SelectedIndex == 1)
            {
                ddb_sortoption.Items.AddRange(data.coachSortMethod);
            }
            else
            {
                ddb_sortoption.Items.AddRange(data.wrestlerSortMethod);
            }
        }

        //Executes sort function
        private void btn_sort_Click(object sender, EventArgs e)
        {
            //Filters which sort option is being requested
            if (ddb_sortoption.SelectedIndex != -1)
            {
                //Filters which member option is being requested
                if (ddb_sortmember.SelectedIndex == 1)
                {
                    //Calls on team class to sort
                    switch (Convert.ToString(ddb_sortoption.SelectedItem))
                    {
                        case ("Last Name"):
                            team.sortCLastName();
                            break;
                        case ("Gender"):
                            team.sortCGender();
                            break;
                        default:
                            team.sortCType();
                            break;
                    }
                }
                else if (ddb_sortmember.SelectedIndex == 0)
                {
                    switch (Convert.ToString(ddb_sortoption.SelectedItem))
                    {
                        case ("Last Name"):
                            team.sortWLastName();
                            break;
                        case ("Gender"):
                            team.sortWGender();
                            break;
                        case ("Wins"):
                            team.sortWWins();
                            break;
                        default:
                            team.sortWWeightGroup();
                            break;
                    }
                }
                UpdateScreen(SORTSECTION);
            }
            else
            {
                MessageBox.Show("Please enter a sorting method", "ERROR", MessageBoxButtons.OK);
            }
        }
        #endregion

        //Manages search, modify and delete interface and fucntions
        #region Search, Modify and Delete Interface and Fucntion
        //Refreshes search section whenever the search option is toggled
        private void ddb_searchmember_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears interface if a member was previously searched
            if (lbx_searchmember.Items.Count != 0)
            {
                UpdateScreen(ADDSECTION);
                UpdateScreen(SEARCHSECTION);
            }   
        }

        /// <summary>
        /// Automatically fills add interface for modification
        /// </summary>
        /// <param name="modifyc">The coach searched up</param>
        private void editCoach(Coach modifyc)
        {
            ddb_addmember.SelectedIndex = 1;
            txb_addfirstname.Text = modifyc.getFirstName();
            txb_addlastname.Text = modifyc.getLastName();
            ddb_addgender.SelectedItem = modifyc.getGender();
            txb_addyearofexp.Text = modifyc.getYearExp();
            txb_addschool.Text = modifyc.getSchool();
            ddb_addtype.SelectedItem = modifyc.getType();
            btn_modify.Visible = true;
            btn_delete.Enabled = true;
            btn_cancel.Enabled = true;
            ddb_addmember.Enabled = false;
        }

        /// <summary>
        /// Automatically fills add interface for modification
        /// </summary>
        /// <param name="modifyw">The wrestler searched up</param>
        private void editWrestler(Wrestler modifyw)
        {
            ddb_addmember.SelectedIndex = 0;
            txb_addfirstname.Text = modifyw.getFirstName();
            txb_addlastname.Text = modifyw.getLastName();
            ddb_addgender.SelectedItem = modifyw.getGender();
            txb_addyearofexp.Text = modifyw.getYearExp();
            txb_addschool.Text = modifyw.getSchool();
            ddb_addstatus.SelectedItem = modifyw.getStatus();
            txb_addbirthday.Text = modifyw.getBirthday();
            txb_addweight.Text = Convert.ToString(modifyw.getWeight());
            txb_addwin.Text = Convert.ToString(modifyw.getWin());
            txb_addlose.Text = Convert.ToString(modifyw.getLoss());
            txb_addpinwin.Text = Convert.ToString(modifyw.getPinWin());
            txb_addtotalpoint.Text = Convert.ToString(modifyw.getTotalPoint());
            ddb_adduniform.SelectedItem = modifyw.getUniform();
            btn_modify.Visible = true;
            btn_delete.Enabled = true;
            btn_cancel.Enabled = true;
            ddb_addmember.Enabled = false;
        }

        //Executes search function
        private void btn_search_Click(object sender, EventArgs e)
        {
            //Ensures all fields are vaild
            if (txb_searchfirstname.Text.Length != 0 && txb_searchlastname.Text.Length != 0)
            {
                modifyFirstName = txb_searchfirstname.Text;
                modifyLastName = txb_searchlastname.Text;

                //Filters which search option is being requested
                if (ddb_searchmember.SelectedIndex == 1)
                {
                    resultIndex = team.indexCoach(modifyFirstName, modifyLastName);

                    //Returns result of search to user
                    if (resultIndex >= 0)
                    {
                        lbx_searchmember.Items.Clear();
                        lbx_searchmember.Items.Add(data.coachLabel);
                        lbx_searchmember.Items.Add(team.listCoach(resultIndex));
                        editCoach(team.getCoachList()[resultIndex]);
                    }
                    else
                    {
                        MessageBox.Show("That Coach does not exist", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    resultIndex = team.indexWrestler(modifyFirstName, modifyLastName);

                    if (resultIndex >= 0)
                    {
                        lbx_searchmember.Items.Clear();
                        lbx_searchmember.Items.Add(data.wrestlerLabel);
                        lbx_searchmember.Items.Add(team.listWrestler(resultIndex));
                        editWrestler(team.getWrestlerList()[resultIndex]);
                    }
                    else
                    {
                        MessageBox.Show("That Wrestler does not exist", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter full name", "Error", MessageBoxButtons.OK);
            }
        }

        //Refreshes search section upon request
        private void btn_cancel_Click(object sender, EventArgs e)
        {           
            UpdateScreen(ADDSECTION);
            UpdateScreen(SEARCHSECTION);
        }

        //Executes remove function
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Filters which member type is being removed
            if (ddb_searchmember.SelectedIndex == 1)
            {
                team.removeCoach(resultIndex);
            }
            else
            {
                team.removeWrestler(resultIndex);
            }

            UpdateScreen(ADDSECTION);
            UpdateScreen(SORTSECTION);
            UpdateScreen(SEARCHSECTION);
            UpdateScreen(TEAMSECTION);
        }

        //Executes modify function
        private void btn_modify_Click(object sender, EventArgs e)
        {
            //Filters which member type is being removed
            if (ddb_addmember.SelectedIndex == 1)
            {
                //Ensures all fields are vaild
                if (txb_addfirstname.Text.Trim().Length != 0 && txb_addlastname.Text.Trim().Length != 0 && ddb_addgender.SelectedIndex != -1 &&
                    txb_addyearofexp.Text.Trim().Length != 0 && txb_addschool.Text.Trim().Length != 0 && ddb_addtype.SelectedIndex != -1)
                {
                    //Calls on team class to add and remove member
                    string firstName = txb_addfirstname.Text.Trim();
                    string lastName = txb_addlastname.Text.Trim();
                    string gender = Convert.ToString(ddb_addgender.SelectedItem);
                    string yearExp = txb_addyearofexp.Text.Trim();
                    string school = txb_addschool.Text.ToUpper().Trim();
                    string type = Convert.ToString(ddb_addtype.SelectedItem);

                    team.addCoach(firstName, lastName, gender, yearExp, school, type);
                    team.removeCoach(resultIndex);
                    UpdateScreen(ADDSECTION);
                    UpdateScreen(SORTSECTION);
                    UpdateScreen(SEARCHSECTION);
                    UpdateScreen(TEAMSECTION);
                }
                else
                {
                    MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (txb_addfirstname.Text.Trim().Length != 0 && txb_addlastname.Text.Trim().Length != 0 && ddb_addgender.SelectedIndex != -1 &&
                    txb_addyearofexp.Text.Trim().Length != 0 && txb_addschool.Text.Trim().Length != 0 && ddb_addstatus.SelectedIndex != -1 &&
                    txb_addbirthday.Text.Trim().Length != 0 && txb_addweight.Text.Trim().Length != 0 && txb_addwin.Text.Trim().Length != 0 &&
                    txb_addlose.Text.Trim().Length != 0 && txb_addpinwin.Text.Trim().Length != 0 && txb_addtotalpoint.Text.Trim().Length != 0 &&
                    ddb_adduniform.SelectedIndex != -1)
                {
                    string gender = Convert.ToString(ddb_addgender.SelectedItem);
                    double weight = Convert.ToDouble(txb_addweight.Text.Trim());

                    //Rejects request if wrestler's overweight or underweight
                    if (gender == "Male" && weight <= data.maleWeights[data.maleWeights.Length - 1] && weight >= data.maleWeights[0] - 5 || gender == "Female" && weight <= data.femaleWeights[data.femaleWeights.Length - 1] && weight >= data.femaleWeights[0] - 5)
                    {
                        string firstName = txb_addfirstname.Text.Trim();
                        string lastName = txb_addlastname.Text.Trim();
                        string yearExp = txb_addyearofexp.Text.Trim();
                        string school = txb_addschool.Text.ToUpper().Trim();
                        string status = Convert.ToString(ddb_addstatus.SelectedItem);
                        string birthday = txb_addbirthday.Text.Trim();
                        double win = Convert.ToDouble(txb_addwin.Text.Trim());
                        double loss = Convert.ToDouble(txb_addlose.Text.Trim());
                        int pinWin = Convert.ToInt32(txb_addpinwin.Text.Trim());
                        double totalPoint = Convert.ToDouble(txb_addtotalpoint.Text.Trim());
                        string uniform = Convert.ToString(ddb_adduniform.SelectedItem);

                        team.addWrestler(firstName, lastName, gender, yearExp, school, birthday, weight, win, loss, pinWin, totalPoint, status, uniform);
                        team.removeWrestler(team.indexWrestler(modifyFirstName, modifyLastName));          
                        UpdateScreen(ADDSECTION);
                        UpdateScreen(SORTSECTION);
                        UpdateScreen(SEARCHSECTION);
                        UpdateScreen(TEAMSECTION);
                    }
                    else
                    {
                        MessageBox.Show("Wrestlers can only be added if they are at least 5KG below their gender’s bottom weight category and at most the weight of the top category of their gender", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK);
                }
            }
        }
        #endregion

        //Manages add interface and functions
        #region Adding Interface and Function
        //Refreshes add section whenever the add option is toggled
        private void ddb_addtype_SelectedIndexChanged(object sender, EventArgs e)
        {   
            UpdateScreen(ADDSECTION);
            UpdateScreen(SEARCHSECTION);
        }

        //Executes add function
        private void btn_add_Click(object sender, EventArgs e)
        {
            //Filters which add option is being requested
             if (ddb_addmember.SelectedIndex == 1)
             {
                //Ensures all fields are vaild
                if (txb_addfirstname.Text.Trim().Length != 0 && txb_addlastname.Text.Trim().Length != 0 && ddb_addgender.SelectedIndex != -1 && 
                    txb_addyearofexp.Text.Trim().Length != 0 && txb_addschool.Text.Trim().Length != 0 && ddb_addtype.SelectedIndex != -1)
                {
                    //Calls on team class to add member
                    string firstName = txb_addfirstname.Text.Trim();
                    string lastName = txb_addlastname.Text.Trim();
                    string gender = Convert.ToString(ddb_addgender.SelectedItem);
                    string yearExp = txb_addyearofexp.Text.Trim();
                    string school = txb_addschool.Text.ToUpper().Trim();
                    string type = Convert.ToString(ddb_addtype.SelectedItem);

                    team.addCoach(firstName, lastName, gender, yearExp, school, type);
                    UpdateScreen(ADDSECTION);
                    UpdateScreen(SORTSECTION);
                    UpdateScreen(TEAMSECTION);
                }
                else
                {
                    MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK);
                }
             }
             else
             {
                if (txb_addfirstname.Text.Trim().Length != 0 && txb_addlastname.Text.Trim().Length != 0 && ddb_addgender.SelectedIndex != -1 && 
                    txb_addyearofexp.Text.Trim().Length != 0 && txb_addschool.Text.Trim().Length != 0 && ddb_addstatus.SelectedIndex != -1 &&
                    txb_addbirthday.Text.Trim().Length != 0 && txb_addweight.Text.Trim().Length != 0 && txb_addwin.Text.Trim().Length != 0 && 
                    txb_addlose.Text.Trim().Length != 0 && txb_addpinwin.Text.Trim().Length != 0 && txb_addtotalpoint.Text.Trim().Length != 0 && 
                    ddb_adduniform.SelectedIndex != -1)
                {
                    string gender = Convert.ToString(ddb_addgender.SelectedItem);
                    double weight = Convert.ToDouble(txb_addweight.Text.Trim());

                    //Rejects request if wrestler's overweight or underweight
                    if (gender == "Male" && weight <= data.maleWeights[data.maleWeights.Length - 1] && weight >= data.maleWeights[0] - 5 || gender == "Female" && weight <= data.femaleWeights[data.femaleWeights.Length - 1] && weight >= data.femaleWeights[0] - 5)
                    {
                        string firstName = txb_addfirstname.Text.Trim();
                        string lastName = txb_addlastname.Text.Trim();
                        string yearExp = txb_addyearofexp.Text.Trim();
                        string school = txb_addschool.Text.ToUpper().Trim();
                        string status = Convert.ToString(ddb_addstatus.SelectedItem);
                        string birthday = txb_addbirthday.Text.Trim();
                        double win = Convert.ToDouble(txb_addwin.Text.Trim());
                        double loss = Convert.ToDouble(txb_addlose.Text.Trim());
                        int pinWin = Convert.ToInt32(txb_addpinwin.Text.Trim());
                        double totalPoint = Convert.ToDouble(txb_addtotalpoint.Text.Trim());
                        string uniform = Convert.ToString(ddb_adduniform.SelectedItem);

                        team.addWrestler(firstName, lastName, gender, yearExp, school, birthday, weight, win, loss, pinWin, totalPoint, status, uniform);
                        UpdateScreen(ADDSECTION);
                        UpdateScreen(SORTSECTION);
                        UpdateScreen(TEAMSECTION);
                    }
                    else
                    {
                        MessageBox.Show("Wrestlers can only be added if they are at least 5KG below their gender’s bottom weight category and at most the weight of the top category of their gender", "Error", MessageBoxButtons.OK);
                    }
                 }
                 else
                 {
                     MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK);
                 }
             }
        }
        #endregion

        //Manages team statistics interface and functions
        #region Team Stat Interface
        //Refreshes team stat section whenever the stat option is toggled
        private void ddb_teamstat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScreen(TEAMSECTION);
        }

        //Refreshes team stat section whenever the gender option toggled
        private void ddb_teamgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScreen(TEAMSECTION);
        }
        #endregion

        /// <summary>
        /// Updates visual data for the user
        /// </summary>
        /// <param name="selection">A constant int value representing a selection on the screen</param>
        private void UpdateScreen(int selection)
        {
            switch (selection)
            {
                //Updates adding fields according to selected member type
                case (ADDSECTION):
                    txb_addfirstname.Clear();
                    txb_addlastname.Clear();
                    ddb_addgender.SelectedIndex = -1;
                    txb_addyearofexp.Text = "0";
                    txb_addschool.Clear();
                    ddb_addtype.SelectedIndex = -1;
                    ddb_addstatus.SelectedIndex = -1;
                    txb_addbirthday.Clear();
                    txb_addweight.Clear();
                    txb_addwin.Text = "0";
                    txb_addlose.Text = "0";
                    txb_addpinwin.Text = "0";
                    txb_addtotalpoint.Text = "0";
                    ddb_adduniform.SelectedIndex = -1;
                    ddb_addmember.Enabled = true;

                    if (ddb_addmember.SelectedIndex != 0)
                    {
                        lbl_addtxt.Text = "Type";
                        lbl_birthday.Visible = false;
                        lbl_weight.Visible = false;
                        lbl_win.Visible = false;
                        lbl_lose.Visible = false;
                        lbl_pinwin.Visible = false;
                        lbl_totalpoint.Visible = false;
                        lbl_uniform.Visible = false;
                        ddb_addtype.Visible = true;
                        ddb_addstatus.Visible = true;
                        txb_addbirthday.Visible = false;
                        txb_addweight.Visible = false;
                        txb_addwin.Visible = false;
                        txb_addlose.Visible = false;
                        txb_addpinwin.Visible = false;
                        txb_addtotalpoint.Visible = false;
                        ddb_adduniform.Visible = false;
                    }
                    else
                    {
                        lbl_addtxt.Text = "Status";
                        lbl_birthday.Visible = true;
                        lbl_weight.Visible = true;
                        lbl_win.Visible = true;
                        lbl_lose.Visible = true;
                        lbl_pinwin.Visible = true;
                        lbl_totalpoint.Visible = true;
                        lbl_uniform.Visible = true;
                        ddb_addtype.Visible = false;
                        txb_addbirthday.Visible = true;
                        txb_addweight.Visible = true;
                        txb_addwin.Visible = true;
                        txb_addlose.Visible = true;
                        txb_addpinwin.Visible = true;
                        txb_addtotalpoint.Visible = true;
                        ddb_adduniform.Visible = true;
                    }
                    break;
                //Updates sorting list box according to the selected member type
                case (SORTSECTION):
                    lbx_sortedlist.Items.Clear();

                    //Calls on team class to list member
                    if (ddb_sortmember.SelectedIndex == 0)
                    {
                        lbx_sortedlist.Items.Add(data.wrestlerLabel);
             
                        i = 0;

                        //Limits list to only display a maximum of 10 members
                        while (lbx_sortedlist.Items.Count <= data.sortListMaximum && i < team.getWrestlerList().Count)
                        {
                            lbx_sortedlist.Items.Add(Convert.ToString(i + 1) + "# " + team.listWrestler(i));
                            i++;
                        }       
                    }
                    else if (ddb_sortmember.SelectedIndex == 1)
                    {
                        lbx_sortedlist.Items.Add(data.coachLabel);

                        i = 0;

                        while (lbx_sortedlist.Items.Count <= data.sortListMaximum && i < team.getCoachList().Count)
                        {
                            lbx_sortedlist.Items.Add(Convert.ToString(i + 1) + "# " + team.listCoach(i));
                            i++;
                        }
                    }
                    break;
                //Updates sorting list box according to the selected tean stat option
                case (TEAMSECTION):
                    lbx_teamstat.Items.Clear();
                    ddb_teamgender.Visible = false;

                    Stats stat = new Stats(team.getCoachList(), team.getWrestlerList());

                    //Calls on stats class to list stats
                    if (ddb_teamstat.SelectedIndex == 0)
                    {
                        lbx_teamstat.Items.Add("Number of People on the Team: " + stat.getNumMember());
                        lbx_teamstat.Items.Add("Number of Wrestlers: " + stat.getNumWrestler());
                        lbx_teamstat.Items.Add("Number of Male Wrestlers: " + stat.getNumMaleWrestler());
                        lbx_teamstat.Items.Add("Number of Female Wrestlers: " + stat.getNumFemaleWrestler());
                        lbx_teamstat.Items.Add("Number of Coaches: " + stat.getNumCoach());
                        lbx_teamstat.Items.Add("Number of Male Coachs: " + stat.getNumMaleCoach());
                        lbx_teamstat.Items.Add("Number of Female Coachs: " + stat.getNumFemaleCoach());
                        lbx_teamstat.Items.Add("Number of Hands-On Coachs: " + stat.getNumHandsOn());
                        lbx_teamstat.Items.Add("Number of Support Coachs: " + stat.getNumSupport());
                        lbx_teamstat.Items.Add("Team's Total Number of Wins: " + stat.getTotalWin());
                        lbx_teamstat.Items.Add("Team's Total Number of Losses: " + stat.getTotalLose());
                        lbx_teamstat.Items.Add("Team's Win Percentage: " + stat.getTotalWinPercentage());
                        lbx_teamstat.Items.Add("Team's Loss Percentage: " + stat.getTotalLosePercentage());
                        lbx_teamstat.Items.Add("Team's Total Point Count: " + stat.getTotalPoint());
                        lbx_teamstat.Items.Add("Team's Total Pin Count: " + stat.getTotalPin());
                        lbx_teamstat.Items.Add("Team's Total Number of Matches: " + stat.getTotalMatch());
                        lbx_teamstat.Items.Add("Team's Average Point Count: " + stat.getTotalAverage());
                    }
                    else if (ddb_teamstat.SelectedIndex == 1)
                    {
                        lbx_teamstat.Items.Clear();
                        ddb_teamgender.Visible = true;

                        //Updates sorting list box according to the selected gender option
                        if (ddb_teamgender.SelectedIndex == 1)
                        {
                            for (i = 0; i < data.maleWeights.Length; i++)
                            {
                                lbx_teamstat.Items.Add((Convert.ToString(data.maleWeights[i])) + " Category: " + Convert.ToString(stat.getMaleCounter(i)));
                            }
                        }
                        else if (ddb_teamgender.SelectedIndex == 2)
                        {
                            for (i = 0; i < data.femaleWeights.Length; i++)
                            {
                                lbx_teamstat.Items.Add((Convert.ToString(data.femaleWeights[i])) + " Category: " + Convert.ToString(stat.getFemaleCounter(i)));
                            }
                        }
                        else
                        {
                            for (i = 0; i < data.allWeights.Length; i++)
                            {
                                lbx_teamstat.Items.Add((Convert.ToString(data.allWeights[i])) + " Category: " + Convert.ToString(stat.getAllCounter(i)));
                            }
                        }
                    }
                    else if (ddb_teamstat.SelectedIndex == 2)
                    {
                        lbx_teamstat.Items.Clear();
                        lbx_teamstat.Items.Add(data.wrestlerLabel);

                        for (i = 0; i < stat.getUniformLenght(); i++)
                        {
                            lbx_teamstat.Items.Add(stat.getListUniform(i));
                        }
                    }
                    else
                    {
                        lbx_teamstat.Items.Clear();
                        lbx_teamstat.Items.Add(data.percentageLabel);

                        for (i = 0; i < team.getWrestlerList().Count(); i++)
                        {
                            lbx_teamstat.Items.Add(team.getWrestlerList()[i].getFirstName() + " " + team.getWrestlerList()[i].getLastName() + ": " + team.getWrestlerList()[i].getWinPercentage() + "/ " + team.getWrestlerList()[i].getLossPercentage());
                        }
                    }
                    break;
                    //Clears search interface
                case (SEARCHSECTION):
                    txb_searchfirstname.Clear();
                    txb_searchlastname.Clear();
                    lbx_searchmember.Items.Clear();
                    btn_modify.Visible = false;
                    btn_delete.Enabled = false;
                    btn_cancel.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
