IF DB_ID('DVLD') IS NULL EXECUTE('CREATE DATABASE [DVLD];');
GO

USE [DVLD];
GO

IF SCHEMA_ID('dbo') IS NULL EXECUTE('CREATE SCHEMA [dbo];');
GO

CREATE  TABLE dbo.ApplicationTypes ( 
	ApplicationTypeID    tinyint      NOT NULL,
	ApplicationTypeTitle nvarchar(150) COLLATE Arabic_CI_AS     NOT NULL,
	ApplicationTypeTitleAR nvarchar(150) COLLATE Arabic_CI_AS     NOT NULL,
	ApplicationTypeFees  smallmoney      NOT NULL,
	CONSTRAINT pk_ApplicationTypes PRIMARY KEY CLUSTERED ( ApplicationTypeID  asc ) 
 );
GO

CREATE  TABLE dbo.Countries ( 
	CountryID            tinyint    IDENTITY  NOT NULL,
	CountryName          nvarchar(50) COLLATE Arabic_CI_AS     NOT NULL,
	CountryNameAR        nvarchar(50) COLLATE Arabic_CI_AS     NOT NULL,
	CONSTRAINT pk_Countries PRIMARY KEY CLUSTERED ( CountryID  asc ) 
 );
GO

CREATE  TABLE dbo.LicenseClasses ( 
	LicenseClassID       tinyint      NOT NULL,
	ClassName            nvarchar(50) COLLATE Arabic_CI_AS     NOT NULL,
	ClassNameAR          nvarchar(50) COLLATE Arabic_CI_AS     NOT NULL,
	ClassDescription     nvarchar(110) COLLATE Arabic_CI_AS     NOT NULL,
	ClassDescriptionAR   nvarchar(110) COLLATE Arabic_CI_AS     NOT NULL,
	MinimumAllowedAge    tinyint      NOT NULL,
	DefaultValidityLength tinyint      NOT NULL,
	ClassFees            smallmoney      NOT NULL,
	CONSTRAINT pk_LicenseClasses PRIMARY KEY CLUSTERED ( LicenseClassID  asc ) ,
	CONSTRAINT unq_LicenseClasses_ClassDescription UNIQUE ( ClassDescription  asc ) ,
	CONSTRAINT idx_LicenseClasses_ClassName UNIQUE ( ClassName  asc ) 
 );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- The Classes are fixed in the system. The User can only modify the MinimumAllowedAge, ValidityLength, and ClassFees.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LicenseClasses';;
GO

CREATE  TABLE dbo.Months ( 
	MonthID              tinyint      NOT NULL,
	MonthName            varchar(10) COLLATE Arabic_CI_AS     NOT NULL,
	ShortMonthName       char(3) COLLATE Arabic_CI_AS     NOT NULL,
	MonthNameAR          nvarchar(10) COLLATE Arabic_CI_AS     NOT NULL,
	CONSTRAINT PK_Months PRIMARY KEY CLUSTERED ( MonthID  asc ) 
 );
GO

CREATE  TABLE dbo.People ( 
	PersonID             int    IDENTITY  NOT NULL,
	NationalNum          char(14) COLLATE Arabic_CI_AS     NOT NULL,
	FirstName            nvarchar(20) COLLATE Arabic_CI_AS     NOT NULL,
	SecondName           nvarchar(20) COLLATE Arabic_CI_AS     NOT NULL,
	ThirdName            nvarchar(20) COLLATE Arabic_CI_AS     NULL,
	LastName             varchar(20) COLLATE Arabic_CI_AS     NOT NULL,
	Gender               char(1) COLLATE Arabic_CI_AS CONSTRAINT DF_People_Gender DEFAULT 'M'    NOT NULL,
	DateOfBirth          date      NOT NULL,
	Address              nvarchar(400) COLLATE Arabic_CI_AS     NOT NULL,
	PhoneNumber          nvarchar(16) COLLATE Arabic_CI_AS     NOT NULL,
	Email                varchar(50) COLLATE Arabic_CI_AS     NULL,
	NationalityCountryID tinyint      NOT NULL,
	ImagePath            nvarchar(250) COLLATE Arabic_CI_AS     NULL,
	CONSTRAINT pk_Person PRIMARY KEY CLUSTERED ( PersonID  asc ) 
 );
GO

CREATE UNIQUE NONCLUSTERED INDEX unq_Person ON dbo.People ( NationalNum  asc );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- This entity acts as the registered persons stored on the system that can perform applications to get a number of services provided by the system.
- It can also act as a base entity for User and Driver.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'People';;
GO

CREATE  TABLE dbo.Permissions ( 
	PermissionsID        int    IDENTITY  NOT NULL,
	People               smallint      NOT NULL,
	Users                smallint      NOT NULL,
	Drivers              smallint      NOT NULL,
	LocalDrivingLicenseApplications smallint      NOT NULL,
	InternationalDrivingLicenseApplications smallint      NOT NULL,
	Tests_TestAppointments int      NOT NULL,
	LicenseDetention     smallint      NOT NULL,
	Licenses             smallint      NOT NULL,
	Dashboard            smallint      NOT NULL,
	Reports              smallint      NOT NULL,
	LookupTables         smallint      NOT NULL,
	ApplicationSettings  smallint      NOT NULL,
	CONSTRAINT PK__Permissi__EFA6FB0F10B10485 PRIMARY KEY CLUSTERED ( PermissionsID  asc ) 
 );
GO

CREATE  TABLE dbo.TestTypes ( 
	TestTypeID           tinyint      NOT NULL,
	TestTypeTitle        nvarchar(100) COLLATE Arabic_CI_AS     NOT NULL,
	TestTypeTitleAR      nvarchar(100) COLLATE Arabic_CI_AS     NOT NULL,
	TestTypeDescription  nvarchar(400) COLLATE Arabic_CI_AS     NOT NULL,
	TestTypeDescriptionAR nvarchar(400) COLLATE Arabic_CI_AS     NOT NULL,
	TestTypeFees         smallmoney      NOT NULL,
	CONSTRAINT pk_TestTypes PRIMARY KEY CLUSTERED ( TestTypeID  asc ) 
 );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- This value can be changed by the User.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTypes', @level2type=N'COLUMN',@level2name=N'TestTypeFees';
