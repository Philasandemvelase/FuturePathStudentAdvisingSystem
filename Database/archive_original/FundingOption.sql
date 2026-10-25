FundingOption

USE FuturePathDB;
GO
/* --- FundingOption ---*/
SET IDENTITY_INSERT FundingOption ON;
INSERT INTO FundingOption (fundingID, fundingName, fundingType, eligibilityDescription, requiredDocuments, closingDate, contactinfo, isActive)
SELECT v.id, v.fundingName, v.funding Type, v.eligibility, v.requiredDocuments, v.closingDate, v.contactinfo, v.isActive
FROM (
	VALUES

	(1, 'Sample Commerce Merit Award',	'Scholarship, 'Based on academic merit; verify the providers criteria. ‘, 'Results, identity document, application form', '2026-11-30', 'Sample contact: commerce.awards@example.org', 1),

	(2, 'Sample Study Support Bursary', 'Bursary', 'Based on financial need. ‘ , ‘Results, ID, proof of income’, '2026-12-15' , 'Sample contact: bursaries@example.org’, 1),

 	(3, 'Sample Science Excellence Scholarship', 'Scholarship', 'Based on academic merit in science subjects’, ’Results, identity document', ‘2026-11-15’, 'Sample contact: science.awards@example.org', 1),

	(4, 'Sample Engineering Talent Bursary', 'Bursary', 'Based on academic merit and financial need’, ’Results, ID, proof of income', ‘2026-10-31’, 'Sample contact: eng.bursary@example.org’, 1),

	(5, 'Sample Health Sciences Merit Award', 'Scholarship', 'Based on academic merit.’, ’Results, identity document, motivation letter', '2026-11-20', 'Sample contact:health.awards@example.org', 1),

	(6, 'Sample Health Sciences Need Bursary', 'Bursary','Based on financial need. ‘ ,’Results, ID, proof of income', '2026-12-01', 'Sample contact: health.bursary@example.org', 1),

	(7, 'Sample Humanities Community Scholarship', 'Scholarship', 'Based on academic merit and community involvement. ‘ ,’Results, identity document, reference letter, ‘2027-01-15',
'Sample contact: humanities@example.org', 1), 
 
	(8, 'Sample General Financial Aid', 'Financial Aid', 'Based on financial need.’ ,’Results, ID, proof of income', '2027-01-31’, 'Sample contact: finaid@example.org', 1),

	(9, 'Sample External Corporate Bursary' ,'External Funding', 'Based on academic merit; technical fields only. ‘, ‘Results, ID, application form', '2026-12-10', 'Sample contact: corporate.bursary@example.org', 1),

	(10, 'Sample Expired Merit Award', ‘Scholarship’, 'Based on academic merit (inactive, tests exclusion). ‘, ‘Results, identity document', '2026-06-30', 'Sample contact: old.award@example.org', 0),

) AS v(id, fundingName, fundingType, eligibility, requiredDocuments, closingDate, contactInfo, isActive)
WHERE NOT EXISTS (
	SELECT 1
	FROM FundingOption fo
	WHERE fo.fundingID = v.id
);
SET IDENTITY_INSERT FundingOption OFF;
GO