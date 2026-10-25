/* =====================================================================
   Future Path Student Advising System
   02_CreateTables.sql  -  (re)builds every table from scratch

   WARNING: drops all 18 tables first, so any data in them is lost.
   Run 03_SeedData.sql afterwards to repopulate.

   Conventions
   - Every table has an INT IDENTITY primary key named <thing>ID.
   - Column names match the team's seed scripts (camelCase).
   - Constraints are explicitly named so error messages are readable
     (e.g. "FK_Learner_GradeLevel" instead of "FK__Learner__gra__3A4B").
   - Dates are DATE / DATETIME2, never VARCHAR.
   ===================================================================== */
USE FuturePathDB;
GO

/* ---------- Drop in reverse dependency order (children first) ---------- */
DROP TABLE IF EXISTS dbo.ExportReport;
DROP TABLE IF EXISTS dbo.RecommendationResult;
DROP TABLE IF EXISTS dbo.AdvisorySession;
DROP TABLE IF EXISTS dbo.LearnerInterestReport;
DROP TABLE IF EXISTS dbo.LearnerSubject;
DROP TABLE IF EXISTS dbo.FundingProgramme;
DROP TABLE IF EXISTS dbo.FundingFaculty;
DROP TABLE IF EXISTS dbo.FundingOption;
DROP TABLE IF EXISTS dbo.DegreeInterestMap;
DROP TABLE IF EXISTS dbo.InterestQuestion;
DROP TABLE IF EXISTS dbo.ProgrammeRequirements;
DROP TABLE IF EXISTS dbo.DegreeProgramme;
DROP TABLE IF EXISTS dbo.Learner;
DROP TABLE IF EXISTS dbo.UserAccount;
DROP TABLE IF EXISTS dbo.InterestQuestionCategory;
DROP TABLE IF EXISTS dbo.Subject;
DROP TABLE IF EXISTS dbo.Faculty;
DROP TABLE IF EXISTS dbo.GradeLevel;
GO

/* =====================================================================
   1. LOOKUP / REFERENCE TABLES (no foreign keys)
   ===================================================================== */

CREATE TABLE dbo.GradeLevel
(
    gradeLevelID    INT IDENTITY(1,1) NOT NULL,
    gradeName       VARCHAR(20)       NOT NULL,
    CONSTRAINT PK_GradeLevel           PRIMARY KEY (gradeLevelID),
    CONSTRAINT UQ_GradeLevel_gradeName UNIQUE (gradeName)
);

CREATE TABLE dbo.Faculty
(
    facultyID       INT IDENTITY(1,1) NOT NULL,
    facultyName     VARCHAR(50)       NOT NULL,
    CONSTRAINT PK_Faculty             PRIMARY KEY (facultyID),
    CONSTRAINT UQ_Faculty_facultyName UNIQUE (facultyName)
);

CREATE TABLE dbo.Subject
(
    subjectID       INT IDENTITY(1,1) NOT NULL,
    subjectName     VARCHAR(60)       NOT NULL,
    CONSTRAINT PK_Subject             PRIMARY KEY (subjectID),
    CONSTRAINT UQ_Subject_subjectName UNIQUE (subjectName)
);

CREATE TABLE dbo.InterestQuestionCategory
(
    categoryID      INT IDENTITY(1,1) NOT NULL,
    categoryName    VARCHAR(50)       NOT NULL,
    description     VARCHAR(255)      NULL,
    CONSTRAINT PK_InterestQuestionCategory              PRIMARY KEY (categoryID),
    CONSTRAINT UQ_InterestQuestionCategory_categoryName UNIQUE (categoryName)
);

CREATE TABLE dbo.UserAccount
(
    userID          INT IDENTITY(1,1) NOT NULL,
    username        VARCHAR(50)       NOT NULL,
    passwordHash    CHAR(64)          NOT NULL,   -- SHA-256 as 64 uppercase hex chars
    role            VARCHAR(30)       NOT NULL,
    isActive        BIT               NOT NULL CONSTRAINT DF_UserAccount_isActive DEFAULT (1),
    CONSTRAINT PK_UserAccount          PRIMARY KEY (userID),
    CONSTRAINT UQ_UserAccount_username UNIQUE (username),
    CONSTRAINT CK_UserAccount_role     CHECK (role IN ('Administrator', 'Career Advisor'))
);
GO

/* =====================================================================
   2. CORE TABLES
   ===================================================================== */

