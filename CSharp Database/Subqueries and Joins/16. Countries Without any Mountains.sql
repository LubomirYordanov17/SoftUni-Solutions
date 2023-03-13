SELECT COUNT(*) AS [Count]
	FROM (
		SELECT [mc].[MountainId] AS [m]
			FROM [MountainsCountries] AS [mc]
	  RIGHT JOIN [Countries] AS [c]
			  ON [c].[CountryCode] = [mc].[CountryCode]
		WHERE [mc].[MountainId] IS NULL
		) AS k