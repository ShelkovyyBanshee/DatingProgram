



namespace DatingProgram.Data
{
    internal static class DataBaseAccess
    {
        public static DataBase InstantiateProfilesBase()
        {
            return new DataBase(@"Data Source=(LocalDb)\LocalDbDating;Initial Catalog=Profiles;Integrated Security=True");
        }
    }
}