CREATE TABLE dbo.Learner
(
    learnerID       INT IDENTITY(1,1) NOT NULL,
    fullName        VARCHAR(100)      NOT NULL,
    gradeLevelID    INT               NOT NULL,
    schoolName      VARCHAR(100)      NULL,
    province        VARCHAR(30)       NULL,
    contactDetails  VARCHAR(100)      NULL,
    CONSTRAINT PK_Learner            PRIMARY KEY (learnerID),
    CONSTRAINT FK_Learner_GradeLevel FOREIGN KEY (gradeLevelID) REFERENCES dbo.GradeLevel (gradeLevelID)
);

CREATE TABLE dbo.DegreeProgramme
(
    degreeID        INT IDENTITY(1,1) NOT NULL,
    facultyID       INT               NOT NULL,
    degreeName      VARCHAR(100)      NOT NULL,
    description     VARCHAR(500)      NULL,
    isActive        BIT               NOT NULL CONSTRAINT DF_DegreeProgramme_isActive DEFAULT (1),
    CONSTRAINT PK_DegreeProgramme            PRIMARY KEY (degreeID),
    CONSTRAINT UQ_DegreeProgramme_degreeName UNIQUE (degreeName),
    CONSTRAINT FK_DegreeProgramme_Faculty    FOREIGN KEY (facultyID) REFERENCES dbo.Faculty (facultyID)
);

CREATE TABLE dbo.ProgrammeRequirements
(
    requirementID                INT IDENTITY(1,1) NOT NULL,
    degreeID                     INT               NOT NULL,
    subjectID                    INT               NOT NULL,
    minimumMark                  DECIMAL(5,2)      NOT NULL,
    isRequired                   BIT               NOT NULL CONSTRAINT DF_ProgrammeRequirements_isRequired DEFAULT (1),
    acceptedAlternativeSubjectID INT               NULL,      -- e.g. Mathematical Literacy instead of Mathematics
    minimumOverallAverage        DECIMAL(5,2)      NULL,
    requirementType              VARCHAR(30)       NOT NULL CONSTRAINT DF_ProgrammeRequirements_requirementType DEFAULT ('Subject'),
    notes                        VARCHAR(255)      NULL,
    CONSTRAINT PK_ProgrammeRequirements                 PRIMARY KEY (requirementID),
    CONSTRAINT UQ_ProgrammeRequirements_degree_subject  UNIQUE (degreeID, subjectID),
    CONSTRAINT FK_ProgrammeRequirements_DegreeProgramme FOREIGN KEY (degreeID)  REFERENCES dbo.DegreeProgramme (degreeID) ON DELETE CASCADE,
    CONSTRAINT FK_ProgrammeRequirements_Subject         FOREIGN KEY (subjectID) REFERENCES dbo.Subject (subjectID),
    CONSTRAINT FK_ProgrammeRequirements_AltSubject      FOREIGN KEY (acceptedAlternativeSubjectID) REFERENCES dbo.Subject (subjectID),
    CONSTRAINT CK_ProgrammeRequirements_minimumMark     CHECK (minimumMark BETWEEN 0 AND 100),
    CONSTRAINT CK_ProgrammeRequirements_minOverallAvg   CHECK (minimumOverallAverage IS NULL OR minimumOverallAverage BETWEEN 0 AND 100),
    CONSTRAINT CK_ProgrammeRequirements_altNotSame      CHECK (acceptedAlternativeSubjectID IS NULL OR acceptedAlternativeSubjectID <> subjectID)
);

CREATE TABLE dbo.InterestQuestion
(
    questionID      INT IDENTITY(1,1) NOT NULL,
    questionText    VARCHAR(255)      NOT NULL,
    categoryID      INT               NOT NULL,
    isActive        BIT               NOT NULL CONSTRAINT DF_InterestQuestion_isActive DEFAULT (1),
    CONSTRAINT PK_InterestQuestion                          PRIMARY KEY (questionID),
    CONSTRAINT FK_InterestQuestion_InterestQuestionCategory FOREIGN KEY (categoryID) REFERENCES dbo.InterestQuestionCategory (categoryID)
);

CREATE TABLE dbo.DegreeInterestMap
(
    mappingID       INT IDENTITY(1,1) NOT NULL,
    degreeID        INT               NOT NULL,
    categoryID      INT               NOT NULL,
    weightedScore   DECIMAL(3,2)      NOT NULL,   -- 0.00 .. 1.00
    CONSTRAINT PK_DegreeInterestMap                          PRIMARY KEY (mappingID),
    CONSTRAINT UQ_DegreeInterestMap_degree_category          UNIQUE (degreeID, categoryID),
    CONSTRAINT FK_DegreeInterestMap_DegreeProgramme          FOREIGN KEY (degreeID)   REFERENCES dbo.DegreeProgramme (degreeID) ON DELETE CASCADE,
    CONSTRAINT FK_DegreeInterestMap_InterestQuestionCategory FOREIGN KEY (categoryID) REFERENCES dbo.InterestQuestionCategory (categoryID),
    CONSTRAINT CK_DegreeInterestMap_weightedScore            CHECK (weightedScore BETWEEN 0 AND 1)
);
GO

