using DatingProgram.Data;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatingProgram.Mails
{
    internal static class MailCenter
    {
        private static DataBase dataBase = DataBaseAccess.InstantiateProfilesBase();

        public static void SendMail(int senderId, int receiverId, string text)
        {
            dataBase.OpenConnection();

            var adapter = new SqlDataAdapter("SELECT * FROM Mails", dataBase.Connection);
            var table = new DataTable();
            adapter.Fill(table);

            int mailId = table.Rows.Count + 1;
            
            var command = new SqlCommand("insert into Mails (id, senderid, receiverid, text)" +
                "values (@Id, @SenderId, @ReceiverId, @Text)", dataBase.Connection);

            command.Parameters.AddWithValue("@Id", mailId);
            command.Parameters.AddWithValue("@SenderId", senderId);
            command.Parameters.AddWithValue("@ReceiverId", receiverId);
            command.Parameters.AddWithValue("@Text", text);

            command.ExecuteNonQuery();

            dataBase.CloseConnection();
        }

        public static DataTable GetUsersMail(int userId)
        {
            dataBase.OpenConnection();

            var adapter = new SqlDataAdapter("SELECT * FROM Mails where receiverId = " + userId + "",
                dataBase.Connection);

            var result = new DataTable();
            adapter.Fill(result);

            dataBase.CloseConnection();
            return result;
        }

        public static void DeleteMail(int mailId)
        {
            dataBase.OpenConnection();

            var commandFirst = new SqlCommand("DELETE FROM Mails where id = " + mailId + "", dataBase.Connection);
            var commandSecond = new SqlCommand("update Mails set id = id - 1 where id < " + mailId + "",
                dataBase.Connection);

            commandFirst.ExecuteNonQuery();
            commandSecond.ExecuteNonQuery();

            dataBase.CloseConnection();
        }
    }
}
