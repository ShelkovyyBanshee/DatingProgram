using System.Data;
using System.Windows.Forms;
using System;
using DatingProgram.Data;
using DatingProgram.DataTools;
using DatingProgram.Mails;

namespace DatingProgram.Forms
{
    public partial class MyMailsWindow : Form
    {
        private DataBase dataBase = DataBaseAccess.InstantiateProfilesBase();

        private int userId;
        private DataTable mails;
        private int mailsAmount;
        private int currentMailIndex;

        public MyMailsWindow(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            WindowsFirstUpdate();
        }

        private void WindowsFirstUpdate()
        { 
            UpdateActualData(true);
            UpdateWindowInterface();
            infoLabel.Text = "";
        }

        private void UpdateActualData(bool firstTime)
        {
            mails = MailCenter.GetUsersMail(userId);
            mailsAmount = mails.Rows.Count;

            if (mailsAmount == 0)
                currentMailIndex = -1;
            else if (currentMailIndex > mailsAmount)
                currentMailIndex = mailsAmount - 1;
            else if (firstTime) 
                currentMailIndex = 0;
        }
        

        private void UpdateWindowInterface()
        {
            if (mailsAmount != 0)
                mailNumberLabel.Text = $@"Письмо {currentMailIndex + 1}/{mailsAmount}";
            else
                mailNumberLabel.Text = "У вас нет новых писем";

            bool status = mailsAmount > 0;

            sendAnswerButton.Enabled = status;
            sendAnswerButton.Visible = status;
            deleteMailButton.Enabled = status;
            deleteMailButton.Visible = status;

            moveLeftButton.Enabled = status && currentMailIndex > 0;
            moveRightButton.Enabled = status && currentMailIndex < mailsAmount - 1;

            if (status)
            {
                textBox.Text = mails.Rows[currentMailIndex].Field<string>("text");
                UpdateSenderInfo();
            }

            senderLabel.Visible = status;
            senderTitleLabel.Visible = status;
            textBox.Visible = status;

            
        }

        private void UpdateSenderInfo()
        {
            dataBase.OpenConnection();

            int senderId = mails.Rows[currentMailIndex].Field<int>("senderId");

            if (DataBaseTools.IdExist(dataBase, "ActualProfiles", "regid", senderId))
            {
                DataRow row = DataBaseTools.GetRowFromTable(dataBase, "ActualProfiles", senderId);
                string name = row.Field<string>("name");
                int age = DateTimeTools.YearsBetween(row.Field<DateTime>("birthDay"), DateTime.UtcNow);
                string city = row.Field<string>("city");

                senderLabel.Text = $"{name}, {age}, {city}";
            }
            else
            {
                senderLabel.Text = "Пользователь удалил свой профиль";
                sendAnswerButton.Enabled = false;
            }

            dataBase.CloseConnection();
        }
        private void moveRightButton_Click(object sender, System.EventArgs e)
        {
            infoLabel.Text = "";
            currentMailIndex += 1;
            UpdateWindowInterface();
        }

        private void moveLeftButton_Click(object sender, System.EventArgs e)
        {
            infoLabel.Text = "";
            currentMailIndex -= 1;
            UpdateWindowInterface();
        }

        private void deleteMailButton_Click(object sender, System.EventArgs e)
        {
            if (mailsAmount != 0)
            {
                MailCenter.DeleteMail(mails.Rows[currentMailIndex].Field<int>("id"));

                if (currentMailIndex > 1 || mailsAmount == 1)
                    currentMailIndex -= 1;
                else
                    currentMailIndex += 1;

                UpdateActualData(false);
                UpdateWindowInterface();
            }
        }

        private void sendAnswerButton_Click(object sender, System.EventArgs e)
        {
            var newMailWindow = new NewMailWindow(userId,
                mails.Rows[currentMailIndex].Field<int>("senderid"));

            newMailWindow.ShowDialog();
            if (newMailWindow.MailSuccessfullyCreated)
                infoLabel.Text = "Ваше письмо успешно доставлено!";
            else
                infoLabel.Text = "";
        }
    }
}
