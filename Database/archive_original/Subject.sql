USE FuturePathDB;
GO 

/* ----------- Subject ----------- */
SET IDENTITY_INSERT Subject ON;
INSERT INTO Subject (subjectID, subjectName)
SELECT v.id, v.name
FROM(
    VALUES
        (1, 'English'),
        (2, 'Afrikaans'),
        (3, 'Mathematics'),
        (4, 'Mathematical Literacy'),
        (5, 'Physical Science'),
        (6, 'Life Sciences'),
        (7, 'Accounting'),
        (8, 'Business Studies'),
        (9, 'Economics'),
        (10, 'Geography'),
        (11, 'History'),
        (12, 'Computer Application Technology'),
        (13, 'Life Orientation'),
        (14, 'Tourism'),
        (15, 'Engineering Graphics and Design'),
        (16, 'Visual Arts')
)AS v(id, name)
WHERE NOT EXISTS(
    SELECT 1
    FROM Subject s
    WHERE s.subjectID = v.id
);
SET IDENTITY_INSERT Subject OFF;
GO