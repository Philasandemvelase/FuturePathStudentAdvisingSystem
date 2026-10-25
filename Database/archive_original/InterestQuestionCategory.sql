USE FuturePathDB;
GO

/*  InterestQuestionCategory  */
SET IDENTITY_INSERT InterestQuestionCategory ON;
INSERT INTO InterestQuestionCategory (categoryID, categoryName)
SELECT v.id, v.name
FROM (
	VALUES
		(1, 'Numbers and Technology'),
        (2, 'Business and Finance'),
        (3, 'Science and Research'),
        (4, 'People and Community'),
        (5, 'Language and Ideas'),
        (6, 'Society and Law'),
        (7, 'Health and Life Sciences')
) AS v(id, name)
WHERE NOT EXISTS (
	SELECT 1
    FROM InterestQuestionCategory c
    WHERE c.categoryID = v.id
);
SET IDENTITY_INSERT InterestQuestionCategory OFF;
GO