GO

CREATE  TABLE dbo.ThemeColorPalettes ( 
	ColorPaletteID       int    IDENTITY  NOT NULL,
	BaseBackColor        char(6) COLLATE Arabic_CI_AS     NOT NULL,
	SurfaceBackColor     char(6) COLLATE Arabic_CI_AS     NOT NULL,
	BaseForeColor        char(6) COLLATE Arabic_CI_AS     NOT NULL,
	AccentForeColor      char(6) COLLATE Arabic_CI_AS     NOT NULL,
	BaseLinkColor        char(6) COLLATE Arabic_CI_AS     NOT NULL,
	InactiveForeColor    char(6) COLLATE Arabic_CI_AS     NOT NULL,
	StrongForeColor      char(6) COLLATE Arabic_CI_AS     NOT NULL,
	MainMenuStripColor   char(6) COLLATE Arabic_CI_AS     NOT NULL,
	GridHeaderCellColor  char(6) COLLATE Arabic_CI_AS     NOT NULL,
	SurfaceBorderColor   char(6) COLLATE Arabic_CI_AS     NOT NULL,
	TitleBarColorMode    tinyint      NOT NULL,
	GridHeaderCellHighlightColor char(6) COLLATE Arabic_CI_AS     NOT NULL,
	SurfaceHoverColor    char(6) COLLATE Arabic_CI_AS     NOT NULL,
	InactiveTabBackColor char(6) COLLATE Arabic_CI_AS     NOT NULL,
	DateTimePickerStyle  tinyint      NOT NULL,
	SyncTextBoxStyle     tinyint      NOT NULL,
	MenuStripItemBorderColor char(6) COLLATE Arabic_CI_AS     NOT NULL,
	MenuStripItemHoverBackColor char(6) COLLATE Arabic_CI_AS     NOT NULL,
	CONSTRAINT PK_AppThemes PRIMARY KEY CLUSTERED ( ColorPaletteID  asc ) 
 );
GO

CREATE  TABLE dbo.Themes ( 
	ThemeID              int    IDENTITY  NOT NULL,
	ThemeName            varchar(50) COLLATE Arabic_CI_AS     NOT NULL,
	LightColorPaletteID  int      NOT NULL,
	DarkColorPaletteID   int      NOT NULL,
	IsUserDefined        bit      NOT NULL,
	CONSTRAINT PK_ThemeID PRIMARY KEY CLUSTERED ( ThemeID  asc ) ,
	CONSTRAINT UNQ_ThemeName UNIQUE ( ThemeName  asc ) ,
	CONSTRAINT unq_Themes UNIQUE ( LightColorPaletteID  asc ) ,
	CONSTRAINT unq_Themes_0 UNIQUE ( DarkColorPaletteID  asc ) 
 );
GO

CREATE  TABLE dbo.Users ( 
	UserID               int    IDENTITY  NOT NULL,
	PersonID             int      NOT NULL,
	Username             varchar(14) COLLATE Arabic_CI_AS     NOT NULL,
	Password             varchar(40) COLLATE Arabic_CI_AS     NOT NULL,
	IsActive             bit      NOT NULL,
	PermissionsID        int      NOT NULL,
	CONSTRAINT pk_Users PRIMARY KEY CLUSTERED ( UserID  asc ) ,
	CONSTRAINT unq_Users_Username UNIQUE ( Username  asc ) ,
	CONSTRAINT unq_Users_PersonID UNIQUE ( PersonID  asc ) ,
	CONSTRAINT unq_Users_PermissionsID UNIQUE ( PermissionsID  asc ) 
 );
GO

CREATE  TABLE dbo.Applications ( 
	ApplicationID        int    IDENTITY  NOT NULL,
	ApplicantPersonID    int      NOT NULL,
	ApplicationTypeID    tinyint      NOT NULL,
	ApplicationDate      datetime2(2)      NOT NULL,
	ApplicationStatus    tinyint      NOT NULL,
	UpdateStatusDate     datetime2(2)      NULL,
	FeesPaid             smallmoney      NOT NULL,
	CreatedByUserID      int      NOT NULL,
	CONSTRAINT pk_ServiceRequests PRIMARY KEY CLUSTERED ( ApplicationID  asc ) 
 );
GO

CREATE NONCLUSTERED INDEX IX_Applications ON dbo.Applications ( ApplicationDate  asc, ApplicationStatus  asc );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- This entity acts as a base entity for LocalDrivingLicenseApplication.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Applications';;
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- This field is retrieved through the NationalID of the Person concened in the final product.
- If the Person concerned doesn''t already exist in the system, they should be added first.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Applications', @level2type=N'COLUMN',@level2name=N'ApplicantPersonID';
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- Can be one of the following:
   1. "New" (1),
   2. "Complete" (2), or
   3. "Cancelled" (3).' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Applications', @level2type=N'COLUMN',@level2name=N'ApplicationStatus';
GO

CREATE  TABLE dbo.Drivers ( 
	DriverID             int    IDENTITY  NOT NULL,
	PersonID             int      NOT NULL,
	CreatedByUserID      int      NOT NULL,
	DateCreated          datetime2(2)      NOT NULL,
	CONSTRAINT pk_Drivers PRIMARY KEY CLUSTERED ( DriverID  asc ) ,
	CONSTRAINT unq_Drivers UNIQUE ( PersonID  asc ) 
 );
GO

CREATE  TABLE dbo.Licenses ( 
	LicenseID            int    IDENTITY  NOT NULL,
	DriverID             int      NOT NULL,
	IssueReason          tinyint  CONSTRAINT DF_Licenses_IssueReason DEFAULT 1    NOT NULL,
	IssueDate            datetime2(2)      NOT NULL,
	ExpirationDate       datetime2(2)      NOT NULL,
	IsActive             bit  CONSTRAINT DF_Licenses_IsActive DEFAULT 1    NOT NULL,
	CreatedByUserID      int      NOT NULL,
	ApplicationID        int      NOT NULL,
	CONSTRAINT pk_Licenses PRIMARY KEY CLUSTERED ( LicenseID  asc ) ,
	CONSTRAINT unq_Licenses UNIQUE ( ApplicationID  asc ) 
 );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- This is a base entity for LocalLicense and InternationalLicense.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Licenses';;
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- Can be one of the following: 
   1. "New" (1),
   2. "Replacement for Lost" (2),
   3. "Replacement for Damaged" (3), or
   4. "Renewal" (4).

