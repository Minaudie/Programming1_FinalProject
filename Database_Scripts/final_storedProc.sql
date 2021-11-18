/*
	CNSA 212 Final Prokject
	Stored Procedures
*/

USE mmn_FinalProject;

--*** Add records ***
--add client
CREATE PROC addNewClient (
	@fName VARCHAR(25),
	@mInitial CHAR(1) = '',
	@lName VARCHAR(25),
	@street1 VARCHAR(100) = '',
	@street2 VARCHAR(100) = '',
	@city VARCHAR(25) = '',
	@addr_state VARCHAR(25) = '',
	@zip VARCHAR(10) = '',
	@phone VARCHAR(15) = '',
	@email VARCHAR(100) = '',
	@gender CHAR(1),
	@dateOfBirth DATE,
	@username VARCHAR(25) = ''
)
AS
	IF NOT EXISTS (
		SELECT 1 FROM client
		WHERE UPPER(fName) = UPPER(@fName)
			AND UPPER(lName) = UPPER(@lName)
			AND dateOfBirth = @dateOfBirth
	)
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO client(fName, mInitial, lName, street1,
			street2, city, addr_state, zip, phone, email,
			gender, dateOfBirth, username)
		VALUES(@fName, @mInitial, @lName, @street1,
			@street2, @city, @addr_state, @zip, @phone, @email,
			@gender, @dateOfBirth, @username)

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
ELSE
	BEGIN
		PRINT('Record already exists.')
		RETURN
	END
GO

--add insurance company
CREATE PROC addNewInsurance (
	@companyName VARCHAR(50),
	@coveragePercent DECIMAL(5,2),
	@phone VARCHAR(15) = '',
	@street1 VARCHAR(100) = '',
	@street2 VARCHAR(100) = '',
	@city VARCHAR(25) = '',
	@addr_state VARCHAR(25) = '',
	@zip VARCHAR(10) = ''
)
AS
	IF NOT EXISTS (
		SELECT 1 FROM insurance
		WHERE UPPER(companyName) = UPPER(@companyName)
	)
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO insurance(companyName, coveragePercent,
			phone, street1, street2, city, addr_state, zip)
		VALUES(@companyName, @coveragePercent, @phone,
			@street1, @street2, @city, @addr_state, @zip)

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION 
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
ELSE
	BEGIN
		PRINT('Record already exists.')
		RETURN
	END
GO

--add new client insurance record
CREATE PROC newClientInsuranceRecord (
	@clientID INT,
	@insuranceID INT,
	@clientInsuranceNum INT
)
AS
	/*IF NOT EXISTS (
		SELECT 1 FROM clientInsurance
		WHERE clientID = @clientID
			AND insuranceID = @insuranceID
	)*/
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO clientInsurance(clientID, insuranceID, clientInsuranceNum)
		VALUES(@clientID, @insuranceID, @clientInsuranceNum)

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
/*ELSE 
	BEGIN
		PRINT('Record already exists.')
		RETURN
	END*/
GO

--new physician
CREATE PROC addNewPhysician (
	@fName VARCHAR(25),
	@mInitial CHAR(1) = '',
	@lName VARCHAR(25),
	@phone VARCHAR(15) = '',
	@email VARCHAR(100) = ''
)
AS
	IF NOT EXISTS (
		SELECT 1 FROM physician
		WHERE UPPER(fName) = UPPER(@fName)
			AND UPPER(lName) = UPPER(@lName)
	)
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO physician(fName, mInitial, lName,
			phone, email)
		VALUES(@fName, @mInitial, @lName, @phone, @email)

		IF @@ERROR <> 0 
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
ELSE
	BEGIN
		PRINT('Record already exists.')
		RETURN
	END
GO

--new medicine
CREATE PROC addNewMedicine (
	@medicineName VARCHAR(25),
	@intakeMethod VARCHAR(100),
	@cost DECIMAL(7,2)
)
AS
	IF NOT EXISTS (
		SELECT 1 FROM medicine
		WHERE UPPER(medicineName) = UPPER(@medicineName)
			AND UPPER(intakeMethod) = UPPER(@intakeMethod)
	)
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO medicine(medicineName, intakeMethod, cost)
		VALUES(@medicineName, @intakeMethod, @cost)

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
ELSE
	BEGIN
		PRINT('Record already exists.')
		RETURN
	END
GO

--new prescription
CREATE PROC addNewPrescription (
	@clientID INT,
	@physicianID INT,
	@medicineID INT,
	@expiryDate DATE  = '',
	@refillCounter TINYINT = ''
)
AS
	/*IF NOT EXISTS (
		SELECT 1 FROM prescription
		WHERE clientID = @clientID
			AND startDate = GETDATE()
			AND medicineID = @medicineID
	)*/
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO prescription(clientID, physicianID, medicineID,
			expiryDate, refillCounter)
		VALUES(@clientID, @physicianID, @medicineID, @expiryDate, @refillCounter)

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
/*ELSE
	BEGIN
		PRINT('Record already exists.')
		RETURN
	END*/
