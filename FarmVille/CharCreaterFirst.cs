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
    public partial class CharCreaterFirst : Form
    {
        Farmer farmerWorkWith;
        List<string> charNameMale = new List<string>();
        List<string> charNameFeMale = new List<string>();
        int shirt = 0;

        private void FirstLoadImage(bool exists)
        {
            SaveLoad loadImage = new SaveLoad();
            if (!exists) LoadImage("F1CB");
            if (exists) SetDefultValues(loadImage.LoadThisChar(farmerWorkWith));
            if (exists) LoadImage(loadImage.LoadThisChar(farmerWorkWith));

        }

        private void LoadImage(string imageName)
        {
            picBoxChar.Image = Image.FromFile(@"..\..\Farmers\" + imageName + ".png");
        }

        private void SetDefultValues(string charInfoBase)
        {
            charInfoBase = charInfoBase.FromCharFile();

            //Gender
            cmbGender.SelectedText = charInfoBase.SplitInfo(0);

            //Names
            cmbGender.SelectedText = charInfoBase.SplitInfo(1);

            //Shirt
            shirt = int.Parse(charInfoBase.SplitInfo(2));
            lblOutfitText.Text = charInfoBase.SplitInfo(3);
            


        }


        public CharCreaterFirst(Farmer farmerRecived, bool exists)
        {
            InitializeComponent();
            farmerWorkWith = farmerRecived;
            charNameMale.Add("Ou Piet");
            charNameMale.Add("Young John");
            charNameFeMale.Add("Ms Martha");
            charNameFeMale.Add("Bettie Boob");
            picBoxChar.SizeMode = PictureBoxSizeMode.StretchImage;
            FirstLoadImage(exists);
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedText == "Male")   { cmbChar.DataSource = charNameMale;   cmbChar.Text = "Ou Piet"; }
            if (cmbGender.SelectedText == "Female") { cmbChar.DataSource = charNameFeMale; cmbChar.Text = "Ms Martha"; }

            UpdateImage();

        }
        private void cmbChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }


        public void UpdateImage()
        {
            if (cmbChar.SelectedItem == null)
            {
                switch (shirt)
                {
                    case 0:
                        LoadImage("F1CB");
                        break;

                    case 1:
                        LoadImage("F1CG");
                        break;

                    case 2:
                        LoadImage("F1CR");
                        break;

                    default:
                        LoadImage("F1CB");
                        break;
                }
            }
            else if (cmbGender.Text.Equals("Male"))
            {
                if (cmbChar.SelectedItem == null)
                {
                    switch (shirt)
                    {
                        case 0:
                            LoadImage("F1CB");
                            break;

                        case 1:
                            LoadImage("F1CG");
                            break;

                        case 2:
                            LoadImage("F1CR");
                            break;

                        default:
                            LoadImage("F1CB");
                            break;
                    }
                }
                else if (cmbChar.SelectedText.Equals("Ou Piet"))
                {
                    switch (shirt)
                    {
                        case 0:
                            LoadImage("F1CB");
                            break;

                        case 1:
                            LoadImage("F1CG");
                            break;

                        case 2:
                            LoadImage("F1CR");
                            break;
                        
                        default:
                            LoadImage("F1CB");
                            break;
                    }
                }
                else if (cmbChar.SelectedText=="Young John")
                {
                    switch (shirt)
                    {
                        case 0:
                            LoadImage("F2CB");
                            break;

                        case 1:
                            LoadImage("F2CG");
                            break;

                        case 2:
                            LoadImage("F2CR");
                            break;

                        default:
                            LoadImage("F2CB");
                            break;
                    }
                }
            }
            else if (cmbGender.Text.Equals("Female"))
            {
                if (cmbChar.SelectedItem == null) { }
                else if (cmbChar.SelectedText.Equals("Ms Martha"))
                {
                    switch (shirt)
                    {
                        case 0:
                            LoadImage("F1CBF");
                            break;

                        case 1:
                            LoadImage("F1CGF");
                            break;

                        case 2:
                            LoadImage("F1CRF");
                            break;

                        default:
                            LoadImage("F1CBF");
                            break;
                    }
                }
                else if (cmbChar.SelectedText == "Bettie Boob")
                {
                    switch (shirt)
                    {
                        case 0:
                            LoadImage("F2CBF");
                            break;

                        case 1:
                            LoadImage("F2CGF");
                            break;

                        case 2:
                            LoadImage("F2CRF");
                            break;

                        default:
                            LoadImage("F2CBF");
                            break;
                    }
                }
            }
        }

        private void btnOutfitNext_Click(object sender, EventArgs e)
        {
                 if (shirt == 0) { lblOutfitText.Text = "Green"; shirt = 1; }
            else if (shirt == 1) { lblOutfitText.Text = " Red";  shirt = 2; }
            else if (shirt == 2) { lblOutfitText.Text = " Blue"; shirt = 0; }
        }

        private void btnOutfitPrev_Click(object sender, EventArgs e)
        {
                 if (shirt == 0) { lblOutfitText.Text = " Red";  shirt = 2; }
            else if (shirt == 1) { lblOutfitText.Text = " Blue"; shirt = 0; }
            else if (shirt == 2) { lblOutfitText.Text = "Green"; shirt = 1; }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SaveLoad saveConfig = new SaveLoad();

            string saveThis = string.Format(cmbGender.SelectedText + Changebles.splitOn + cmbChar.SelectedText + Changebles.splitOn +
                shirt.ToString());

            saveThis = saveThis.ToCharFile();

            saveConfig.SaveThisChar(saveThis, farmerWorkWith);

            
        }

        private void lblBackdropText_Click(object sender, EventArgs e)
        {

        }

        //public string CharConfig()
        //{
        //    //Gendar 
        //    //Char
        //    //Shirt
        //    //BackColour
        //    string GenCharShirBack = 

        //}
    }
}

//<add name="default" connectionString="Data Source=LAPTOP-MEJR4OCD\SQLEXPRESS;Initial Catalog=FarmingSimulator;Integrated Security=True"/>