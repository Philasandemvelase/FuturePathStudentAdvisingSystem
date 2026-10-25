USE FuturePathDB
GO

/*    Learner  */
SET IDENTITY_INSERT Learner ON;
INSERT INTO Learner (learnerID, fullName, gradeLevelID, schoolName, province, contactDetails)
SELECT v.id, v.fullName, v.gradeLevelID, v.schoolName, v.province, v.contactDetails
FROM (
	VALUES
		(1, 'Gadija Jacobs', 2, 'Example Secondary School', 'Western Cape', NULL),
        (2, 'Aadiel-Raboo Magwa', 2, 'Sample High School', 'Gauteng', NULL),
        (3, 'Labeeqah Rademeyer', 1, 'Example Secondary School', 'Western Cape', 'labeeqah.r@example.com'),
        (4, 'Siyabonga Dickson', 2, 'Sample Technical High School', 'KwaZulu-Natal', NULL),
        (5, 'Derek Vin Diesel', 2, 'Sample High School', 'Western Cape', NULL),
        (6, 'Thabo Nkosi', 1, 'Sample High School', 'Gauteng', NULL),
        (7, 'Zanele Dlamini', 2, 'Example Secondary School', 'KwaZulu-Natal', 'zanele.d@example.com'),
        (8, 'Ayesha Patel', 2, 'Sample Commercial High School School', 'Gauteng', NULL),
        (9, 'Sipho Mokoena', 2, 'Sample High School', 'Free State', NULL),
        (10, 'Lerato Molefe', 1, 'Example Secondary School', 'Eastern Cape', NULL)
) AS v(id, fullName, gradeLevelID, schoolName, province, contactDetails)
WHERE NOT EXISTS (
	SELECT 1
    FROM Learner 1
    WHERE 1.learnerID = v.id
);
SET IDENTITY_INSERT Learner OFF;
GO