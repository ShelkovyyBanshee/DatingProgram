using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
