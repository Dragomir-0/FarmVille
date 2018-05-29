using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BLL;

namespace FarmVille
{
	public class SaveLoad
	{

		//FarmName
		//FarmMetaData

		//UserCloths
		//Farms size
		

		//Animal+Amount

		public void SaveThis(List<string> animals, Farm farm)
		{
			List<string> dataToSave = new List<string>();

			string fileDirectory = 
				Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
			string filePath = fileDirectory + farm.FarmName + "Save.txt";
			FileHandler saveData = new FileHandler(filePath);

			dataToSave.Add(farm.FarmName + Changebles.splitOn + farm.Size);
			foreach(string a in animals)
			{
				dataToSave.Add(a);
			}

			saveData.WriteDataToTXT(dataToSave);

		}

		public List<string> LoadThis(string farmName)
		{
			

			string fileDirectory = 
				Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
			string filePath = fileDirectory + farmName + "Save.txt";
			FileHandler retriveData = new FileHandler(filePath);

			

			return retriveData.ReadDataFromTXT();

		}

	}
}