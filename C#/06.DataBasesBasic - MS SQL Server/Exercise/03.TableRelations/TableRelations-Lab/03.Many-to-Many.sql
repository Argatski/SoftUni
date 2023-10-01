CREATE TABLE Employees(
  EmployeeID INT PRIMARY KEY,
  EmployeeName VARCHAR(50)
)

CREATE TABLE Projects
(  
	ProjectID INT PRIMARY KEY,
	ProjectName VARCHAR(50)
)


CREATE TABLE EmployeesProjects
(
	EmployeeID INT,
	ProjectID INT,
	CONSTRAINT PK_EmployeesProjects PRIMARY KEY (EmployeeID, ProjectId),
	CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY(EmployeeId)
	REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY(ProjectId)
	REFERENCES Projects(ProjectID)
)