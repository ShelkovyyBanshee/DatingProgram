using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DatingProgram.Data;
using DatingProgram.DataTools;

namespace DatingProgram.Forms
{
    public partial class ArchiveWindow : Form
    {
        public delegate void ProfileRemovedHandler();

        public event ProfileRemovedHandler profileRemoved;

        private int ChosenId
        {
            get
            {
                if (dataGridView.CurrentRow != null)
                    return int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
                return -1;
            }
        }

        private DataBase dataBase;

        public ArchiveWindow()
        {
            dataBase = DataBaseAccess.InstantiateProfilesBase();
            InitializeComponent();
            FormsCommunicationChannel.ArchiveW = this;
        }

        // Метод, обновляющий таблицу
        public void UpdateTable()
        {
            dataBase.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Archive", dataBase.Connection);
            dataBase.CloseConnection();

            DataTable tableToShow = new DataTable();
            TableTools.FillProfilesTable(tableToShow, adapter);

            dataGridView.DataSource = tableToShow;

            emptyTableLabel.Visible = dataGridView.Rows.Count == 0;
            toActualButton.Enabled = dataGridView.Rows.Count != 0;
        }

        // Метод, вызываемый при закрытии окна
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            FormsCommunicationChannel.ArchiveW = null;
        }

        private void ArchiveWindow_Load(object sender, System.EventArgs e)
        {
            UpdateTable();
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
            DataBaseTools.RemoveAndAdd(ChosenId, dataBase, "Archive", "ActualProfiles");
            UpdateTable();
            profileRemoved.Invoke();
        }
    }
}
