using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using DatingProgram.Data;

namespace DatingProgram.DataTools
{
    internal static class DataBaseTools
    {
        public static void RemoveAndAdd(int rowId, DataBase dataBase, 
            string nameRemove, string nameAdd)
        {
            dataBase.OpenConnection();

            SqlCommand removeCommand = new SqlCommand("delete from " + nameRemove 
                + " where regid = " + rowId + "", dataBase.Connection);

            SqlCommand addCommand = GenerateInsertProfileCommand(dataBase, nameAdd,
                DataBaseTools.DataRowToObject(GetRowFromTable(dataBase, nameRemove, rowId)));

            addCommand.ExecuteNonQuery();
            removeCommand.ExecuteNonQuery();

            dataBase.CloseConnection();
        }

        public static object GetFieldById(DataBase dataBase, string tableName, string fieldName, int id)
        {
            dataBase.OpenConnection();

            object result = GetRowFromTable(dataBase, tableName, id).Field<object>(fieldName);

            dataBase.CloseConnection();

            return result;
        }

        public static DataRow GetRowFromTable(DataBase dataBase, string tableName, int rowId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + tableName +
                " where regid = " + rowId + "", dataBase.Connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows[0];
        }

        public static bool IdExist(DataBase dataBase, string tableName, string idFieldName, int id)
        {
            var adapter = new SqlDataAdapter("SELECT * FROM " + tableName +
                " where " + idFieldName + " = " + id + "", dataBase.Connection);
            var table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count != 0;
        }

        private static object[] DataRowToObject(DataRow row)
        {
            var regId = row.Field<int>("regid");
            var regDate = row.Field<DateTime>("regdate");
            var gender = row.Field<String>("gender");
            var name = row.Field<String>("name");
            var birthDay = row.Field<DateTime>("birthDay");
            var city = row.Field<String>("city");
            var description = row.Field<String>("description");
            var contract = row.Field<String>("contract");

            object[] result = { regId, regDate, gender, name, birthDay, city, description, contract };
            return result;
        }

        private static SqlCommand GenerateInsertProfileCommand(DataBase dataBase, string
            tableName, object[] values)
        {
            SqlCommand commandResult = new SqlCommand("insert into " + tableName +
                " (regid, regdate, gender, name, birthDay, city, description, contract) " +
                "values (@RegId, @RegDate, @Gender, @Name, @BirthDay, @City, @Description, @Contract)",
                dataBase.Connection);

            string[] names = new string[8]{"@RegId", "@RegDate", "@Gender", "@Name", "@BirthDay", "@City",
            "@Description", "@Contract"};

            for (int i = 0; i < 8; i++)
            {
                commandResult.Parameters.AddWithValue(names[i], values[i]);
            }

            return commandResult;
        }
    }
}
