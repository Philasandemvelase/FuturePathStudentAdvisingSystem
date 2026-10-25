
USE Advisory

Go 

INSERT INTO LearnerSubject (learnerID, subjectID, mark)
SELECT v.learnerID, v.subjectID, v.mark)
FROM (
	VALUES
		-- 1 Gadija Jacobs
		(1, 1, 72), (1, 3, 70), (1, 7, 74), (1, 8, 79), (1, 9, 70), (1, 13, 80),
		-- 2 Aadiel-Raboo Magwa
		(2, 1, 65), (2, 4, 78), (2, 8, 71), (2, 11, 69), (2, 14, 75), (2, 13, 82),
		-- 3 Labeeqah Rademeyer
		(3, 1, 80), (3, 3, 58), (3, 5, 62), (3, 6, 70), (3, 10, 66), (3, 13, 85),
		-- 4 Siyabonga Dickson
		(4, 1, 70), (4, 3, 75), (4, 5, 78), (4, 15, 73), (4, 13, 80),
		-- 5 Derek Vin Diesel
		(5, 1, 82), (5, 4, 76), (5, 11, 79), (5, 6, 68), (5, 16, 85), (5, 13, 90),		
		Thabo Nkosi (Mathematics mark NOT supplied - More Information Needed)
		(6, 1, 68), (6, 3, NULL, (6, 5,64), (6, 12, 72), (6, 13,75),
		-- 7 Zanele Dlamini
		(7, 1, 78), (7, 2, 66), (7, 11, 72), (7, 4, 70), (7, 13, 81),
		-- 8 Ayesha Patel
		(8, 1, 74), (8, 3, 55), (8, 7, 68), (8, 9, 71), (8, 8, 66), (8, 13, 79),
		-- 9 Sipho Mokoena
		(9, 1, 71), (9, 3, 66), (9, 6, 72), (9, 5, 61), (9, 10, 68), (9, 13, 77),
		-- 10 Lerato Molefe
		(10, 1, 69), (10, 4, 64), (10, 11, 75), (10, 2, 71), (10, 14, 66), (10, 13, 83)
) AS v(learnerID, subjectID, mark)
WHERE NOT EXISTS (
	SELECT 1
	FROM Learner Subject 1s
	WHERE ls.learnerID = v.learnerID
		AND ls.subjectID = v.subjectID
);
GO