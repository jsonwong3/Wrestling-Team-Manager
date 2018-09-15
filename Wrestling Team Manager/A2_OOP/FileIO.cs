//Project Name	: A2_OOP
//File Name		: FileIO
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 22 2017
//Description	: File manipulation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace A2_OOP
{
    class FileIO
    {
        //Access to systems text files and documents
        StreamWriter outFile;
        StreamReader inFile;
        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();

        //Character to be removed once stored
        char removableComma = ',';

        //Loop variable
        int i;

        //Path of the debug folder
        string debugLocation;

        /// <summary>
        /// Finds the path for the Debug folder
        /// </summary>
        public FileIO()
        {
            debugLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// Saves any changes to the text file by overwriting it
        /// </summary>
        /// <param name="txtFile">The text file's name currently being used</param>
        /// <param name="team">The team currently being edited</param>
        public void saveTeam(string txtFile, Team team)
        {
            File.WriteAllText(Path.Combine(debugLocation, txtFile), String.Empty);

            try
            {
                outFile = File.AppendText(txtFile);

                for (i = 0; i < team.getWrestlerList().Count; i++)
                {
                    outFile.WriteLine(team.listWrestler(i));
                }

                for (i = 0; i < team.getCoachList().Count; i++)
                {
                    outFile.WriteLine(team.listCoach(i));
                }

                outFile.Close();
            }
            catch (FileNotFoundException dne)
            {
                MessageBox.Show("ERROR: The file cannot be found.\n\n"
                    , "Missing Configuration File"
                    , MessageBoxButtons.OK);
                outFile.Close();
            }
            catch (EndOfStreamException eos)
            {
                MessageBox.Show("ERROR: Attempted to write past the end of a file", "File Exceeded",
                MessageBoxButtons.OK);
                outFile.Close();
            }
        }

        /// <summary>
        /// Opens the text file requested and copies members into the current team class
        /// </summary>
        /// <param name="txtFile">The text file's name being requested</param>
        /// <param name="team">The team to be edited</param>
        public void openTeam(string txtFile, Team team)
        {
            inFile = File.OpenText(txtFile);

            while (!inFile.EndOfStream)
            {
                //Splits each line at the comma's
                string[] tempValue = (inFile.ReadLine().Split(removableComma));

                try
                {
                    if (tempValue[0] == "Coach")
                    {
                        team.addCoach(tempValue[2], tempValue[1], tempValue[3], tempValue[5], tempValue[4], tempValue[6]);
                    }
                    else
                    {
                        team.addWrestler(tempValue[2], tempValue[1], tempValue[3], tempValue[5], tempValue[4], tempValue[6], Convert.ToDouble(tempValue[7]), Convert.ToDouble(tempValue[9]), Convert.ToDouble(tempValue[10]), Convert.ToInt32(tempValue[12]), Convert.ToDouble(tempValue[11]), tempValue[13], tempValue[14]);
                    }
                }
                catch (IndexOutOfRangeException ire)
                {
                    //Ignores blank line at the end of the text file
                }
            }

            inFile.Close();
        }
    }
}
