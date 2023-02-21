SELECT TOP(5) e.EmployeeID,
FirstName,
p.[Name] as 'ProjectName' FROM Employees as e
JOIN EmployeesProjects as ep
ON e.EmployeeID=ep.EmployeeID
 JOIN Projects as p
ON ep.ProjectID=p.ProjectID
WHERE p.StartDate > 13/08/2002  and p.EndDate is null
ORDER BY e.EmployeeID