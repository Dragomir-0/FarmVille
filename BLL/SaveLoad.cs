using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

			dataToSave.Add(Farm.FarmName + Change.splitOn + Farm.FarmSize);
			foreach(string a in animals)
			{
				dataToSave.Add(a);
			}

			saveData.WriteDataToTXT(dataToSave);

		}

		public void SaveThis(List<string> animals, Farm farm)
		{
			List<string> dataToSave = new List<string>();

			string fileDirectory = 
				Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
			string filePath = fileDirectory + farm.FarmName + "Save.txt";
			FileHandler saveData = new FileHandler(filePath);

			dataToSave.Add(Farm.FarmName + ChangeAbles.splitOn + Farm.FarmSize);
			foreach(string a in animals)
			{
				dataToSave.Add(a);
			}

			saveData.WriteDataToTXT(dataToSave);

		}

	}
}