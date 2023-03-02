SELECT MIN([Avg]) AS [MinAverageSalary]
	FROM(
	SELECT AVG([Salary]) AS [Avg]
		  FROM [Employees]
	  GROUP BY [DepartmentID]
	) AS [AverageSalaries]