/* =====================================================================
   Future Path Student Advising System
   03_SeedData.sql  -  populates every table with the team's sample data

   - Inserts run in foreign-key order (parents before children).
   - Safe to re-run: every INSERT skips rows that already exist.
   - Runs as ONE transaction: if any row fails, nothing is kept.
   - Tables whose IDs are referenced elsewhere are inserted with fixed
     IDs (SET IDENTITY_INSERT ON) so the numbers below line up.
   ===================================================================== */
USE FuturePathDB;
GO

SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRY
BEGIN TRANSACTION;

/* ------------------------------ GradeLevel ------------------------------ */
SET IDENTITY_INSERT dbo.GradeLevel ON;
INSERT INTO dbo.GradeLevel (gradeLevelID, gradeName)
SELECT v.id, v.name
FROM (VALUES
        (1, 'Grade 11'),
        (2, 'Grade 12')
     ) AS v(id, name)
WHERE NOT EXISTS (SELECT 1 FROM dbo.GradeLevel g WHERE g.gradeLevelID = v.id);
SET IDENTITY_INSERT dbo.GradeLevel OFF;

/* ------------------------------- Faculty -------------------------------- */
SET IDENTITY_INSERT dbo.Faculty ON;
INSERT INTO dbo.Faculty (facultyID, facultyName)
SELECT v.id, v.name
FROM (VALUES
        (1, 'Commerce'),
        (2, 'Humanities'),
        (3, 'Science'),
        (4, 'Engineering'),
        (5, 'Health Sciences'),
        (6, 'Law')
     ) AS v(id, name)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Faculty f WHERE f.facultyID = v.id);
SET IDENTITY_INSERT dbo.Faculty OFF;

/* ------------------------------- Subject -------------------------------- */
SET IDENTITY_INSERT dbo.Subject ON;
INSERT INTO dbo.Subject (subjectID, subjectName)
SELECT v.id, v.name
FROM (VALUES
        (1,  'English'),
        (2,  'Afrikaans'),
        (3,  'Mathematics'),
        (4,  'Mathematical Literacy'),
        (5,  'Physical Sciences'),
        (6,  'Life Sciences'),
        (7,  'Accounting'),
        (8,  'Business Studies'),
        (9,  'Economics'),
        (10, 'Geography'),
        (11, 'History'),
        (12, 'Computer Applications Technology'),
        (13, 'Life Orientation'),
        (14, 'Tourism'),
        (15, 'Engineering Graphics and Design'),
        (16, 'Visual Arts')
     ) AS v(id, name)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Subject s WHERE s.subjectID = v.id);
SET IDENTITY_INSERT dbo.Subject OFF;

/* ----------------------- InterestQuestionCategory ----------------------- */
SET IDENTITY_INSERT dbo.InterestQuestionCategory ON;
INSERT INTO dbo.InterestQuestionCategory (categoryID, categoryName)
SELECT v.id, v.name
FROM (VALUES
        (1, 'Numbers and Technology'),
        (2, 'Business and Finance'),
        (3, 'Science and Research'),
        (4, 'People and Community'),
        (5, 'Language and Ideas'),
        (6, 'Society and Law'),
        (7, 'Health and Life Sciences')
     ) AS v(id, name)
WHERE NOT EXISTS (SELECT 1 FROM dbo.InterestQuestionCategory c WHERE c.categoryID = v.id);
SET IDENTITY_INSERT dbo.InterestQuestionCategory OFF;

/* ----------------------------- UserAccount ------------------------------
   Passwords are stored as SHA-256, 64 uppercase hex chars.
   Login test values:  admin01 / Admin@123   advisor01 / Advisor@123
                       advisor02 / Admin@456 (inactive account)
   The C# PasswordHasher class produces exactly the same hash.          */
INSERT INTO dbo.UserAccount (username, passwordHash, role, isActive)
SELECT v.username, CONVERT(CHAR(64), HASHBYTES('SHA2_256', v.plainPassword), 2), v.role, v.isActive
FROM (VALUES
        ('admin01',   CAST('Admin@123'   AS VARCHAR(50)), 'Administrator',  1),
        ('advisor01', CAST('Advisor@123' AS VARCHAR(50)), 'Career Advisor', 1),
        ('advisor02', CAST('Admin@456'   AS VARCHAR(50)), 'Career Advisor', 0)
     ) AS v(username, plainPassword, role, isActive)
