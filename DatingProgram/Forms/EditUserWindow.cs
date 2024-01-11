using DatingProgram.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatingProgram.Forms
{
    public partial class EditUserWindow : Form
    {
        public bool EditedSuccessfully => editedSuccessfully;

        // Если пользователь внёс изменения, должно стать true
        private bool editedSuccessfully = false;
        
        private DataBase actualProfilesBase;
        private bool maleChecked;
        private int id;


        public EditUserWindow(int id)
        {
            this.id = id;
            actualProfilesBase = DataBaseAccess.InstantiateProfilesBase();
            InitializeComponent();
            InitializeTextFields();
        }

        private void InitializeTextFields()
        { 
            // тут по id из таблицы ActualProfiles надо достать нужную запись и перенести значения в поля для ввода
        }

        private void textBoxContract_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAboutMe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
