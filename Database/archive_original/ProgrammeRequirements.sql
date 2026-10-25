USE FuturePathDB;
GO

/* ------------ ProgrammeRequirement ------------ */

INSERT INTO  ProgrammeRequirements (degreeID, subjectID, minimumMark, isRequired, acceptedAlternativeSubjectID, notes)
SELECT v.degreeID, v.subjectID, v.minimumMark, v.isRequired, v.altSubjectID, v.notes
FROM(
    VALUES
        (1, 1, 60, 1, NULL, 'English is required.'),
        (1, 3, 60, 1, NULL, 'Mathematics is required.'),
        (2, 3, 60, 1, NULL, 'Mathematics is required.'),
        (2, 7, 60, 1, NULL, 'Accounting is required.'),
        (3, 1, 60, 1, NULL, 'English is required.'),
        (3, 3, 50, 1, 4, 'Mathematics or Mathematical Literacy accepted.'),
        (4, 1, 60, 1, NULL, 'English is required.'),
        (4, 3, 60, 1, NuLL, 'Mathematics is required; Mathematical Literacy is accepted.'),
        (5, 1, 60, 1, NULL, 'English is required.'),
        (5, 3, 60, 1, NULL, 'Mathematics is required.'),
        (5, 6, 60, 1, NULL, 'Life Sciences is required.'),
        (6, 1, 60, 1, NULL, 'English is required.'),
        (6, 3, 70, 1, NULL, 'Mathematics is required.'),
        (6, 5, 70, 1, NULL, 'Physical Sciences is required.'),
        (7, 1, 60, 1, NULL, 'English is required.'),
        (7, 3, 50, 1, 4, 'Mathematics or Mathematical Literacy accepted.'),
        (8, 1, 65, 1, NULL, 'English is required.'),
        (8, 3, 50, 1, 4, 'Mathematics or Mathematical Literacy accepted.'),
        (9, 1, 70, 1, NULL, 'English is required.'),
        (10, 3, 60, 1, NULL, 'Mathematics is required.'),
        (10, 5, 60, 1, NULL, 'Physical Sciences is required.'),
        (10, 6, 60, 1, NULL, 'Life Sciences is required.'),

       
)As v(degreeID, subjectID, minimumMark, isRequired, altSubjectID, notes)
WHERE NOT EXISTS (
    SELECT 1
    FROM ProgrammeRequirements pr
    WHERE pr.degreeID = v.degreeID
        AND pr.subjectID = v.subjectID
);
Go