GO

--new refill
CREATE PROC addNewRefill (
	@prescriptionID INT,
	@dosage VARCHAR(50),
	@frequency VARCHAR(50),
	@supplyDays TINYINT,
	@quantitySupplied TINYINT
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO refill(prescriptionID, dosage, frequency, supplyDays,
			quantitySupplied)
		VALUES(@prescriptionID, @dosage, @frequency, @supplyDays,
			@quantitySupplied)

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
GO

--new payment
CREATE PROC newPayment (
	@refillID INT,
	@paymentType VARCHAR(6)
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO payment(refillID, paymentType)
		VALUES(@refillID, UPPER(@paymentType))

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to insert record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record added successfully!')
			END
END
GO

-- *** Select Records ***
--select client
CREATE PROC selectClient (
	@clientID INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM client
	WHERE clientID = @clientID
END 
GO

--select prescription for certain client
CREATE PROC selectPrescriptionPerClient (
	@clientID INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM prescription
	WHERE clientID = @clientID
END
GO

--select refill by client
CREATE PROC selectRefillPerClient (
	@clientID INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT r.refillID, r.prescriptionID, r.dosage, r.frequency, 
		r.supplyDays, r.quantitySupplied, r.amountDue, r.dateOfRefill
	FROM refill r
	LEFT JOIN prescription p
	ON r.prescriptionID = p.prescriptionID
	WHERE p.clientID = @clientID
END
GO

--select client info and prescription info
CREATE PROC selectClientPrescription (
	@clientID INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT p.prescriptionID, p.clientID, c.fName + ' ' + c.lName AS 'Client Name',
		p.physicianID, p.medicineID, p.startDate, p.expiryDate, p.refillCounter
	FROM prescription AS p
	INNER JOIN client AS c on c.clientID = p.clientID
	WHERE p.clientID = @clientID
END
GO

--select refills
CREATE PROC selectRefill (
	@refillID INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM  refill
	WHERE refillID = @refillID
END
GO

CREATE PROC checkUsername(
	@suppliedUsername VARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @clientID INT

	--if an employee username
	IF EXISTS(SELECT 1 FROM employee
					WHERE username = @suppliedUsername)
		SET @clientID = 0
	ELSE
		SET @clientID = (SELECT clientID
						FROM client
						WHERE username = @suppliedUsername)
	
	--0 is employee, !0 is client
	RETURN @clientID
END
GO

--if password matches, return 1
--if no match, return 0
CREATE PROC checkPassword(
	@clientID INT,
	@suppliedPassword VARCHAR(50)
)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @RETURN INT

	IF EXISTS(
		SELECT 1 FROM clientPassword
		WHERE clientID = @clientID
			AND client_password = @suppliedPassword
	)
		SET @RETURN = 1;
	ELSE
		SET @RETURN = 0;

END
GO

-- *** Update Records ***
-- update client
CREATE PROC updateClient (
	@clientID INT,
	@fName VARCHAR(25),
	@mInitial CHAR(1) = '',
	@lName VARCHAR(25),
	@street1 VARCHAR(100) = '',
	@street2 VARCHAR(100) = '',
	@city VARCHAR(25) = '',
	@addr_state VARCHAR(25) = '',
	@zip VARCHAR(10) = '',
	@phone VARCHAR(15) = '',
	@email VARCHAR(100) = '',
	@gender CHAR(1),
	@dateOfBirth DATE
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		UPDATE client
		SET fName = @fName,
			mInitial = @mInitial,
			lName = @lName,
			street1 = @street1,
			street2 = @street2,
			city = @city,
			addr_state = @addr_state,
			zip = @zip,
			phone = @phone,
			email = @email,
			gender = @gender,
			dateOfBirth = @dateOfBirth
		WHERE clientID = @clientID

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to update record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record updated successfully.')
			END
END
GO

--update client username
CREATE PROC updateClientUsername (
	@username VARCHAR(25),
	@clientID INT
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		UPDATE client
		SET username = @username
		WHERE clientID = @clientID

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to update record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record updated successfully!')
			END
END
GO

CREATE PROC updateClientUserPass (
	@username VARCHAR(25),
	@newUsername VARCHAR(25),
	@clientPassword VARCHAR(50)
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION

		--get clientID based on current username
		DECLARE @clientID INT
		SELECT @clientID = (SELECT clientID
							FROM client
							WHERE username = @username)

		--update username to the new one
		UPDATE client
		SET username = @newUsername
		WHERE username = @username

		--update password to the new one
		UPDATE clientPassword
		SET client_password = @clientPassword
		WHERE clientID = @clientID

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to update record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record updated successfully')
			END
END
GO

CREATE PROC updatePrescription (
	@prescriptionID INT,
	@clientID INT,
	@physicianID INT,
	@medicineID INT,
	@expiryDate DATE,
	@refillCounter TINYINT
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		UPDATE prescription
		SET clientID = @clientID,
			physicianID = @physicianID,
			medicineID = @medicineID,
			expiryDate = @expiryDate,
			refillCounter = @refillCounter
		WHERE prescriptionID = @prescriptionID

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to update record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record updated successfully!')
			END
END
GO

--update refill
CREATE PROC updateRefill (
	@refillID INT,
	@prescriptionID INT,
	@dosage VARCHAR(50),
	@frequency VARCHAR(50),
	@supplyDays TINYINT,
	@quantitySupplied TINYINT
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		UPDATE refill
		SET prescriptionID = @prescriptionID,
			dosage = @dosage,
			frequency = @frequency,
			supplyDays = @supplyDays,
			quantitySupplied = @quantitySupplied
		WHERE refillID = @refillID

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to update record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record updated successfully!')
			END
END
GO

-- *** Delete Records ***
--delete refill
CREATE PROC deleteRefill (
	@refillID INT
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION

		DELETE
		FROM payment
		WHERE refillID = @refillID

		DELETE
		FROM refill
		WHERE refillID = @refillID

		IF @@ERROR <> 0
			BEGIN
				ROLLBACK TRANSACTION
				RAISERROR('Unable to delete record.',16,1)
				RETURN -1
			END
		ELSE
			BEGIN
				COMMIT TRANSACTION
				PRINT('Record deleted successfully!')
			END
END
GO

-- *** TRIGGERS ***
--check refill counter and expiry date when creating new refill
CREATE TRIGGER trg_checkRefillCounter
ON refill
FOR INSERT 
AS 
BEGIN
	DECLARE @prescriptionID INT
	DECLARE @refillCount TINYINT
	DECLARE @expiryDate DATE

	SELECT @prescriptionID = (SELECT prescriptionID FROM inserted)
	SELECT @refillCount = (SELECT refillCounter 
							FROM prescription
							WHERE prescriptionID = @prescriptionID)
	SELECT @expiryDate = (SELECT expiryDate 
							FROM prescription
							WHERE prescriptionID = @prescriptionID)

	IF @refillCount = 0 OR @expiryDate < GETDATE()
		RAISERROR('This prescription has expired/reached the refill limit.',16,1)
	ELSE
		BEGIN
			UPDATE prescription
			SET refillCounter = @refillCount - 1
			WHERE prescriptionID = @prescriptionID
		END

	IF @@ERROR <> 0
		RAISERROR('Unable to insert record.',16,1)
END

--trigger for price of prescription
CREATE TRIGGER trg_setPrescriptionPrice
ON prescription
FOR INSERT
AS
BEGIN
	DECLARE @medicineID INT
	DECLARE @medicineCost DECIMAL(7,2)
	DECLARE @clientID INT
	DECLARE @insuranceID INT
	DECLARE @insuranceCoverage DECIMAL(5,2)
	DECLARE @prescriptionID INT
	DECLARE @prescriptionPrice DECIMAL(7,2)

	SELECT @medicineID = (SELECT medicineID FROM inserted)
	SELECT @medicineCost = (SELECT cost 
							FROM medicine
							WHERE medicineID = @medicineID)
	SELECT @clientID = (SELECT clientID FROM inserted)
	SELECT @insuranceID = (SELECT insuranceID 
							FROM clientInsurance
							WHERE clientID = @clientID)

	SELECT @insuranceCoverage = (SELECT coveragePercent 
								FROM insurance
								WHERE insuranceID = @insuranceID)

	SELECT @prescriptionID = (SELECT prescriptionID FROM inserted)

	SET @prescriptionPrice = @medicineCost - (@medicineCost / @insuranceCoverage)

	UPDATE prescription
	SET price = @prescriptionPrice
	WHERE prescriptionID = @prescriptionID

	IF @@ERROR <> 0
		BEGIN
			RAISERROR('Unable to insert record.',16,1)
		END
END

--set refill price
CREATE TRIGGER trg_setRefillPrice
ON refill
FOR INSERT
AS
BEGIN
	DECLARE @prescriptionID INT
	DECLARE @refillID INT
	DECLARE @prescriptionPrice DECIMAL(7,2)

	SELECT @prescriptionID = (SELECT prescriptionID FROM inserted)
	SELECT @refillID = (SELECT refillID FROM inserted)

	SELECT @prescriptionPrice = (SELECT price
									FROM prescription
									WHERE prescriptionID = @prescriptionID)

	UPDATE refill
	SET amountDue = @prescriptionPrice
	WHERE refillID = @refillID

	IF @@ERROR <> 0
		BEGIN
			RAISERROR('Unable to insert record.',16,1)
		END
END