- Default value: 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Licenses', @level2type=N'COLUMN',@level2name=N'IssueReason';
GO

CREATE  TABLE dbo.LocalDrivingLicenseApplications ( 
	ApplicationID        int      NOT NULL,
	LicenseClassID       tinyint      NOT NULL,
	LocalDrivingLicenseApplicationID int    IDENTITY  NOT NULL,
	CONSTRAINT pk_LocalDrivingLicenseApplications PRIMARY KEY CLUSTERED ( LocalDrivingLicenseApplicationID  asc ) ,
	CONSTRAINT unq_LocalDrivingLicenseApplications UNIQUE ( ApplicationID  asc ) 
 );
GO

CREATE  TABLE dbo.LocalLicenses ( 
	LocalLicenseID       int    IDENTITY  NOT NULL,
	BaseLicenseID        int      NOT NULL,
	LicenseClassID       tinyint      NOT NULL,
	Notes                nvarchar(500) COLLATE Arabic_CI_AS     NULL,
	LicenseClassPaidFees smallmoney      NULL,
	CONSTRAINT pk_LicenseCards PRIMARY KEY CLUSTERED ( LocalLicenseID  asc ) ,
	CONSTRAINT unq_LocalLicenses UNIQUE ( BaseLicenseID  asc ) 
 );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- After succeeding in all tests and conditions, a LicenseCard is issued to said applicant, making them considered as an official driver in the system.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LocalLicenses';;
GO

CREATE  TABLE dbo.TestAppointments ( 
	TestAppointmentID    int    IDENTITY  NOT NULL,
	TestTypeID           tinyint      NOT NULL,
	LocalDrivingLicenseApplicationID int      NOT NULL,
	AppointmentDate      datetime2(2)      NOT NULL,
	FeesPaid             smallmoney      NOT NULL,
	CreatedByUserID      int      NOT NULL,
	IsLocked             bit  CONSTRAINT DF_TestAppointments_IsLocked DEFAULT 0    NOT NULL,
	RetakeFailedTestApplicationID int      NULL,
	CONSTRAINT pk_ApplicationTests PRIMARY KEY CLUSTERED ( TestAppointmentID  asc ) 
 );
GO

CREATE UNIQUE NONCLUSTERED INDEX unq_RetakeApplicationID ON dbo.TestAppointments ( RetakeFailedTestApplicationID  asc ) WHERE ([RetakeFailedTestApplicationID] IS NOT NULL);
GO

CREATE NONCLUSTERED INDEX ix_AppointmentDate ON dbo.TestAppointments ( AppointmentDate  asc );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- The Tests are fixed in the system. The User can only modify the fees of them.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestAppointments';;
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- This date is manually assigned by the User.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestAppointments', @level2type=N'COLUMN',@level2name=N'AppointmentDate';
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- This is the actual fees paid for applying for the Test. It may be different from the TestFees.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestAppointments', @level2type=N'COLUMN',@level2name=N'FeesPaid';
GO

CREATE  TABLE dbo.Tests ( 
	TestID               int    IDENTITY  NOT NULL,
	TestAppointmentID    int      NOT NULL,
	TestResults          bit      NOT NULL,
	Notes                nvarchar(500) COLLATE Arabic_CI_AS     NULL,
	CreatedByUserID      int      NOT NULL,
	CONSTRAINT pk_Tests PRIMARY KEY CLUSTERED ( TestID  asc ) ,
	CONSTRAINT unq_Tests UNIQUE ( TestAppointmentID  asc ) 
 );
GO

execute [DVLD].sys.sp_addextendedproperty  @name=N'MS_Description', @value=N'- 0 (Fail)
- 1 (Pass)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tests', @level2type=N'COLUMN',@level2name=N'TestResults';
GO

CREATE  TABLE dbo.DetainedLicenses ( 
	DetainID             int    IDENTITY  NOT NULL,
	BaseLicenseID        int      NOT NULL,
	FineFees             smallmoney      NOT NULL,
	DetainReason         nvarchar(150) COLLATE Arabic_CI_AS     NOT NULL,
	DetainDate           datetime2(2)      NOT NULL,
	CreatedByUserID      int      NOT NULL,
	IsReleased           bit  CONSTRAINT DF_DetainedLicenses_IsReleased DEFAULT 0    NOT NULL,
	ReleaseDate          datetime2(2)      NULL,
	ReleasedByUserID     int      NULL,
	ReleaseApplicationID int      NULL,
	CONSTRAINT pk_LicenseRestrictions PRIMARY KEY CLUSTERED ( DetainID  asc ) 
 );
GO

CREATE UNIQUE NONCLUSTERED INDEX unq_ReleaseApplicationID ON dbo.DetainedLicenses ( ReleaseApplicationID  asc ) WHERE ([ReleaseApplicationID] IS NOT NULL);
GO

CREATE NONCLUSTERED INDEX ix_dates ON dbo.DetainedLicenses ( DetainDate  asc, ReleaseDate  asc );
GO

CREATE  TABLE dbo.InternationalLicenses ( 
	InternationalLicenseID int    IDENTITY  NOT NULL,
	BaseLicenseID        int      NOT NULL,
	IssuedUsingLocalLicenseID int      NOT NULL,
	CONSTRAINT pk_InternationalLicenses PRIMARY KEY CLUSTERED ( InternationalLicenseID  asc ) ,
	CONSTRAINT unq_InternationalLicenses UNIQUE ( BaseLicenseID  asc ) 
 );
GO

CREATE VIEW dbo.VU_AllApplications AS
SELECT Applications.ApplicationID, Applications.ApplicantPersonID, (People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName) AS FullName,
ApplicationTypes.ApplicationTypeTitle, Applications.ApplicationDate, Applications.ApplicationStatus, Applications.UpdateStatusDate, CAST(Applications.FeesPaid AS VARCHAR) AS FeesPaid, Users.Username AS CreatedBy, Applications.ApplicationTypeID
FROM Applications 
INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID
INNER JOIN ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
INNER JOIN Users ON Applications.CreatedByUserID = Users.UserID;
GO

