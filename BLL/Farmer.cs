using System;
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
      
       
        public Farmer(string userPaswordPrm = "Admin", string UserUsernamePrm = "Admin",
            int userID = 1, string userNamePrm = "Admin", string userSurnamePrm = "Ruler", string genderPrm = "Male")
                :base (userID, userNamePrm, userSurnamePrm, genderPrm)
        {
            
            this.UserUsername = UserUsernamePrm;
            this.UserPassword = userPaswordPrm;
        }

        public Farmer(string userPaswordPrm="Admin", string UserUsernamePrm = "Admin", 
            string userNamePrm = "Admin", string userSurnamePrm = "Ruler")
                :base (userNamePrm, userSurnamePrm)
        {
            Farmer f = new Farmer(userPaswordPrm, UserUsernamePrm);

            this.UserID = f.GetHashCode();
            this.UserUsername = UserUsernamePrm;
            this.UserPassword = userPaswordPrm;
        }
        public Farmer(string userPaswordPrm = "Admin", string UserUsernamePrm = "Admin", string userNamePrm = "Admin")
                : base()
        {
            this.UserUsername = UserUsernamePrm;
            this.UserPassword = userPaswordPrm;
            this.UserName = userNamePrm;
        }
        public Farmer(string userUsernamePrm = "Admin",string userPaswordPrm = "Admin")
                : base()
        {
            this.UserUsername = userUsernamePrm;
            this.UserPassword = userPaswordPrm;
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

            Datahandler handler = new Datahandler();
            handler.InsertUser(userParams);
        }
        public List<Farmer> getUserInformation()
        {
            List<Farmer> dataList = new List<Farmer>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.getUserInformation();

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(
                    new Farmer(dataItem["UserUsername"].ToString(),
                               dataItem["UserPassword"].ToString()));
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



