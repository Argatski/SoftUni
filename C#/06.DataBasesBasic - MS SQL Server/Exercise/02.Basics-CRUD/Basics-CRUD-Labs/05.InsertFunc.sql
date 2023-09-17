/*INSERT COMMAND*/
/*USE DATABASE SOFTUNI*/
/*FIRST METHOD TO INSERT*/
INSERT INTO Towns
	VALUES ('Pleven'), ('Varna'), ('Burgas')


/*INSERT IN EMPLOYEE*/
/*SECOND METHOD TO INSERT MOST USE*/
INSERT INTO Employees 
			(FirstName,LastName,JobTitle,DepartmentID,HireDate,Salary)
	VALUES 
			('Niki', 'Kostov','Trainer', 7, GETDATE(),10000),
			('Stoqn', 'Shopov','Trainer',1, GETDATE(),10000)

/*INSERT WITH USE SELECT*/
INSERT INTO Projects (Name,StartDate)
	SELECT Name + ' Restructuring', GETDATE()
	FROM Departments

/*GET DATA FROM DIFFERENT TABLE AND CREATE NEW TABLE WITH INSERT INF (COPY TABLE IN NEW TABLE)*/
SELECT FirstName + ' ' + LastName AS FullName ,Salary
	INTO Names
	FROM Employees 
	 