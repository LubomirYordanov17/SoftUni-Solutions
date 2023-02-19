SELECT TOP(3) e.EmployeeID,FirstName FROM Employees as e
LEFT JOIN EmployeesProjects as ep
ON e.EmployeeID=ep.EmployeeID
LEFT JOIN Projects as p
ON ep.ProjectID=p.ProjectID
WHERE p.[Name] IS NULL
ORDER BY EmployeeID
