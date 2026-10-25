USE FuturePathDB;
GO
/*  ----------RecommendationResult----------
     Overall = 0.4*subject + 0.3*mark + 0.2*interest  + 0.1*facultyPreference (scoring weights are our assumption).
     First row per session = the selected degree; extra rows = recommended alternatives.  */
INSERT INTO RecommendationResult
	(sessionID, degreeID, subjectMatchScore, markMatchScore, interestMatchScore, falcultyPreference, overallScore, advisoryOutcome, gapDescription)
SELECT v.sessionID, v.degreeID, v.subjectScore, v.markScore, v.interestScore, v.facultyPref, v.overallScore, v.outcome, v.gap
FROM (
           VALUES
	       (1, 1, 100.00, 100.00, 85.00, 100.00, 97.00, ‘Strong Match’,   ‘None identified’),
	       (2, 4, 50.00, 50.00, 40.00, 100.00, 53.00, ‘Not Currently Eligible’ , ‘Required subject missing: Mathematics (Mathematical Literacy not accepted)’ ), 
	       (2, 3, 100.00, 100.00, 70.00, 0.00, 84.00, ‘Strong Match’,   ‘None identified’)
	       (2, 7, 100.00, 100.00, 75.00, 0.00, 85.00, ‘Strong Match’,   ‘None identified’)
	       (3, 5, 100.00, 66.67, 80.00, 100.00, 86.10, ‘Possible Match’,   ‘Mathematics mark 58% is below the minimum of 60%’),
	       (4, 6, 100.00, 100.00, 90.00, 100.00, 98.00, ‘Strong Match’,   ‘None identified’)
	       (5, 10, 33.33, 33.33, 55.00, 100.00, 44.33,  ‘Not Currently Eligible’ ,  ‘‘Required subject missing: Mathematics and Physical Sciences’),
	     (5, 7, 100.00, 100.00, 70.00, 0.00, 84.00, ‘Strong Match’,   ‘None identified’ ),
                    (5, 8, 100.00, 100.00, 75.00, 0.00, 85.00, ‘Strong Match’,   ‘None identified’),
	     (6, 4, NULL, NULL, 60.00, 100.00, NULL, ‘ More Information Needed’ , ‘Mathematics mark not supplied ; assessment cannot be completed’ ),
	     (7, 9, 100.00, 100.00, 85.00, 100.00, 97.00, ‘Strong Match’,   ‘None identified’),
	     (8, 2, 100.00, 50.00, 80.00, 100.00, 81.00, ‘Possible Match’,   ‘Mathematics mark 55% is below the minimum of 60%’ ) ,
	     (9, 5, 100.00, 100.00, 35.00, 100.00, 87.00, ‘Possible Match’,   ‘interest alignment ; interests align more closely with Humaties’ ),
	     (9, 7, 100.00, 100.00, 90.00, 0.00, 88.00, ‘Strong Match’,   ‘None identified’ ) ,
	     (10, 7, 100.00, 100.00, 85.00, 100.00, 97.00, ‘Strong Match’,   ‘None identified’ ),
) AS v( sessionID, degreeID, subjectScore, markScore, interestScore, facultyPref, overallScore, outcome, gap )
WHERE NOT EXISTS  (
	SELECT 1
	FROM RecommendationResult rr
	WHERE rr.sessionID = v.sessionID
	        AND rr.degreeID = v.degreeID
);
GO
