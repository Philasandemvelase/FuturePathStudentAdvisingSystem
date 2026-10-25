USE FuturePathDB;
GO
/*  ----------ExportReport---------- */
INSERT INTO ExportReport (sessionID, disclaimerText, reportFormat, exportDate )
SELECT v.sessionID, v. disclaimerText, v.reportFormat, v.exportDate
FROM (
	VALUES
		( 1,  ‘Advisory guidance only. Not an official admission or funding decision. ‘ , ‘PDF’ ,  ‘2026-09-11’ ) ,
		( 4,  ‘Advisory guidance only. Not an official admission or funding decision. ‘ , ‘PDF’ ,  ‘2026-09-09 ’ ),
		(7,  ‘Advisory guidance only. Not an official admission or funding decision. ‘ , ‘TXT’ ,  ‘2026-09-10’ )  ,
		(10,  ‘Advisory guidance only. Not an official admission or funding decision. ‘ , ‘PDF’ ,  ‘2026-09-07’ )
) AS v (sessionID, disclaimerText, reportFormat, exportDate )
WHERE NOT EXISTS (
	SELECT 1
	FROM ExportReport er
	WHERE er.sessionID = v.sessionID
	       AND er.reportFormat = v.reportFormat
	       AND er.exportDate = v.exportDate 
);
GO