WHERE NOT EXISTS (SELECT 1 FROM dbo.UserAccount u WHERE u.username = v.username);

/* ------------------------------- Learner -------------------------------- */
SET IDENTITY_INSERT dbo.Learner ON;
INSERT INTO dbo.Learner (learnerID, fullName, gradeLevelID, schoolName, province, contactDetails)
SELECT v.id, v.fullName, v.gradeLevelID, v.schoolName, v.province, v.contactDetails
FROM (VALUES
        (1,  'Gadija Jacobs',      2, 'Lakeside Secondary School',      'Western Cape',  NULL),
        (2,  'Aadiel-Raboo Magwa', 2, 'Hillview High School',            'Gauteng',       NULL),
        (3,  'Labeeqah Rademeyer', 1, 'Lakeside Secondary School',      'Western Cape',  'labeeqah.r@example.com'),
        (4,  'Siyabonga Dickson',  2, 'Hillview Technical High School',  'KwaZulu-Natal', NULL),
        (5,  'Derek Vin Diesel',   2, 'Hillview High School',            'Western Cape',  NULL),
        (6,  'Thabo Nkosi',        1, 'Hillview High School',            'Gauteng',       NULL),
        (7,  'Zanele Dlamini',     2, 'Lakeside Secondary School',      'KwaZulu-Natal', 'zanele.d@example.com'),
        (8,  'Ayesha Patel',       2, 'Hillview Commercial High School', 'Gauteng',       NULL),
        (9,  'Sipho Mokoena',      2, 'Hillview High School',            'Free State',    NULL),
        (10, 'Lerato Molefe',      1, 'Lakeside Secondary School',      'Eastern Cape',  NULL)
     ) AS v(id, fullName, gradeLevelID, schoolName, province, contactDetails)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Learner l WHERE l.learnerID = v.id);
SET IDENTITY_INSERT dbo.Learner OFF;

/* --------------------------- DegreeProgramme ---------------------------- */
SET IDENTITY_INSERT dbo.DegreeProgramme ON;
INSERT INTO dbo.DegreeProgramme (degreeID, facultyID, degreeName, description, isActive)
SELECT v.id, v.facultyID, v.name, v.description, v.isActive
FROM (VALUES
        (1,  1, 'BCom Information Systems',                 'Information systems in business',  1),
        (2,  1, 'BCom Accounting',                          'Accounting and financial reporting', 1),
        (3,  1, 'BCom General',                             'Broad commerce degree',             1),
        (4,  3, 'BSc Computer Science',                     'Computing and software',            1),
        (5,  3, 'BSc Biological Sciences',                  'Life sciences',                     1),
        (6,  4, 'BSc Engineering (Mechanical Engineering)', 'Mechanical engineering',            1),
        (7,  2, 'BA Humanities',                            'Languages, history and society',    1),
        (8,  2, 'BSocSci',                                  'Social sciences',                   1),
        (9,  6, 'LLB (Law)',                                'Law degree',                        1),
        (10, 5, 'Bachelor of Health Sciences',              'Health sciences',                   1)
     ) AS v(id, facultyID, name, description, isActive)
WHERE NOT EXISTS (SELECT 1 FROM dbo.DegreeProgramme d WHERE d.degreeID = v.id);
SET IDENTITY_INSERT dbo.DegreeProgramme OFF;

