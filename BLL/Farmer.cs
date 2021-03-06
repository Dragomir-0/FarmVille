﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Collections;

namespace BLL
{

 public partial class Farmer:Person
    {
        #region Fields
        private string userPassword;
        private string userUsername;
        #endregion

        #region Constructor


        public Farmer(string userPaswordPrm = "Qwerty1234", string UserUsernamePrm = "GameTag",
            int userID = 1, string userNamePrm = "Micheal", string userSurnamePrm = "Knight", string genderPrm = "Male", string dateOfBirthPrm = "17-06-1952")
                : base(userID, userNamePrm, userSurnamePrm, genderPrm, dateOfBirthPrm)
        {

            this.UserUsername = UserUsernamePrm;
            this.UserPassword = userPaswordPrm;
        }

        public Farmer(string userPaswordPrm = "Qwerty1234", string UserUsernamePrm = "GameTag",
                 string userNamePrm = "Micheal", string userSurnamePrm = "Knight", string genderPrm = "Male", string dateOfBirthPrm = "17-06-1952")
                 : base(userNamePrm, userSurnamePrm, genderPrm, dateOfBirthPrm)
        {
            Farmer f = new Farmer(userPaswordPrm, UserUsernamePrm);

            this.UserID = f.GetHashCode();
            this.UserUsername = UserUsernamePrm;
            this.UserPassword = userPaswordPrm;
        }

        public Farmer(string userPaswordPrm= "Qwerty1234", string UserUsernamePrm = "GameTag", 
            string userNamePrm = "Micheal", string userSurnamePrm = "Knight")
                :base (userNamePrm, userSurnamePrm)
        {
            Farmer f = new Farmer(userPaswordPrm, UserUsernamePrm);

            this.UserID = f.GetHashCode();
            this.UserUsername = UserUsernamePrm;
            this.UserPassword = userPaswordPrm;
        }
        public Farmer(string userPaswordPrm = "Qwerty1234", string UserUsernamePrm = "GameTag", string userNamePrm = "Micheal")
                : base()
        {
            this.UserUsername = UserUsernamePrm;
            this.UserPassword = userPaswordPrm;
            this.UserName = userNamePrm;
        }
        public Farmer(string userUsernamePrm = "GameTag", string userPaswordPrm = "Qwerty1234")
                : base()
        {
            this.UserUsername = userUsernamePrm;
            this.UserPassword = userPaswordPrm;
        }

        //Constructor for registration
        public Farmer(string userUsernamePrm = "GameTag")
                : base()
        {
            this.UserUsername = userUsernamePrm;
        }

        public Farmer()
        {

        }
        #endregion

        #region Properties
        public string UserUsername
        {
            get { return userUsername; }
            set { userUsername = value; }
        }


        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        #endregion

        #region override
        public override int GetHashCode()
        {
            return this.userUsername.GetHashCode() ^ userPassword.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Farmer farmer = obj as Farmer;
            if ((object)farmer == null) return false;

            return ((farmer.userPassword == this.UserPassword) && (farmer.userUsername==this.userUsername));
        }
        public bool Equal(object obj)
        {
            if (obj == null) return false;
            Farmer farmer = obj as Farmer;
            if ((object)farmer == null) return false;

            return (farmer.userUsername == this.userUsername);
        }

        public override string ToString()
        {
            return string.Format(UserID+" "+UserName+" "+UserSurname+" : "+UserUsername);
        }
        #endregion

        #region methods
        public List<Farmer> AllUsers()
        {
            Datahandler handler = new Datahandler();
            List<Farmer> list = new List<Farmer>();
            DataTable table = handler.AllUsers();
            foreach (DataRow dataItem in table.Rows)
            {
                list.Add(new Farmer(dataItem[0].ToString(), dataItem[1].ToString()));
               // list.Add(new Farmer(dataItem[0].ToString(), dataItem[1].ToString(),Convert.ToInt32(dataItem[0].ToString()),dataItem[3].ToString(), dataItem[4].ToString()));
            }
            return list;
        }

        #endregion
    }


    #region Jan
    public partial class Farmer
    {
        #region Methods
        public void InsertUser()
        {
            ArrayList userParams = new ArrayList();

            userParams.Add(this.UserID);
            userParams.Add(this.UserName);
            userParams.Add(this.UserSurname);
            userParams.Add(this.Gender);
            userParams.Add(this.UserPassword);
            userParams.Add(this.UserUsername);
            userParams.Add(this.BirthDate.convertDateToStringDDMMYYYY());

            Datahandler handler = new Datahandler();
            handler.InsertUser(userParams);
        }
        public Farmer getUserInformation()
        {
            List<Farmer> dataList = new List<Farmer>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.getUserInformation(this.UserUsername,this.UserPassword);

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                Farmer farmer =  new Farmer(dataItem["UserUsername"].ToString(),
                                           dataItem["UserPassword"].ToString());
                return farmer;
            }

            return null;
        }
        //Used to check username avability
        public List<Farmer> getUsernames()
        {
            List<Farmer> dataList = new List<Farmer>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.AllUsers();

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(
                    new Farmer(dataItem["UserUsername"].ToString()));
            }

            return dataList;
        }

        #endregion
    }
    #endregion

    #region Hermann
    public partial class Farmer
    {
        
    }
    #endregion

}



