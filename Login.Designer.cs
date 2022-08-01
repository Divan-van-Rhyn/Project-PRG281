
namespace Project_PRG281
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.campusLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butLogIn = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(515, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.CausesValidation = false;
            this.usernameTextBox.Location = new System.Drawing.Point(549, 393);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.Size = new System.Drawing.Size(169, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(549, 450);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(169, 23);
            this.passwordTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_PRG281.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(518, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(518, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // campusLogo
            // 
            this.campusLogo.Image = global::Project_PRG281.Properties.Resources.BC_Logo;
            this.campusLogo.Location = new System.Drawing.Point(502, 64);
            this.campusLogo.Name = "campusLogo";
            this.campusLogo.Size = new System.Drawing.Size(238, 159);
            this.campusLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.campusLogo.TabIndex = 5;
            this.campusLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 61);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(1, 606);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1213, 22);
            this.panel3.TabIndex = 7;
            // 
            // butLogIn
            // 
            this.butLogIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butLogIn.Location = new System.Drawing.Point(518, 517);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(94, 37);
            this.butLogIn.TabIndex = 8;
            this.butLogIn.Text = "Log In";
            this.butLogIn.UseVisualStyleBackColor = true;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click_1);
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butCancel.Location = new System.Drawing.Point(624, 517);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(94, 37);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.butLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 703);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butLogIn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.campusLogo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Belgium Campus Tuckshop Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox campusLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butLogIn;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

