/*
	CNSA 212 Final Project
	Filling the Database
*/

USE mmn_FinalProject;

EXEC addNewClient 'Pauline', 'D','Patterson','1489 Courtright St.','','Carson','North Dakota',
	'58529', '701-555-8415','patterson@hotmail.com','F', '8/31/1983'

EXEC addNewClient 'Brady', 'C','Masson','28 West Drive','','Hickory Hills','Illinois',
	'60457', '312-555-5265','brady@yahoo.com','M', '1995/05/07' 

EXEC addNewClient 'Mary', 'R', 'Hagen', '40 Mattson Street', '', 'Salem', 'Oregon',
	'97301', '503-555-1522','maryhagen@gmail.com','F','1986/05/17'

EXEC addNewClient 'Bill','L','Alexander','38 Skips Lane', '','Prescott','Arizona',
	'86301','928-555-6593','balex@gmail.com','M','1973/02/07'

EXEC addNewClient 'Robin', 'C','Mancini','349 Bigger Drive','','Poydras','Louisianna',
	'70085','504-555-4529','robin@yahoo.com','F','1997/12/25'

EXEC addNewClient 'Manuel','H','Ruiz','4801 Better Street','','Overland Park', 'Kansas',
	'66210','913-555-2440','mannyruiz@hotmail.com','M', '1964/09/12'

EXEC addNewClient 'Lewis','A','Allen', '49 Comfort Court','','Madison','Wisconsin',
	'53704','608-555-4066','aalleenn@gmail.com','M','1986/06/17'

EXEC addNewClient 'Jonathan','S','Miles','23 Park Boulevard','','Forest City', 'Iowa',
	'50468','641-555-7065','jonathanmiles@yahoo.com','M','1978/01/03'

EXEC addNewClient 'Lisa','T','Herrera','22 Finley Avenue','','Reeder','North Dakota',
	'58654','701-555-1186','lisa@gmail.com','F','1980/01/23'

EXEC addNewClient 'Melanie','J','Tucker','26 Timber Oak Drive','','Sherman Oaks','California',
	'91430','805-555-2276','melanie@hotmail.com','F','1990/11/12'

EXEC addNewInsurance 'Green Falls Insurance',20.0,'717-555-2929','181 West Fork Drive','',
	'Hollywood','Florida','33024'

EXEC newClientInsuranceRecord 1,1,1

EXEC newClientInsuranceRecord 2,1,2

EXEC newClientInsuranceRecord 3,1,3

EXEC newClientInsuranceRecord 4,1,4

EXEC newClientInsuranceRecord 5,1,5

EXEC newClientInsuranceRecord 6,1,6

EXEC newClientInsuranceRecord 7,1,7

EXEC newClientInsuranceRecord 8,1,8

EXEC newClientInsuranceRecord 9,1,9

EXEC newClientInsuranceRecord 10,1,10

EXEC addNewPhysician 'Margaret','D','Vecchio','954-555-0866','margaretmd@yahoo.com'

EXEC addNewPhysician 'Jameson','P','McFarlane','659-456-9852','jameson@aim.com'

EXEC addNewPhysician 'Tyler','L','Greg','856-854-7132','greg@yahoo.com'

EXEC addNewMedicine 'Morphine','oral',100.00

EXEC addNewMedicine 'Sophiclox','oral',50.00

EXEC addNewPrescription 1,1,1,'2022/11/05',12

EXEC addNewPrescription 1,1,2,'2022/11/05',12

EXEC addNewPrescription 2,1,1,'2022/11/05',12

EXEC addNewPrescription 3,1,2,'2022/10/05',12

EXEC addNewPrescription 4,1,1,'2022/11/05',12

EXEC addNewPrescription 5,1,2,'2022/11/05',12

EXEC addNewPrescription 6,1,1,'2022/11/05',12

EXEC addNewPrescription 7,1,2,'2022/11/05',12

EXEC addNewPrescription 8,1,2,'2022/11/05',12

EXEC addNewPrescription 9,1,1,'2022/11/05',12

EXEC addNewPrescription 10,1,2,'2022/11/05',12

EXEC addNewRefill 1,'50mg','Twice daily',30,60

EXEC addNewRefill 2,'10mg','Once daily',60,60

EXEC addNewRefill 2,'10mg','Once daily',60,60

EXEC addNewRefill 3,'10mg','Once daily',60,60

EXEC addNewRefill 4,'10mg','Once daily',60,60

EXEC addNewRefill 5,'10mg','Once daily',60,60

EXEC addNewRefill 6,'10mg','Once daily',60,60

EXEC addNewRefill 7,'10mg','Once daily',60,60

EXEC addNewRefill 8,'10mg','Once daily',60,60

EXEC addNewRefill 9,'10mg','Once daily',60,60

EXEC addNewRefill 10,'10mg','Once daily',60,60

EXEC newPayment 1000,'CREDIT'

EXEC newPayment 1001,'CASH'