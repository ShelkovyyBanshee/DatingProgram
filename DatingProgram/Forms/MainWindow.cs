using System;
using System.Windows.Forms;
using DatingProgram.Data;
using DatingProgram.Widgets;

namespace DatingProgram.Forms
{
    public partial class MainWindow : Form
    {
        // Доступ к базе данных
        private DataBase dataBase;

        // Дополнительные виджеты
        private ProfilesDataGridView profilesTable;
        private AgeFilter ageFilter;

        public MainWindow()
        {
            dataBase = DataBaseAccess.InstantiateProfilesBase();
            InitializeComponent();
            InitializeAdditionalWidgets();
            InitializeFilters();
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
            var archiveWindow = new ArchiveWindow();
            archiveWindow.ShowDialog();
        }

        private GenderFilterStatus GetGenderFilterStatus()
        {
            return checkBoxMale.Checked && checkBoxFemale.Checked ? GenderFilterStatus.NoFilter
                : (checkBoxMale.Checked ? GenderFilterStatus.Male : GenderFilterStatus.Female);
        }
    }
}
