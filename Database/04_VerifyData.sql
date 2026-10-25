/* =====================================================================
   Future Path Student Advising System
   04_VerifyData.sql  -  read-only checks; run after 03_SeedData.sql
   Every row in the first result should say PASS.
   ===================================================================== */
USE FuturePathDB;
GO

/* 1. Row counts vs expected */
SELECT t.tableName, t.expected, t.actual,
       CASE WHEN t.expected = t.actual THEN 'PASS' ELSE 'FAIL' END AS result
FROM (
          SELECT 'GradeLevel'               AS tableName, 2   AS expected, (SELECT COUNT(*) FROM dbo.GradeLevel)               AS actual
    UNION ALL SELECT 'Faculty',                 6,   (SELECT COUNT(*) FROM dbo.Faculty)
    UNION ALL SELECT 'Subject',                 16,  (SELECT COUNT(*) FROM dbo.Subject)
    UNION ALL SELECT 'InterestQuestionCategory', 7,  (SELECT COUNT(*) FROM dbo.InterestQuestionCategory)
    UNION ALL SELECT 'UserAccount',             3,   (SELECT COUNT(*) FROM dbo.UserAccount)
    UNION ALL SELECT 'Learner',                 10,  (SELECT COUNT(*) FROM dbo.Learner)
    UNION ALL SELECT 'DegreeProgramme',         10,  (SELECT COUNT(*) FROM dbo.DegreeProgramme)
    UNION ALL SELECT 'ProgrammeRequirements',   22,  (SELECT COUNT(*) FROM dbo.ProgrammeRequirements)
    UNION ALL SELECT 'InterestQuestion',        10,  (SELECT COUNT(*) FROM dbo.InterestQuestion)
    UNION ALL SELECT 'DegreeInterestMap',       21,  (SELECT COUNT(*) FROM dbo.DegreeInterestMap)
    UNION ALL SELECT 'FundingOption',           10,  (SELECT COUNT(*) FROM dbo.FundingOption)
    UNION ALL SELECT 'FundingFaculty',          12,  (SELECT COUNT(*) FROM dbo.FundingFaculty)
    UNION ALL SELECT 'FundingProgramme',        4,   (SELECT COUNT(*) FROM dbo.FundingProgramme)
    UNION ALL SELECT 'LearnerSubject',          57,  (SELECT COUNT(*) FROM dbo.LearnerSubject)
    UNION ALL SELECT 'LearnerInterestReport',   100, (SELECT COUNT(*) FROM dbo.LearnerInterestReport)
    UNION ALL SELECT 'AdvisorySession',         10,  (SELECT COUNT(*) FROM dbo.AdvisorySession)
    UNION ALL SELECT 'RecommendationResult',    15,  (SELECT COUNT(*) FROM dbo.RecommendationResult)
    UNION ALL SELECT 'ExportReport',            4,   (SELECT COUNT(*) FROM dbo.ExportReport)
) AS t
ORDER BY result, tableName;

/* 2. Every learner answered all 10 interest questions (expect 0 rows) */
SELECT l.learnerID, l.fullName, COUNT(r.responseID) AS answers
FROM dbo.Learner l
LEFT JOIN dbo.LearnerInterestReport r ON r.learnerID = l.learnerID
GROUP BY l.learnerID, l.fullName
HAVING COUNT(r.responseID) <> 10;

/* 3. overallScore matches the weighting formula (expect 0 rows) */
SELECT rr.sessionID, rr.degreeID, rr.overallScore,
       CAST(0.4*rr.subjectMatchScore + 0.3*rr.markMatchScore + 0.2*rr.interestMatchScore + 0.1*rr.facultyPreference AS DECIMAL(5,2)) AS expectedScore
FROM dbo.RecommendationResult rr
WHERE rr.overallScore IS NOT NULL
  AND ABS(rr.overallScore - (0.4*rr.subjectMatchScore + 0.3*rr.markMatchScore + 0.2*rr.interestMatchScore + 0.1*rr.facultyPreference)) > 0.05;

/* 4. Login check: should return admin01 (hash of 'Admin@123') */
SELECT userID, username, role, isActive
FROM dbo.UserAccount
WHERE username = 'admin01'
  AND passwordHash = CONVERT(CHAR(64), HASHBYTES('SHA2_256', 'Admin@123'), 2);

/* 5. Sample end-to-end join: each session with its recommendations */
SELECT s.sessionID, l.fullName, g.gradeName, s.sessionDate,
       d.degreeName, rr.overallScore, rr.advisoryOutcome, rr.gapDescription,
       CASE WHEN rr.degreeID = s.degreeID THEN 'Selected' ELSE 'Alternative' END AS rowType
FROM dbo.AdvisorySession s
JOIN dbo.Learner l              ON l.learnerID = s.learnerID
JOIN dbo.GradeLevel g           ON g.gradeLevelID = l.gradeLevelID
JOIN dbo.RecommendationResult rr ON rr.sessionID = s.sessionID
JOIN dbo.DegreeProgramme d      ON d.degreeID = rr.degreeID
ORDER BY s.sessionID, rowType DESC, rr.overallScore DESC;

/* 6. Active funding open on/after a date, per faculty */
SELECT f.facultyName, fo.fundingName, fo.fundingType, fo.closingDate
FROM dbo.FundingOption fo
JOIN dbo.FundingFaculty ff ON ff.fundingID = fo.fundingID
JOIN dbo.Faculty f         ON f.facultyID = ff.facultyID
WHERE fo.isActive = 1
ORDER BY f.facultyName, fo.closingDate;
GO
