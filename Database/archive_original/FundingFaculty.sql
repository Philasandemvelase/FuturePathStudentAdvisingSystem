
USE FuturePathDB;
GO

/*-------- FundingFaculty ---------- */ 
INSERT INTO FundingFaculty (fundingID, facultylD)
SELECT v.fundingID, v.facultylD
FROM (
	VALUES 
		(1, 1),					-- Commerce
		(2, 1), (2, 2), 				-- Commerce, Humanities 
		(3, 3),					-- Science
		(4, 4),					-- Engineering
		(5, 5),					-- Health Sciences
		(6, 5),					-- Health Sciences
		(7, 2),					-- Humanities
		(8, 6),					-- Law
		(9, 3), (9, 4), 				-- Science, Engineering
		(10, 1)					-- Commerce (inactive)
) AS v (fundingID, facultylD)
WHERE NOT EXISTS (
	SELECT 1
	FROM FundingFaculty ff
	WHERE ff.fundingID = v.fundingID
		AND ff.facultyID = v.facultylD
);
GO