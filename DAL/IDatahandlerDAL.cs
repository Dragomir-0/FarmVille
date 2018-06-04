using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;


namespace DAL
{
    interface IDatahandlerDAL
    {
        #region PushData
        //Farmer Class
        void InsertUser(ArrayList userTableInfo);
        //Farm Class
        void InsertFarm(ArrayList farmTableInfo);
        //UserFarm
        void InsertFarmAnimal(ArrayList animalTableInfo);
        void DeleteDeadAnimal(ArrayList animalTableInfo);
        void InsertNewFarmAnimal(ArrayList animalTableInfo);
       

        #endregion

        #region RetrieveData
       //Farmer Class
        DataTable getUserInformation(string userName, string userPassword);
        //Animal Class
        DataTable getAnimalsNameAndType();
        DataTable getAnimalInfo(int animalID);
        //Farm Class
        DataTable getUserFarms(string userName);
        DataTable getUserFarmSize(string farmName);
        //UserFarm Class
        DataTable getFarmAnimals(string farmName);
        


        #endregion
    }
}
