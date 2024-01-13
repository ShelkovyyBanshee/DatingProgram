using DatingProgram.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using DatingProgram.DataTools;

namespace DatingProgram.Forms
{
    public partial class NewUserWindow : Form
    {
        public bool CreatedSuccessfully => createdSuccessfully;
        
        // это надо сделать true, если запись удалось добавить
        private bool createdSuccessfully = false;

        //проверки
        private bool nameIsCorrect = true;


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

        
        private void button1_Click(object sender, EventArgs e) //добавление в базу
        {

            if (IsCorrectCity() && IsCorrectName() && IsCorrectDate())
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
                     $"INSERT INTO ActualProfiles(regid, regdate, gender, name, birthDay, city, description, contract) values(@regid, @regdate, @gender, @name, @birthDay, @city, @description, @contract)",
                     actualProfilesBase.GetConnection());
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                Command.Parameters.AddWithValue("regid", id);
                Command.Parameters.AddWithValue("regdate", localDate);
                Command.Parameters.AddWithValue("gender", Gender);
                Command.Parameters.AddWithValue("name", textBoxName.Text.ToString());
                Command.Parameters.AddWithValue("birthDay", $"{date.Month}/{date.Day}/{date.Year}");
                Command.Parameters.AddWithValue("city", textBoxCity.Text.ToString());
                Command.Parameters.AddWithValue("description", textBoxAboutMe.Text.ToString());
                Command.Parameters.AddWithValue("contract", textBoxContract.Text.ToString());

                Command.ExecuteNonQuery().ToString();
                MessageBox.Show("Вы успешно создали профиль!\nБудем рады, чтобы вы нашли себе здесь новых друзей!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                createdSuccessfully = true;
                actualProfilesBase.CloseConnection();
                Close();
            }
            else
            {
                String ErrBox = "Неверно введенные данные!!!\n";
                if (!IsCorrectCity()&& textBoxCity.Text != "")
                {
                    ErrBox += "Неправильно введён город\n";
                }
                else if (!IsCorrectCity() && textBoxCity.Text == "")
                {
                    ErrBox += "Вы не ввели данные в обязательное поле Город\n";
                }
                if (!IsCorrectName() && textBoxName.Text != "")
                {
                    ErrBox += "Неправильно введено имя\n";
                }
                else if (!IsCorrectName() && textBoxName.Text == "")
                {
                    ErrBox += "Вы не ввели данные в обязательное поле Имя\n";
                }
                if (!IsCorrectDate())
                {
                    ErrBox += "Ваш возраст должен быть больше 16 лет\n";
                }

                var res = MessageBox.Show(ErrBox, "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Cancel)
                {
                    Close();
                }
            }
   
            
        }
        //Проверка правильности заполнения данных
        private bool IsCorrectCity()
        {
            return textBoxCity.Text.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == ' ') && textBoxCity.Text != "";
        }
        private bool IsCorrectName()
        {
            return textBoxName.Text.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == ' ') && textBoxName.Text != "";
        }

        private bool IsCorrectDate()
        {
            return DateTimeTools.YearsBetween(dateTimePicker1.Value, localDate) >= 16;
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
        private void textBoxContract_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAboutMe_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUserWindow_Load(object sender, EventArgs e)
        {
        }
    }
}
