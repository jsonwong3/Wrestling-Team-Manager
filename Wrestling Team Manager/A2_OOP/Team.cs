//Project Name	: A2_OOP
//File Name		: Team
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 22 2017
//Description	: Holds a list of coachs and wrestlers of the current team
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace A2_OOP
{
    class Team
    {
        //List of coachs and wrestlers in the current team loaded up
        List<Coach> coach = new List<Coach>();
        List<Wrestler> wrestler = new List<Wrestler>();

        #region Functions
        /// <summary>
        /// Clears the list of coaches and wrestlers
        /// </summary>
        public void resetTeam()
        {
            coach.Clear();
            wrestler.Clear();
        }

        /// <summary>
        /// Creates a new coach and adds them into the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="yearExp"></param>
        /// <param name="school"></param>
        /// <param name="type"></param>
        public void addCoach(string firstName, string lastName, string gender, string yearExp, string school, string type)
        {
            Coach newCoach = new Coach(firstName, lastName, gender, yearExp, school, type);
            coach.Add(newCoach);
        }

        /// <summary>
        /// Creates a new wrestler and adds them into the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="yearExp"></param>
        /// <param name="school"></param>
        /// <param name="birthday"></param>
        /// <param name="weight"></param>
        /// <param name="win"></param>
        /// <param name="loss"></param>
        /// <param name="pinWin"></param>
        /// <param name="totalPoint"></param>
        /// <param name="status"></param>
        /// <param name="uniform"></param>
        public void addWrestler(string firstName, string lastName, string gender, string yearExp, string school, string birthday, double weight, double win, double loss, int pinWin, double totalPoint, string status, string uniform)
        {
            Wrestler newWrestler = new Wrestler(firstName, lastName, gender, yearExp, school, birthday, weight, win, loss, pinWin, totalPoint, status, uniform);
            wrestler.Add(newWrestler);
        }

        /// <summary>
        /// Removes the coach at a given index
        /// </summary>
        /// <param name="i">The index of the coach</param>
        public void removeCoach(int i)
        {
            coach.RemoveAt(i);
        }

        /// <summary>
        /// Removes the wrestler at a given index
        /// </summary>
        /// <param name="i">The index of the wrestler</param>
        public void removeWrestler(int i)
        {
            wrestler.RemoveAt(i);
        }

        /// <summary>
        /// Sort coaches by their last and first names
        /// </summary>
        public void sortCLastName()
        {
            coach.Sort((c1, c2) => ((c1.getFullName()).ToLower()).CompareTo((c2.getFullName()).ToLower()));
        }

        /// <summary>
        /// Sort coaches by their gender
        /// </summary>
        public void sortCGender()
        {
            coach.Sort((c1, c2) => ((c1.getGender())).CompareTo((c2.getGender())));
        }

        /// <summary>
        /// Sort coaches by their type
        /// </summary>
        public void sortCType()
        {
            coach.Sort((c1, c2) => ((c1.getType())).CompareTo((c2.getType())));
        }

        /// <summary>
        /// Sort wrestlers by their last and first names
        /// </summary>
        public void sortWLastName()
        {
            wrestler.Sort((w1, w2) => ((w1.getFullName()).ToLower()).CompareTo((w2.getFullName()).ToLower()));
        }

        /// <summary>
        /// Sort wrestlers by their genders
        /// </summary>
        public void sortWGender()
        {
            wrestler.Sort((w1, w2) => ((w1.getGender())).CompareTo((w2.getGender())));
        }

        /// <summary>
        /// Sort wrestlers by their wins
        /// </summary>
        public void sortWWins()
        {
            //Reverse to display from highest to lowest
            wrestler.Sort((w1, w2) => ((w1.getWin())).CompareTo((w2.getWin())));
            wrestler.Reverse();
        }

        /// <summary>
        /// Sort wrestlers by their weight groups
        /// </summary>
        public void sortWWeightGroup()
        {
            wrestler.Sort((w1, w2) => ((w1.getWeightGroup())).CompareTo((w2.getWeightGroup())));
        }
        #endregion

        #region Get Variable Value
        /// <summary>
        /// Gets the list of coaches
        /// </summary>
        /// <returns>The list of coaches in the team</returns>
        public List<Coach> getCoachList()
        {
            return coach;
        }

        /// <summary>
        /// Gets the list of wrestlers
        /// </summary>
        /// <returns>The list of wrestlers in the team</returns>
        public List<Wrestler> getWrestlerList()
        {
            return wrestler;
        }

        /// <summary>
        /// Creates a user friendly string of the coach requested
        /// </summary>
        /// <param name="i">The index of the coach within the list</param>
        /// <returns>A string properly displaying a coachs information to the user</returns>
        public string listCoach(int i)
        {
            return ("Coach," + coach[i].getLastName() + "," + coach[i].getFirstName() + "," + coach[i].getGender() + "," + coach[i].getSchool() + "," + coach[i].getYearExp() + "," + coach[i].getType());
        }

        /// <summary>
        /// Creates a user friendly string of the wrestler requested
        /// </summary>
        /// <param name="i">The index of the wrestler within the list</param>
        /// <returns>A string properly displaying a wrestlers information to the user</returns>
        public string listWrestler(int i)
        {
            return ("Wrestler," + wrestler[i].getLastName() + "," + wrestler[i].getFirstName() + "," + wrestler[i].getGender() + "," + wrestler[i].getSchool() + "," + wrestler[i].getYearExp() + "," + wrestler[i].getBirthday() + "," + wrestler[i].getWeight() + "," + wrestler[i].getWeightGroup() + "," + wrestler[i].getWin() + "," + wrestler[i].getLoss() + "," + wrestler[i].getTotalPoint() + "," + wrestler[i].getPinWin() + "," + wrestler[i].getStatus() + "," + wrestler[i].getUniform());
        }

        /// <summary>
        /// Searches a coach based on their full name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>The index which the coach was found</returns>
        public int indexCoach(string firstName, string lastName)
        {
            return coach.FindIndex(resultCoach => resultCoach.getFirstName() == firstName && resultCoach.getLastName() == lastName);
        }

        /// <summary>
        /// Searches a wrestler based on their full name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>The index which the wrestler was found</returns>
        public int indexWrestler(string firstName, string lastName)
        {
            return wrestler.FindIndex(resultWrestler => resultWrestler.getFirstName() == firstName && resultWrestler.getLastName() == lastName);
        }
        #endregion
    }
}
