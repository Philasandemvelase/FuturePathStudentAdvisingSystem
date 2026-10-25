USE FuturePathDB;
GO

/* ------------ Faculty ------------ */
SET IDENTITY_INSERT Faculty ON;
INSERT INTO  Faculty (facultyID, facultyName)
SELECT v.id, v.name 
FROM(
    VALUES
        (1, 'Commerce'),
        (2, 'Humanities'),
        (3, 'Science'),
        (4, 'Engineering'),
        (5, 'Health Sciences'),
        (6, 'Law')
)As v(id, name)
WHERE NOT EXISTS (
    SELECT 1
    FROM Faculty f
    WHERE f.facultyID = v.id
);
SET IDENTITY_INSERT Faculty OFF;
Go