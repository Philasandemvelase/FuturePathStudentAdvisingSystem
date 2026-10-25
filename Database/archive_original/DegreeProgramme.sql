USE FuturePathDB;
GO

/* ---------- DegreeProgramme ---------- */
SET IDENTITY_INSERT DegreeProgramme ON;
INSERT INTO DegreeProgramme (degreeID, facultyID, degreeName, description, isActive)
SELECT v.id, v.facultyID, v.name, v.description, v.isActive
FROM (
    VALUES
        (1, 1, 'BCom Information Systems',                  'Sample programme: information systems in business', 1),
        (2, 1, 'BCom Accounting',                           'Sample programme: accounting and financial reporting', 1),
        (3, 1, 'BCom General',                              'Sample programme: broad commerce degree', 1),
        (4, 3, 'BSc Computer Science',                      'Sample programme: computing and software', 1),
        (5, 3, 'BSc Biological Sciences',                   'Sample programme: life sciences', 1),
        (6, 4, 'BSc Engineering (Mechanical Engineering)'   'Sample programme: mechanical engineering' 1),
        (7, 2, 'BA Humanities',                             'Sample programme: languages,history and society', 1),
        (8, 2, 'BSocSci',                                   'Sample programme: social sciences', 1),
        (9, 6, 'LLB (Law)',                                 'Sample programme: law degree', 1),
        (10, 5, 'Bachelor of Health Sciences',                  'Sample programme: health sciences', 1),
        
) AS v(id, facultyID, name, description, isActive)
WHERE NOT EXISTS (
    SELECT 1
    FROM DegreeProgramme d
    WHERE d.degreeID = v.id
);
SET IDENTITY_INSERT Faculty OFF;
GO