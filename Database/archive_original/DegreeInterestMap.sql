USE FuturePathDB;
GO

/* DegreeInterestMap   */
INSERT INTO DegreeInterestMap (degreeID, categoryID, weightedScore)
SELECT v.degreeID, v.categoryID, v.weightedScore
FROM (
	VALUE
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
WHERE NOT EXISTS (
	SELECT 1
    FROM DegreeInterestMap m
    WHERE m.degreeID = v.degreeID
    AND m.categoryID = v.categoryID
);
GO