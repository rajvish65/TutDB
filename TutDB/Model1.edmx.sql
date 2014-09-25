
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/31/2014 20:38:30
-- Generated from EDMX file: C:\Users\rvishwakarma\Documents\Visual Studio 2012\Projects\TutDB\TutDB\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TutDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tblBatchCourse_tblBatchMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBatchCourse] DROP CONSTRAINT [FK_tblBatchCourse_tblBatchMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBatchCourse_tblCourseMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBatchCourse] DROP CONSTRAINT [FK_tblBatchCourse_tblCourseMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblCourseSubjectMapping_tblCourseMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblCourseSubjectMapping] DROP CONSTRAINT [FK_tblCourseSubjectMapping_tblCourseMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblCourseSubjectMapping_tblSubjectMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblCourseSubjectMapping] DROP CONSTRAINT [FK_tblCourseSubjectMapping_tblSubjectMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblEmployeeDetails_tblCityMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblEmployeeDetails] DROP CONSTRAINT [FK_tblEmployeeDetails_tblCityMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblEmployeeDetails_tblGederMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblEmployeeDetails] DROP CONSTRAINT [FK_tblEmployeeDetails_tblGederMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblFeesDetails_tblStudentDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblFeesDetails] DROP CONSTRAINT [FK_tblFeesDetails_tblStudentDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_tblFeesMaster_tblCourseMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblFeesMaster] DROP CONSTRAINT [FK_tblFeesMaster_tblCourseMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblFeeStructure_tblStudentDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblFeeStructure] DROP CONSTRAINT [FK_tblFeeStructure_tblStudentDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_tblLocationRoomMapping_tblLocationMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblLocationRoomMapping] DROP CONSTRAINT [FK_tblLocationRoomMapping_tblLocationMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblLocationRoomMapping_tblRoomMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblLocationRoomMapping] DROP CONSTRAINT [FK_tblLocationRoomMapping_tblRoomMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSessionActivity_tblBatchMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSessionActivity] DROP CONSTRAINT [FK_tblSessionActivity_tblBatchMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSessionActivity_tblCourseMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSessionActivity] DROP CONSTRAINT [FK_tblSessionActivity_tblCourseMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSessionActivity_tblLocationMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSessionActivity] DROP CONSTRAINT [FK_tblSessionActivity_tblLocationMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSessionActivity_tblRoomMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSessionActivity] DROP CONSTRAINT [FK_tblSessionActivity_tblRoomMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSessionActivity_tblSessionMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSessionActivity] DROP CONSTRAINT [FK_tblSessionActivity_tblSessionMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSessionActivity_tblTaskMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSessionActivity] DROP CONSTRAINT [FK_tblSessionActivity_tblTaskMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStaffAttendance_tblEmployeeDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStaffAttendance] DROP CONSTRAINT [FK_tblStaffAttendance_tblEmployeeDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStaffAttendance_tblSessionActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStaffAttendance] DROP CONSTRAINT [FK_tblStaffAttendance_tblSessionActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStudentAttendance_tblSessionActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStudentAttendance] DROP CONSTRAINT [FK_tblStudentAttendance_tblSessionActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStudentAttendance_tblStudentDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStudentAttendance] DROP CONSTRAINT [FK_tblStudentAttendance_tblStudentDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStudentDetails_tblBatchMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStudentDetails] DROP CONSTRAINT [FK_tblStudentDetails_tblBatchMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStudentDetails_tblCityMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStudentDetails] DROP CONSTRAINT [FK_tblStudentDetails_tblCityMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStudentDetails_tblCourseMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStudentDetails] DROP CONSTRAINT [FK_tblStudentDetails_tblCourseMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStudentDetails_tblGenderMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStudentDetails] DROP CONSTRAINT [FK_tblStudentDetails_tblGenderMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSubjectEmployeeMapping_tblEmployeeDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSubjectEmployeeMapping] DROP CONSTRAINT [FK_tblSubjectEmployeeMapping_tblEmployeeDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_tblSubjectEmployeeMapping_tblSubjectMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblSubjectEmployeeMapping] DROP CONSTRAINT [FK_tblSubjectEmployeeMapping_tblSubjectMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblTaskMaster_tblSubjectMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblTaskMaster] DROP CONSTRAINT [FK_tblTaskMaster_tblSubjectMaster];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[tblBasicMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBasicMaster];
GO
IF OBJECT_ID(N'[dbo].[tblBatchCourse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBatchCourse];
GO
IF OBJECT_ID(N'[dbo].[tblBatchMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBatchMaster];
GO
IF OBJECT_ID(N'[dbo].[tblCityMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblCityMaster];
GO
IF OBJECT_ID(N'[dbo].[tblCourseMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblCourseMaster];
GO
IF OBJECT_ID(N'[dbo].[tblCourseSubjectMapping]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblCourseSubjectMapping];
GO
IF OBJECT_ID(N'[dbo].[tblEmployeeDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblEmployeeDetails];
GO
IF OBJECT_ID(N'[dbo].[tblFeesDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblFeesDetails];
GO
IF OBJECT_ID(N'[dbo].[tblFeesMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblFeesMaster];
GO
IF OBJECT_ID(N'[dbo].[tblFeeStructure]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblFeeStructure];
GO
IF OBJECT_ID(N'[dbo].[tblGenderMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblGenderMaster];
GO
IF OBJECT_ID(N'[dbo].[tblLocationMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblLocationMaster];
GO
IF OBJECT_ID(N'[dbo].[tblLocationRoomMapping]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblLocationRoomMapping];
GO
IF OBJECT_ID(N'[dbo].[tblRoomMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblRoomMaster];
GO
IF OBJECT_ID(N'[dbo].[tblSessionActivity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblSessionActivity];
GO
IF OBJECT_ID(N'[dbo].[tblSessionMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblSessionMaster];
GO
IF OBJECT_ID(N'[dbo].[tblStaffAttendance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblStaffAttendance];
GO
IF OBJECT_ID(N'[dbo].[tblStudentAttendance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblStudentAttendance];
GO
IF OBJECT_ID(N'[dbo].[tblStudentDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblStudentDetails];
GO
IF OBJECT_ID(N'[dbo].[tblSubjectEmployeeMapping]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblSubjectEmployeeMapping];
GO
IF OBJECT_ID(N'[dbo].[tblSubjectMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblSubjectMaster];
GO
IF OBJECT_ID(N'[dbo].[tblTaskMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblTaskMaster];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'tblBasicMasters'
CREATE TABLE [dbo].[tblBasicMasters] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Description] varchar(50)  NULL,
    [Value] nvarchar(50)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblBatchCourses'
CREATE TABLE [dbo].[tblBatchCourses] (
    [BatchCourseId] bigint IDENTITY(1,1) NOT NULL,
    [CourseId] bigint  NULL,
    [BatchId] bigint  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblBatchMasters'
CREATE TABLE [dbo].[tblBatchMasters] (
    [BatchId] bigint IDENTITY(1,1) NOT NULL,
    [BatchCode] varchar(20)  NULL,
    [BatchName] varchar(30)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblCityMasters'
CREATE TABLE [dbo].[tblCityMasters] (
    [CityId] bigint IDENTITY(1,1) NOT NULL,
    [CityName] varchar(30)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblCourseMasters'
CREATE TABLE [dbo].[tblCourseMasters] (
    [CourseId] bigint IDENTITY(1,1) NOT NULL,
    [CourseCode] varchar(20)  NULL,
    [CourseName] varchar(30)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblCourseSubjectMappings'
CREATE TABLE [dbo].[tblCourseSubjectMappings] (
    [CourseMapId] bigint IDENTITY(1,1) NOT NULL,
    [CourseId] bigint  NULL,
    [SubjectId] bigint  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblEmployeeDetails'
CREATE TABLE [dbo].[tblEmployeeDetails] (
    [EmployeeId] bigint IDENTITY(1,1) NOT NULL,
    [EmployeeCode] varchar(30)  NULL,
    [FirstName] varchar(30)  NULL,
    [MiddleName] varchar(30)  NULL,
    [LastName] varchar(30)  NULL,
    [FatherName] varchar(50)  NULL,
    [MotherName] varchar(50)  NULL,
    [DOB] datetime  NULL,
    [Sex] bigint  NULL,
    [Address1] varchar(100)  NULL,
    [Address2] varchar(100)  NULL,
    [CityId] bigint  NULL,
    [ResiContacts] varchar(20)  NULL,
    [Contacts] varchar(20)  NULL,
    [Email] varchar(50)  NULL,
    [Dpic] varbinary(max)  NULL,
    [Designation] varchar(50)  NULL,
    [isActive] bigint  NULL,
    [Qualificaton] varchar(50)  NULL,
    [JoiningDate] datetime  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblFeesDetails'
CREATE TABLE [dbo].[tblFeesDetails] (
    [RecordId] bigint IDENTITY(1,1) NOT NULL,
    [FeeReceiptNo] nchar(10)  NULL,
    [StudentId] bigint  NULL,
    [AmountToBePaid] decimal(19,4)  NULL,
    [AmountPaid] decimal(19,4)  NULL,
    [ActualFees] decimal(19,4)  NULL,
    [ServiceTax] decimal(19,4)  NULL,
    [OtherTax] decimal(19,4)  NULL,
    [PaidTimeStamp] datetime  NULL,
    [Balance] decimal(19,4)  NULL,
    [Advance] decimal(19,4)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblFeesMasters'
CREATE TABLE [dbo].[tblFeesMasters] (
    [FeeRecordId] bigint IDENTITY(1,1) NOT NULL,
    [CourseId] bigint  NULL,
    [Amount] decimal(19,4)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblFeeStructures'
CREATE TABLE [dbo].[tblFeeStructures] (
    [FeeStructId] bigint IDENTITY(1,1) NOT NULL,
    [StudentId] bigint  NULL,
    [InstallmentNo] int  NULL,
    [InstallmentAmount] decimal(19,4)  NULL,
    [InstallmentDate] datetime  NULL,
    [AmountRemaining] decimal(19,4)  NULL,
    [PaidStatus] varchar(20)  NULL,
    [PaidDate] datetime  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblGenderMasters'
CREATE TABLE [dbo].[tblGenderMasters] (
    [GenderId] bigint IDENTITY(1,1) NOT NULL,
    [Description] varchar(20)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblLocationMasters'
CREATE TABLE [dbo].[tblLocationMasters] (
    [LocationId] bigint IDENTITY(1,1) NOT NULL,
    [LocationCode] varchar(50)  NULL,
    [LocationName] varchar(50)  NULL,
    [LocationDescription] varchar(50)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblLocationRoomMappings'
CREATE TABLE [dbo].[tblLocationRoomMappings] (
    [LocationRoomId] bigint IDENTITY(1,1) NOT NULL,
    [LocationId] bigint  NULL,
    [RoomId] bigint  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblRoomMasters'
CREATE TABLE [dbo].[tblRoomMasters] (
    [RoomId] bigint IDENTITY(1,1) NOT NULL,
    [RoomName] varchar(50)  NULL,
    [RoomDescription] varchar(50)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblSessionActivities'
CREATE TABLE [dbo].[tblSessionActivities] (
    [SessionActivityId] bigint IDENTITY(1,1) NOT NULL,
    [SessionId] bigint  NULL,
    [TaskId] bigint  NULL,
    [SessionDate] datetime  NULL,
    [StartTime] time  NULL,
    [EndTime] time  NULL,
    [SessionDuration] nchar(10)  NULL,
    [LocationId] bigint  NULL,
    [RoomId] bigint  NULL,
    [CourseId] bigint  NULL,
    [BatchId] bigint  NULL,
    [SubjectId] bigint  NULL,
    [isActive] bigint  NULL,
    [isCompleted] bigint  NULL,
    [ActivityStatus] bigint  NULL,
    [AttendanceRecorded] bigint  NULL,
    [Comments] varchar(100)  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblSessionMasters'
CREATE TABLE [dbo].[tblSessionMasters] (
    [SessionId] bigint IDENTITY(1,1) NOT NULL,
    [SessionCode] varchar(50)  NULL,
    [SessionOwnerId] bigint  NULL,
    [SessionDescription] varchar(50)  NULL,
    [SessionTime] int  NULL,
    [SessionOccurances] bigint  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblStaffAttendances'
CREATE TABLE [dbo].[tblStaffAttendances] (
    [StaffAttendanceId] bigint IDENTITY(1,1) NOT NULL,
    [EmployeeId] bigint  NULL,
    [SessionActivityId] bigint  NULL,
    [EnteredDate] datetime  NULL,
    [AttendanceDate] datetime  NULL,
    [isPresent] int  NULL,
    [LeaveReason] varchar(50)  NULL,
    [Reviewed] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblStudentAttendances'
CREATE TABLE [dbo].[tblStudentAttendances] (
    [StudentAttendanceId] bigint IDENTITY(1,1) NOT NULL,
    [SessionActivityId] bigint  NULL,
    [StudentId] bigint  NULL,
    [EnteredDate] datetime  NULL,
    [AttendanceDate] datetime  NULL,
    [isPresent] int  NULL,
    [LeaveReason] varchar(100)  NULL,
    [Reviewed] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblStudentDetails'
CREATE TABLE [dbo].[tblStudentDetails] (
    [StudentId] bigint IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(30)  NULL,
    [MiddleName] varchar(30)  NULL,
    [LastName] varchar(30)  NULL,
    [FatherName] varchar(50)  NULL,
    [MotherName] varchar(50)  NULL,
    [DOB] datetime  NULL,
    [Sex] bigint  NULL,
    [Address1] varchar(100)  NULL,
    [Address2] varchar(100)  NULL,
    [CityId] bigint  NULL,
    [Dpic] varbinary(max)  NULL,
    [isActive] bigint  NULL,
    [CourseId] bigint  NULL,
    [BatchId] bigint  NULL,
    [LastQualificaton] varchar(50)  NULL,
    [LastQualificationScore] varchar(30)  NULL,
    [AdmitDate] datetime  NULL,
    [Fees] decimal(19,4)  NULL,
    [Discount] decimal(19,4)  NULL,
    [Deposit] decimal(19,4)  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL,
    [FatherContacts] varchar(20)  NULL,
    [MotherContacts] varchar(20)  NULL,
    [ResiContacts] varchar(20)  NULL,
    [Contacts] varchar(20)  NULL,
    [Email] varchar(50)  NULL,
    [StudentCode] varchar(20)  NULL,
    [ActualFees] decimal(19,4)  NULL
);
GO

-- Creating table 'tblSubjectEmployeeMappings'
CREATE TABLE [dbo].[tblSubjectEmployeeMappings] (
    [SubjectMapId] bigint IDENTITY(1,1) NOT NULL,
    [EmployeeId] bigint  NULL,
    [SubjectId] bigint  NULL,
    [isActvie] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblSubjectMasters'
CREATE TABLE [dbo].[tblSubjectMasters] (
    [SubjectId] bigint IDENTITY(1,1) NOT NULL,
    [SubjectName] varchar(30)  NULL,
    [Description] varchar(100)  NULL,
    [isActive] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- Creating table 'tblTaskMasters'
CREATE TABLE [dbo].[tblTaskMasters] (
    [TaskId] bigint IDENTITY(1,1) NOT NULL,
    [TaskCode] varchar(50)  NULL,
    [TaskName] varchar(50)  NULL,
    [TaskDescription] varchar(50)  NULL,
    [isActive] bigint  NULL,
    [TaskAgainstId] bigint  NULL,
    [EstimatedTime] int  NULL,
    [ActualTime] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedDate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'tblBasicMasters'
ALTER TABLE [dbo].[tblBasicMasters]
ADD CONSTRAINT [PK_tblBasicMasters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [BatchCourseId] in table 'tblBatchCourses'
ALTER TABLE [dbo].[tblBatchCourses]
ADD CONSTRAINT [PK_tblBatchCourses]
    PRIMARY KEY CLUSTERED ([BatchCourseId] ASC);
GO

-- Creating primary key on [BatchId] in table 'tblBatchMasters'
ALTER TABLE [dbo].[tblBatchMasters]
ADD CONSTRAINT [PK_tblBatchMasters]
    PRIMARY KEY CLUSTERED ([BatchId] ASC);
GO

-- Creating primary key on [CityId] in table 'tblCityMasters'
ALTER TABLE [dbo].[tblCityMasters]
ADD CONSTRAINT [PK_tblCityMasters]
    PRIMARY KEY CLUSTERED ([CityId] ASC);
GO

-- Creating primary key on [CourseId] in table 'tblCourseMasters'
ALTER TABLE [dbo].[tblCourseMasters]
ADD CONSTRAINT [PK_tblCourseMasters]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- Creating primary key on [CourseMapId] in table 'tblCourseSubjectMappings'
ALTER TABLE [dbo].[tblCourseSubjectMappings]
ADD CONSTRAINT [PK_tblCourseSubjectMappings]
    PRIMARY KEY CLUSTERED ([CourseMapId] ASC);
GO

-- Creating primary key on [EmployeeId] in table 'tblEmployeeDetails'
ALTER TABLE [dbo].[tblEmployeeDetails]
ADD CONSTRAINT [PK_tblEmployeeDetails]
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC);
GO

-- Creating primary key on [RecordId] in table 'tblFeesDetails'
ALTER TABLE [dbo].[tblFeesDetails]
ADD CONSTRAINT [PK_tblFeesDetails]
    PRIMARY KEY CLUSTERED ([RecordId] ASC);
GO

-- Creating primary key on [FeeRecordId] in table 'tblFeesMasters'
ALTER TABLE [dbo].[tblFeesMasters]
ADD CONSTRAINT [PK_tblFeesMasters]
    PRIMARY KEY CLUSTERED ([FeeRecordId] ASC);
GO

-- Creating primary key on [FeeStructId] in table 'tblFeeStructures'
ALTER TABLE [dbo].[tblFeeStructures]
ADD CONSTRAINT [PK_tblFeeStructures]
    PRIMARY KEY CLUSTERED ([FeeStructId] ASC);
GO

-- Creating primary key on [GenderId] in table 'tblGenderMasters'
ALTER TABLE [dbo].[tblGenderMasters]
ADD CONSTRAINT [PK_tblGenderMasters]
    PRIMARY KEY CLUSTERED ([GenderId] ASC);
GO

-- Creating primary key on [LocationId] in table 'tblLocationMasters'
ALTER TABLE [dbo].[tblLocationMasters]
ADD CONSTRAINT [PK_tblLocationMasters]
    PRIMARY KEY CLUSTERED ([LocationId] ASC);
GO

-- Creating primary key on [LocationRoomId] in table 'tblLocationRoomMappings'
ALTER TABLE [dbo].[tblLocationRoomMappings]
ADD CONSTRAINT [PK_tblLocationRoomMappings]
    PRIMARY KEY CLUSTERED ([LocationRoomId] ASC);
GO

-- Creating primary key on [RoomId] in table 'tblRoomMasters'
ALTER TABLE [dbo].[tblRoomMasters]
ADD CONSTRAINT [PK_tblRoomMasters]
    PRIMARY KEY CLUSTERED ([RoomId] ASC);
GO

-- Creating primary key on [SessionActivityId] in table 'tblSessionActivities'
ALTER TABLE [dbo].[tblSessionActivities]
ADD CONSTRAINT [PK_tblSessionActivities]
    PRIMARY KEY CLUSTERED ([SessionActivityId] ASC);
GO

-- Creating primary key on [SessionId] in table 'tblSessionMasters'
ALTER TABLE [dbo].[tblSessionMasters]
ADD CONSTRAINT [PK_tblSessionMasters]
    PRIMARY KEY CLUSTERED ([SessionId] ASC);
GO

-- Creating primary key on [StaffAttendanceId] in table 'tblStaffAttendances'
ALTER TABLE [dbo].[tblStaffAttendances]
ADD CONSTRAINT [PK_tblStaffAttendances]
    PRIMARY KEY CLUSTERED ([StaffAttendanceId] ASC);
GO

-- Creating primary key on [StudentAttendanceId] in table 'tblStudentAttendances'
ALTER TABLE [dbo].[tblStudentAttendances]
ADD CONSTRAINT [PK_tblStudentAttendances]
    PRIMARY KEY CLUSTERED ([StudentAttendanceId] ASC);
GO

-- Creating primary key on [StudentId] in table 'tblStudentDetails'
ALTER TABLE [dbo].[tblStudentDetails]
ADD CONSTRAINT [PK_tblStudentDetails]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- Creating primary key on [SubjectMapId] in table 'tblSubjectEmployeeMappings'
ALTER TABLE [dbo].[tblSubjectEmployeeMappings]
ADD CONSTRAINT [PK_tblSubjectEmployeeMappings]
    PRIMARY KEY CLUSTERED ([SubjectMapId] ASC);
GO

-- Creating primary key on [SubjectId] in table 'tblSubjectMasters'
ALTER TABLE [dbo].[tblSubjectMasters]
ADD CONSTRAINT [PK_tblSubjectMasters]
    PRIMARY KEY CLUSTERED ([SubjectId] ASC);
GO

-- Creating primary key on [TaskId] in table 'tblTaskMasters'
ALTER TABLE [dbo].[tblTaskMasters]
ADD CONSTRAINT [PK_tblTaskMasters]
    PRIMARY KEY CLUSTERED ([TaskId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BatchId] in table 'tblBatchCourses'
ALTER TABLE [dbo].[tblBatchCourses]
ADD CONSTRAINT [FK_tblBatchCourse_tblBatchMaster]
    FOREIGN KEY ([BatchId])
    REFERENCES [dbo].[tblBatchMasters]
        ([BatchId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBatchCourse_tblBatchMaster'
CREATE INDEX [IX_FK_tblBatchCourse_tblBatchMaster]
ON [dbo].[tblBatchCourses]
    ([BatchId]);
GO

-- Creating foreign key on [CourseId] in table 'tblBatchCourses'
ALTER TABLE [dbo].[tblBatchCourses]
ADD CONSTRAINT [FK_tblBatchCourse_tblCourseMaster]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[tblCourseMasters]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBatchCourse_tblCourseMaster'
CREATE INDEX [IX_FK_tblBatchCourse_tblCourseMaster]
ON [dbo].[tblBatchCourses]
    ([CourseId]);
GO

-- Creating foreign key on [BatchId] in table 'tblSessionActivities'
ALTER TABLE [dbo].[tblSessionActivities]
ADD CONSTRAINT [FK_tblSessionActivity_tblBatchMaster]
    FOREIGN KEY ([BatchId])
    REFERENCES [dbo].[tblBatchMasters]
        ([BatchId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSessionActivity_tblBatchMaster'
CREATE INDEX [IX_FK_tblSessionActivity_tblBatchMaster]
ON [dbo].[tblSessionActivities]
    ([BatchId]);
GO

-- Creating foreign key on [BatchId] in table 'tblStudentDetails'
ALTER TABLE [dbo].[tblStudentDetails]
ADD CONSTRAINT [FK_tblStudentDetails_tblBatchMaster]
    FOREIGN KEY ([BatchId])
    REFERENCES [dbo].[tblBatchMasters]
        ([BatchId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStudentDetails_tblBatchMaster'
CREATE INDEX [IX_FK_tblStudentDetails_tblBatchMaster]
ON [dbo].[tblStudentDetails]
    ([BatchId]);
GO

-- Creating foreign key on [CityId] in table 'tblEmployeeDetails'
ALTER TABLE [dbo].[tblEmployeeDetails]
ADD CONSTRAINT [FK_tblEmployeeDetails_tblCityMaster]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[tblCityMasters]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblEmployeeDetails_tblCityMaster'
CREATE INDEX [IX_FK_tblEmployeeDetails_tblCityMaster]
ON [dbo].[tblEmployeeDetails]
    ([CityId]);
GO

-- Creating foreign key on [CityId] in table 'tblStudentDetails'
ALTER TABLE [dbo].[tblStudentDetails]
ADD CONSTRAINT [FK_tblStudentDetails_tblCityMaster]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[tblCityMasters]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStudentDetails_tblCityMaster'
CREATE INDEX [IX_FK_tblStudentDetails_tblCityMaster]
ON [dbo].[tblStudentDetails]
    ([CityId]);
GO

-- Creating foreign key on [CourseId] in table 'tblCourseSubjectMappings'
ALTER TABLE [dbo].[tblCourseSubjectMappings]
ADD CONSTRAINT [FK_tblCourseSubjectMapping_tblCourseMaster]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[tblCourseMasters]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblCourseSubjectMapping_tblCourseMaster'
CREATE INDEX [IX_FK_tblCourseSubjectMapping_tblCourseMaster]
ON [dbo].[tblCourseSubjectMappings]
    ([CourseId]);
GO

-- Creating foreign key on [CourseId] in table 'tblFeesMasters'
ALTER TABLE [dbo].[tblFeesMasters]
ADD CONSTRAINT [FK_tblFeesMaster_tblCourseMaster]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[tblCourseMasters]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblFeesMaster_tblCourseMaster'
CREATE INDEX [IX_FK_tblFeesMaster_tblCourseMaster]
ON [dbo].[tblFeesMasters]
    ([CourseId]);
GO

-- Creating foreign key on [CourseId] in table 'tblSessionActivities'
ALTER TABLE [dbo].[tblSessionActivities]
ADD CONSTRAINT [FK_tblSessionActivity_tblCourseMaster]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[tblCourseMasters]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSessionActivity_tblCourseMaster'
CREATE INDEX [IX_FK_tblSessionActivity_tblCourseMaster]
ON [dbo].[tblSessionActivities]
    ([CourseId]);
GO

-- Creating foreign key on [CourseId] in table 'tblStudentDetails'
ALTER TABLE [dbo].[tblStudentDetails]
ADD CONSTRAINT [FK_tblStudentDetails_tblCourseMaster]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[tblCourseMasters]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStudentDetails_tblCourseMaster'
CREATE INDEX [IX_FK_tblStudentDetails_tblCourseMaster]
ON [dbo].[tblStudentDetails]
    ([CourseId]);
GO

-- Creating foreign key on [SubjectId] in table 'tblCourseSubjectMappings'
ALTER TABLE [dbo].[tblCourseSubjectMappings]
ADD CONSTRAINT [FK_tblCourseSubjectMapping_tblSubjectMaster]
    FOREIGN KEY ([SubjectId])
    REFERENCES [dbo].[tblSubjectMasters]
        ([SubjectId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblCourseSubjectMapping_tblSubjectMaster'
CREATE INDEX [IX_FK_tblCourseSubjectMapping_tblSubjectMaster]
ON [dbo].[tblCourseSubjectMappings]
    ([SubjectId]);
GO

-- Creating foreign key on [Sex] in table 'tblEmployeeDetails'
ALTER TABLE [dbo].[tblEmployeeDetails]
ADD CONSTRAINT [FK_tblEmployeeDetails_tblGederMaster]
    FOREIGN KEY ([Sex])
    REFERENCES [dbo].[tblGenderMasters]
        ([GenderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblEmployeeDetails_tblGederMaster'
CREATE INDEX [IX_FK_tblEmployeeDetails_tblGederMaster]
ON [dbo].[tblEmployeeDetails]
    ([Sex]);
GO

-- Creating foreign key on [EmployeeId] in table 'tblStaffAttendances'
ALTER TABLE [dbo].[tblStaffAttendances]
ADD CONSTRAINT [FK_tblStaffAttendance_tblEmployeeDetails]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[tblEmployeeDetails]
        ([EmployeeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStaffAttendance_tblEmployeeDetails'
CREATE INDEX [IX_FK_tblStaffAttendance_tblEmployeeDetails]
ON [dbo].[tblStaffAttendances]
    ([EmployeeId]);
GO

-- Creating foreign key on [EmployeeId] in table 'tblSubjectEmployeeMappings'
ALTER TABLE [dbo].[tblSubjectEmployeeMappings]
ADD CONSTRAINT [FK_tblSubjectEmployeeMapping_tblEmployeeDetails]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[tblEmployeeDetails]
        ([EmployeeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSubjectEmployeeMapping_tblEmployeeDetails'
CREATE INDEX [IX_FK_tblSubjectEmployeeMapping_tblEmployeeDetails]
ON [dbo].[tblSubjectEmployeeMappings]
    ([EmployeeId]);
GO

-- Creating foreign key on [StudentId] in table 'tblFeesDetails'
ALTER TABLE [dbo].[tblFeesDetails]
ADD CONSTRAINT [FK_tblFeesDetails_tblStudentDetails]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[tblStudentDetails]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblFeesDetails_tblStudentDetails'
CREATE INDEX [IX_FK_tblFeesDetails_tblStudentDetails]
ON [dbo].[tblFeesDetails]
    ([StudentId]);
GO

-- Creating foreign key on [StudentId] in table 'tblFeeStructures'
ALTER TABLE [dbo].[tblFeeStructures]
ADD CONSTRAINT [FK_tblFeeStructure_tblStudentDetails]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[tblStudentDetails]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblFeeStructure_tblStudentDetails'
CREATE INDEX [IX_FK_tblFeeStructure_tblStudentDetails]
ON [dbo].[tblFeeStructures]
    ([StudentId]);
GO

-- Creating foreign key on [Sex] in table 'tblStudentDetails'
ALTER TABLE [dbo].[tblStudentDetails]
ADD CONSTRAINT [FK_tblStudentDetails_tblGenderMaster]
    FOREIGN KEY ([Sex])
    REFERENCES [dbo].[tblGenderMasters]
        ([GenderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStudentDetails_tblGenderMaster'
CREATE INDEX [IX_FK_tblStudentDetails_tblGenderMaster]
ON [dbo].[tblStudentDetails]
    ([Sex]);
GO

-- Creating foreign key on [LocationId] in table 'tblLocationRoomMappings'
ALTER TABLE [dbo].[tblLocationRoomMappings]
ADD CONSTRAINT [FK_tblLocationRoomMapping_tblLocationMaster]
    FOREIGN KEY ([LocationId])
    REFERENCES [dbo].[tblLocationMasters]
        ([LocationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblLocationRoomMapping_tblLocationMaster'
CREATE INDEX [IX_FK_tblLocationRoomMapping_tblLocationMaster]
ON [dbo].[tblLocationRoomMappings]
    ([LocationId]);
GO

-- Creating foreign key on [LocationId] in table 'tblSessionActivities'
ALTER TABLE [dbo].[tblSessionActivities]
ADD CONSTRAINT [FK_tblSessionActivity_tblLocationMaster]
    FOREIGN KEY ([LocationId])
    REFERENCES [dbo].[tblLocationMasters]
        ([LocationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSessionActivity_tblLocationMaster'
CREATE INDEX [IX_FK_tblSessionActivity_tblLocationMaster]
ON [dbo].[tblSessionActivities]
    ([LocationId]);
GO

-- Creating foreign key on [RoomId] in table 'tblLocationRoomMappings'
ALTER TABLE [dbo].[tblLocationRoomMappings]
ADD CONSTRAINT [FK_tblLocationRoomMapping_tblRoomMaster]
    FOREIGN KEY ([RoomId])
    REFERENCES [dbo].[tblRoomMasters]
        ([RoomId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblLocationRoomMapping_tblRoomMaster'
CREATE INDEX [IX_FK_tblLocationRoomMapping_tblRoomMaster]
ON [dbo].[tblLocationRoomMappings]
    ([RoomId]);
GO

-- Creating foreign key on [RoomId] in table 'tblSessionActivities'
ALTER TABLE [dbo].[tblSessionActivities]
ADD CONSTRAINT [FK_tblSessionActivity_tblRoomMaster]
    FOREIGN KEY ([RoomId])
    REFERENCES [dbo].[tblRoomMasters]
        ([RoomId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSessionActivity_tblRoomMaster'
CREATE INDEX [IX_FK_tblSessionActivity_tblRoomMaster]
ON [dbo].[tblSessionActivities]
    ([RoomId]);
GO

-- Creating foreign key on [SessionId] in table 'tblSessionActivities'
ALTER TABLE [dbo].[tblSessionActivities]
ADD CONSTRAINT [FK_tblSessionActivity_tblSessionMaster]
    FOREIGN KEY ([SessionId])
    REFERENCES [dbo].[tblSessionMasters]
        ([SessionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSessionActivity_tblSessionMaster'
CREATE INDEX [IX_FK_tblSessionActivity_tblSessionMaster]
ON [dbo].[tblSessionActivities]
    ([SessionId]);
GO

-- Creating foreign key on [TaskId] in table 'tblSessionActivities'
ALTER TABLE [dbo].[tblSessionActivities]
ADD CONSTRAINT [FK_tblSessionActivity_tblTaskMaster]
    FOREIGN KEY ([TaskId])
    REFERENCES [dbo].[tblTaskMasters]
        ([TaskId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSessionActivity_tblTaskMaster'
CREATE INDEX [IX_FK_tblSessionActivity_tblTaskMaster]
ON [dbo].[tblSessionActivities]
    ([TaskId]);
GO

-- Creating foreign key on [SessionActivityId] in table 'tblStaffAttendances'
ALTER TABLE [dbo].[tblStaffAttendances]
ADD CONSTRAINT [FK_tblStaffAttendance_tblSessionActivity]
    FOREIGN KEY ([SessionActivityId])
    REFERENCES [dbo].[tblSessionActivities]
        ([SessionActivityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStaffAttendance_tblSessionActivity'
CREATE INDEX [IX_FK_tblStaffAttendance_tblSessionActivity]
ON [dbo].[tblStaffAttendances]
    ([SessionActivityId]);
GO

-- Creating foreign key on [SessionActivityId] in table 'tblStudentAttendances'
ALTER TABLE [dbo].[tblStudentAttendances]
ADD CONSTRAINT [FK_tblStudentAttendance_tblSessionActivity]
    FOREIGN KEY ([SessionActivityId])
    REFERENCES [dbo].[tblSessionActivities]
        ([SessionActivityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStudentAttendance_tblSessionActivity'
CREATE INDEX [IX_FK_tblStudentAttendance_tblSessionActivity]
ON [dbo].[tblStudentAttendances]
    ([SessionActivityId]);
GO

-- Creating foreign key on [StudentId] in table 'tblStudentAttendances'
ALTER TABLE [dbo].[tblStudentAttendances]
ADD CONSTRAINT [FK_tblStudentAttendance_tblStudentDetails]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[tblStudentDetails]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStudentAttendance_tblStudentDetails'
CREATE INDEX [IX_FK_tblStudentAttendance_tblStudentDetails]
ON [dbo].[tblStudentAttendances]
    ([StudentId]);
GO

-- Creating foreign key on [SubjectId] in table 'tblSubjectEmployeeMappings'
ALTER TABLE [dbo].[tblSubjectEmployeeMappings]
ADD CONSTRAINT [FK_tblSubjectEmployeeMapping_tblSubjectMaster]
    FOREIGN KEY ([SubjectId])
    REFERENCES [dbo].[tblSubjectMasters]
        ([SubjectId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblSubjectEmployeeMapping_tblSubjectMaster'
CREATE INDEX [IX_FK_tblSubjectEmployeeMapping_tblSubjectMaster]
ON [dbo].[tblSubjectEmployeeMappings]
    ([SubjectId]);
GO

-- Creating foreign key on [TaskAgainstId] in table 'tblTaskMasters'
ALTER TABLE [dbo].[tblTaskMasters]
ADD CONSTRAINT [FK_tblTaskMaster_tblSubjectMaster]
    FOREIGN KEY ([TaskAgainstId])
    REFERENCES [dbo].[tblSubjectMasters]
        ([SubjectId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tblTaskMaster_tblSubjectMaster'
CREATE INDEX [IX_FK_tblTaskMaster_tblSubjectMaster]
ON [dbo].[tblTaskMasters]
    ([TaskAgainstId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------