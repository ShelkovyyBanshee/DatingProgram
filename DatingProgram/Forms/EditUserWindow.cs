using DatingProgram.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatingProgram.DataTools;
using System.Linq;
using System.Data.SqlTypes;

namespace DatingProgram.Forms
{
    public partial class EditUserWindow : Form
    {
        public bool EditedSuccessfully => editedSuccessfully;

        // Если пользователь внёс изменения, должно стать true
        private bool editedSuccessfully = false;
        
        private DataBase actualProfilesBase;
        DateTime localDate = DateTime.Now;
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
            actualProfilesBase.OpenConnection();
            // тут по id из таблицы ActualProfiles надо достать нужную запись и перенести значения в поля для ввода
            var Row = DataBaseTools.GetRowFromTable(actualProfilesBase, "ActualProfiles", id);

            String name = Row.Field<String>("name");
            DateTime birthDay = Row.Field<DateTime>("birthDay");
            String city = Row.Field<String>("city");
            String description = Row.Field<String>("description");
            String contract = Row.Field<String>("contract");
            textBoxName.Text = name;
            dateTimePicker1.Value = birthDay;
            textBoxCity.Text = city;
            textBoxAboutMe.Text = description;
            textBoxContract.Text = contract;

            actualProfilesBase.CloseConnection();
        }

        private void textBoxContract_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAboutMe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsCorrectCity() && IsCorrectDate() && IsCorrectName())
            {
                actualProfilesBase.OpenConnection();

                SqlCommand Command = new SqlCommand("UPDATE [dbo].[ActualProfiles]  SET [regdate] = regdate, [gender] = gender, [name] = @name, [birthDay] = @birthDay, [city] = @city, [description] = @description, [contract] = @contract WHERE regid = " + id + "",
                    actualProfilesBase.GetConnection());
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                Command.Parameters.AddWithValue("name", textBoxName.Text.ToString());
                Command.Parameters.AddWithValue("birthDay", $"{date.Month}/{date.Day}/{date.Year}");
                Command.Parameters.AddWithValue("city", textBoxCity.Text.ToString());
                Command.Parameters.AddWithValue("description", textBoxAboutMe.Text.ToString());
                Command.Parameters.AddWithValue("contract", textBoxContract.Text.ToString());

                Command.ExecuteNonQuery();
                MessageBox.Show("Вы успешно редактировали профиль!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                editedSuccessfully = true;
                actualProfilesBase.CloseConnection();
                Close();
            }
            else
            {
                String ErrBox = "Неверно введенные данные!!!\n";
                if (!IsCorrectCity() && textBoxCity.Text != "")
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
        //проверка правильности введенных данных
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
