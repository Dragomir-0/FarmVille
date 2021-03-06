﻿using System;
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
    public partial class LoggedIn : Form
    {
        Farm farmHandler = new Farm();
        List<Farm> farms = new List<Farm>();
        Create_Farm frmCrate;
        Farmer farmerWorkingWith;

        private void FirstLoadImage()
        {
            SaveLoad loadImage = new SaveLoad();
            pbUserPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            LoadImage(loadImage.LoadThisChar(farmerWorkingWith));

        }

        private void LoadImage(string imageName)
        {
            pbUserPfp.Image = Image.FromFile(@"..\..\Farmers\" + imageName + ".png");
        }

        public LoggedIn(Farmer farmerRecieved)
        {

            InitializeComponent();

            farmerWorkingWith = farmerRecieved;
            farms = farmHandler.getUserFarms(farmerRecieved.UserUsername);
            cmbFarms.DataSource = farms;
            
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            frmCrate = new Create_Farm(farmerWorkingWith);
            
            frmCrate.Show();

            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();


        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SaveLoad load = new SaveLoad();

            List<string> savedData = load.LoadThis(cmbFarms.SelectedText, farmerWorkingWith);
            
            Farm farmToSend = new Farm(savedData[0], int.Parse(savedData[1]));

            DisplayFarm theForm = new DisplayFarm(farmToSend, farmerWorkingWith);
            theForm.Width = farmToSend.Size + 17;
            theForm.Height = farmToSend.Size + 40;
            theForm.Show();
            theForm.Activate();
        }

        private void characterCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void characterCreatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CharCreaterFirst creatForm = new CharCreaterFirst(farmerWorkingWith, true);
        }
    }
}
