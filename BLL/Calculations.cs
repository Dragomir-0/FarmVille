using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class Calculations
    {

    }


    #region Algorithm
    public partial class Calculations
    {
       public void createTheFarm(List<string> farmInfoList)
        {
            //Farm Size
            //Amount of Animals
            //AnimalNameOne/Amount
            //AnimalNameTwo/Amount
            //AnimalNameThree/Amount
            //AnimalNameFour/Amount
            //AnimalNameFive/Amount

            int farmSize = int.Parse(farmInfoList[0])*10000;
            int amountOfAnimals = int.Parse(farmInfoList[1]);
            //int eatingGroundSize =int.Parse(0.6666 * farmSize);
            switch (amountOfAnimals)
            {
                case 1:
                    {
                        int AnimalSize = 2;
                        int amount = 13;
                        string preyORfood = "prey";

                        


                    } break;
                case 2: { } break;
                case 3: { } break;
                case 4: { } break;
                case 5: { } break;
                default:
                    { }
                    break;
            }

        }
    }
    #endregion
}
