using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using DatingProgram.Data;
using DatingProgram.DataTools;
using DatingProgram.Widgets;

namespace DatingProgram.Forms
{
    public partial class MainWindow : Form
    {
        public delegate void ProfileMovedToArchiveHandler();
        public event ProfileMovedToArchiveHandler profileMovedToArchive;
        // Доступ к базе данных
        private DataBase dataBase;

        // Дополнительные виджеты
        private ProfilesDataGridView profilesTable;
        private AgeFilter ageFilter;

        private int ChosenId 
        { 
            get
            {
                if (dataGridView.CurrentRow != null)
                    return int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
                return -1;

            }
        }
        private string infoLabelBaseText;
        private int ActiveUserId
        {
            get
            {
                return activeUserId;
            }
            set
            {
                activeUserId = value;
                profilesTable.ActiveUserId = value;
            }
        }

        private int activeUserId;

        public MainWindow()
        {
            activeUserId = -1;
            dataBase = DataBaseAccess.InstantiateProfilesBase();
            InitializeComponent();
            InitializeAdditionalWidgets();
            InitializeFilters();
            infoLabelBaseText = infoLabel.Text;

            FormsCommunicationChannel.MainW = this;
        }

        public void UpdateTable()
        {
            profilesTable.UpdateTable();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            FormsCommunicationChannel.MainW = null;
        }

        private void InitializeAdditionalWidgets()
        {
            profilesTable = new ProfilesDataGridView(dataGridView, emptyTableLabel);

            ageFilter = new AgeFilter(numericAgeFirst, numericAgeSecond, ageLabelPart1,
                ageLabelPart2, profilesTable);
            checkBoxInterval.CheckedChanged -= checkBoxInterval_CheckedChanged;
            checkBoxInterval.Checked = true;
            checkBoxInterval.CheckedChanged += checkBoxInterval_CheckedChanged;
        }

        private void InitializeFilters()
        {
            checkBoxMale.CheckedChanged -= checkBoxMale_CheckedChanged;
            checkBoxMale.Checked = true;
            checkBoxMale.CheckedChanged += checkBoxMale_CheckedChanged;

            checkBoxFemale.CheckedChanged -= checkBoxFemale_CheckedChanged;
            checkBoxFemale.Checked = true;
            checkBoxFemale.CheckedChanged += checkBoxFemale_CheckedChanged;

            numericAgeFirst.Validated += NumericAgeFirst_Validated;
            numericAgeSecond.Validated += NumericAgeSecond_Validated;
        }

        private void NumericAgeFirst_Validated(object sender, EventArgs e)
        {
            if (numericAgeFirst.Text == "")
            {
                numericAgeFirst.Text = numericAgeFirst.Minimum.ToString();
            }
        }

        private void NumericAgeSecond_Validated(object sender, EventArgs e)
        {
            if (numericAgeSecond.Text == "")
            {
                numericAgeSecond.Text = (numericAgeFirst.Value + 1).ToString();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            profilesTable.UpdateTable();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMale.Checked && !checkBoxFemale.Checked)
            {
                checkBoxMale.CheckedChanged -= checkBoxMale_CheckedChanged;
                checkBoxMale.Checked = true;
                checkBoxMale.CheckedChanged += checkBoxMale_CheckedChanged;
            }
            else
            {
                profilesTable.SetGenderFilter(GetGenderFilterStatus());
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxFemale.Checked && !checkBoxMale.Checked)
            {
                checkBoxFemale.CheckedChanged -= checkBoxFemale_CheckedChanged;
                checkBoxFemale.Checked = true;
                checkBoxFemale.CheckedChanged += checkBoxFemale_CheckedChanged;
            }
            else
            {
                profilesTable.SetGenderFilter(GetGenderFilterStatus());
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            profilesTable.UpdateTable();
        }

        private void checkBoxCity_CheckedChanged(object sender, EventArgs e)
        {
            bool widgetsEnabled = checkBoxCity.Checked;

            cityLabel.Enabled = widgetsEnabled;
            textBoxCity.Enabled = widgetsEnabled;
            cityButton.Enabled = widgetsEnabled;

            string filter = widgetsEnabled ? textBoxCity.Text : "";
            profilesTable.SetFilterByCity(filter);
        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            profilesTable.SetFilterByCity(textBoxCity.Text);
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            if(textBoxCity.Text == "")
            {
                profilesTable.SetFilterByCity("");
            }
        }

        private void checkBoxAge_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxInterval.Enabled = checkBoxAge.Checked;
            ageFilter.SetEnabled(checkBoxAge.Checked);
        }

