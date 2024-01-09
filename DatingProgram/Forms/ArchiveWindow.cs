using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DatingProgram.Data;
using DatingProgram.DataTools;

namespace DatingProgram.Forms
{
    public partial class ArchiveWindow : Form
    {
        private DataBase dataBase;
        public ArchiveWindow()
        {
            dataBase = DataBaseAccess.InstantiateProfilesBase();
            InitializeComponent();
        }

        private void ArchiveWindow_Load(object sender, System.EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataBase.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Archive", dataBase.Connection);
            dataBase.CloseConnection();

            DataTable tableToShow = new DataTable();
            TableTools.FillProfilesTable(tableToShow, adapter);

            dataGridView.DataSource = tableToShow;

            emptyTableLabel.Visible = dataGridView.Rows.Count == 0;
        }

        private void updateButton_Click(object sender, System.EventArgs e)
        {
            UpdateTable();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void toActualButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
