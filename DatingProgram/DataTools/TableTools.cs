using System.Data;
using System;

namespace DatingProgram.DataTools
{
    internal static class TableTools
    {
        public static DataTable FillProfilesTable(DataTable table)
        {
            table.Columns.Add("Регистрационный номер");
            table.Columns.Add("Дата регистрации");
            table.Columns.Add("Пол");
            table.Columns.Add("Имя");
            table.Columns.Add("Возраст");
            table.Columns.Add("Город");
            table.Columns.Add("Информация о себе");
            table.Columns.Add("Требования к партнеру");
            return table;
        }

        public static object[] DataRowToObject(DataRow row)
        {
            var regId = row.Field<int>("regid");
            var regDate = row.Field<DateTime>("regdate");
            var gender = row.Field<String>("gender");
            var name = row.Field<String>("name");
            var age = row.Field<int>("age");
            var city = row.Field<String>("city");
            var discription = row.Field<String>("description");
            var contract = row.Field<String>("contract");

            object[] result = { regId, regDate, gender, name, age, city, discription, contract};
            return result;
        }

        public static void IncludeRow(DataTable table, DataRow row)
        {
            table.Rows.Add(DataRowToObject(row));
        }
    }
}
