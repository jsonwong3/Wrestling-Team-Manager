//Project Name	: A2_OOP
//File Name		: Stats
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 22 2017
//Description	: Team statistics constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_OOP
{
    class Stats
    {
        //Access weight categoeries from SharedData
        SharedData data = new SharedData();

        //List of members used to calculate statistics
        List<Coach> c = new List<Coach>();
        List<Wrestler> w = new List<Wrestler>();

        //List used to seperate wrestlers based on their gender
        List<Wrestler> maleWrestler = new List<Wrestler>();
        List<Wrestler> femaleWrestler = new List<Wrestler>();

        //List used to seperate wrestlers based on their uniform sign out status
        List<Wrestler> uniformWrestler = new List<Wrestler>();

        //Weight category counters
        int[] maleWCounter;
        int[] femaleWCounter;
        int[] allWCounter;

        //Class Attributes
        private int numMaleWrestler;
        private int numMaleCoach;
        private int numHandOnCoach;
        private double totalWin;
        private double totalWinPercentage;
        private double totalPoint;
        private double totalMatch;

        //Loop variables
        int i;
        int j;

        /// <summary>
        /// Creates a variety of statistics based on the given team
        /// </summary>
        /// <param name="c">The current list of coaches from team</param>
        /// <param name="w">The current list of wrestlers from team</param>
        public Stats(List<Coach> c, List<Wrestler> w)
        {
            this.c = c;
            this.w = w;
            numMaleWrestler = calcMaleWrestler();
            numMaleCoach = calcMaleCoach();
            numHandOnCoach = calcHandOnCoach();
            totalMatch = calcTotalMatch();
            totalWin = calcTotalWin();
            totalWinPercentage = calcWinPercentage();
            totalPoint = calcTotalPoint();
            genderSeperator();
            femaleWCounter = femaleCategoryCount();
            maleWCounter = maleCategoryCount();
            allWCounter = allCategoryCount();
            uniformSignOutList();
        }

        #region Calculations
        /// <summary>
        /// Calculates the number of male wrestlers
        /// </summary>
        /// <returns>The amount of male wrestlers</returns>
        private int calcMaleWrestler()
        {
            int mCounter = 0;

            for (i = 0; i < w.Count; i++)
            {
                if (w[i].getGender() == "Male")
                {
                    mCounter++;
                }
            }
            return mCounter;
        }

        /// <summary>
        /// Calculates the number of male coaches
        /// </summary>
        /// <returns>The amount of male coaches</returns>
        private int calcMaleCoach()
        {
            int mCounter = 0;

            for (i = 0; i < c.Count; i++)
            {
                if (c[i].getGender() == "Male")
                {
                    mCounter++;
                }
            }
            return mCounter;
        }

        /// <summary>
        /// Calculates the number of hands-on coaches
        /// </summary>
        /// <returns>The amount of hands-on coaches</returns>
        private int calcHandOnCoach()
        {
            int hCounter = 0;

            for (i = 0; i < c.Count; i++)
            {
                if (c[i].getType() == "Hands-on")
                {
                    hCounter++;
                }
            }
            return hCounter;
        }

        /// <summary>
        /// Calculates the teams total amount of wins
        /// </summary>
        /// <returns>The total win value</returns>
        private double calcTotalWin()
        {
            double win = 0;

            for (i = 0; i < w.Count; i++)
            {
                win += w[i].getWin();
            }
            return win;
        }

        /// <summary>
        /// Calculates the teams total amount of matches played
        /// </summary>
        /// <returns>The total matches value</returns>
        private double calcTotalMatch()
        {
            double totalM = 0;

            for (i = 0; i < w.Count; i++)
            {
                totalM += w[i].getTotalMatch();
            }
            return totalM;
        }

        /// <summary>
        /// Calculates the teams win percentage in the general format; [total wins/ total matches * 100]
        /// </summary>
        /// <returns>The overall win percentage</returns>
        private double calcWinPercentage()
        {
            double winP = Math.Round(totalWin / totalMatch * 100, 2);

            //Checks for NaN cases (Not a Number)
            if (winP != winP)
            {
                return 0;
            }
            else
            {
                return winP;
            }
        }

        /// <summary>
        /// Calculates the teams total amount of points acheived
        /// </summary>
        /// <returns>The total points variable</returns>
        private double calcTotalPoint()
        {
            double totalP = 0;

            for (i = 0; i < w.Count; i++)
            {
                totalP += w[i].getTotalPoint();
            }
            return totalP;
        }

        /// <summary>
        /// Seperates the list of wresters based on their gender
        /// </summary>
        private void genderSeperator()
        {
            for (i = 0; i < w.Count; i++)
            {
                if (w[i].getGender() == "Male")
                {
                    maleWrestler.Add(w[i]);
                }
                else
                {
                    femaleWrestler.Add(w[i]);
                }
            }
        }

        /// <summary>
        /// Tracks the amount of females in each weight category
        /// </summary>
        /// <returns>An array tracking the number of females in each weight category</returns>
        private int[] femaleCategoryCount()
        {
            int[] femaleCounter = new int[data.femaleWeights.Count()];

            for (i = 0; i < femaleWrestler.Count(); i++)
            {
                for (j = 0; j < data.femaleWeights.Count(); j++)
                {
                    if (data.femaleWeights[j] == femaleWrestler[i].getWeightGroup())
                    {
                        femaleCounter[j]++;
                    }
                }
            }
            return femaleCounter;
        }

        /// <summary>
        /// Tracks the amount of males in each weight category
        /// </summary>
        /// <returns>An array tracking the number of males in each weight category</returns>
        private int[] maleCategoryCount()
        {
            int[] maleCounter = new int[data.maleWeights.Count()];

            for (i = 0; i < maleWrestler.Count(); i++)
            {
                for (j = 0; j < data.maleWeights.Count(); j++)
                {
                    if (data.maleWeights[j] == maleWrestler[i].getWeightGroup())
                    {
                        maleCounter[j]++;
                    }
                }
            }
            return maleCounter;
        }

        /// <summary>
        /// Tracks the amount of wrestlers in each weight category
        /// </summary>
        /// <returns>An array tracking the number of wrestlers in each weight category</returns>
        private int[] allCategoryCount()
        {
            int[] allCounter = new int[data.allWeights.Count()];

            for (i = 0; i < w.Count(); i++)
            {
                for (j = 0; j < data.allWeights.Count(); j++)
                {
                    if (data.allWeights[j] == w[i].getWeightGroup())
                    {
                        allCounter[j]++;
                    }
                }
            }
            return allCounter;
        }

        /// <summary>
        /// Seperates the wrestler list based on their uniform sign out
        /// </summary>
        private void uniformSignOutList()
        {
            for (i = 0; i < w.Count; i++)
            {
                if (w[i].getUniform() == "True")
                {
                    uniformWrestler.Add(w[i]);
                }
            }
        }
        #endregion

        #region Get Variable Value
        /// <summary>
        /// Gets the number of members in the team
        /// </summary>
        /// <returns>The number of member variable</returns>
        public string getNumMember()
        {
            return Convert.ToString(c.Count + w.Count);
        }

        /// <summary>
        /// Getrs the number of wrestlers in the team
        /// </summary>
        /// <returns>The number of wrestler variable</returns>
        public string getNumWrestler()
        {
            return Convert.ToString(w.Count);
        }

        /// <summary>
        /// Gets the number of male wrestlers in the team
        /// </summary>
        /// <returns></returns>
        public string getNumMaleWrestler()
        {
            return Convert.ToString(numMaleWrestler);
        }

        /// <summary>
        /// Gets the number of female wrestlers in the team
        /// </summary>
        /// <returns>The number of female wrestler variable</returns>
        public string getNumFemaleWrestler()
        {
            return Convert.ToString(w.Count - numMaleWrestler);
        }

        /// <summary>
        /// Gets the number of coaches in the team
        /// </summary>
        /// <returns></returns>
        public string getNumCoach()
        {
            return Convert.ToString(c.Count);
        }

        /// <summary>
        /// Gets the number of male coaches in the team
        /// </summary>
        /// <returns>The number of male coach variable</returns>
        public string getNumMaleCoach()
        {
            return Convert.ToString(numMaleCoach);
        }

        /// <summary>
        /// Gets the number of female coaches in the team
        /// </summary>
        /// <returns>The number of female coach variable</returns>
        public string getNumFemaleCoach()
        {
            return Convert.ToString(c.Count - numMaleCoach);
        }

        /// <summary>
        /// Gets the number of hands-on coaches in the team
        /// </summary>
        /// <returns>The number of hands-on coach variable</returns>
        public string getNumHandsOn()
        {
            return Convert.ToString(numHandOnCoach);
        }

        /// <summary>
        /// Gets the number of support coaches in the team
        /// </summary>
        /// <returns>The number of support coach variable</returns>
        public string getNumSupport()
        {
            return Convert.ToString(c.Count - numHandOnCoach);
        }

        /// <summary>
        /// Gets the total win in the team
        /// </summary>
        /// <returns>The total amount of wins achieved by the team</returns>
        public string getTotalWin()
        {
            return Convert.ToString(totalWin);
        }


        /// <summary>
        /// Gets the total loss in the team
        /// </summary>
        /// <returns>The total amount of losses achieved by the team</returns>
        public string getTotalLose()
        {
            return Convert.ToString(totalMatch - totalWin);
        }

        /// <summary>
        /// Gets the teams win percentage
        /// </summary>
        /// <returns>The win percentage value along with a percent sign</returns>
        public string getTotalWinPercentage()
        {
            return Convert.ToString(calcWinPercentage()) + "%";
        }

        /// <summary>
        /// Gets the teams loss percentage
        /// </summary>
        /// <returns>The loss percentage value along with a percent sign</returns>
        public string getTotalLosePercentage()
        {
            if (totalWinPercentage != 0)
            {
                return Convert.ToString(100 - totalWinPercentage) + "%";
            }
            else
            {
                return "0%";
            }
        }

        /// <summary>
        /// Gets The total amount of points achieved by the team
        /// </summary>
        /// <returns>The total points variable</returns>
        public string getTotalPoint()
        {
            return Convert.ToString(totalPoint);
        }

        /// <summary>
        /// Gets the total amount of pins achieved by the team
        /// </summary>
        /// <returns>The pin total varaible</returns>
        public string getTotalPin()
        {
            int pinTotal = 0;

            for (i = 0; i < w.Count; i++)
            {
                pinTotal += w[i].getPinWin();
            }

            return Convert.ToString(pinTotal);
        }

        /// <summary>
        /// Gets the total amount of matches the team participated in
        /// </summary>
        /// <returns>The total match variable</returns>
        public string getTotalMatch()
        {
            return Convert.ToString(totalMatch);
        }

        /// <summary>
        /// Gets the average amount of points the team achieves 
        /// each match in the general format; [total points/ total matches]
        /// </summary>
        /// <returns>The total average variable</returns>
        public string getTotalAverage()
        {
            double totalA = Math.Round(totalPoint / totalMatch, 2);

            //Checks for NaN cases (Not a Number)
            if (totalA != totalA)
            {
                return "0";
            }
            else
            {
                return Convert.ToString(totalA);
            }      
        }

        /// <summary>
        /// Gets the number of male wrestlers in a specific weight category
        /// </summary>
        /// <param name="i">The index of the weight category requested</param>
        /// <returns>The number of male wrestlers within that weight category</returns>
        public int getMaleCounter(int i)
        {
            return maleWCounter[i];
        }

        /// <summary>
        /// Gets the number of female wrestlers in a specific weight category
        /// </summary>
        /// <param name="i">The index of the weight category requested</param>
        /// <returns>The number of female wrestlers within that weight category</returns>
        public int getFemaleCounter(int i)
        {
            return femaleWCounter[i];
        }

        /// <summary>
        /// Gets the number of wrestlers in a specific weight category
        /// </summary>
        /// <param name="i">The index of the weight category requested</param>
        /// <returns>The number of wrestlers within that weight category</returns>
        public int getAllCounter(int i)
        {
            return allWCounter[i];
        }

        /// <summary>
        /// Creates a user friendly string of the wrestler requested
        /// </summary>
        /// <param name="i">The index of the wrestler within the list</param>
        /// <returns>A string properly displaying a wrestlers information to the user</returns>
        public string getListUniform(int i)
        {
            return ("Wrestler," + uniformWrestler[i].getLastName() + "," + uniformWrestler[i].getFirstName() + "," + uniformWrestler[i].getGender() + "," + uniformWrestler[i].getSchool() + "," + uniformWrestler[i].getYearExp() + "," + uniformWrestler[i].getBirthday() + "," + uniformWrestler[i].getWeight() + "," + uniformWrestler[i].getWeightGroup() + "," + uniformWrestler[i].getWin() + "," + uniformWrestler[i].getLoss() + "," + uniformWrestler[i].getTotalPoint() + "," + uniformWrestler[i].getPinWin() + "," + uniformWrestler[i].getStatus() + "," + uniformWrestler[i].getUniform());
        }

        /// <summary>
        /// Gets the lenght of the uniformWrestler list
        /// </summary>
        /// <returns>The number of wrestlers in the uniformWrestler list</returns>
        public int getUniformLenght()
        {
            return uniformWrestler.Count;
        }
        #endregion
    }
}