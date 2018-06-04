namespace FarmVille
{
    partial class CharCreaterFirst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxChar = new System.Windows.Forms.PictureBox();
            this.lblOutfitLable = new System.Windows.Forms.Label();
            this.lblBackdrop = new System.Windows.Forms.Label();
            this.lblBackdropText = new System.Windows.Forms.Label();
            this.lblOutfitText = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbChar = new System.Windows.Forms.ComboBox();
            this.btnOutfitNext = new System.Windows.Forms.Button();
            this.btnOutfitPrev = new System.Windows.Forms.Button();
            this.btnBackPrev = new System.Windows.Forms.Button();
            this.btnBackNest = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxChar
            // 
            this.picBoxChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxChar.Image = global::FarmVille.Properties.Resources.F1CB;
            this.picBoxChar.Location = new System.Drawing.Point(318, 23);
            this.picBoxChar.Name = "picBoxChar";
            this.picBoxChar.Size = new System.Drawing.Size(368, 396);
            this.picBoxChar.TabIndex = 0;
            this.picBoxChar.TabStop = false;
            // 
            // lblOutfitLable
            // 
            this.lblOutfitLable.AutoSize = true;
            this.lblOutfitLable.Location = new System.Drawing.Point(122, 228);
            this.lblOutfitLable.Name = "lblOutfitLable";
            this.lblOutfitLable.Size = new System.Drawing.Size(42, 17);
            this.lblOutfitLable.TabIndex = 1;
            this.lblOutfitLable.Text = "Outfit";
            // 
            // lblBackdrop
            // 
            this.lblBackdrop.AutoSize = true;
            this.lblBackdrop.Location = new System.Drawing.Point(122, 305);
            this.lblBackdrop.Name = "lblBackdrop";
            this.lblBackdrop.Size = new System.Drawing.Size(40, 17);
            this.lblBackdrop.TabIndex = 2;
            this.lblBackdrop.Text = "Farm";
            // 
            // lblBackdropText
            // 
            this.lblBackdropText.AutoSize = true;
            this.lblBackdropText.Location = new System.Drawing.Point(95, 338);
            this.lblBackdropText.Name = "lblBackdropText";
            this.lblBackdropText.Size = new System.Drawing.Size(86, 17);
            this.lblBackdropText.TabIndex = 3;
            this.lblBackdropText.Text = "Desert Farm";
            // 
            // lblOutfitText
            // 
            this.lblOutfitText.AutoSize = true;
            this.lblOutfitText.Location = new System.Drawing.Point(122, 260);
            this.lblOutfitText.Name = "lblOutfitText";
            this.lblOutfitText.Size = new System.Drawing.Size(36, 17);
            this.lblOutfitText.TabIndex = 4;
            this.lblOutfitText.Text = "Blue";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(111, 148);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(70, 17);
            this.lblCharacter.TabIndex = 5;
            this.lblCharacter.Text = "Character";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(122, 72);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(83, 92);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 9;
            this.cmbGender.Text = "Male";
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // cmbChar
            // 
            this.cmbChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbChar.FormattingEnabled = true;
            this.cmbChar.Items.AddRange(new object[] {
            "Ou Piet",
            "Young John"});
            this.cmbChar.Location = new System.Drawing.Point(83, 168);
            this.cmbChar.Name = "cmbChar";
            this.cmbChar.Size = new System.Drawing.Size(121, 24);
            this.cmbChar.TabIndex = 10;
            this.cmbChar.Text = "Ou Piet";
            this.cmbChar.SelectedIndexChanged += new System.EventHandler(this.cmbChar_SelectedIndexChanged);
            // 
            // btnOutfitNext
            // 
            this.btnOutfitNext.Location = new System.Drawing.Point(202, 253);
            this.btnOutfitNext.Name = "btnOutfitNext";
            this.btnOutfitNext.Size = new System.Drawing.Size(33, 30);
            this.btnOutfitNext.TabIndex = 11;
            this.btnOutfitNext.Text = ">";
            this.btnOutfitNext.UseVisualStyleBackColor = true;
            this.btnOutfitNext.Click += new System.EventHandler(this.btnOutfitNext_Click);
            // 
            // btnOutfitPrev
            // 
            this.btnOutfitPrev.Location = new System.Drawing.Point(41, 253);
            this.btnOutfitPrev.Name = "btnOutfitPrev";
            this.btnOutfitPrev.Size = new System.Drawing.Size(33, 30);
            this.btnOutfitPrev.TabIndex = 12;
            this.btnOutfitPrev.Text = "<";
            this.btnOutfitPrev.UseVisualStyleBackColor = true;
            this.btnOutfitPrev.Click += new System.EventHandler(this.btnOutfitPrev_Click);
            // 
            // btnBackPrev
            // 
            this.btnBackPrev.Location = new System.Drawing.Point(41, 331);
            this.btnBackPrev.Name = "btnBackPrev";
            this.btnBackPrev.Size = new System.Drawing.Size(33, 30);
            this.btnBackPrev.TabIndex = 14;
            this.btnBackPrev.Text = "<";
            this.btnBackPrev.UseVisualStyleBackColor = true;
            // 
            // btnBackNest
            // 
            this.btnBackNest.Location = new System.Drawing.Point(202, 331);
            this.btnBackNest.Name = "btnBackNest";
            this.btnBackNest.Size = new System.Drawing.Size(33, 30);
            this.btnBackNest.TabIndex = 13;
            this.btnBackNest.Text = ">";
            this.btnBackNest.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(106, 396);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // CharCreaterFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(707, 431);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnBackPrev);
            this.Controls.Add(this.btnBackNest);
            this.Controls.Add(this.btnOutfitPrev);
            this.Controls.Add(this.btnOutfitNext);
            this.Controls.Add(this.cmbChar);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblOutfitText);
            this.Controls.Add(this.lblBackdropText);
            this.Controls.Add(this.lblBackdrop);
            this.Controls.Add(this.lblOutfitLable);
            this.Controls.Add(this.picBoxChar);
            this.Name = "CharCreaterFirst";
            this.Text = "CharCreaterFirst";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxChar;
        private System.Windows.Forms.Label lblOutfitLable;
        private System.Windows.Forms.Label lblBackdrop;
        private System.Windows.Forms.Label lblBackdropText;
        private System.Windows.Forms.Label lblOutfitText;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbChar;
        private System.Windows.Forms.Button btnOutfitNext;
        private System.Windows.Forms.Button btnOutfitPrev;
        private System.Windows.Forms.Button btnBackPrev;
        private System.Windows.Forms.Button btnBackNest;
        private System.Windows.Forms.Button btnAccept;
    }
}