        private void checkBoxInterval_CheckedChanged(object sender, EventArgs e)
        {
            numericAgeSecond.ValueChanged -= numericAgeSecond_ValueChanged;
            ageFilter.SetIntervalMode(checkBoxInterval.Checked);
            numericAgeSecond.ValueChanged += numericAgeSecond_ValueChanged;
        }

        private void numericAgeFirst_ValueChanged(object sender, EventArgs e)
        {
            numericAgeFirst.ValueChanged -= numericAgeFirst_ValueChanged;
            ageFilter.BottomValueChanged();
            numericAgeFirst.ValueChanged += numericAgeFirst_ValueChanged;

        }

        private void numericAgeSecond_ValueChanged(object sender, EventArgs e)
        {
            numericAgeSecond.ValueChanged -= numericAgeSecond_ValueChanged;
            ageFilter.UpperValueChanged();
            numericAgeSecond.ValueChanged += numericAgeSecond_ValueChanged;
        }

        private void seeArchiveButton_Click(object sender, EventArgs e)
        {
            FormsCommunicationChannel.ArchiveW?.Close();

            var archiveWindow = new ArchiveWindow();
            archiveWindow.Show();
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            if (ActiveUserId == -1)
                infoLabel.Text = "Невозможно выполнить операцию удаления: Вы не вошли в профиль";
            else
            {
                DataBaseTools.RemoveAndAdd(ActiveUserId, dataBase, "ActualProfiles", "Archive");
                ActiveUserId = -1;
                infoLabel.Text = "Ваш профиль успешно отправлен в архив!";
                currentUserLabel.Text = "Пользователь не выбран";
                profilesTable.UpdateTable();
                profileMovedToArchive.Invoke();
            }
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            if (ActiveUserId != -1)
            {
                infoLabel.Text = infoLabelBaseText;
                var editWindow = new EditUserWindow(ActiveUserId);

                editWindow.ShowDialog();
                UpdateTable();
            }
            else
            {
                infoLabel.Text = "Вы не выбрали активного пользователя!";
            }

        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            if (ChosenId == -1)
                infoLabel.Text = "Выберите запись в таблице, чтобы назначить пользователя";
            else
            {
                dataBase.OpenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ActualProfiles where regid = " 
                    + ChosenId + "", dataBase.Connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataBase.CloseConnection();

                ActiveUserId = table.Rows[0].Field<int>("regid");
                currentUserLabel.Text = table.Rows[0].Field<String>("name");

                infoLabel.Text = "Пользователь успешно выбран!";
                profilesTable.UpdateTable();
            }
        }

        private void newProfileButton_Click(object sender, EventArgs e)
        {
            var actual = new DataTable();
            var archive = new DataTable();

            dataBase.OpenConnection();

            var adapterActual = new SqlDataAdapter("SELECT * FROM ActualProfiles", dataBase.Connection);
            var adapterArchive = new SqlDataAdapter("SELECT * FROM Archive", dataBase.Connection);

            adapterActual.Fill(actual);
            adapterArchive.Fill(archive);

            dataBase.CloseConnection();

            int id = actual.Rows.Count + archive.Rows.Count + 1;
            var newProfileWindow = new NewUserWindow(id);
            newProfileWindow.ShowDialog();
            if (newProfileWindow.CreatedSuccessfully)
            {
                infoLabel.Text = "Вы создали профиль и вошли в него!";
                ActiveUserId = id;
                currentUserLabel.Text = (string)DataBaseTools.GetFieldById(dataBase, "ActualProfiles", "name", id);
            }
                
            UpdateTable();
        }

        private void createMailButton_Click(object sender, EventArgs e)
        {
            if (ActiveUserId == -1)
                infoLabel.Text = "Нельзя отправить письмо, так как вы не вошли в профиль";
            else if (ChosenId == -1)
                infoLabel.Text = "Выберите человека в таблице, чтобы отправить письмо!";
            else
            {

                var sendMailWindow = new NewMailWindow(ActiveUserId, ChosenId);
                sendMailWindow.ShowDialog();

                if (sendMailWindow.MailSuccessfullyCreated)
                    infoLabel.Text = "Письмо успешно доставлено!";
            }
        }

        private void lookForMailsButton_Click(object sender, EventArgs e)
        {
            if (ActiveUserId != -1)
            {
                var myMailsWindow = new MyMailsWindow(ActiveUserId);
                myMailsWindow.ShowDialog();
            }
            else
            {
                infoLabel.Text = "Невозможно отрыть почту, так как вы не вошли в профиль";
            }
            
        }

        private GenderFilterStatus GetGenderFilterStatus()
        {
            return checkBoxMale.Checked && checkBoxFemale.Checked ? GenderFilterStatus.NoFilter
                : (checkBoxMale.Checked ? GenderFilterStatus.Male : GenderFilterStatus.Female);
        }
    }
}