/* ------------------------ ProgrammeRequirements ------------------------- */
INSERT INTO dbo.ProgrammeRequirements (degreeID, subjectID, minimumMark, isRequired, acceptedAlternativeSubjectID, notes)
SELECT v.degreeID, v.subjectID, v.minimumMark, v.isRequired, v.altSubjectID, v.notes
FROM (VALUES
        (1,  1, 60, 1, NULL, 'English is required.'),
        (1,  3, 60, 1, NULL, 'Mathematics is required.'),
        (2,  3, 60, 1, NULL, 'Mathematics is required.'),
        (2,  7, 60, 1, NULL, 'Accounting is required.'),
        (3,  1, 60, 1, NULL, 'English is required.'),
        (3,  3, 50, 1, 4,    'Mathematics or Mathematical Literacy accepted.'),
        (4,  1, 60, 1, NULL, 'English is required.'),
        (4,  3, 60, 1, NULL, 'Mathematics is required; Mathematical Literacy is not accepted.'),
        (5,  1, 60, 1, NULL, 'English is required.'),
        (5,  3, 60, 1, NULL, 'Mathematics is required.'),
        (5,  6, 60, 1, NULL, 'Life Sciences is required.'),
        (6,  1, 60, 1, NULL, 'English is required.'),
        (6,  3, 70, 1, NULL, 'Mathematics is required.'),
        (6,  5, 70, 1, NULL, 'Physical Sciences is required.'),
        (7,  1, 60, 1, NULL, 'English is required.'),
        (7,  3, 50, 1, 4,    'Mathematics or Mathematical Literacy accepted.'),
        (8,  1, 65, 1, NULL, 'English is required.'),
        (8,  3, 50, 1, 4,    'Mathematics or Mathematical Literacy accepted.'),
        (9,  1, 70, 1, NULL, 'English is required.'),
        (10, 3, 60, 1, NULL, 'Mathematics is required.'),
        (10, 5, 60, 1, NULL, 'Physical Sciences is required.'),
        (10, 6, 60, 1, NULL, 'Life Sciences is required.')
     ) AS v(degreeID, subjectID, minimumMark, isRequired, altSubjectID, notes)
WHERE NOT EXISTS (SELECT 1 FROM dbo.ProgrammeRequirements pr
                  WHERE pr.degreeID = v.degreeID AND pr.subjectID = v.subjectID);

/* --------------------------- InterestQuestion --------------------------- */
SET IDENTITY_INSERT dbo.InterestQuestion ON;
INSERT INTO dbo.InterestQuestion (questionID, questionText, categoryID, isActive)
SELECT v.id, v.questionText, v.categoryID, v.isActive
FROM (VALUES
        (1,  'I enjoy solving problems using numbers or data.',                          1, 1),
        (2,  'I enjoy understanding how computers and digital systems work.',            1, 1),
        (3,  'I enjoy learning how businesses operate and make decisions.',              2, 1),
        (4,  'I enjoy planning how money could be earned, saved or spent.',              2, 1),
        (5,  'I enjoy conducting experiments to understand why things happen.',          3, 1),
        (6,  'I enjoy investigating questions about living things or the natural world.', 7, 1),
        (7,  'I enjoy helping people work through challenges.',                          4, 1),
        (8,  'I enjoy participating in activities that improve my community.',           4, 1),
        (9,  'I enjoy reading, writing or discussing different viewpoints.',             5, 1),
        (10, 'I enjoy exploring how society, laws and public decisions affect people.',  6, 1)
     ) AS v(id, questionText, categoryID, isActive)
WHERE NOT EXISTS (SELECT 1 FROM dbo.InterestQuestion q WHERE q.questionID = v.id);
SET IDENTITY_INSERT dbo.InterestQuestion OFF;

/* -------------------------- DegreeInterestMap --------------------------- */
INSERT INTO dbo.DegreeInterestMap (degreeID, categoryID, weightedScore)
SELECT v.degreeID, v.categoryID, v.weightedScore
FROM (VALUES
        (1, 1, 1.00), (1, 2, 0.80),
        (2, 2, 1.00), (2, 1, 0.60),
        (3, 2, 1.00), (3, 5, 0.40),
        (4, 1, 1.00), (4, 3, 0.50),
        (5, 3, 1.00), (5, 7, 0.90),
        (6, 3, 1.00), (6, 1, 0.80),
        (7, 5, 1.00), (7, 6, 0.60),
        (8, 4, 1.00), (8, 6, 0.80),
        (9, 6, 1.00), (9, 5, 0.80),
        (10, 7, 1.00), (10, 4, 0.70), (10, 3, 0.50)
     ) AS v(degreeID, categoryID, weightedScore)
WHERE NOT EXISTS (SELECT 1 FROM dbo.DegreeInterestMap m
                  WHERE m.degreeID = v.degreeID AND m.categoryID = v.categoryID);

