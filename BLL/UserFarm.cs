using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    class UserFarm:Farm
    {
        #region Fields
        private int animalID;
        private string animalGender;
        private string animalDateofBirth;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="farmNamePrm"></param>
        /// <param name="sizePrm"></param>
        /// <param name="animalIDPrm"></param>
        /// <param name="animalGenderPrm"></param>
        /// <param name="animalDateofBirthPrm"></param>
        public UserFarm(string farmNamePrm, int sizePrm, int animalIDPrm, string animalGenderPrm, string animalDateofBirthPrm)
           : base(farmNamePrm, sizePrm)
        {
            this.AnimalID = animalIDPrm;
            this.AnimalGender = animalGenderPrm;
            this.AnimalDateofBirth = animalDateofBirthPrm;
        }
        public UserFarm(int animalIDPrm, string animalGenderPrm, string animalDateofBirthPrm)
          : base()
        {
            this.AnimalID = animalIDPrm;
            this.AnimalGender = animalGenderPrm;
            this.AnimalDateofBirth = animalDateofBirthPrm;
        }
        public UserFarm(string farmNamePrm, int sizePrm,string animalGenderPrm, string animalDateofBirthPrm)
            :base( farmNamePrm, sizePrm)
        {
            this.AnimalGender = animalGenderPrm;
            this.AnimalDateofBirth = animalDateofBirthPrm;
        }
        public UserFarm()
            : base()
        {

        }
        #endregion

        #region Properties
        public string AnimalDateofBirth
        {
            get { return animalDateofBirth; }
            set { animalDateofBirth = value; }
        }


        public string AnimalGender
        {
            get { return animalGender; }
            set { animalGender = value; }
        }


        public int AnimalID
        {
            get { return animalID; }
            set { animalID = value; }
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region methods
        public void InsertFarmAnimal(string animalName)
        {
            ArrayList userParams = new ArrayList();

            userParams.Add(animalName);
            userParams.Add(this.AnimalGender);
            userParams.Add(this.AnimalDateofBirth);
            userParams.Add(this.FarmName);

            Datahandler handler = new Datahandler();
            handler.InsertFarm(userParams);
        }

        public List<UserFarm> getFarmAnimals()
        {
            List<UserFarm> dataList = new List<UserFarm>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.getFarmAnimals(this.FarmName);
            Farmer frm = new Farmer();

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(
                    new UserFarm(int.Parse(dataItem["AnimalID"].ToString()),
                                           dataItem["AnimalDateofBirth"].ToString(),
                                           dataItem["AnimalDateofBirth"].ToString()));
            }
            
            return dataList;
        }

        public void DeleteDeadAnimal(string animalName)
        {
            ArrayList userParams = new ArrayList();

            userParams.Add(this.FarmName);
            userParams.Add(animalName);
            userParams.Add(this.AnimalDateofBirth);

            Datahandler handler = new Datahandler();
            handler.InsertFarm(userParams);
        }

        /*
        public DateTime ConvertStringToDate(string date)
        {

        }
        */

        public string ConvertDateToString(DateTime theDate)
        {
            DateTime dateTime = theDate;
            string dateString = dateTime.convertDateToStringDDMMYYYY();
            return dateString;
        }

        #endregion
    }
}