/* =====================================================================
   3. FUNDING
   ===================================================================== */

CREATE TABLE dbo.FundingOption
(
    fundingID               INT IDENTITY(1,1) NOT NULL,
    fundingName             VARCHAR(100)      NOT NULL,
    fundingType             VARCHAR(30)       NOT NULL,
    eligibilityDescription  VARCHAR(500)      NULL,
    requiredDocuments       VARCHAR(255)      NULL,
    closingDate             DATE              NULL,
    contactInfo             VARCHAR(100)      NULL,
    isActive                BIT               NOT NULL CONSTRAINT DF_FundingOption_isActive DEFAULT (1),
    CONSTRAINT PK_FundingOption             PRIMARY KEY (fundingID),
    CONSTRAINT UQ_FundingOption_fundingName UNIQUE (fundingName),
    CONSTRAINT CK_FundingOption_fundingType CHECK (fundingType IN ('Scholarship', 'Bursary', 'Financial Aid', 'External Funding'))
);

CREATE TABLE dbo.FundingFaculty
(
    fundingFacultyID INT IDENTITY(1,1) NOT NULL,
    fundingID        INT               NOT NULL,
    facultyID        INT               NOT NULL,
    CONSTRAINT PK_FundingFaculty                 PRIMARY KEY (fundingFacultyID),
    CONSTRAINT UQ_FundingFaculty_funding_faculty UNIQUE (fundingID, facultyID),
    CONSTRAINT FK_FundingFaculty_FundingOption   FOREIGN KEY (fundingID) REFERENCES dbo.FundingOption (fundingID) ON DELETE CASCADE,
    CONSTRAINT FK_FundingFaculty_Faculty         FOREIGN KEY (facultyID) REFERENCES dbo.Faculty (facultyID)
);

CREATE TABLE dbo.FundingProgramme
(
    fundingProgrammeID INT IDENTITY(1,1) NOT NULL,
    fundingID          INT               NOT NULL,
    degreeID           INT               NOT NULL,
    CONSTRAINT PK_FundingProgramme                 PRIMARY KEY (fundingProgrammeID),
    CONSTRAINT UQ_FundingProgramme_funding_degree  UNIQUE (fundingID, degreeID),
    CONSTRAINT FK_FundingProgramme_FundingOption   FOREIGN KEY (fundingID) REFERENCES dbo.FundingOption (fundingID) ON DELETE CASCADE,
    CONSTRAINT FK_FundingProgramme_DegreeProgramme FOREIGN KEY (degreeID)  REFERENCES dbo.DegreeProgramme (degreeID)
);
GO

/* =====================================================================
   4. LEARNER DATA
   ===================================================================== */

CREATE TABLE dbo.LearnerSubject
(
    learnerSubjectID INT IDENTITY(1,1) NOT NULL,
    learnerID        INT               NOT NULL,
    subjectID        INT               NOT NULL,
    mark             DECIMAL(5,2)      NULL,      -- NULL = mark not supplied ("More Information Needed")
    CONSTRAINT PK_LearnerSubject                 PRIMARY KEY (learnerSubjectID),
    CONSTRAINT UQ_LearnerSubject_learner_subject UNIQUE (learnerID, subjectID),
    CONSTRAINT FK_LearnerSubject_Learner         FOREIGN KEY (learnerID) REFERENCES dbo.Learner (learnerID) ON DELETE CASCADE,
    CONSTRAINT FK_LearnerSubject_Subject         FOREIGN KEY (subjectID) REFERENCES dbo.Subject (subjectID),
    CONSTRAINT CK_LearnerSubject_mark            CHECK (mark IS NULL OR mark BETWEEN 0 AND 100)
);

CREATE TABLE dbo.LearnerInterestReport
(
    responseID          INT IDENTITY(1,1) NOT NULL,
    learnerID           INT               NOT NULL,
    questionID          INT               NOT NULL,
    selectedOptionValue TINYINT           NOT NULL,   -- Likert 1 (strongly disagree) .. 5 (strongly agree)
    CONSTRAINT PK_LearnerInterestReport                   PRIMARY KEY (responseID),
    CONSTRAINT UQ_LearnerInterestReport_learner_question  UNIQUE (learnerID, questionID),
    CONSTRAINT FK_LearnerInterestReport_Learner           FOREIGN KEY (learnerID)  REFERENCES dbo.Learner (learnerID) ON DELETE CASCADE,
    CONSTRAINT FK_LearnerInterestReport_InterestQuestion  FOREIGN KEY (questionID) REFERENCES dbo.InterestQuestion (questionID),
    CONSTRAINT CK_LearnerInterestReport_value             CHECK (selectedOptionValue BETWEEN 1 AND 5)
);
GO

