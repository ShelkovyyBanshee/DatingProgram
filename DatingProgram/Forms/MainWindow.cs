using System;
using System.Windows.Forms;
using DatingProgram.Data;
using DatingProgram.Widgets;

namespace DatingProgram.Forms
{
    public partial class MainWindow : Form
    {
        // Доступ к базе данных
        private DataBase actualProfilesBase;

        // Дополнительные виджеты
        private ProfilesDataGridView profilesTable;

        public MainWindow()
        {
            actualProfilesBase = DataBaseAccess.InstantiateProfilesBase();
            InitializeComponent();
            InitializeAdditionalWidgets();
        }

        private void InitializeAdditionalWidgets()
        {
            profilesTable = new ProfilesDataGridView(dataGridView);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            profilesTable.UpdateTable();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
