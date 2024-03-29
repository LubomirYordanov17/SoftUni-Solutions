SELECT [e].[EmployeeID], [e].[FirstName], [e].[ManagerID], [m].[FirstName] AS [ManagerName]
		FROM [Employees] AS [e]
		JOIN [Employees] AS [m]
		  ON [m].[EmployeeID] = [e].[ManagerID]
	   WHERE [m].[EmployeeID] IN (3, 7)
	ORDER BY [e].[EmployeeID] 