/* =====================================================================
   5. ADVISORY SESSIONS AND OUTPUTS
   ===================================================================== */

CREATE TABLE dbo.AdvisorySession
(
    sessionID        INT IDENTITY(1,1) NOT NULL,
    learnerID        INT               NOT NULL,
    facultyID        INT               NULL,      -- learner's preferred faculty (drives facultyPreference score)
    degreeID         INT               NULL,      -- degree the learner asked about
    sessionDate      DATE              NOT NULL CONSTRAINT DF_AdvisorySession_sessionDate DEFAULT (CAST(GETDATE() AS DATE)),
    fundingRequested BIT               NOT NULL CONSTRAINT DF_AdvisorySession_fundingRequested DEFAULT (0),
    CONSTRAINT PK_AdvisorySession                 PRIMARY KEY (sessionID),
    CONSTRAINT FK_AdvisorySession_Learner         FOREIGN KEY (learnerID) REFERENCES dbo.Learner (learnerID) ON DELETE CASCADE,
    CONSTRAINT FK_AdvisorySession_Faculty         FOREIGN KEY (facultyID) REFERENCES dbo.Faculty (facultyID),
    CONSTRAINT FK_AdvisorySession_DegreeProgramme FOREIGN KEY (degreeID)  REFERENCES dbo.DegreeProgramme (degreeID)
);

CREATE TABLE dbo.RecommendationResult
(
    resultID           INT IDENTITY(1,1) NOT NULL,
    sessionID          INT               NOT NULL,
    degreeID           INT               NOT NULL,
    subjectMatchScore  DECIMAL(5,2)      NULL,
    markMatchScore     DECIMAL(5,2)      NULL,
    interestMatchScore DECIMAL(5,2)      NULL,
    facultyPreference  DECIMAL(5,2)      NULL,
    overallScore       DECIMAL(5,2)      NULL,     -- NULL when assessment could not be completed
    advisoryOutcome    VARCHAR(30)       NOT NULL,
    gapDescription     VARCHAR(500)      NULL,
    CONSTRAINT PK_RecommendationResult                 PRIMARY KEY (resultID),
    CONSTRAINT UQ_RecommendationResult_session_degree  UNIQUE (sessionID, degreeID),
    CONSTRAINT FK_RecommendationResult_AdvisorySession FOREIGN KEY (sessionID) REFERENCES dbo.AdvisorySession (sessionID) ON DELETE CASCADE,
    CONSTRAINT FK_RecommendationResult_DegreeProgramme FOREIGN KEY (degreeID)  REFERENCES dbo.DegreeProgramme (degreeID),
    CONSTRAINT CK_RecommendationResult_outcome         CHECK (advisoryOutcome IN ('Strong Match', 'Possible Match', 'Not Currently Eligible', 'More Information Needed')),
    CONSTRAINT CK_RecommendationResult_scores          CHECK (
           (subjectMatchScore  IS NULL OR subjectMatchScore  BETWEEN 0 AND 100)
       AND (markMatchScore     IS NULL OR markMatchScore     BETWEEN 0 AND 100)
       AND (interestMatchScore IS NULL OR interestMatchScore BETWEEN 0 AND 100)
       AND (facultyPreference  IS NULL OR facultyPreference  BETWEEN 0 AND 100)
       AND (overallScore       IS NULL OR overallScore       BETWEEN 0 AND 100))
);

CREATE TABLE dbo.ExportReport
(
    reportID        INT IDENTITY(1,1) NOT NULL,
    sessionID       INT               NOT NULL,
    disclaimerText  VARCHAR(500)      NOT NULL,
    reportFormat    VARCHAR(10)       NOT NULL,
    exportDate      DATETIME2(0)      NOT NULL CONSTRAINT DF_ExportReport_exportDate DEFAULT (SYSDATETIME()),
    filePath        VARCHAR(260)      NULL,
    CONSTRAINT PK_ExportReport                 PRIMARY KEY (reportID),
    CONSTRAINT FK_ExportReport_AdvisorySession FOREIGN KEY (sessionID) REFERENCES dbo.AdvisorySession (sessionID) ON DELETE CASCADE,
    CONSTRAINT CK_ExportReport_reportFormat    CHECK (reportFormat IN ('PDF', 'TXT'))
);
GO

PRINT 'All 18 tables created.';
GO
