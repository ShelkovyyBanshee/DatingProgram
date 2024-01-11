using System.Windows.Forms;
using DatingProgram.Data;
using DatingProgram.DataTools;
using DatingProgram.Mails;

namespace DatingProgram.Forms
{
    public partial class NewMailWindow : Form
    {
        public bool MailSuccessfullyCreated => mailSuccessfullyCreated;

        private DataBase dataBase = DataBaseAccess.InstantiateProfilesBase();
        private int currentUserId;
        private int receiverId;
        private bool mailSuccessfullyCreated;

        public NewMailWindow(int currentUserId, int receiverId)
        {
            this.currentUserId = currentUserId;
            this.receiverId = receiverId;

            InitializeComponent();

            receiverNameLabel.Text = (string)DataBaseTools.GetFieldById(dataBase, "ActualProfiles", "name", receiverId);
        }

        private void sendMailButton_Click(object sender, System.EventArgs e)
        {
            MailCenter.SendMail(currentUserId, receiverId, textBox.Text);
            mailSuccessfullyCreated = true;
            this.Close();
        }
    }
}
