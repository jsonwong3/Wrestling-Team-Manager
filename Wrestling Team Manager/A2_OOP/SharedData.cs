//Project Name	: A2_OOP
//File Name		: SharedData
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 20 2017
//Description	: Holds magic numbers and variables used by multiple classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_OOP
{
    class SharedData
    {
        //Sorting Categories
        public string[] coachSortMethod = new string[] {"Last Name", "Gender", "Type"};
        public string[] wrestlerSortMethod = new string[] { "Last Name", "Gender", "Wins", "Weight Group" };

        //List Box Labels
        public string coachLabel = "Coach/ Last Name/ First Name/ Gender/ School/ Years of Experiences/ Type";
        public string wrestlerLabel = "Wrestler/ Last Name/ First Name/ Gender/ School/ Years of Experiences/ Birthday/ Weight/ Weight Category/ Wins/ Losses/ Total Points/ Total Pin Wins/ Status/ Uniform Sign-out";
        public string percentageLabel = "Wrestler: Win Percentage/ Loss Percentage";
        public int sortListMaximum = 10;

        //Weight Categories
        public double[] maleWeights = new double[] { 38, 41, 44, 47.5, 51, 54, 57.5, 61, 64, 67.5, 72, 77, 83, 89, 95, 130 };
        public double[] femaleWeights = new double[] { 41, 44, 47.5, 51, 54, 57.5, 61, 64, 67.5, 72, 77, 83, 115 };
        public double[] allWeights = new double[] { 38, 41, 44, 47.5, 51, 54, 57.5, 61, 64, 67.5, 72, 77, 83, 89, 95, 115, 130 };
    }
}
