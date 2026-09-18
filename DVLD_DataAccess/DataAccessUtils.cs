using Salem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class DataAccessUtils {
        internal static DataTable ExecuteForDataTable(in string query) {
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader())
                    using (DataTable _table = new DataTable()) {
                        _table.Load(_reader);

                        return _table;
                    }
                } catch (Exception ex) {
                    EventLogger.LogError(ex);
                    return null;
                }
            }
        }

        internal static DataView ExecuteForDataView(in string query) {
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader())
                    using (DataTable _table = new DataTable()) {
                        _table.Load(_reader);

                        return _table.DefaultView;
                    }
                } catch (Exception ex) {
                    EventLogger.LogError(ex);
                    return null;
                }
            }
        }

        internal static short ExecuteForSmallInt(in string query) {
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                try {
                    _connection.Open();

                    return Convert.ToInt16(_command.ExecuteScalar() ?? 0);
                } catch (Exception ex) {
                    EventLogger.LogError(ex);
                    return -1;
                }
            }
        }

        internal static int ExecuteForNonQuery(in string query) {
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery();
                } catch (Exception ex) {
                    EventLogger.LogError(ex);
                    return -1;
                }
            }
        }

        internal static string[] ExecuteForStringArray(in string query) {
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                try {
                    _connection.Open();

                    var _result = new List<string>();

                    using (SqlDataReader _reader = _command.ExecuteReader())
                        while (_reader.Read())
                            _result.Add(_reader[0] as string); //This field doesn't allow NULL in the DB

                    return _result.ToArray();
                } catch (Exception ex) {
                    EventLogger.LogError(ex);
                    return null;
                }
            }
        }

        /// <summary>
        /// Returns the ID of the last-inserted record in the database.
        /// </summary>
        /// <param name="currentConnection">This connection is NOT owned by this method, it should be closed and disposed of by the owner/caller.</param>
        internal static int SelectGlobalIdentity(SqlConnection currentConnection) {
            using (SqlCommand _command = new SqlCommand("SELECT CAST (@@IDENTITY AS INT)", currentConnection)) {
                try {
                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception ex) {
                    EventLogger.LogError(ex);
                    return -1;
                }
            }
        }

        internal static bool ExecuteForBoolean(string query) {
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception ex) {
                    EventLogger.LogError(ex);
                    return false;
                }
            }
        }

        public static class Charting {
            public static DataTable GetSystemWideRevenue_Arabic() => ExecuteForDataTable("select * from VU_SystemWideRevenue_AR ORDER BY DateTime ASC");

            public static DataTable GetSystemWideRevenue_Default() => ExecuteForDataTable("select * from VU_SystemWideRevenue ORDER BY DateTime ASC");
        }
    }
}