/* ---------------------------- FundingOption ----------------------------- */
SET IDENTITY_INSERT dbo.FundingOption ON;
INSERT INTO dbo.FundingOption (fundingID, fundingName, fundingType, eligibilityDescription, requiredDocuments, closingDate, contactInfo, isActive)
SELECT v.id, v.fundingName, v.fundingType, v.eligibility, v.requiredDocuments, v.closingDate, v.contactInfo, v.isActive
FROM (VALUES
        (1,  'Commerce Merit Award',             'Scholarship',      'Based on academic merit; verify the provider''s criteria.',     'Results, identity document, application form',     '2026-11-30', 'Contact: commerce.awards@example.org',     1),
        (2,  'Study Support Bursary',            'Bursary',          'Based on financial need.',                                      'Results, ID, proof of income',                     '2026-12-15', 'Contact: bursaries@example.org',           1),
        (3,  'Science Excellence Scholarship',   'Scholarship',      'Based on academic merit in science subjects.',                  'Results, identity document',                       '2026-11-15', 'Contact: science.awards@example.org',      1),
        (4,  'Engineering Talent Bursary',       'Bursary',          'Based on academic merit and financial need.',                   'Results, ID, proof of income',                     '2026-10-31', 'Contact: eng.bursary@example.org',         1),
        (5,  'Health Sciences Merit Award',      'Scholarship',      'Based on academic merit.',                                      'Results, identity document, motivation letter',    '2026-11-20', 'Contact: health.awards@example.org',       1),
        (6,  'Health Sciences Need Bursary',     'Bursary',          'Based on financial need.',                                      'Results, ID, proof of income',                     '2026-12-01', 'Contact: health.bursary@example.org',      1),
        (7,  'Humanities Community Scholarship', 'Scholarship',      'Based on academic merit and community involvement.',            'Results, identity document, reference letter',     '2027-01-15', 'Contact: humanities@example.org',          1),
        (8,  'General Financial Aid',            'Financial Aid',    'Based on financial need.',                                      'Results, ID, proof of income',                     '2027-01-31', 'Contact: finaid@example.org',              1),
        (9,  'External Corporate Bursary',       'External Funding', 'Based on academic merit; technical fields only.',               'Results, ID, application form',                    '2026-12-10', 'Contact: corporate.bursary@example.org',   1),
        (10, 'Expired Merit Award',              'Scholarship',      'Based on academic merit (inactive, tests exclusion).',          'Results, identity document',                       '2026-06-30', 'Contact: old.award@example.org',           0)
     ) AS v(id, fundingName, fundingType, eligibility, requiredDocuments, closingDate, contactInfo, isActive)
WHERE NOT EXISTS (SELECT 1 FROM dbo.FundingOption fo WHERE fo.fundingID = v.id);
SET IDENTITY_INSERT dbo.FundingOption OFF;

/* ---------------------------- FundingFaculty ---------------------------- */
INSERT INTO dbo.FundingFaculty (fundingID, facultyID)
SELECT v.fundingID, v.facultyID
FROM (VALUES
        (1, 1),            -- Commerce
        (2, 1), (2, 2),    -- Commerce, Humanities
        (3, 3),            -- Science
        (4, 4),            -- Engineering
        (5, 5),            -- Health Sciences
        (6, 5),            -- Health Sciences
        (7, 2),            -- Humanities
        (8, 6),            -- Law
        (9, 3), (9, 4),    -- Science, Engineering
        (10, 1)            -- Commerce (inactive)
     ) AS v(fundingID, facultyID)
WHERE NOT EXISTS (SELECT 1 FROM dbo.FundingFaculty ff
                  WHERE ff.fundingID = v.fundingID AND ff.facultyID = v.facultyID);

/* --------------------------- FundingProgramme --------------------------- */
INSERT INTO dbo.FundingProgramme (fundingID, degreeID)
SELECT v.fundingID, v.degreeID
FROM (VALUES
        (1, 1),            -- Commerce Merit Award      -> BCom Information Systems
        (3, 5),            -- Science Excellence        -> BSc Biological Sciences
        (9, 4), (9, 6)     -- External Corporate Bursary -> BSc Computer Science, BSc Mechanical Engineering
     ) AS v(fundingID, degreeID)
WHERE NOT EXISTS (SELECT 1 FROM dbo.FundingProgramme fp
                  WHERE fp.fundingID = v.fundingID AND fp.degreeID = v.degreeID);