CREATE VIEW dbo.VU_AllApplications_AR AS
SELECT Applications.ApplicationID, Applications.ApplicantPersonID, (People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName) AS FullName,
ApplicationTypes.ApplicationTypeTitleAR, Applications.ApplicationDate, Applications.ApplicationStatus, Applications.UpdateStatusDate, CAST(Applications.FeesPaid AS VARCHAR) AS FeesPaid, Users.Username AS CreatedBy, Applications.ApplicationTypeID
FROM Applications 
INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID
INNER JOIN ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
INNER JOIN Users ON Applications.CreatedByUserID = Users.UserID;
GO

CREATE VIEW dbo.VU_AllDrivers AS
SELECT Drivers.DriverID, Drivers.PersonID, People.NationalNum, (People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName) AS FullName, Drivers.DateCreated, (SELECT COUNT(*) FROM Licenses WHERE Licenses.DriverID = Drivers.DriverID AND Licenses.IsActive = 1) AS ActiveLicensesCount
FROM Drivers
INNER JOIN People ON Drivers.PersonID = People.PersonID;
GO

CREATE VIEW dbo.VU_AllPeople AS
SELECT
People.PersonID, 
People.NationalNum, 
People.FirstName, 
People.SecondName, 
People.ThirdName, 
People.LastName, 
People.Gender, 
People.DateOfBirth, 
Countries.CountryName, 
People.PhoneNumber, 
People.Email 
FROM People 
INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID;
GO

CREATE VIEW dbo.VU_AllPeople_AR AS
SELECT
People.PersonID, 
People.NationalNum, 
People.FirstName, 
People.SecondName, 
People.ThirdName, 
People.LastName, 
People.Gender, 
People.DateOfBirth, 
Countries.CountryNameAR, 
People.PhoneNumber, 
People.Email 
FROM People 
INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID;
GO

CREATE VIEW dbo.VU_AllUsers
AS
SELECT dbo.Users.UserID, dbo.Users.PersonID, CONCAT_WS(' ', dbo.People.FirstName, dbo.People.SecondName, dbo.People.ThirdName, dbo.People.LastName) AS FullName, dbo.Users.Username, CAST(dbo.Users.IsActive AS INT) 
                  AS IsActive
FROM     dbo.Users INNER JOIN
                  dbo.People ON dbo.Users.PersonID = dbo.People.PersonID;
GO

CREATE VIEW dbo.VU_DetainedLicenses AS
SELECT DetainedLicenses.DetainID, LocalLicenses.LocalLicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased, DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNum, FullName = CONCAT_WS(' ', People.FirstName, People.SecondName, People.ThirdName, People.LastName), DetainedLicenses.ReleaseApplicationID
FROM DetainedLicenses
INNER JOIN LocalLicenses ON DetainedLicenses.BaseLicenseID = LocalLicenses.BaseLicenseID
INNER JOIN Licenses ON DetainedLicenses.BaseLicenseID = Licenses.LicenseID
INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
INNER JOIN People ON Drivers.PersonID = People.PersonID;
GO

create view dbo.VU_InternationalLicenseApplications as
SELECT InternationalLicenses.InternationalLicenseID, Licenses.ApplicationID, Licenses.DriverID,
InternationalLicenses.IssuedUsingLocalLicenseID, Licenses.IssueDate, Licenses.ExpirationDate, CAST(Licenses.IsActive AS TINYINT) AS IsActive
FROM InternationalLicenses
INNER JOIN Licenses ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID;
GO

CREATE VIEW dbo.VU_InternationalLicenses
AS
SELECT dbo.InternationalLicenses.InternationalLicenseID, CONCAT_WS(' ', dbo.People.FirstName, dbo.People.SecondName, dbo.People.ThirdName, dbo.People.LastName) AS FullName, dbo.People.NationalNum, dbo.Licenses.IssueDate, 
                  dbo.Licenses.ExpirationDate, dbo.Licenses.ApplicationID AS BaseApplicationID, dbo.InternationalLicenses.IssuedUsingLocalLicenseID, CAST(dbo.Licenses.IsActive AS TINYINT) AS IsActive
FROM     dbo.InternationalLicenses INNER JOIN
                  dbo.Licenses ON dbo.InternationalLicenses.BaseLicenseID = dbo.Licenses.LicenseID INNER JOIN
                  dbo.Drivers ON dbo.Licenses.DriverID = dbo.Drivers.DriverID INNER JOIN
                  dbo.People ON dbo.Drivers.PersonID = dbo.People.PersonID;
GO

CREATE VIEW dbo.VU_LocalDrivingLicenseApplications
AS
SELECT dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, dbo.LicenseClasses.ClassName, dbo.People.NationalNum, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName + ' ', '') 
                  + dbo.People.LastName AS FullName, dbo.Applications.ApplicationDate,
                      (SELECT CAST(COUNT(dbo.TestAppointments.TestTypeID) AS TINYINT) AS PassedTestsCount
                       FROM      dbo.Tests INNER JOIN
                                         dbo.TestAppointments ON dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID
                       WHERE   (dbo.TestAppointments.LocalDrivingLicenseApplicationID = dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID) AND (dbo.Tests.TestResults = 1)) AS PassedTestsCount, dbo.Applications.ApplicationStatus, 
                  dbo.LocalDrivingLicenseApplications.LicenseClassID, dbo.Applications.ApplicantPersonID
FROM     dbo.LocalDrivingLicenseApplications INNER JOIN
                  dbo.Applications ON dbo.LocalDrivingLicenseApplications.ApplicationID = dbo.Applications.ApplicationID INNER JOIN
                  dbo.LicenseClasses ON dbo.LocalDrivingLicenseApplications.LicenseClassID = dbo.LicenseClasses.LicenseClassID INNER JOIN
                  dbo.People ON dbo.Applications.ApplicantPersonID = dbo.People.PersonID;
GO

