USE FuturePathDB;
GO

/* ------------ Grade Level ------------ */
SET IDENTITY_INSERT GradeLevel ON;
INSERT INTO  GradeLevel (gradeLevelID, gradeName)
SELECT v.id, v.name 
FROM(
    VALUES
        (1, 'Grade 11'),
        (2, 'Grade 12')
)As v(id, name)
WHERE NOT EXISTS (
    SELECT 1
    FROM GradeLevel g 
    WHERE g.gradeLevelID = v.id
);
SET IDENTITY_INSERT GradeLevel OFF;
Go