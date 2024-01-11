namespace DatingProgram.Forms
{
    partial class MyMailsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMailsWindow));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.mailNumberLabel = new System.Windows.Forms.Label();
            this.senderTitleLabel = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.sendAnswerButton = new System.Windows.Forms.Button();
            this.deleteMailButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(526, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "❤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "❤";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мои письма";
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveLeftButton.Location = new System.Drawing.Point(17, 75);
            this.moveLeftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(56, 48);
            this.moveLeftButton.TabIndex = 6;
            this.moveLeftButton.Text = "<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveRightButton.Location = new System.Drawing.Point(524, 75);
            this.moveRightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(56, 48);
            this.moveRightButton.TabIndex = 7;
            this.moveRightButton.Text = ">";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(17, 128);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(564, 240);
            this.textBox.TabIndex = 8;
            this.textBox.Text = "";
            // 
            // mailNumberLabel
            // 
            this.mailNumberLabel.AutoSize = true;
            this.mailNumberLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailNumberLabel.Location = new System.Drawing.Point(85, 96);
            this.mailNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mailNumberLabel.Name = "mailNumberLabel";
            this.mailNumberLabel.Size = new System.Drawing.Size(111, 26);
            this.mailNumberLabel.TabIndex = 9;
            this.mailNumberLabel.Text = "Письмо 1/1";
            // 
            // senderTitleLabel
            // 
            this.senderTitleLabel.AutoSize = true;
            this.senderTitleLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.senderTitleLabel.ForeColor = System.Drawing.Color.Purple;
            this.senderTitleLabel.Location = new System.Drawing.Point(14, 383);
            this.senderTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senderTitleLabel.Name = "senderTitleLabel";
            this.senderTitleLabel.Size = new System.Drawing.Size(135, 23);
            this.senderTitleLabel.TabIndex = 10;
            this.senderTitleLabel.Text = "Отправитель: ";
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.senderLabel.Location = new System.Drawing.Point(141, 383);
            this.senderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(300, 23);
            this.senderLabel.TabIndex = 11;
            this.senderLabel.Text = "Имя пользователя, Возраст, Город";
            // 
            // sendAnswerButton
            // 
            this.sendAnswerButton.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendAnswerButton.Location = new System.Drawing.Point(167, 472);
            this.sendAnswerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendAnswerButton.Name = "sendAnswerButton";
            this.sendAnswerButton.Size = new System.Drawing.Size(268, 50);
            this.sendAnswerButton.TabIndex = 12;
            this.sendAnswerButton.Text = "Отправить  в ответ";
            this.sendAnswerButton.UseVisualStyleBackColor = true;
            this.sendAnswerButton.Click += new System.EventHandler(this.sendAnswerButton_Click);
            // 
            // deleteMailButton
            // 
            this.deleteMailButton.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteMailButton.Location = new System.Drawing.Point(167, 417);
            this.deleteMailButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteMailButton.Name = "deleteMailButton";
            this.deleteMailButton.Size = new System.Drawing.Size(268, 50);
            this.deleteMailButton.TabIndex = 13;
            this.deleteMailButton.Text = "Удалить письмо";
            this.deleteMailButton.UseVisualStyleBackColor = true;
            this.deleteMailButton.Click += new System.EventHandler(this.deleteMailButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Purple;
            this.infoLabel.Location = new System.Drawing.Point(14, 523);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(299, 23);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.Text = "Ваше письмо успешно доставлено!";
            // 
            // MyMailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 552);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deleteMailButton);
            this.Controls.Add(this.sendAnswerButton);
            this.Controls.Add(this.senderLabel);
            this.Controls.Add(this.senderTitleLabel);
            this.Controls.Add(this.mailNumberLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MyMailsWindow";
            this.Text = "MyMailsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label mailNumberLabel;
        private System.Windows.Forms.Label senderTitleLabel;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.Button sendAnswerButton;
        private System.Windows.Forms.Button deleteMailButton;
        private System.Windows.Forms.Label infoLabel;
    }
}