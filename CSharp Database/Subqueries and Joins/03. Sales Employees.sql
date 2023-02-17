Select EmployeeID,
FirstName,
LastName,[Name] AS 'DepartmentName' FROM Employees AS E
JOIN Departments AS D
ON D.DepartmentID=E.DepartmentID
WHERE [Name]='Sales'
ORDER BY EmployeeID


