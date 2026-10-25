INSERT INTO UserAccount(userID, username, password, role, isActive)
SELECT v.userID, v.username, v.password, v.role, v.isActive
FROM (
	VALUES
	('admin01', CONVERT(VARCHAR(50), HASHBYTES('SHA2_256', 'Admin@123'), 2), 'Administrator', 1),
	('advisor01', CONVERT(VARCHAR(50), HASHBYTES('SHA2_256', 'User@123'), 2), 'Career Advisor', 1),
	('advisor02', CONVERT(VARCHAR(50), HASHBYTES('SHA2_256', 'User@456'), 2), 'Career Advisor', 0)
	