CREATE VIEW dbo.VU_LocalDrivingLicenseApplications_AR
AS
SELECT dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, dbo.LicenseClasses.ClassNameAR, dbo.People.NationalNum, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName + ' ', '') 
                  + dbo.People.LastName AS FullName, dbo.Applications.ApplicationDate,
                      (SELECT CAST(COUNT(dbo.TestAppointments.TestTypeID) AS TINYINT) AS PassedTestsCount
                       FROM      dbo.Tests INNER JOIN
                                         dbo.TestAppointments ON dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID
                       WHERE   (dbo.TestAppointments.LocalDrivingLicenseApplicationID = dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID) AND (dbo.Tests.TestResults = 1)) AS PassedTestsCount, dbo.Applications.ApplicationStatus, 
                  dbo.LocalDrivingLicenseApplications.LicenseClassID, dbo.Applications.ApplicantPersonID
FROM     dbo.LocalDrivingLicenseApplications INNER JOIN
                  dbo.Applications ON dbo.LocalDrivingLicenseApplications.ApplicationID = dbo.Applications.ApplicationID INNER JOIN
                  dbo.LicenseClasses ON dbo.LocalDrivingLicenseApplications.LicenseClassID = dbo.LicenseClasses.LicenseClassID INNER JOIN
                  dbo.People ON dbo.Applications.ApplicantPersonID = dbo.People.PersonID;
GO

CREATE VIEW dbo.VU_LocalLicenses_AR
AS
SELECT dbo.LocalLicenses.LocalLicenseID, dbo.LicenseClasses.ClassNameAR, CONCAT_WS(' ', dbo.People.FirstName, dbo.People.SecondName, dbo.People.ThirdName, dbo.People.LastName) AS FullName, dbo.People.NationalNum, 
                  dbo.Licenses.IssueDate, dbo.Licenses.ExpirationDate, dbo.Licenses.ApplicationID AS BaseApplicationID, CAST(dbo.Licenses.IsActive AS TINYINT) AS IsActive,
                      (SELECT CASE WHEN EXISTS
                                             (SELECT TOP 1 1
                                              FROM      DetainedLicenses
                                              WHERE   DetainedLicenses.BaseLicenseID = Licenses.LicenseID AND IsReleased = 0) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Expr1) AS IsDetained
FROM     dbo.LocalLicenses INNER JOIN
                  dbo.Licenses ON dbo.LocalLicenses.BaseLicenseID = dbo.Licenses.LicenseID INNER JOIN
                  dbo.Drivers ON dbo.Licenses.DriverID = dbo.Drivers.DriverID INNER JOIN
                  dbo.People ON dbo.Drivers.PersonID = dbo.People.PersonID INNER JOIN
                  dbo.LicenseClasses ON dbo.LocalLicenses.LicenseClassID = dbo.LicenseClasses.LicenseClassID LEFT OUTER JOIN
                  dbo.DetainedLicenses ON dbo.Licenses.LicenseID = dbo.DetainedLicenses.BaseLicenseID AND dbo.DetainedLicenses.IsReleased = 0;
GO

CREATE VIEW dbo.VU_LocalLicenses_Default
AS
SELECT dbo.LocalLicenses.LocalLicenseID, dbo.LicenseClasses.ClassName, CONCAT_WS(' ', dbo.People.FirstName, dbo.People.SecondName, dbo.People.ThirdName, dbo.People.LastName) AS FullName, dbo.People.NationalNum, 
                  dbo.Licenses.IssueDate, dbo.Licenses.ExpirationDate, dbo.Licenses.ApplicationID AS BaseApplicationID, CAST(dbo.Licenses.IsActive AS TINYINT) AS IsActive,
                      (SELECT CASE WHEN EXISTS
                                             (SELECT TOP 1 1
                                              FROM      DetainedLicenses
                                              WHERE   DetainedLicenses.BaseLicenseID = Licenses.LicenseID AND IsReleased = 0) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Expr1) AS IsDetained
FROM     dbo.LocalLicenses INNER JOIN
                  dbo.Licenses ON dbo.LocalLicenses.BaseLicenseID = dbo.Licenses.LicenseID INNER JOIN
                  dbo.Drivers ON dbo.Licenses.DriverID = dbo.Drivers.DriverID INNER JOIN
                  dbo.People ON dbo.Drivers.PersonID = dbo.People.PersonID INNER JOIN
                  dbo.LicenseClasses ON dbo.LocalLicenses.LicenseClassID = dbo.LicenseClasses.LicenseClassID LEFT OUTER JOIN
                  dbo.DetainedLicenses ON dbo.Licenses.LicenseID = dbo.DetainedLicenses.BaseLicenseID AND dbo.DetainedLicenses.IsReleased = 0;
GO

CREATE VIEW dbo.VU_SystemWideRevenue AS
SELECT 
	DateTime = Applications.ApplicationDate, 
	RevenueSource = ApplicationTypes.ApplicationTypeTitle, 
	SourceType = 'Application',
	Amount = Applications.FeesPaid, 
	RegisteredBy = Users.Username
FROM Applications INNER JOIN ApplicationTypes
ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID LEFT JOIN Users
ON Applications.CreatedByUserID = Users.UserID
UNION ALL
SELECT 
	DateTime = TestAppointments.AppointmentDate, 
	RevenueSource = TestTypes.TestTypeTitle, 
	SourceType = 'Test Appointment',
	Amount = TestAppointments.FeesPaid,
	RegisteredBy = Users.Username
FROM TestAppointments INNER JOIN TestTypes
ON TestAppointments.TestTypeID = TestTypes.TestTypeID LEFT JOIN Users
ON TestAppointments.CreatedByUserID = Users.UserID
UNION ALL
SELECT
	DateTime = Licenses.IssueDate,
	RevenueSource = LicenseClasses.ClassName,
	SourceType = 'Issue Local License (First Time)',
	Amount = LocalLicenses.LicenseClassPaidFees,
	RegisteredBy = Users.Username
FROM LocalLicenses INNER JOIN Licenses
ON LocalLicenses.BaseLicenseID = Licenses.LicenseID INNER JOIN LicenseClasses
ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID LEFT JOIN Users
ON Licenses.CreatedByUserID = Users.UserID
WHERE LocalLicenses.LicenseClassPaidFees IS NOT NULL
UNION ALL
SELECT
	DateTime = DetainedLicenses.ReleaseDate,
	RevenueSource = ApplicationTypes.ApplicationTypeTitle,
	SourceType = 'Fine Fees Payment',
	Amount = DetainedLicenses.FineFees,
	RegisteredBy = Users.Username
