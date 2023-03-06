 SELECT [c].[CountryCode], COUNT([mc].[CountryCode]) AS [MountainRanges]
     FROM [Countries] AS [c]
LEFT JOIN [MountainsCountries] AS [mc]
       ON [c].[CountryCode] = [mc].[CountryCode]
    WHERE [c].[CountryCode] IN ('BG', 'US', 'RU')
 GROUP BY [c].[CountryCode]