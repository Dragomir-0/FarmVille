using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Animal
    {
        #region Fields
        private int animalID;
        private string animalSpecies;
        private string animalType;
        private int animalSize;
        private int animalLifespan;
        private int animalBreedingRate;
        #endregion

        #region Constructor
        public Animal()
        {

        }
        public Animal(int animalIDPrm, string animalSpeciesPrm, string animalTypePrm, int animalSizePrm,  int animalLifespanPrm, int animalBreedingRatePrm)
        {
            this.AnimalID = animalIDPrm;
            this.AnimalSpecies = animalSpeciesPrm;
            this.AnimalType = animalTypePrm;
            this.AnimalSize = animalSizePrm;
            this.AnimalLifespan = animalLifespanPrm;
            this.AnimalBreedingRate = animalBreedingRatePrm;
        }
        public Animal(string animalSpeciesPrm, string animalTypePrm, int animalSizePrm, int animalLifespanPrm, int animalBreedingRatePrm)
        {
            this.AnimalSpecies = animalSpeciesPrm;
            this.AnimalType = animalTypePrm;
            this.AnimalSize = animalSizePrm;
            this.AnimalLifespan = animalLifespanPrm;
            this.AnimalBreedingRate = animalBreedingRatePrm;
        }
        public Animal(string animalSpeciesPrm, string animalTypePrm)
        {
            this.AnimalSpecies = animalSpeciesPrm;
            this.AnimalType = animalTypePrm;
        }
        #endregion

        #region Properties
        public int AnimalBreedingRate
        {
            get { return animalBreedingRate; }
            set { animalBreedingRate = value; }
        }


        public int AnimalLifespan
        {
            get { return animalLifespan; }
            set { animalLifespan = value; }
        }


        public int AnimalSize
        {
            get { return animalSize; }
            set { animalSize = value; }
        }

        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public string AnimalSpecies
        {
            get { return animalSpecies; }
            set { animalSpecies = value; }
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
            return this.AnimalSpecies+","+this.AnimalType+","+this.AnimalSize+","+this.AnimalLifespan+","+this.AnimalBreedingRate;
        }
        #endregion

        #region Methods
        public List<Animal> getAnimalsNameAndType()
        {
            List<Animal> dataList = new List<Animal>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.getAnimalsNameAndType();

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Animal(dataItem["AnimalSpecies"].ToString(),dataItem["AnimalType"].ToString()));
            }

            return dataList;
        }

        public List<Animal> getAnimalInfo()
        {
            List<Animal> dataList = new List<Animal>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.getAnimalInfo(animalID);
            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Animal(dataItem["AnimalSpecies"].ToString(), 
                                        dataItem["AnimalType"].ToString(),
                                        int.Parse(dataItem["AnimalSize"].ToString()),
                                        int.Parse(dataItem["AnimalLifespan"].ToString()),
                                        int.Parse(dataItem["AnimalPregnancy"].ToString())));
                //hey
            }
            return dataList;
        }
        #endregion

        //WonderWorld
        //Another one added

    }
}
