SELECT TOP(5)	EmployeeID,
	FirstName ,
	Salary,
	[Name] as 'DepartmentName' FROM Employees as e
	JOIN Departments as d
	ON e.DepartmentID=d.DepartmentID
	WHERE e.Salary>15000
	ORDER BY e.DepartmentID

