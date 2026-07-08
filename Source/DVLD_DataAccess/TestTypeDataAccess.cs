using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class TestTypeDataAccess {
        public static DataView GetAllTestTypes_Default() =>
            DataAccessUtils.ExecuteForDataView("SELECT TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees FROM TestTypes");

        public static DataView GetAllTestTypes_Arabic() =>
            DataAccessUtils.ExecuteForDataView("SELECT TestTypeID, TestTypeTitleAR, TestTypeDescriptionAR, TestTypeFees FROM TestTypes");

        public static bool UpdateTestTypeFees(byte testTypeID, decimal newFees) {
            const string QUERY = "UPDATE TestTypes SET TestTypeFees = @NewFees WHERE TestTypeID = @TestTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);
                _command.Parameters.AddWithValue("NewFees", newFees);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static decimal GetTestTypeFees(byte testTypeID) {
            const string QUERY = "SELECT TOP 1 TestTypeFees FROM TestTypes WHERE TestTypeID = @TestTypeID";
            
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    return (decimal) (_command.ExecuteScalar() ?? 0);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindTestType(byte testTypeID, ref string title, ref string titleAR, ref string description, ref string descriptionAR, ref decimal fees) {
            const string QUERY = "SELECT TOP 1 * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            title = _reader["TestTypeTitle"] as string;
                            titleAR = _reader["TestTypeTitleAR"] as string;
                            description = _reader["TestTypeDescription"] as string;
                            descriptionAR = _reader["TestTypeDescriptionAR"] as string;
                            fees = (decimal) _reader["TestTypeFees"];

                            return true;
                        }

                        return false;
                    }
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static string[] GetTestTypeTitles_Arabic() => DataAccessUtils.ExecuteForStringArray("SELECT TestTypeTitleAR FROM TestTypes ORDER BY TestTypeID");

        public static string[] GetTestTypeTitles_Default() => DataAccessUtils.ExecuteForStringArray("SELECT TestTypeTitle FROM TestTypes ORDER BY TestTypeID");

        public static class Charting {
            public static DataView GetAllTimeTestTypesRevenues() => DataAccessUtils.ExecuteForDataView(
                @"SELECT TestTypes.TestTypeID, TotalRevenue = SUM(TestAppointments.FeesPaid)
                FROM TestTypes LEFT JOIN TestAppointments
                ON TestAppointments.TestTypeID = TestTypes.TestTypeID
                GROUP BY TestTypes.TestTypeID"
            );

            public static DataView GetPerMonthTestTypesRevenues(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"SELECT 
                        	Months.{_query},
                        	TotalRevenue_VisionTests = SUM(CASE WHEN TestAppointments.TestTypeID = 1 THEN TestAppointments.FeesPaid ELSE 0 END),
                        	TotalRevenue_WrittenTests = SUM(CASE WHEN TestAppointments.TestTypeID = 2 THEN TestAppointments.FeesPaid ELSE 0 END),
                        	TotalRevenue_DrivingTests = SUM(CASE WHEN TestAppointments.TestTypeID = 3 THEN TestAppointments.FeesPaid ELSE 0 END),
                        	TotalRevenue = ISNULL(SUM(TestAppointments.FeesPaid), 0)
                        FROM Months LEFT JOIN TestAppointments
                        ON Months.MonthID = MONTH(TestAppointments.AppointmentDate) AND TestAppointments.AppointmentDate >= DATEFROMPARTS(@Year, 1, 1) AND TestAppointments.AppointmentDate < DATEFROMPARTS(@Year + 1, 1, 1)
                        GROUP BY Months.MonthID, Months.{_query}
                        ORDER BY Months.MonthID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("Year", year);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }
        }
    }
}
