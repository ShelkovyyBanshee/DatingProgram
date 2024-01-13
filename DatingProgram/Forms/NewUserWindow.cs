using DatingProgram.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        DateTime localDate = DateTime.Now;
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
        private void button1_Click(object sender, EventArgs e) //добавление в базу
        {
            String Gender;
            if (maleChecked) //мужчина
            {
                Gender = "М";
            }
            else //женщина
            {
                Gender = "Ж";
            }
            actualProfilesBase.OpenConnection();

            SqlCommand Command = new SqlCommand(
                 $"INSERT INTO ActualProfiles(regdate, gender, name, birthDay, city, description, contract) values(@regdate, @gender, @name, @birthDay, @city, @description, @contract)",
                 actualProfilesBase.GetConnection());
            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            Command.Parameters.AddWithValue("regdate", localDate);
            Command.Parameters.AddWithValue("gender", Gender);
            Command.Parameters.AddWithValue("name", textBoxName.Text.ToString());
            Command.Parameters.AddWithValue("birthDay", $"{date.Month }/{ date.Day}/{ date.Year}");
            Command.Parameters.AddWithValue("city", textBoxCity.Text.ToString());
            Command.Parameters.AddWithValue("description", textBoxAboutMe.Text.ToString());
            Command.Parameters.AddWithValue("contract", textBoxContract.Text.ToString());


            MessageBox.Show(Command.ExecuteNonQuery().ToString());
            createdSuccessfully = true;
            
            
            
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