FROM DetainedLicenses LEFT JOIN Users
ON DetainedLicenses.ReleasedByUserID = Users.UserID INNER JOIN
ApplicationTypes ON ApplicationTypes.ApplicationTypeID = 5
WHERE DetainedLicenses.IsReleased = 1;
GO

CREATE VIEW dbo.VU_SystemWideRevenue_AR AS
SELECT 
	DateTime = Applications.ApplicationDate, 
	RevenueSource = ApplicationTypes.ApplicationTypeTitleAR, 
	SourceType = 'طلب',
	Amount = Applications.FeesPaid, 
	RegisteredBy = Users.Username
FROM Applications INNER JOIN ApplicationTypes
ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID LEFT JOIN Users
ON Applications.CreatedByUserID = Users.UserID
UNION ALL
SELECT 
	DateTime = TestAppointments.AppointmentDate, 
	RevenueSource = TestTypes.TestTypeTitleAR, 
	SourceType = 'حجز اختبار',
	Amount = TestAppointments.FeesPaid,
	RegisteredBy = Users.Username
FROM TestAppointments INNER JOIN TestTypes
ON TestAppointments.TestTypeID = TestTypes.TestTypeID LEFT JOIN Users
ON TestAppointments.CreatedByUserID = Users.UserID
UNION ALL
SELECT
	DateTime = Licenses.IssueDate,
	RevenueSource = LicenseClasses.ClassNameAR,
	SourceType = 'إصدار رخصة محلية (للمرة الأولى)',
	Amount = LocalLicenses.LicenseClassPaidFees,
	RegisteredBy = Users.Username
FROM LocalLicenses INNER JOIN Licenses
ON LocalLicenses.BaseLicenseID = Licenses.LicenseID INNER JOIN LicenseClasses
ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID LEFT JOIN Users
ON Licenses.CreatedByUserID = Users.UserID
WHERE LocalLicenses.LicenseClassPaidFees IS NOT NULL
UNION ALL
SELECT
	DateTime = DetainedLicenses.ReleaseDate,
	RevenueSource = ApplicationTypes.ApplicationTypeTitleAR,
	SourceType = 'سداد غرامة حجز رخصة',
	Amount = DetainedLicenses.FineFees,
	RegisteredBy = Users.Username
FROM DetainedLicenses LEFT JOIN Users
ON DetainedLicenses.ReleasedByUserID = Users.UserID INNER JOIN
ApplicationTypes ON ApplicationTypes.ApplicationTypeID = 5
WHERE DetainedLicenses.IsReleased = 1;
GO

