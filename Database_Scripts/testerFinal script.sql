/* 
	new client registration
	enter clientID, a username, and a password
	username updates client table where clientID matches
	password is added as new entry to clientUser table, using clientID as pk

	clientID int
	username varchar 25
	userpassword nvarchar(max)
	compassword nvarchar(max)
	salt nvarchar(512)

*/

CREATE PROC newClientRegistration(
	@clientID INT,
	@username VARCHAR(25),
	@clientPassword NVARCHAR(MAX),
	@comPassword NVARCHAR(MAX),
	@salt NVARCHAR(512)
)
AS
BEGIN
	SET NOCOUNT ON;

	--insert username into client
	BEGIN TRANSACTION
		UPDATE client
		SET username = @username
		WHERE clientID = @clientID

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RETURN
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION

				INSERT INTO clientUser
				VALUES(@clientID, @clientPassword, @comPassword, @salt)
			END
END
GO

CREATE PROC getLoginInfo(
	@username NVARCHAR(64)
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT u.clientPassword, u.salt, c.username
	FROM client c
	INNER JOIN clientUser u on c.clientID = u.clientID
	WHERE c.username = @username
END

CREATE PROC findUsername (
	@username VARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS( SELECT 1 FROM client WHERE username = @username)
		BEGIN
			RETURN 1
		END

	ELSE
		BEGIN
			IF EXISTS( SELECT 1 FROM employee WHERE username = @username)
				RETURN 2
			ELSE
				RETURN 0
		END
END
GO


INSERT INTO employee
VALUES('employeeUser')

select * from client

declare @tester int
exec @tester = findUsername 'JOE'
print @tester
