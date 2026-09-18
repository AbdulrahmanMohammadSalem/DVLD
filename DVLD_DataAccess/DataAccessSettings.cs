using System.Configuration;

namespace DVLD_DataAccess {
    internal static class DataAccessSettings {
        internal static readonly string ConnectionString;

        static DataAccessSettings() => ConnectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
    }
}