CREATE VIEW dbo.VU_UserActivities AS
/*APPLICATION CREATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = apps.ApplicationID, EntityType = 'Application', DateTime = apps.ApplicationDate, Specification = appTypes.ApplicationTypeTitle, Description = CONCAT_WS(' ','User created a new application of type:', appTypes.ApplicationTypeTitle, 'for the person whose ID is', People.PersonID, 'and national number of', People.NationalNum), 
                  DoneByUserID = apps.CreatedByUserID
FROM     Applications apps INNER JOIN People
on apps.ApplicantPersonID = People.PersonID LEFT JOIN
                  ApplicationTypes appTypes ON apps.ApplicationTypeID = appTypes.ApplicationTypeID
UNION ALL
/*TEST APPOINTMENT CREATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = appoints.TestAppointmentID, EntityType = 'Test Appointment', DateTime = appoints.AppointmentDate, Specification = TestTypes.TestTypeTitle, 
                  Description = CONCAT('User created a new appointment for the following test type: ', TestTypes.TestTypeTitle), DoneByUserID = appoints.CreatedByUserID
FROM     TestAppointments appoints LEFT JOIN
                  TestTypes ON appoints.TestTypeID = TestTypes.TestTypeID
UNION ALL
/*TEST RESULTS CREATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = Tests.TestID, EntityType = 'Test Result', DateTime = appoints.AppointmentDate, Specification = TestTypes.TestTypeTitle, Description = CONCAT_WS(' ', 'User saved the result of the appointment whose ID is', 
                  appoints.TestAppointmentID, 'with the test type:', TestTypes.TestTypeTitle), DoneByUserID = Tests.CreatedByUserID
FROM     Tests INNER JOIN
                  TestAppointments appoints ON Tests.TestAppointmentID = appoints.TestAppointmentID LEFT JOIN
                  TestTypes ON appoints.TestTypeID = TestTypes.TestTypeID
UNION ALL
/*LICENSE CREATIONS (Local)*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = LocalLicenses.LocalLicenseID, EntityType = 'Local License', DateTime = Licenses.IssueDate, Specification = LicenseClasses.ClassName, Description = CONCAT_WS(' ', 'User issued a new local license with the following class:', 
                  LicenseClasses.ClassName, 'and for the following reason:', 
                  CASE WHEN Licenses.IssueReason = 1 THEN 'New' WHEN Licenses.IssueReason = 2 THEN 'Replacement for Lost' WHEN Licenses.IssueReason = 3 THEN 'Replacement for Damaged' WHEN Licenses.IssueReason = 4 THEN 'Renewal' END),
                   DoneByUserID = Licenses.CreatedByUserID
FROM     LocalLicenses INNER JOIN
                  Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID LEFT JOIN
                  LicenseClasses ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID
UNION ALL
/*LICESNE CREATIONS (International)*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = interLicenses.InternationalLicenseID, EntityType = 'International License', DateTime = Licenses.IssueDate, Specification = 'None', 
                  Description = CONCAT('User issued a new international license based of the local license whose ID is ', interLicenses.IssuedUsingLocalLicenseID), DoneByUserID = Licenses.CreatedByUserID
FROM     InternationalLicenses interLicenses INNER JOIN
                  Licenses ON interLicenses.BaseLicenseID = Licenses.LicenseID
UNION ALL
/*DRIVER CREATION*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = Drivers.DriverID, EntityType = 'Driver', DateTime = Drivers.DateCreated, Specification = Countries.CountryName, Description = CONCAT('User created a new driver whose nationality is ', Countries.CountryName), 
                  DoneByUserID = Drivers.CreatedByUserID
FROM     Drivers INNER JOIN
                  People ON Drivers.PersonID = People.PersonID LEFT JOIN
                  Countries ON People.NationalityCountryID = Countries.CountryID
UNION ALL
/*LICENSE DETENTION OPERATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = DetainID, EntityType = 'License Detention', DateTime = DetainDate, Specification = 'None', Description = CONCAT('User detained a license whose base ID is ', BaseLicenseID), DoneByUserID = CreatedByUserID
FROM     DetainedLicenses
UNION ALL
SELECT EntityID = DetainID, EntityType = 'License Release', DateTime = ReleaseDate, Specification = 'None', Description = CONCAT('User released a license whose base ID is ', BaseLicenseID), DoneByUserID = ReleasedByUserID
FROM     DetainedLicenses
WHERE  ReleasedByUserID IS NOT NULL;
GO

CREATE view dbo.VU_UserActivities_AR AS
/*APPLICATION CREATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = apps.ApplicationID, EntityType = 'طلب', DateTime = apps.ApplicationDate, Specification = appTypes.ApplicationTypeTitleAR, Description = CONCAT_WS(' ', 'قام المستخدم بإنشاء طلب جديد من نوع:', appTypes.ApplicationTypeTitleAR, 'وذلك للشخص ذي الرقم التعريفي', People.PersonID, 'والرقم القومي', People.NationalNum), 
                  DoneByUserID = apps.CreatedByUserID
FROM     Applications apps INNEr JOIN People
on apps.ApplicantPersonID = People.PersonID LEFT JOIN
                  ApplicationTypes appTypes ON apps.ApplicationTypeID = appTypes.ApplicationTypeID
UNION ALL
/*TEST APPOINTMENT CREATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = appoints.TestAppointmentID, EntityType = 'حجز اختبار', DateTime = appoints.AppointmentDate, Specification = TestTypes.TestTypeTitleAR, Description = CONCAT('قام المستخدم بإنشاء حجز اختبار جديد من نوع: ', TestTypes.TestTypeTitleAR), 
                  DoneByUserID = appoints.CreatedByUserID
FROM     TestAppointments appoints LEFT JOIN
                  TestTypes ON appoints.TestTypeID = TestTypes.TestTypeID
UNION ALL
/*TEST RESULTS CREATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = Tests.TestID, EntityType = 'نتيجة اختبار', DateTime = appoints.AppointmentDate, Specification = TestTypes.TestTypeTitleAR, Description = CONCAT_WS(' ', 'قام المستخدم بحفظ نتيجة الاختبار التابع للحجز ذي الرقم التعريفي', appoints.TestAppointmentID, 
                  'الذي نوعه:', TestTypes.TestTypeTitleAR), DoneByUserID = Tests.CreatedByUserID
FROM     Tests INNER JOIN
                  TestAppointments appoints ON Tests.TestAppointmentID = appoints.TestAppointmentID LEFT JOIN
                  TestTypes ON appoints.TestTypeID = TestTypes.TestTypeID
UNION ALL
/*LICENSE CREATIONS (Local)*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = LocalLicenses.LocalLicenseID, EntityType = 'رخصة محلية', DateTime = Licenses.IssueDate, Specification = LicenseClasses.ClassNameAR, Description = CONCAT_WS(' ', 'قام المستخدم بإصدار رخصة قيادة محلية جديدة من الفئة:', 
                  LicenseClasses.ClassNameAR, 'وقد تم الإصدار لهذا السبب:', 
                  CASE WHEN Licenses.IssueReason = 1 THEN 'إصدار لأول مرة' WHEN Licenses.IssueReason = 2 THEN 'إصدار بدل فاقد' WHEN Licenses.IssueReason = 3 THEN 'إصدار بدل تالف' WHEN Licenses.IssueReason = 4 THEN 'تجديد الرخصة' END), 
                  DoneByUserID = Licenses.CreatedByUserID
FROM     LocalLicenses INNER JOIN
                  Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID LEFT JOIN
                  LicenseClasses ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID
UNION ALL
/*LICESNE CREATIONS (International)*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = interLicenses.InternationalLicenseID, EntityType = 'رخصة دولية', DateTime = Licenses.IssueDate, Specification = 'بدون', Description = CONCAT('قام المستخدم بإصدار رخصة دولية جديدة تابعة للرخصة المحلية ذات الرقم التعريفي ', 
                  interLicenses.IssuedUsingLocalLicenseID), DoneByUserID = Licenses.CreatedByUserID
FROM     InternationalLicenses interLicenses INNER JOIN
                  Licenses ON interLicenses.BaseLicenseID = Licenses.LicenseID
UNION ALL
/*DRIVER CREATION*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = Drivers.DriverID, EntityType = 'سائق', DateTime = Drivers.DateCreated, Specification = Countries.CountryName, Description = CONCAT('قام المستخدم بإضافة سائق جديد صاحب الجنسية التالية: ', Countries.CountryName), 
                  DoneByUserID = Drivers.CreatedByUserID
FROM     Drivers INNER JOIN
                  People ON Drivers.PersonID = People.PersonID LEFT JOIN
                  Countries ON People.NationalityCountryID = Countries.CountryID
UNION ALL
/*LICENSE DETENTION OPERATIONS*/ SELECT EntityID = - 1, EntityType = '-', DateTime = DATEFROMPARTS(1, 1, 1), Specification = '-', Description = '-', DoneByUserID = - 1
UNION ALL
SELECT EntityID = DetainID, EntityType = 'حجز رخصة', DateTime = DetainDate, Specification = 'بدون', Description = CONCAT('قام المستخدم بحجز رخصة رقمها التعريفي الأساسي ', BaseLicenseID), DoneByUserID = CreatedByUserID
FROM     DetainedLicenses
UNION ALL
SELECT EntityID = DetainID, EntityType = 'فك الحجز عن رخصة', DateTime = ReleaseDate, Specification = 'بدون', Description = CONCAT('قام المستخدم بفك الحجز عن رخصة رقمها التعريفي الأساسي ', BaseLicenseID), DoneByUserID = ReleasedByUserID
FROM     DetainedLicenses
WHERE  ReleasedByUserID IS NOT NULL;
GO

