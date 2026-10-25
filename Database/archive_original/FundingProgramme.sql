
USE FuturePathDB;
GO

/* ------ FundingProgramme ---------- */
INSERT INTO FundingProgramme (fundingID, degreelD)
SELECT v.fundingID, v.degreelD
FROM(
	VALUES 
		(1, 1),				-- Commerce Merit Award -> BCom Information Systems
		(3, 5),				-- Science Excellence -> BSc Biological Sciences
		(9, 4), (9, 6)			-- Corporate Bursary - BSc Computer Science, BSc Mechanical Engineering
) AS v (fundingID, degreelD)
WHERE NOT EXISTS (
	SELECT 1
	FROM FundingProgramme fp
	WHERE fp.fundingID = v.fundingID
		AND fp.degreelD = v.degreelD
);
GO