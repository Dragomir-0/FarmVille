using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace FarmVille
{
    public partial class Create_Farm : Form
    {
        Farmer farmerWorkingWith;

        public Create_Farm(Farmer farmerRecieved)
        {
            
            InitializeComponent();

            farmerWorkingWith = farmerRecieved;

            cmbAnimalOne.Enabled = false;
            txtAnimalAmountOne.Enabled = false;

            cmbAnimalTwo.Enabled = false;
            txtAnimalAmountTwo.Enabled = false;

            cmbAnimalThree.Enabled = false;
            txtAnimalAmountThree.Enabled = false;

            cmbAnimalFour.Enabled = false;
            txtAnimalAmountFour.Enabled = false;

            cmbAnimalFive.Enabled = false;
            txtAnimalAmountFive.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(cmbAmountOfAnimals.SelectedItem);
            switch(a)
            {
                case 2:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;

                    cmbAnimalThree.Enabled = false;
                    txtAnimalAmountThree.Enabled = false;

                    cmbAnimalFour.Enabled = false;
                    txtAnimalAmountFour.Enabled = false;

                    cmbAnimalFive.Enabled = false;
                    txtAnimalAmountFive.Enabled = false;

                    break;
                case 3:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;

                    cmbAnimalThree.Enabled = true;
                    txtAnimalAmountThree.Enabled = true;

                    cmbAnimalFour.Enabled = false;
                    txtAnimalAmountFour.Enabled = false;

                    cmbAnimalFive.Enabled = false;
                    txtAnimalAmountFive.Enabled = false;
                    break;
                case 4:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;

                    cmbAnimalThree.Enabled = true;
                    txtAnimalAmountThree.Enabled = true;

                    cmbAnimalFour.Enabled = true;
                    txtAnimalAmountFour.Enabled = true;

                    cmbAnimalFive.Enabled = false;
                    txtAnimalAmountFive.Enabled = false;
                    break;
                case 5:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;

                    cmbAnimalThree.Enabled = true;
                    txtAnimalAmountThree.Enabled = true;

                    cmbAnimalFour.Enabled = true;
                    txtAnimalAmountFour.Enabled = true;

                    cmbAnimalFive.Enabled = true;
                    txtAnimalAmountFive.Enabled = true;
                    break;
            }
        }

        private void Create_Farm_Load(object sender, EventArgs e)
        {

        }


        //Create Farm
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> dataToSave = new List<string>();

            Farm farmToSave = new Farm(txtFarmName.Text, int.Parse(txtFarmSize.Text));

            //dataToSave.Add(txtFarmName.Text + Changebles.splitOn + txtFarmSize.Text);
            SaveLoad save = new SaveLoad();
            dataToSave.Add(cmbAmountOfAnimals.SelectedText);
            switch (int.Parse(cmbAmountOfAnimals.SelectedText))
            {
                case 2:
                    dataToSave.Add(cmbAnimalOne.SelectedText + Changebles.splitOn + txtAnimalAmountOne);
                    dataToSave.Add(cmbAnimalTwo.SelectedText + Changebles.splitOn + txtAnimalAmountTwo);

                    break;

                case 3:
                    dataToSave.Add(cmbAnimalOne.SelectedText + Changebles.splitOn + txtAnimalAmountOne);
                    dataToSave.Add(cmbAnimalTwo.SelectedText + Changebles.splitOn + txtAnimalAmountTwo);
                    dataToSave.Add(cmbAnimalThree.SelectedText + Changebles.splitOn + txtAnimalAmountThree);
                    break;

                case 4:
                    dataToSave.Add(cmbAnimalOne.SelectedText + Changebles.splitOn + txtAnimalAmountOne);
                    dataToSave.Add(cmbAnimalTwo.SelectedText + Changebles.splitOn + txtAnimalAmountTwo);
                    dataToSave.Add(cmbAnimalThree.SelectedText + Changebles.splitOn + txtAnimalAmountThree);
                    dataToSave.Add(cmbAnimalFour.SelectedText + Changebles.splitOn + txtAnimalAmountFour);
                    break;

                case 5:
                    dataToSave.Add(cmbAnimalOne.SelectedText + Changebles.splitOn + txtAnimalAmountOne);
                    dataToSave.Add(cmbAnimalTwo.SelectedText + Changebles.splitOn + txtAnimalAmountTwo);
                    dataToSave.Add(cmbAnimalThree.SelectedText + Changebles.splitOn + txtAnimalAmountThree);
                    dataToSave.Add(cmbAnimalFour.SelectedText + Changebles.splitOn + txtAnimalAmountFour);
                    dataToSave.Add(cmbAnimalFive.SelectedText + Changebles.splitOn + txtAnimalAmountFive);
                    break;

                default:
                    break;
            }
            save.SaveThis(dataToSave, farmToSave);

            LoggedIn frmLogged = new LoggedIn(farmerWorkingWith);
        }

        private void btnCheckAvability_Click(object sender, EventArgs e)
        {
            List<Farm> farms = new List<Farm>();
            Farm farm = new Farm();
            //farms = farm.GetAllFarmers();
            var farmTest = from farmList
                             in farms
                             where farm.FarmName.Equals(txtFarmName.Text.ToString())
                             select farmList;
            if (farmTest != null) NameAvalible();
            if (farmTest == null) NotNameAvalible();
            if (txtFarmName == null) NotNameAvalible();
        }

        private void NameAvalible()
        {
            lblNotAvalible.Visible = false;
            lblAvalible.Visible = true;
        }

        private void NotNameAvalible()
        {
            lblNotAvalible.Visible = true;
            lblAvalible.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoggedIn frmLog = new LoggedIn(farmerWorkingWith);
            frmLog.Show();
            this.Close();
        }
    }
}
