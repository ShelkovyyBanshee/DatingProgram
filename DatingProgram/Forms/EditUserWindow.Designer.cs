﻿namespace DatingProgram.Forms
{
    partial class EditUserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserWindow));
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.aboutPersonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contractLabel = new System.Windows.Forms.Label();
            this.textBoxAboutMe = new System.Windows.Forms.RichTextBox();
            this.textBoxContract = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTitleLabel.Location = new System.Drawing.Point(9, 7);
            this.mainTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(425, 44);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Редактирование пофиля ";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(21, 395);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(170, 29);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Дата рождения";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(40, 71);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 29);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Имя";
            // 
            // aboutPersonLabel
            // 
            this.aboutPersonLabel.AutoSize = true;
            this.aboutPersonLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutPersonLabel.Location = new System.Drawing.Point(21, 149);
            this.aboutPersonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutPersonLabel.Name = "aboutPersonLabel";
            this.aboutPersonLabel.Size = new System.Drawing.Size(85, 29);
            this.aboutPersonLabel.TabIndex = 9;
            this.aboutPersonLabel.Text = "О себе:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Город";
            // 
            // contractLabel
            // 
            this.contractLabel.AutoSize = true;
            this.contractLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractLabel.Location = new System.Drawing.Point(21, 269);
            this.contractLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractLabel.Name = "contractLabel";
            this.contractLabel.Size = new System.Drawing.Size(257, 29);
            this.contractLabel.TabIndex = 11;
            this.contractLabel.Text = "Требования к партнёру:";
            // 
            // textBoxAboutMe
            // 
            this.textBoxAboutMe.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAboutMe.Location = new System.Drawing.Point(26, 180);
            this.textBoxAboutMe.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAboutMe.MaxLength = 150;
            this.textBoxAboutMe.Name = "textBoxAboutMe";
            this.textBoxAboutMe.Size = new System.Drawing.Size(381, 79);
            this.textBoxAboutMe.TabIndex = 13;
            this.textBoxAboutMe.Text = "";
            this.textBoxAboutMe.TextChanged += new System.EventHandler(this.textBoxAboutMe_TextChanged);
            // 
            // textBoxContract
            // 
            this.textBoxContract.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContract.Location = new System.Drawing.Point(26, 301);
            this.textBoxContract.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContract.MaxLength = 150;
            this.textBoxContract.Name = "textBoxContract";
            this.textBoxContract.Size = new System.Drawing.Size(381, 79);
            this.textBoxContract.TabIndex = 14;
            this.textBoxContract.Text = "";
            this.textBoxContract.TextChanged += new System.EventHandler(this.textBoxContract_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(99, 68);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.MaxLength = 28;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(308, 35);
            this.textBoxName.TabIndex = 15;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(99, 102);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.MaxLength = 28;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(308, 35);
            this.textBoxCity.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(61, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 400);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // EditUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(443, 609);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxContract);
            this.Controls.Add(this.textBoxAboutMe);
            this.Controls.Add(this.contractLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutPersonLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.mainTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditUserWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label aboutPersonLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contractLabel;
        private System.Windows.Forms.RichTextBox textBoxAboutMe;
        private System.Windows.Forms.RichTextBox textBoxContract;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}