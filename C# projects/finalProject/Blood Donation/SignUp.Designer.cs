﻿namespace Blood_Donation
{
    partial class SignUp
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
            this.bgroup = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Ph = new System.Windows.Forms.TextBox();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BloodGroup = new System.Windows.Forms.Label();
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.Passowrd = new System.Windows.Forms.Label();
            this.Confirmpasswordbox = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bgroup
            // 
            this.bgroup.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgroup.FormattingEnabled = true;
            this.bgroup.Items.AddRange(new object[] {
            "B+",
            "A-",
            "A+",
            "B-",
            "O+",
            "O-",
            "AB-",
            "AB+"});
            this.bgroup.Location = new System.Drawing.Point(217, 164);
            this.bgroup.Name = "bgroup";
            this.bgroup.Size = new System.Drawing.Size(193, 24);
            this.bgroup.TabIndex = 28;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(259, 280);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(99, 38);
            this.Back.TabIndex = 27;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(58, 280);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(100, 38);
            this.Confirm.TabIndex = 26;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Ph
            // 
            this.Ph.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ph.Location = new System.Drawing.Point(217, 201);
            this.Ph.Name = "Ph";
            this.Ph.Size = new System.Drawing.Size(193, 23);
            this.Ph.TabIndex = 25;
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(38, 203);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(73, 18);
            this.PhoneNo.TabIndex = 24;
            this.PhoneNo.Text = "PhoneNo";
            // 
            // Ad
            // 
            this.Ad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad.Location = new System.Drawing.Point(217, 235);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(193, 23);
            this.Ad.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address";
            // 
            // BloodGroup
            // 
            this.BloodGroup.AutoSize = true;
            this.BloodGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroup.Location = new System.Drawing.Point(38, 164);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.Size = new System.Drawing.Size(92, 18);
            this.BloodGroup.TabIndex = 21;
            this.BloodGroup.Text = "BloodGroup";
            // 
            // Passwordbox
            // 
            this.Passwordbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordbox.Location = new System.Drawing.Point(217, 99);
            this.Passwordbox.Name = "Passwordbox";
            this.Passwordbox.Size = new System.Drawing.Size(193, 23);
            this.Passwordbox.TabIndex = 20;
            // 
            // Passowrd
            // 
            this.Passowrd.AutoSize = true;
            this.Passowrd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passowrd.Location = new System.Drawing.Point(38, 101);
            this.Passowrd.Name = "Passowrd";
            this.Passowrd.Size = new System.Drawing.Size(78, 18);
            this.Passowrd.TabIndex = 19;
            this.Passowrd.Text = "Password";
            // 
            // Confirmpasswordbox
            // 
            this.Confirmpasswordbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmpasswordbox.Location = new System.Drawing.Point(217, 128);
            this.Confirmpasswordbox.Name = "Confirmpasswordbox";
            this.Confirmpasswordbox.Size = new System.Drawing.Size(193, 23);
            this.Confirmpasswordbox.TabIndex = 18;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(38, 130);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(133, 18);
            this.ConfirmPassword.TabIndex = 17;
            this.ConfirmPassword.Text = "ConfirmPassword";
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.Location = new System.Drawing.Point(217, 31);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(193, 23);
            this.Namebox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(217, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 23);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 330);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bgroup);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Ph);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BloodGroup);
            this.Controls.Add(this.Passwordbox);
            this.Controls.Add(this.Passowrd);
            this.Controls.Add(this.Confirmpasswordbox);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bgroup;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox Ph;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BloodGroup;
        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.Label Passowrd;
        private System.Windows.Forms.TextBox Confirmpasswordbox;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;

    }
}