/*
	Attempting a password stored proc
*/

--CREATE PROC addNewClientPassword (
--	@clientID INT,
--	@client_password VARCHAR(50)
--)
--AS
--BEGIN
--	SET NOCOUNT ON;
--	--DECLARE @salt UNIQUEIDENTIFIER=NEWID()
--	DECLARE @id_seed INT

--	--check if client already has a password 
--	/* may not need this bc clientID is the PK?? */
--	IF NOT EXISTS(
--		SELECT 1 FROM clientPassword
--		WHERE clientID = @clientID
--	)

--	BEGIN
--		BEGIN TRANSACTION
--			INSERT INTO clientPassword(clientID)
--			VALUES(@clientID)
			
--			IF @@ERROR <> 0
--				BEGIN
--					ROLLBACK TRANSACTION
--					SELECT @RESULT=-1
--					RETURN RESULT
--				END
--			ELSE
--				BEGIN
--					COMMIT TRANSACTION
--					--SET @id_seed = (SELECT @@IDENTITY)
--					INSERT INTO clientPassword(client_password)

--CREATE PROC addNewClientPassword (
--	@fName VARCHAR(25),
--	@mInitial CHAR(1) = '',
--	@lName VARCHAR(25),
--	@street1 VARCHAR(100) = '',
--	@street2 VARCHAR(100) = '',
--	@city VARCHAR(25) = '',
--	@addr_state VARCHAR(25) = '',
--	@zip VARCHAR(10) = '',
--	@phone VARCHAR(15) = '',
--	@email VARCHAR(100) = '',
--	@gender CHAR(1),
--	@dateOfBirth DATE,
--	--@salt VARBINARY(512),
--	@result INT OUTPUT
--)
--AS
--BEGIN
--	SET NOCOUNT ON;

--	--DECALRE @salt UNIQUEIDENTIFIER=NEWID()
--	DECLARE @id_seed INT

--	/* Check for if client exists already */
--	IF NOT EXISTS(
--		SELECT 1 FROM client
--		WHERE fName = @fName 
--		AND mInitial = @mInitial 
--		AND lName = @lName
--	)
--	BEGIN
--		BEGIN TRANSACTION
--			INSERT INTO client(fName, mInitial, lName, street1, street2, 
--				city, addr_state, zip, phone, email, gender, dateOfBirth)
--			VALUES(@fName, @mInitial, @lName, @street1, @street2,
--				@city, @addr_state, @zip, @phone, @email, @gender, @dateOfBirth)

--			IF @@ERROR <> 0
--				BEGIN
--					ROLLBACK TRANSACTION
--					SELECT @result = -1
--					RETURN @result
--				END
--			ELSE
--				BEGIN
--					COMMIT TRANSACTION
--					SET @id_seed = (
--						SELECT @@IDENTITY
--					)
--					INSERT INTO clientPassword(clientID, client_password)


CREATE PROC registerClient (
	@clientID INT,
	@username VARCHAR(25),
	@client_password VARCHAR(50)
)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS(
		SELECT 1 FROM client
		WHERE clientID = @clientID
	)
	BEGIN
		BEGIN TRANSACTION
			INSERT INTO client(username)
			VALUES(@username)

			/* -- this goes elsewhere I think
			INSERT INTO clientPassword(client_password)
			VALUES(@client_password)
			*/

			IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					--SELECT @result = -1
					--return @result
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					--other stuff
				END
	END
	ELSE
		--clientID does not exist
		RETURN
END
GO

CREATE PROC addNewEmployee (
	@username VARCHAR(25),
	@password VARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS(
		SELECT 1 FROM employee
		WHERE username = @username
	)
	BEGIN
		BEGIN TRANSACTION
			INSERT INTO employee(username)
			VALUES(@username)

			/* --this goes elsewhere, again
			INSERT INTO employee(password)
			VALUES(@password)
			*/

			IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
				END
	END
	ELSE
		--EMPLOYEE username already exists
		RETURN
END
GO
