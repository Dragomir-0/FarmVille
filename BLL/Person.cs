using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Person
    {
        #region Fields
        private int userID;
        private string userName;
        private string userSurname;
        private string gender;

        #endregion

        #region Constructor
        public Person(int userIDPrm = 1, string userNamePrm = "Admin", string userSurnamePrm = "Ruler", string genderPrm="Male")
        {
            this.UserID = userIDPrm;
            this.UserName = UserName;
            this.UserSurname = userSurname;
            this.Gender = genderPrm;
        }

        public Person(string userNamePrm = "Admin", string userSurnamePrm = "Ruler")
        {
           // this.UserID = userIDPrm;
            this.UserName = UserName;
            this.UserSurname = userSurname;
        }

        public Person()
        {

        }
        #endregion

        #region Properties
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string UserSurname
        {
            get { return userSurname; }
            set { userSurname = value; }
        }


        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        #endregion

        #region Override
        //public override bool EqualsUserName() { }
        #endregion

        #region Method

        #endregion





    }
}
