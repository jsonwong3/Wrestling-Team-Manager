//Project Name	: A2_OOP
//File Name		: Memeber
//Author		: Jason Wong
//Due Date		: Feb 22 2017
//Modified Date	: Feb 22 2017
//Description	: General member constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_OOP
{
    class Member
    {
        //Class attributes
        protected string firstName;
        protected string lastName;
        protected string gender;
        protected string yearExp;
        protected string school;

        /// <summary>
        /// Constructor for an indiviual member
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="yearExp"></param>
        /// <param name="school"></param>
        public Member(string firstName, string lastName, string gender, string yearExp, string school)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.yearExp = yearExp;
            this.school = school;
        }

        #region Get Variable Value
        /// <summary>
        /// Gets the first name variable
        /// </summary>
        /// <returns>The first name given to the member</returns>
        public string getFirstName()
        {
            return firstName;
        }

        /// <summary>
        /// Gets the last name variable
        /// </summary>
        /// <returns>The last name given to the member</returns>
        public string getLastName()
        {
            return lastName;
        }

        /// <summary>
        /// Gets the member's full name in the general format; [LastnameFirstname]
        /// </summary>
        /// <returns>The full name given to the member</returns>
        public string getFullName()
        {
            return lastName + firstName;
        }

        /// <summary>
        /// Gets the gender variable
        /// </summary>
        /// <returns>The gender given to the member</returns>
        public string getGender()
        {
            return gender;
        }

        /// <summary>
        /// Gets the years of experiences variable
        /// </summary>
        /// <returns>The years of experience given to the member</returns>
        public string getYearExp()
        {
            return yearExp;
        }

        /// <summary>
        /// Gets the school variable
        /// </summary>
        /// <returns>The school name given to the member</returns>
        public string getSchool()
        {
            return school;
        }
        #endregion
    }
}
