USE FuturePathDB;
GO
/*----------AdvisorySession----------*/
SET IDENTITITY_INSERT AdvisorySession ON;
INSERT INTO AdvisorySession (sessionID, learnerID, degreeID, sessionDate, fundingRequested)
SELECT v.id, v.learnerID, v.degreeID, v.sessionDate, v.fundingRequested
FROM (
        VALUES
                   (1, 1, 1,   ‘2026-09-11’, 1),  -- Gadija  - > BCom IS  Strong Match, requested funding
 	    (2, 2, 4,   ‘2026-09-14’, 0),  -- Aadiel  - > Bsc Comp Sci  Not Currently Eligible (Maths missing)
	      (3, 3, 5,   ‘2026-09-08’, 1),  -- Labeeqah  - > BSc Biological  Possible Match (Maths gap)
    	      (4, 4, 6,   ‘2026-09-09’, 0),  -- Siyabonga  - >  BSc Mech Eng  Strong Match
	      (5, 5, 10,   ‘2026-08-17’, 1),  -- Derek  - >  Health Sciences  Not Currently Eligible
	      (6, 6, 4,   ‘2026-06-26’, 0),  -- Thabo  - > BSc Comp Sci  More Information Needed 
	      (7, 7, 9,   ‘2026-09-10’, 0),  -- Zanele  - >  LLB  Strong Match
	      (8, 8, 2,   ‘2026-09-02’, 1),  -- Ayesha  - >  BCom Accounting  Possible Match  (interests fit Humanities)
	      (9, 9, 5,   ‘2026-09-03’, 0),  -- Sipho  - >  BSc Biological  Possible Match (interests fit Humanities)
	      (10, 10, 7,   ‘2026-09-07’, 0),  -- Lerato  - >  BA Humanities  Strong Match
) AS v(id, learnerID, degreeID, sessionDate, fundingRequested)
WHERE NOT EXISTS (
	SELECT 1
	FROM AdvisorySession s
	WHERE s.sessionID = v.id
);
SET IDENTITY_INSERT AdvisorySession OFF;
GO
