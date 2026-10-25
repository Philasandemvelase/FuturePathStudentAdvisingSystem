USE FuturePathDB;
GO

/*   InterestQuestion    */
SET IDENTITY_INSERT InterestQuestion ON;
INSERT INTO InterestQuestion (questionID, questionText, categoryID, isActive)
SELECT v.id, v.questionText, v.categoryID, v.isActive
FROM (
	VALUES
		(1, 'I enjoy solving problems using numbers or data.',                    1,1),
        (2, 'I enjoy understanding how computers and digital systems work.',      1,1),
        (3, 'I enjoy learning how businesses operate and make decisions.',        2,1),
        (4, 'I enjoy planning how money could be earned, saved or spent.',        2,1),
        (5, 'I enjoy conducting experiments to understand why things happen.',    3,1),
        (6, 'I enjoy investigating questions about living things or the natural world.', 7,1),
        (7, 'I enjoy helping people work through challenges.',                    4,1),
        (8, 'I enjoy participating in activities that improve my community.',     4,1),
        (9, 'I enjoy reading, writing or discussing different viewpoints.',       5,1),
        (10, 'I enjoy exploring how society, laws and public decisions affect people.',  6,1)
) AS v(id, questionText, categoryID, isActive)
WHERE NOT EXISTS (
	SELECT 1
    FROM InterestQuestion q
    WHERE q.questionID = v.id
);
SET IDENTITY_INSERT InterestQuestion OFF;
GO