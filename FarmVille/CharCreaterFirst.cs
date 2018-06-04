using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmVille
{
    public partial class CharCreaterFirst : Form
    {
        List<string> charNameMale = new List<string>();
        List<string> charNameFeMale = new List<string>();
        int shirt = 0;

        public CharCreaterFirst()
        {
            InitializeComponent();
            charNameMale.Add("Ou Piet");
            charNameMale.Add("Young John");
            charNameFeMale.Add("Ms Martha");
            charNameFeMale.Add("Bettie Boob");
            picBoxChar.SizeMode = PictureBoxSizeMode.StretchImage;
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
                        //Display F1CB
                        break;

                    case 1:
                        //Display F1CG
                        break;

                    case 2:
                        //Display F1CR
                        break;

                    default:
                        //Display F1CB
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
                            //Display F1CB
                            break;

                        case 1:
                            //Display F1CG
                            break;

                        case 2:
                            //Display F1CR
                            break;

                        default:
                            //Display F1CB
                            break;
                    }
                }
                else if (cmbChar.SelectedText.Equals("Ou Piet"))
                {
                    switch (shirt)
                    {
                        case 0:
                            //Display F1CB
                            break;

                        case 1:
                            //Display F1CG
                            break;

                        case 2:
                            //Display F1CR
                            break;
                        
                        default:
                            //Display F1CB
                            break;
                    }
                }
                else if (cmbChar.SelectedText=="Young John")
                {
                    switch (shirt)
                    {
                        case 0:
                            //Display F2CB
                            break;

                        case 1:
                            //Display F2CG
                            break;

                        case 2:
                            //Display F2CR
                            break;

                        default:
                            //Display F2CB
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
                            //Display F1CBF
                            break;

                        case 1:
                            //Display F1CGF
                            break;

                        case 2:
                            //Display F1CRF
                            break;

                        default:
                            //Display F1CBF
                            break;
                    }
                }
                else if (cmbChar.SelectedText == "Bettie Boob")
                {
                    switch (shirt)
                    {
                        case 0:
                            //Display F2CBF
                            break;

                        case 1:
                            //Display F2CGF
                            break;

                        case 2:
                            //Display F2CRF
                            break;

                        default:
                            //Display F2CBF
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