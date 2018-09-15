//Project Name	: A2_OOP
//File Name		: Coach
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 22 2017
//Description	: Coach constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_OOP
{
    class Coach : Member
    {
        //Class attributes
        private string type;

        /// <summary>
        /// Constructor for an indiviual coach
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="yearExp"></param>
        /// <param name="school"></param>
        /// <param name="type"></param>
        public Coach(string firstName, string lastName, string gender, string yearExp, string school, string type)
            : base (firstName, lastName, gender, yearExp, school)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.yearExp = yearExp;
            this.school = school;
            this.type = type;
        }

        #region Get Variable Value
        /// <summary>
        /// Gets the coach type variable
        /// </summary>
        /// <returns>The type of coach given to the coach</returns>
        public string getType()
        {
            return type;
        }
        #endregion
    }
}