/* ---------------------------- LearnerSubject ---------------------------- */
INSERT INTO dbo.LearnerSubject (learnerID, subjectID, mark)
SELECT v.learnerID, v.subjectID, v.mark
FROM (VALUES
        -- 1 Gadija Jacobs
        (1, 1, 72), (1, 3, 70), (1, 7, 74), (1, 8, 79), (1, 9, 70), (1, 13, 80),
        -- 2 Aadiel-Raboo Magwa (Mathematical Literacy, no Mathematics)
        (2, 1, 65), (2, 4, 78), (2, 8, 71), (2, 11, 69), (2, 14, 75), (2, 13, 82),
        -- 3 Labeeqah Rademeyer (Mathematics 58%, below 60%)
        (3, 1, 80), (3, 3, 58), (3, 5, 62), (3, 6, 70), (3, 10, 66), (3, 13, 85),
        -- 4 Siyabonga Dickson
        (4, 1, 70), (4, 3, 75), (4, 5, 78), (4, 15, 73), (4, 13, 80),
        -- 5 Derek Vin Diesel (no Mathematics / Physical Sciences)
        (5, 1, 82), (5, 4, 76), (5, 11, 79), (5, 6, 68), (5, 16, 85), (5, 13, 90),
        -- 6 Thabo Nkosi (Mathematics mark NOT supplied -> More Information Needed)
        (6, 1, 68), (6, 3, NULL), (6, 5, 64), (6, 12, 72), (6, 13, 75),
        -- 7 Zanele Dlamini
        (7, 1, 78), (7, 2, 66), (7, 11, 72), (7, 4, 70), (7, 13, 81),
        -- 8 Ayesha Patel (Mathematics 55%, below 60%)
        (8, 1, 74), (8, 3, 55), (8, 7, 68), (8, 9, 71), (8, 8, 66), (8, 13, 79),
        -- 9 Sipho Mokoena
        (9, 1, 71), (9, 3, 66), (9, 6, 72), (9, 5, 61), (9, 10, 68), (9, 13, 77),
        -- 10 Lerato Molefe
        (10, 1, 69), (10, 4, 64), (10, 11, 75), (10, 2, 71), (10, 14, 66), (10, 13, 83)
     ) AS v(learnerID, subjectID, mark)
WHERE NOT EXISTS (SELECT 1 FROM dbo.LearnerSubject ls
                  WHERE ls.learnerID = v.learnerID AND ls.subjectID = v.subjectID);

/* ------------------------ LearnerInterestReport -------------------------
   (questionID, learnerID, selectedOptionValue)  values are 1..5          */
