using DVLD_DataAccess.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class LicenseDetentionDataAccess {
        public static int AddNewLicenseDetain(int baseLicenseID, decimal fineFees, string detainReason, DateTime detainDate, int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID) {
            const string QUERY = "INSERT INTO DetainedLicenses (BaseLicenseID, FineFees, DetainReason, DetainDate, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) " +
                "VALUES (@BaseLicenseID, @FineFees, @DetainReason, @DetainDate, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("FineFees", fineFees);
                _command.Parameters.AddWithValue("DetainReason", detainReason);
                _command.Parameters.AddWithValue("DetainDate", detainDate);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);
                _command.Parameters.AddWithValue("IsReleased", isReleased);

                if (releaseDate is null)
                    _command.Parameters.AddWithValue("ReleaseDate", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ReleaseDate", releaseDate);

                if (releasedByUserID is null)
                    _command.Parameters.AddWithValue("ReleasedByUserID", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ReleasedByUserID", releasedByUserID);

                if (releaseApplicationID is null)
                    _command.Parameters.AddWithValue("ReleaseApplicationID", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ReleaseApplicationID", releaseApplicationID);

                try {
                    _connection.Open();

                    if (_command.ExecuteNonQuery() == 0)
                        return -1;

                    return DataAccessUtils.SelectGlobalIdentity(_connection);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool CheckDetainedLicense(int baseLicenseID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM DetainedLicenses " +
                "WHERE BaseLicenseID = @BaseLicenseID AND IsReleased = 0";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindInfoByLicenseId(int baseLicenseID, ref int detainID, ref decimal fineFees, ref string detainReason, ref DateTime detainDate, ref int createdByUserID, ref bool isReleased, ref DateTime? releaseDate, ref int? releasedByUserID, ref int? releaseApplicationID) {
            const string QUERY = "SELECT TOP 1 * FROM DetainedLicenses WHERE BaseLicenseID = @BaseLicenseID ORDER BY DetainID DESC";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            detainID = (int) _reader["DetainID"];
                            fineFees = (decimal) _reader["FineFees"];
                            detainReason = _reader["DetainReason"] as string;
                            detainDate = (DateTime) _reader["DetainDate"];
                            createdByUserID = (int) _reader["CreatedByUserID"];
                            isReleased = (bool) _reader["IsReleased"];
                            releaseDate = _reader["ReleaseDate"] == DBNull.Value ? null : (DateTime?) _reader["ReleaseDate"];
                            releasedByUserID = _reader["ReleasedByUserID"] == DBNull.Value ? null : (int?) _reader["ReleasedByUserID"];
                            releaseApplicationID = _reader["ReleaseApplicationID"] == DBNull.Value ? null : (int?) _reader["ReleaseApplicationID"];

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

        public static DataTable GetAllLicenseDetains() =>
            DataAccessUtils.ExecuteForDataTable("SELECT * FROM VU_DetainedLicenses ORDER BY IsReleased ASC, LocalLicenseID ASC");

        public static bool ReleaseLicense(int detainID, int releasedByUserID, DateTime releaseDate, int releaseApplicationID) {
            const string QUERY = "UPDATE DetainedLicenses SET ReleaseDate = @ReleaseDate, " +
                "ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID, IsReleased = 1 " +
                "WHERE DetainID = @DetainID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DetainID", detainID);
                _command.Parameters.AddWithValue("ReleaseDate", releaseDate);
                _command.Parameters.AddWithValue("ReleasedByUserID", releasedByUserID);
                _command.Parameters.AddWithValue("ReleaseApplicationID", releaseApplicationID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool UpdateLicenseDetainInfo(int detainID, int baseLicenseID, decimal fineFees, string detainReason, DateTime detainDate, int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID) {
            const string QUERY = @"UPDATE DetainedLicenses SET 
                                        BaseLicenseID = @BaseLicenseID,
                                        FineFees = @FineFees,
                                        DetainReason = @DetainReason,
                                        DetainDate = @DetainDate,
                                        CreatedByUserID = @CreatedByUserID,
                                        IsReleased = @IsReleased,
                                        ReleaseDate = @ReleaseDate,
                                        ReleasedByUserID = @ReleasedByUserID,
                                        ReleaseApplicationID = @ReleaseApplicationID
                                   WHERE DetainID = @DetainID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DetainID", detainID);
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("FineFees", fineFees);
                _command.Parameters.AddWithValue("DetainReason", detainReason);
                _command.Parameters.AddWithValue("DetainDate", detainDate);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);
                _command.Parameters.AddWithValue("IsReleased", isReleased);

                if (releaseDate is null)
                    _command.Parameters.AddWithValue("ReleaseDate", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ReleaseDate", releaseDate);

                if (releasedByUserID is null)
                    _command.Parameters.AddWithValue("ReleasedByUserID", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ReleasedByUserID", releasedByUserID);

                if (releaseApplicationID is null)
                    _command.Parameters.AddWithValue("ReleaseApplicationID", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ReleaseApplicationID", releaseApplicationID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static class Charting {
            public static DataView GetAllTimeTotalFees() => DataAccessUtils.ExecuteForDataView(
                @"SELECT IsReleased, TotalFees = SUM(FineFees)
                FROM DetainedLicenses
                GROUP BY IsReleased
                ORDER BY IsReleased ASC"
            );

            public static short GetHighestYear() => DataAccessUtils.ExecuteForSmallInt("SELECT YEAR(MAX(GREATEST(DetainDate, ReleaseDate))) FROM DetainedLicenses");

            public static short GetLowestYear() => DataAccessUtils.ExecuteForSmallInt("SELECT YEAR(MIN(LEAST(DetainDate, ReleaseDate))) FROM DetainedLicenses");

            public static DataView GetPerMonthTotalFees(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"DECLARE @StartDate DATE = DATEFROMPARTS(@Year, 1, 1);
                            DECLARE @EndDate DATE = DATEFROMPARTS(@Year + 1, 1, 1);

                            WITH Data AS (
                            	SELECT MonthID = MONTH(ReleaseDate), ReleasedFees = FineFees, UnreleasedFees = 0
                            	FROM DetainedLicenses
                            	WHERE IsReleased = 1 AND ReleaseDate >= @StartDate AND ReleaseDate < @EndDate
                            	UNION ALL
                            	SELECT MonthID = MONTH(DetainDate), ReleasedFees = 0, UnreleasedFees = FineFees
                            	FROM DetainedLicenses
                            	WHERE IsReleased = 0 AND DetainDate >= @StartDate AND DetainDate < @EndDate
                            )
                            SELECT 
                            	Months.{_query}, 
                            	TotalFees_ReleasedLicenses = ISNULL(SUM(Data.ReleasedFees), 0),
                            	TotalFees_UnreleasedLicenses = ISNULL(SUM(Data.UnreleasedFees), 0),
                            	GrandTotalFees = ISNULL(SUM(Data.ReleasedFees + Data.UnreleasedFees), 0)
                            FROM Months LEFT JOIN Data
                            ON Data.MonthID = Months.MonthID
                            GROUP BY Months.MonthID, Months.{_query}
                            ORDER BY Months.MonthID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("Year", year);

                    try {
                        _connection.Open();

                        using (var _reader = _command.ExecuteReader())
                        using (var _table = new DataTable()) {
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

        public static class Reporting {
            public static DataTable GetDetentionsView(int localLicenseID, (DateTime StartDate, DateTime EndDate)? dateRange) {
                string _query = $@"SELECT 
                                	detentions.DetainID,
                                	LocalLicenses.LocalLicenseID,
                                	detentions.FineFees,
                                	detentions.DetainReason,
                                	detentions.DetainDate,
                                	CreatedBy = detainUsers.Username,
                                	IsReleased = CASE WHEN detentions.IsReleased = 1 THEN '{StringResources.yes}' ELSE '{StringResources.no}' END,
                                	detentions.ReleaseDate,
                                	ReleasedBy = releaseUsers.Username,
                                	detentions.ReleaseApplicationID
                                FROM DetainedLicenses detentions LEFT JOIN Users detainUsers
                                ON detentions.CreatedByUserID = detainUsers.UserID LEFT JOIN Users releaseUsers
                                ON detentions.ReleasedByUserID = releaseUsers.UserID INNER JOIN Licenses
                                ON detentions.BaseLicenseID = Licenses.LicenseID INNER JOIN LocalLicenses
                                ON Licenses.LicenseID = LocalLicenses.BaseLicenseID INNER JOIN Drivers
                                ON Licenses.DriverID = Drivers.DriverID
                                WHERE LocalLicenses.LocalLicenseID = @LocalLicenseID {(dateRange != null ? "AND detentions.DetainDate BETWEEN @StartDate AND @EndDate" : "")}
                                ORDER BY detentions.IsReleased ASC, detentions.DetainID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("LocalLicenseID", localLicenseID);

                    if (dateRange != null) {
                        _command.Parameters.AddWithValue("StartDate", dateRange.Value.StartDate);
                        _command.Parameters.AddWithValue("EndDate", dateRange.Value.EndDate);
                    }

                    try {
                        _connection.Open();

                        using (var _reader = _command.ExecuteReader())
                        using (var _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table;
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
