using DatingProgram.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatingProgram.Forms
{
    public partial class NewUserWindow : Form
    {
        public bool CreatedSuccessfully => createdSuccessfully;
        
        // это надо сделать true, если запись удалось добавить
        private bool createdSuccessfully = false;

        private DataBase actualProfilesBase;
        private bool maleChecked;
        int id;

        public NewUserWindow(int id)
        {
            this.id = id;
            actualProfilesBase = DataBaseAccess.InstantiateProfilesBase();
            InitializeComponent();
            InitializeCheckBox();
        }

        private void InitializeCheckBox()
        {
            checkBoxMale.Checked = true;
            checkBoxFemale.Checked = false;
            maleChecked = true;
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked)
                changeFemaleCheckBoxState(CheckState.Unchecked);
            else
                changeMaleCheckBoxState(CheckState.Checked);

            maleChecked = true;
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked)
                changeMaleCheckBoxState(CheckState.Unchecked);
            else
                changeFemaleCheckBoxState(CheckState.Checked);

            maleChecked = false;
        }

        private void changeMaleCheckBoxState(CheckState newState)
        {
            checkBoxMale.CheckedChanged -= checkBoxMale_CheckedChanged;
            checkBoxMale.CheckState = newState;
            checkBoxMale.CheckedChanged += checkBoxMale_CheckedChanged;
        }

        private void changeFemaleCheckBoxState(CheckState newState)
        {
            checkBoxFemale.CheckedChanged -= checkBoxFemale_CheckedChanged;
            checkBoxFemale.CheckState = newState;
            checkBoxFemale.CheckedChanged += checkBoxFemale_CheckedChanged;
        }

        private void textBoxContract_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAboutMe_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUserWindow_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            actualProfilesBase.OpenConnection();

            SqlCommand Command = new SqlCommand("insert into ActualProfiles(regid, regdate, gender, name, birthDay, city, description, contract) values(2, '2024-01-07 12:30:30:00', N'Ж', N'Натали Портамн', '1981-06-09', N'', N'Монтесито', N'Актриса', N'Ищу сильного мужчину, на которого можно опереться')");
            Command.Parameters.Add("@regid", Convert.ToString(id));
            createdSuccessfully = true;
            Command.ExecuteNonQuery();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
