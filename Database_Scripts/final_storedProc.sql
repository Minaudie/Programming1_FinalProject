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
	@quantitySupplied TINYINT,
	@amountDue DECIMAL(7,2) = ''
)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
		INSERT INTO refill(prescriptionID, dosage, frequency, supplyDays,
			quantitySupplied, amountDue)
		VALUES(@prescriptionID, @dosage, @frequency, @supplyDays,
			@quantitySupplied, @amountDue)

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

--select client info and prescription info
CREATE PROC selectClientPrescription (
	@clientID INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT p.ClientID, (client.fName + ' ' + client.lName) AS 'Client Name'
	FROM prescription AS P
	INNER JOIN client ON client.clientID = p.clientID
	WHERE client.clientID = @clientID
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
	@dateOfBirth DATE,
	@username VARCHAR(25) = ''
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
			dateOfBirth = @dateOfBirth/*,
			username = @username*/
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

--update refill
CREATE PROC updateRefill (
	@refillID INT,
	@prescriptionID INT,
	@dosage VARCHAR(50),
	@frequency VARCHAR(50),
	@supplyDays TINYINT,
	@quantitySupplied TINYINT,
	@amountDue DECIMAL(7,2)
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
			quantitySupplied = @quantitySupplied,
			amountDue = @amountDue
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