using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business {
    public enum ReportTypes : byte {
        PersonHistoryReport, LocalLicenseAppDetailsReport, DriverProfileReport,
        TestAttemptsReport, LicensesDetentionReport, UserActivityReport
    }
}
