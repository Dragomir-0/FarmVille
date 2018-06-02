using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	#region Exstra Math
    public partial class Calculations
    {
       
    }
    #endregion

    #region Algorithm
    public partial class Calculations
    {
       public List<string> createTheFarm(List<string> farmInfoList)
        {
            //   Farm Name   //
            //User Cloths
            //Farm Size
            //Amount of Animals
            //AnimalNameOne/Amount
            //AnimalNameTwo/Amount
            //AnimalNameThree/Amount
            //AnimalNameFour/Amount
            //AnimalNameFive/Amount

            Animal animal = new Animal();
            List<Animal> animalList = animal.getAnimalInfo();
            List<string> coOrdinateList = new List<string>();

            int biggestAnimalSize = 6 * 10;
            bool notSpace = true;
            int AnimalSize;
            int amount;
            string predatorORfood;
            string animalName;
            string animalInfo=null;
            int tempX, tempY;
            int takenX, takenY, takenSize;


            int farmSize = int.Parse(farmInfoList[1]);
            int amountOfAnimals = int.Parse(farmInfoList[2]);
            int feedingGroundSize = Convert.ToInt32(Math.Round(farmSize*0.3));
            tempX = (farmSize / 2 - (feedingGroundSize/2));
            tempY = (farmSize / 2 - (feedingGroundSize/2));

            string FeedingGroundCoOrdinates = "FeedingGround"+","+tempX+","+tempY+","+feedingGroundSize+","+"Other";
            // Name,X,Y,Size,Type
            coOrdinateList.Add(FeedingGroundCoOrdinates);

            switch (amountOfAnimals)
            {
                case 3:
                    {
                        
                    }
                    break;
                case 4: { } break;
                case 5:
                    {
                        for (int animalListNumber = 3; animalListNumber <= amountOfAnimals+2; animalListNumber++)
                        {
                            foreach (Animal item in animalList)
                            {                      //SplitInfo is a ExtentionClass
                                if (farmInfoList[animalListNumber].SplitInfo(0) == item.AnimalSpecies)
                                {
                                    animalInfo = item.ToString();
                                }
                            }
                            predatorORfood = animalInfo.SplitInfo(2);

                            if (predatorORfood == "Prey")
                            {
                                tempX = 0;
                                tempY = 0;
                                amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                for (int i = amount / 10; i > 0; i--)
                                {

                                    do
                                    {
                                        AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                        string tempCoOrdinates = null;
                                        foreach (string coOrdinateItem in coOrdinateList)
                                        {

                                            int tempSize = 10 * AnimalSize;
                                            string[] lines = coOrdinateItem.Split(',');
                                            takenX = int.Parse(lines[1]);
                                            takenY = int.Parse(lines[2]);
                                            takenSize = int.Parse(lines[3]);
                                            if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize)))
                                            {
                                                // tempX = takenX + takenSize + 1;
                                                tempY = takenY + takenSize + 1;
                                                if (tempY + tempSize > farmSize)
                                                {
                                                    tempY = 0;
                                                    tempX = tempX + 1 + biggestAnimalSize;

                                                    if (tempX + tempSize >= farmSize)
                                                    {
                                                        //There is no space
                                                    }
                                                }
                                            }
                                            else
                                            {                                                          // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }

                                        }
                                        coOrdinateList.Add(tempCoOrdinates);
                                        notSpace = false;
                                    }
                                    while (notSpace);

                                    amount -= 10;
                                }
                            }
                            else
                            {
                                if (predatorORfood == "Predator")
                                {
                                    tempX = 0;
                                    tempY = 0;
                                    amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                    for (int i = amount / 10; i > 0; i--)
                                    {

                                        do
                                        {
                                            AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                            string tempCoOrdinates = null;
                                            foreach (string coOrdinateItem in coOrdinateList)
                                            {

                                                int tempSize = 10 * AnimalSize;
                                                string[] lines = coOrdinateItem.Split(',');
                                                takenX = int.Parse(lines[1]);
                                                takenY = int.Parse(lines[2]);
                                                takenSize = int.Parse(lines[3]);
                                                if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize)))
                                                {
                                                    // tempX = takenX + takenSize + 1;
                                                    tempY = takenY + takenSize + 1;
                                                    if (tempY + tempSize > farmSize)
                                                    {
                                                        tempY = 0;
                                                        tempX = tempX + 1 + biggestAnimalSize;

                                                        if (tempX + tempSize >= farmSize)
                                                        {
                                                            //There is no space
                                                        }
                                                        else
                                                        {
                                                            // Animal Species                                 // Type Prey or Predator
                                                            tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                        }
                                                    }
                                                    else
                                                    {
                                                        // Animal Species                                 // Type Prey or Predator
                                                        tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                    }
                                                }
                                                else
                                                {                                                          // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }

                                            }
                                            coOrdinateList.Add(tempCoOrdinates);
                                            notSpace = false;
                                        }
                                        while (notSpace);

                                        amount -= 10;
                                    }
                                }
                            }
                        }

                    }
                    break;
                default:
                    { }
                    break;
            }
            return coOrdinateList;
        }


        
    }
    #endregion
}