INSERT INTO dbo.LearnerInterestReport (questionID, learnerID, selectedOptionValue)
SELECT v.questionID, v.learnerID, v.selectedOptionValue
FROM (VALUES
        -- learner 1:  4 4 5 5 2 2 3 3 3 2
        (1, 1, 4), (2, 1, 4), (3, 1, 5), (4, 1, 5), (5, 1, 2), (6, 1, 2), (7, 1, 3), (8, 1, 3), (9, 1, 3), (10, 1, 2),
        -- learner 2:  2 2 4 4 2 2 4 4 4 4
        (1, 2, 2), (2, 2, 2), (3, 2, 4), (4, 2, 4), (5, 2, 2), (6, 2, 2), (7, 2, 4), (8, 2, 4), (9, 2, 4), (10, 2, 4),
        -- learner 3:  3 3 2 2 5 5 4 3 2 2
        (1, 3, 3), (2, 3, 3), (3, 3, 2), (4, 3, 2), (5, 3, 5), (6, 3, 5), (7, 3, 4), (8, 3, 3), (9, 3, 2), (10, 3, 2),
        -- learner 4:  5 4 2 2 5 3 3 3 2 2
        (1, 4, 5), (2, 4, 4), (3, 4, 2), (4, 4, 2), (5, 4, 5), (6, 4, 3), (7, 4, 3), (8, 4, 3), (9, 4, 2), (10, 4, 2),
        -- learner 5:  2 2 2 2 3 4 5 4 5 3
        (1, 5, 2), (2, 5, 2), (3, 5, 2), (4, 5, 2), (5, 5, 3), (6, 5, 4), (7, 5, 5), (8, 5, 4), (9, 5, 5), (10, 5, 3),
        -- learner 6:  4 5 3 3 3 2 2 2 2 2   (Q8-Q10 were copy-pasted as learner 5 in the original - see notes)
        (1, 6, 4), (2, 6, 5), (3, 6, 3), (4, 6, 3), (5, 6, 3), (6, 6, 2), (7, 6, 2), (8, 6, 2), (9, 6, 2), (10, 6, 2),
        -- learner 7:  2 2 3 2 2 2 4 4 5 5
        (1, 7, 2), (2, 7, 2), (3, 7, 3), (4, 7, 2), (5, 7, 2), (6, 7, 2), (7, 7, 4), (8, 7, 4), (9, 7, 5), (10, 7, 5),
        -- learner 8:  4 3 5 5 2 2 3 3 3 2
        (1, 8, 4), (2, 8, 3), (3, 8, 5), (4, 8, 5), (5, 8, 2), (6, 8, 2), (7, 8, 3), (8, 8, 3), (9, 8, 3), (10, 8, 2),
        -- learner 9:  2 2 2 2 3 3 3 4 5 5
        (1, 9, 2), (2, 9, 2), (3, 9, 2), (4, 9, 2), (5, 9, 3), (6, 9, 3), (7, 9, 3), (8, 9, 4), (9, 9, 5), (10, 9, 5),
        -- learner 10: 2 2 2 2 2 2 4 4 5 4
        (1, 10, 2), (2, 10, 2), (3, 10, 2), (4, 10, 2), (5, 10, 2), (6, 10, 2), (7, 10, 4), (8, 10, 4), (9, 10, 5), (10, 10, 4)
     ) AS v(questionID, learnerID, selectedOptionValue)
WHERE NOT EXISTS (SELECT 1 FROM dbo.LearnerInterestReport r
                  WHERE r.learnerID = v.learnerID AND r.questionID = v.questionID);

/* --------------------------- AdvisorySession ----------------------------
   facultyID (preferred faculty) is taken from the selected degree, which
   is what the facultyPreference scores in RecommendationResult assume.   */
SET IDENTITY_INSERT dbo.AdvisorySession ON;
INSERT INTO dbo.AdvisorySession (sessionID, learnerID, facultyID, degreeID, sessionDate, fundingRequested)
SELECT v.id, v.learnerID, d.facultyID, v.degreeID, v.sessionDate, v.fundingRequested
FROM (VALUES
        (1,  1,  1,  '2026-09-11', 1),   -- Gadija    -> BCom IS                 Strong Match, requested funding
        (2,  2,  4,  '2026-09-14', 0),   -- Aadiel    -> BSc Computer Science    Not Currently Eligible (Maths missing)
        (3,  3,  5,  '2026-09-08', 1),   -- Labeeqah  -> BSc Biological Sci.     Possible Match (Maths gap)
        (4,  4,  6,  '2026-09-09', 0),   -- Siyabonga -> BSc Mech Eng            Strong Match
        (5,  5,  10, '2026-08-17', 1),   -- Derek     -> Health Sciences         Not Currently Eligible
        (6,  6,  4,  '2026-06-26', 0),   -- Thabo     -> BSc Computer Science    More Information Needed
        (7,  7,  9,  '2026-09-10', 0),   -- Zanele    -> LLB                     Strong Match
        (8,  8,  2,  '2026-09-02', 1),   -- Ayesha    -> BCom Accounting         Possible Match
        (9,  9,  5,  '2026-09-03', 0),   -- Sipho     -> BSc Biological Sci.     Possible Match (interests fit Humanities)
        (10, 10, 7,  '2026-09-07', 0)    -- Lerato    -> BA Humanities           Strong Match
     ) AS v(id, learnerID, degreeID, sessionDate, fundingRequested)
JOIN dbo.DegreeProgramme d ON d.degreeID = v.degreeID
WHERE NOT EXISTS (SELECT 1 FROM dbo.AdvisorySession s WHERE s.sessionID = v.id);
SET IDENTITY_INSERT dbo.AdvisorySession OFF;

