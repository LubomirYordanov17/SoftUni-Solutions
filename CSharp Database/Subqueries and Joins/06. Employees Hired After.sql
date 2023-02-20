SELECT FirstName,
LastName,
HireDate,
[Name] as 'DeptName' FROM Employees as e
RIGHT JOIN Departments as d
ON e.DepartmentID=d.DepartmentID
WHERE e.HireDate > 1999/1/1 AND d.[Name]='Sales' or d.[Name]='Finance' 
ORDER BY HireDate