ALTER TABLE dbo.Applications ADD CONSTRAINT fk_Applications_ApplicationTypes FOREIGN KEY ( ApplicationTypeID ) REFERENCES dbo.ApplicationTypes( ApplicationTypeID );
GO

ALTER TABLE dbo.Applications ADD CONSTRAINT fk_Applications_People FOREIGN KEY ( ApplicantPersonID ) REFERENCES dbo.People( PersonID );
GO

ALTER TABLE dbo.Applications ADD CONSTRAINT fk_Applications_Users FOREIGN KEY ( CreatedByUserID ) REFERENCES dbo.Users( UserID );
GO

ALTER TABLE dbo.DetainedLicenses ADD CONSTRAINT fk_DetainedLicenses_Applications FOREIGN KEY ( ReleaseApplicationID ) REFERENCES dbo.Applications( ApplicationID );
GO

ALTER TABLE dbo.DetainedLicenses ADD CONSTRAINT fk_DetainedLicenses_Licenses FOREIGN KEY ( BaseLicenseID ) REFERENCES dbo.Licenses( LicenseID );
GO

ALTER TABLE dbo.DetainedLicenses ADD CONSTRAINT fk_DetainedLicenses_Users FOREIGN KEY ( CreatedByUserID ) REFERENCES dbo.Users( UserID );
GO

ALTER TABLE dbo.DetainedLicenses ADD CONSTRAINT fk_DetainedLicenses_Users_0 FOREIGN KEY ( ReleasedByUserID ) REFERENCES dbo.Users( UserID );
GO

ALTER TABLE dbo.Drivers ADD CONSTRAINT fk_Drivers_People FOREIGN KEY ( PersonID ) REFERENCES dbo.People( PersonID );
GO

ALTER TABLE dbo.Drivers ADD CONSTRAINT fk_Drivers_Users FOREIGN KEY ( CreatedByUserID ) REFERENCES dbo.Users( UserID );
GO

ALTER TABLE dbo.InternationalLicenses ADD CONSTRAINT fk_InternationalLicenses_Licenses FOREIGN KEY ( BaseLicenseID ) REFERENCES dbo.Licenses( LicenseID ) ON DELETE CASCADE;
GO

ALTER TABLE dbo.InternationalLicenses ADD CONSTRAINT fk_InternationalLicenses_LocalLicenses FOREIGN KEY ( IssuedUsingLocalLicenseID ) REFERENCES dbo.LocalLicenses( LocalLicenseID );
GO

ALTER TABLE dbo.Licenses ADD CONSTRAINT fk_Licenses_Applications FOREIGN KEY ( ApplicationID ) REFERENCES dbo.Applications( ApplicationID );
GO

ALTER TABLE dbo.Licenses ADD CONSTRAINT fk_Licenses_Drivers FOREIGN KEY ( DriverID ) REFERENCES dbo.Drivers( DriverID );
GO

ALTER TABLE dbo.Licenses ADD CONSTRAINT fk_Licenses_Users FOREIGN KEY ( CreatedByUserID ) REFERENCES dbo.Users( UserID );
GO

ALTER TABLE dbo.LocalDrivingLicenseApplications ADD CONSTRAINT fk_LocalDrivingLicenseApplications_Applications FOREIGN KEY ( ApplicationID ) REFERENCES dbo.Applications( ApplicationID ) ON DELETE CASCADE;
GO

ALTER TABLE dbo.LocalDrivingLicenseApplications ADD CONSTRAINT fk_LocalDrivingLicenseApplications_LicenseClasses FOREIGN KEY ( LicenseClassID ) REFERENCES dbo.LicenseClasses( LicenseClassID );
GO

ALTER TABLE dbo.LocalLicenses ADD CONSTRAINT fk_LicenseCards_LicenseClasses FOREIGN KEY ( LicenseClassID ) REFERENCES dbo.LicenseClasses( LicenseClassID );
GO

ALTER TABLE dbo.LocalLicenses ADD CONSTRAINT fk_LocalLicenses_Licenses FOREIGN KEY ( BaseLicenseID ) REFERENCES dbo.Licenses( LicenseID ) ON DELETE CASCADE;
GO

ALTER TABLE dbo.People ADD CONSTRAINT fk_People_Countries FOREIGN KEY ( NationalityCountryID ) REFERENCES dbo.Countries( CountryID );
GO

ALTER TABLE dbo.TestAppointments ADD CONSTRAINT fk_TestAppointments_Applications FOREIGN KEY ( RetakeFailedTestApplicationID ) REFERENCES dbo.Applications( ApplicationID );
GO

ALTER TABLE dbo.TestAppointments ADD CONSTRAINT fk_TestAppointments_TestTypes FOREIGN KEY ( TestTypeID ) REFERENCES dbo.TestTypes( TestTypeID );
GO

ALTER TABLE dbo.TestAppointments ADD CONSTRAINT fk_TestAppointments_Users FOREIGN KEY ( CreatedByUserID ) REFERENCES dbo.Users( UserID );
GO

ALTER TABLE dbo.Tests ADD CONSTRAINT fk_Tests_TestsAppointments FOREIGN KEY ( TestAppointmentID ) REFERENCES dbo.TestAppointments( TestAppointmentID );
GO

ALTER TABLE dbo.Tests ADD CONSTRAINT fk_Tests_Users FOREIGN KEY ( CreatedByUserID ) REFERENCES dbo.Users( UserID );
GO

ALTER TABLE dbo.Themes ADD CONSTRAINT fk_Themes_ThemeColorPalettes FOREIGN KEY ( LightColorPaletteID ) REFERENCES dbo.ThemeColorPalettes( ColorPaletteID );
GO

ALTER TABLE dbo.Themes ADD CONSTRAINT fk_Themes_ThemeColorPalettes_0 FOREIGN KEY ( DarkColorPaletteID ) REFERENCES dbo.ThemeColorPalettes( ColorPaletteID );
GO

ALTER TABLE dbo.Users ADD CONSTRAINT FK_Users_Permissions FOREIGN KEY ( PermissionsID ) REFERENCES dbo.Permissions( PermissionsID ) ON DELETE CASCADE;
GO

ALTER TABLE dbo.Users ADD CONSTRAINT fk_Users_Persons FOREIGN KEY ( PersonID ) REFERENCES dbo.People( PersonID );
GO

