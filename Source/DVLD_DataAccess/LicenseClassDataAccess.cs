using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class LicenseClassDataAccess {
        public static string[] GetAllLicenseClassNames_Default() =>
            DataAccessUtils.ExecuteForStringArray("SELECT ClassName FROM LicenseClasses");

        public static string[] GetAllLicenseClassNames_Arabic() =>
            DataAccessUtils.ExecuteForStringArray("SELECT ClassNameAR FROM LicenseClasses");

        public static bool FindLicenseClass(byte licenseClassID, ref string className, ref string classNameAR, ref string classDescription, ref string classDescriptionAR, ref byte minimumAllowedAge, ref byte defaultValidityLength, ref decimal classFees) {
            const string QUERY = "SELECT TOP 1 * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            className = _reader["ClassName"] as string;
                            classNameAR = _reader["ClassNameAR"] as string;
                            classDescription = _reader["ClassDescription"] as string;
                            classDescriptionAR = _reader["ClassDescriptionAR"] as string;
                            minimumAllowedAge = (byte) _reader["MinimumAllowedAge"];
                            defaultValidityLength = (byte) _reader["DefaultValidityLength"];
                            classFees = (decimal) _reader["ClassFees"];

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

        public static DataView GetAllLicenseClasses_Arabic() =>
            DataAccessUtils.ExecuteForDataView("SELECT LicenseClassID, ClassNameAR, ClassDescriptionAR, MinimumAllowedAge, DefaultValidityLength, ClassFees FROM LicenseClasses");

        public static DataView GetAllLicenseClasses_Default() =>
            DataAccessUtils.ExecuteForDataView("SELECT LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees FROM LicenseClasses");
        
        public static bool UpdateLicenseClassData(byte licenseClassID, byte minimumAllowedAge, byte defaultValidityLength, decimal classFees) {
            const string QUERY = "UPDATE LicenseClasses SET " +
                                 "MinimumAllowedAge = @MinimumAllowedAge, DefaultValidityLength = @DefaultValidityLength, ClassFees = @ClassFees " +
                                 "WHERE LicenseClassID = @LicenseClassID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);
                _command.Parameters.AddWithValue("MinimumAllowedAge", minimumAllowedAge);
                _command.Parameters.AddWithValue("DefaultValidityLength", defaultValidityLength);
                _command.Parameters.AddWithValue("ClassFees", classFees);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static decimal GetClassFees(byte licenseClassID) {
            const string QUERY = "SELECT TOP 1 ClassFees FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                try {
                    _connection.Open();

                    return (decimal) (_command.ExecuteScalar() ?? 0);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static class Charting {
            public static DataView GetAllTimeLicenseClassesRevenues() => DataAccessUtils.ExecuteForDataView(
                @"SELECT LicenseClasses.LicenseClassID, TotalRevenue = SUM(LocalLicenses.LicenseClassPaidFees)
                FROM LicenseClasses LEFT JOIN LocalLicenses
                ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID
                GROUP BY LicenseClasses.LicenseClassID
                ORDER BY LicenseClasses.LicenseClassID"
            );

            public static DataView GetPerMonthLicenseClassesRevenues(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"SELECT 
                        	Months.{_query},
                        	TotalRevenue_SmallMotorcycles = SUM(CASE WHEN R1.LicenseClassID = 1 THEN R1.LicenseClassPaidFees ELSE 0 END),
                        	TotalRevenue_HeavyMotorcycles = SUM(CASE WHEN R1.LicenseClassID = 2 THEN R1.LicenseClassPaidFees ELSE 0 END),
                        	TotalRevenue_Ordinary = SUM(CASE WHEN R1.LicenseClassID = 3 THEN R1.LicenseClassPaidFees ELSE 0 END),
                        	TotalRevenue_Commercial = SUM(CASE WHEN R1.LicenseClassID = 4 THEN R1.LicenseClassPaidFees ELSE 0 END),
                        	TotalRevenue_Agricultural = SUM(CASE WHEN R1.LicenseClassID = 5 THEN R1.LicenseClassPaidFees ELSE 0 END),
                        	TotalRevenue_SmallMediumBuses = SUM(CASE WHEN R1.LicenseClassID = 6 THEN R1.LicenseClassPaidFees ELSE 0 END),
                        	TotalRevenue_TruckHeavyVehicles = SUM(CASE WHEN R1.LicenseClassID = 7 THEN R1.LicenseClassPaidFees ELSE 0 END),
                        	TotalRevenue = ISNULL(SUM(R1.LicenseClassPaidFees), 0)
                        FROM Months LEFT JOIN (
                        	SELECT LocalLicenses.LicenseClassID, Licenses.IssueDate, LocalLicenses.LicenseClassPaidFees
                        	FROM LocalLicenses INNER JOIN Licenses
                        	ON LocalLicenses.BaseLicenseID = Licenses.LicenseID AND LocalLicenses.LicenseClassPaidFees IS NOT NULL AND Licenses.IssueDate >= DATEFROMPARTS(@Year, 1, 1) AND Licenses.IssueDate < DATEFROMPARTS(@Year + 1, 1, 1)
                        ) R1
                        ON Months.MonthID = MONTH(R1.IssueDate)
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
