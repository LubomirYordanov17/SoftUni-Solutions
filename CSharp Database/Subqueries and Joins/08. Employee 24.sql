SELECT TOP(5) e.EmployeeID,
FirstName, 
 CASE	
			WHEN DATEPART(YEAR, [p].[StartDate]) > '2004' THEN NULL
			ELSE [p].[Name]
			END AS [ProjectName]
FROM Employees as e
JOIN EmployeesProjects as ep
ON e.EmployeeID=ep.EmployeeID
 JOIN Projects as p
ON ep.ProjectID=p.ProjectID
WHERE e.EmployeeID=24




