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
    public class Farm
    {
        #region Fields
        private string farmName;
        private int size;
        #endregion

        #region Constructor
        public Farm(string farmNamePrm, int sizePrm)
        {
            this.FarmName = farmNamePrm;
            this.Size = sizePrm;
        }
        public Farm(string farmNamePrm)
        {
            this.FarmName = farmNamePrm;
        }
        public Farm()
        {

        }
        #endregion

        #region Properties
        public int Size
        {
            get { return size; }
            set { size = value; }
        }


        public string FarmName
        {
            get { return farmName; }
            set { farmName = value; }
        }
        #endregion

        #region override
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
        public void InsertFarm(string UserName)
        {
            ArrayList userParams = new ArrayList();

            userParams.Add(this.FarmName);
            userParams.Add(UserName);
            userParams.Add(this.Size);

            Datahandler handler = new Datahandler();
            handler.InsertFarm(userParams);
        }
        public List<Farm> getUserFarms(string userName)
        {
            List<Farm> dataList = new List<Farm>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.getUserFarms(userName);

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Farm(dataItem["FarmName"].ToString()));
            }

            return dataList;
        }
        public List<Farm> getUserFarmSize(string farmName)
        {
            this.FarmName = farmName;
            List<Farm> dataList = new List<Farm>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.getUserFarmSize(FarmName);

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Farm(dataItem["FarmSize"].ToString()));
            }

            return dataList;
        }
        #endregion

    }
}
