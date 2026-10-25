USE FuturePathDB
GO

INSERT INTO UserAccount (username, passwordHash, role, isActive)
SELECT v.username, v.passwordHash, v.role, v.isActive
FROM (
	VALUES
		('admin01', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Admin@123'), 2), 'Administrator', 1),
        ('advisor01', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Advisor@123'), 2), 'Career Advisor', 1),
        ('advisor02', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Admin@456'), 2), 'Career Advisor', 0)
) AS v(username, passwordHash, role, isActive)
WHERE NOT EXISTS (
	SELECT 1
    FROM UserAccount u
    WHERE u.username = v.username
);
GO