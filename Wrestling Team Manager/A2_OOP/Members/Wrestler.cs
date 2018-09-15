//Project Name	: A2_OOP
//File Name		: Wrestler
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 22 2017
//Description	: Wrestler constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_OOP
{
    class Wrestler : Member
    {
        //Access weight categoeries from SharedData
        SharedData data = new SharedData();

        //Class attributes
        private string birthday;
        private double weight;
        private double win;
        private double loss;
        private double winPercentage;
        private double losePercentage;
        private int pinWin;
        private double totalPoint;
        private double totalMatch;
        private double averagePoint;
        private string status;
        private string uniform;

        //Loop variable
        int i;

        /// <summary>
        /// Constructor for an indiviual wrestler
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
        public Wrestler(string firstName, string lastName, string gender, string yearExp, string school, string birthday, double weight, double win, double loss, int pinWin, double totalPoint, string status, string uniform)
            : base (firstName, lastName, gender, yearExp, school)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.yearExp = yearExp;
            this.school = school;
            this.birthday = birthday;
            this.weight = weight;
            this.win = win;
            this.loss = loss;
            this.pinWin = pinWin;
            this.totalPoint = totalPoint;
            this.status = status;
            this.uniform = uniform;
            totalMatch = calcTotalMatch();
            winPercentage = calcWinPercentage();
            losePercentage = 100 - winPercentage;
            averagePoint = calcAverage();
        }

        #region Calculations
        /// <summary>
        /// Calculates the total matches in the general format;[win + loss]
        /// </summary>
        /// <returns>The total amount of matches played</returns>
        private double calcTotalMatch()
        {
            return win + loss;
        }

        /// <summary>
        /// Calculates the win percentage in the general format; [win / total matches * 100]
        /// </summary>
        /// <returns>The win percentage value</returns>
        private double calcWinPercentage()
        {
            return Math.Round(win / totalMatch * 100, 2);
        }

        /// <summary>
        /// Calculates the average score in the general format; [total points/ total matches]
        /// </summary>
        /// <returns>The average points scored</returns>
        private double calcAverage()
        {
            return Math.Round(totalPoint / totalMatch, 2);
        }
        #endregion

        #region Get Variable Value
        /// <summary>
        /// Gets the birthday variable
        /// </summary>
        /// <returns>The birthday given to the wrestler</returns>
        public string getBirthday()
        {
            return birthday;
        }

        /// <summary>
        /// Gets the weight variable
        /// </summary>
        /// <returns>The weight given to the wrestler</returns>
        public double getWeight()
        {
            return weight;
        }

        /// <summary>
        /// Calculates and gets the weight group of the wrestler
        /// </summary>
        /// <returns>The weight group which the wrestler falls into</returns>
        public double getWeightGroup()
        {
            double weightGroup = 0;

            //Checks for gender to access appropirate weight category list
            if (gender == "Male")
            {
                for (i = data.maleWeights.Length - 1; i >= 0; i--)
                {
                    if (weight <= data.maleWeights[i])
                    {
                        weightGroup = data.maleWeights[i];
                    }
                }
            }
            else
            {
                for (i = data.femaleWeights.Length - 1; i >= 0; i--)
                {
                    if (weight <= data.femaleWeights[i])
                    {
                        weightGroup = data.femaleWeights[i];
                    }
                }
            }

            return weightGroup;
        }

        /// <summary>
        /// Gets the win variable
        /// </summary>
        /// <returns>The amount of wins the wrestler acheived</returns>
        public double getWin()
        {
            return win;
        }

        /// <summary>
        /// Gets the loss variable
        /// </summary>
        /// <returns>The amount of losses the wrestler acheived</returns>
        public double getLoss()
        {
            return loss;
        }

        /// <summary>
        /// Gets the win percentage variable
        /// </summary>
        /// <returns>The wrestler's win percentage</returns>
        public string getWinPercentage()
        {
            return Convert.ToString(winPercentage) + "%";
        }

        /// <summary>
        /// Gets the loss percentage variable
        /// </summary>
        /// <returns>The wrestler's loss percentage</returns>
        public string getLossPercentage()
        {
            return Convert.ToString(losePercentage) + "%";
        }

        /// <summary>
        /// Gets the pin win variable
        /// </summary>
        /// <returns>The amount of wins by pinning the wrestler acheived </returns>
        public int getPinWin()
        {
            return pinWin;
        }

        /// <summary>
        /// Gets the total point variable
        /// </summary>
        /// <returns>The total points achieved by the wrestler</returns>
        public double getTotalPoint()
        {
            return totalPoint;
        }

        /// <summary>
        /// Gets the total matches variable
        /// </summary>
        /// <returns>The total amount of matches the wrestler participated in</returns>
        public double getTotalMatch()
        {
            return totalMatch;
        }

        /// <summary>
        /// Gets the average point variable
        /// </summary>
        /// <returns>The average point the wrestler would score during each match</returns>
        public double getAveragePoint()
        {
            return averagePoint;
        }

        /// <summary>
        /// Gets the status variable
        /// </summary>
        /// <returns>The status given to the wrestler</returns>
        public string getStatus()
        {
            return status;
        }

        /// <summary>
        /// Gets the uniform variable
        /// </summary>
        /// <returns>The status of the uniform sign out given to the wrestler</returns>
        public string getUniform()
        {
            return uniform;
        }
        #endregion
    }
}