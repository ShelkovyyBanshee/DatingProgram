using System.Data;
using System;
using System.Data.SqlClient;

namespace DatingProgram.DataTools
{
    internal static class TableTools
    {
        public static void AddColumnsToProfilesTable(DataTable table)
        {
            table.Columns.Add("Регистрационный номер");
            table.Columns.Add("Дата регистрации");
            table.Columns.Add("Пол");
            table.Columns.Add("Имя");
            table.Columns.Add("Возраст");
            table.Columns.Add("Город");
            table.Columns.Add("Информация о себе");
            table.Columns.Add("Требования к партнеру");
        }

        public static object[] DataRowToObject(DataRow row)
        {
            var regId = row.Field<int>("regid");
            var regDate = row.Field<DateTime>("regdate");
            var gender = row.Field<String>("gender");
            var name = row.Field<String>("name");
            var age = DateTimeTools.YearsBetween(row.Field<DateTime>("birthDay"), DateTime.UtcNow);
            var city = row.Field<String>("city");
            var description = row.Field<String>("description");
            var contract = row.Field<String>("contract");

            object[] result = { regId, regDate, gender, name, age, city, description, contract};
            return result;
        }

        public static void IncludeRow(DataTable table, DataRow row)
        {
            table.Rows.Add(DataRowToObject(row));
        }

        public static void FillProfilesTable(DataTable table, SqlDataAdapter adapter)
        {
            DataTable tempTable = new DataTable();
            adapter.Fill(tempTable);
            AddColumnsToProfilesTable(table);
            
            foreach (DataRow row in tempTable.Rows)
                table.Rows.Add(DataRowToObject(row));
        }
    }
}