/* ------------------------- RecommendationResult -------------------------
   overall = 0.4*subject + 0.3*mark + 0.2*interest + 0.1*facultyPreference
   (scoring weights are the team's assumption).
   First row per session = the degree the learner selected;
   extra rows = recommended alternatives.                                  */
INSERT INTO dbo.RecommendationResult
       (sessionID, degreeID, subjectMatchScore, markMatchScore, interestMatchScore, facultyPreference, overallScore, advisoryOutcome, gapDescription)
SELECT v.sessionID, v.degreeID, v.subjectScore, v.markScore, v.interestScore, v.facultyPref, v.overallScore, v.outcome, v.gap
FROM (VALUES
        (1,  1,  100.00, 100.00, 85.00, 100.00, 97.00, 'Strong Match',            'None identified'),
        (2,  4,   50.00,  50.00, 40.00, 100.00, 53.00, 'Not Currently Eligible',  'Required subject missing: Mathematics (Mathematical Literacy not accepted)'),
        (2,  3,  100.00, 100.00, 70.00,   0.00, 84.00, 'Strong Match',            'None identified'),
        (2,  7,  100.00, 100.00, 75.00,   0.00, 85.00, 'Strong Match',            'None identified'),
        (3,  5,  100.00,  66.67, 80.00, 100.00, 86.00, 'Possible Match',          'Mathematics mark 58% is below the minimum of 60%'),
        (4,  6,  100.00, 100.00, 90.00, 100.00, 98.00, 'Strong Match',            'None identified'),
        (5,  10,  33.33,  33.33, 55.00, 100.00, 44.33, 'Not Currently Eligible',  'Required subjects missing: Mathematics and Physical Sciences'),
        (5,  7,  100.00, 100.00, 70.00,   0.00, 84.00, 'Strong Match',            'None identified'),
        (5,  8,  100.00, 100.00, 75.00,   0.00, 85.00, 'Strong Match',            'None identified'),
        (6,  4,  NULL,   NULL,   60.00, 100.00, NULL,  'More Information Needed', 'Mathematics mark not supplied; assessment cannot be completed'),
        (7,  9,  100.00, 100.00, 85.00, 100.00, 97.00, 'Strong Match',            'None identified'),
        (8,  2,  100.00,  50.00, 80.00, 100.00, 81.00, 'Possible Match',          'Mathematics mark 55% is below the minimum of 60%'),
        (9,  5,  100.00, 100.00, 35.00, 100.00, 87.00, 'Possible Match',          'Interest alignment: interests align more closely with Humanities'),
        (9,  7,  100.00, 100.00, 90.00,   0.00, 88.00, 'Strong Match',            'None identified'),
        (10, 7,  100.00, 100.00, 85.00, 100.00, 97.00, 'Strong Match',            'None identified')
     ) AS v(sessionID, degreeID, subjectScore, markScore, interestScore, facultyPref, overallScore, outcome, gap)
WHERE NOT EXISTS (SELECT 1 FROM dbo.RecommendationResult rr
                  WHERE rr.sessionID = v.sessionID AND rr.degreeID = v.degreeID);

/* ----------------------------- ExportReport ----------------------------- */
INSERT INTO dbo.ExportReport (sessionID, disclaimerText, reportFormat, exportDate)
SELECT v.sessionID, v.disclaimerText, v.reportFormat, v.exportDate
FROM (VALUES
        (1,  'Advisory guidance only. Not an official admission or funding decision.', 'PDF', '2026-09-11'),
        (4,  'Advisory guidance only. Not an official admission or funding decision.', 'PDF', '2026-09-09'),
        (7,  'Advisory guidance only. Not an official admission or funding decision.', 'TXT', '2026-09-10'),
        (10, 'Advisory guidance only. Not an official admission or funding decision.', 'PDF', '2026-09-07')
     ) AS v(sessionID, disclaimerText, reportFormat, exportDate)
WHERE NOT EXISTS (SELECT 1 FROM dbo.ExportReport er
                  WHERE er.sessionID = v.sessionID
                    AND er.reportFormat = v.reportFormat
                    AND CAST(er.exportDate AS DATE) = CAST(v.exportDate AS DATE));

COMMIT TRANSACTION;
PRINT 'Seed data loaded successfully.';
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    PRINT 'Seeding FAILED - nothing was saved. Error below:';
    THROW;
END CATCH;
GO
