SELECT TOP(50) FirstName,LastName,Name as 'Town',AddressText FROM Employees as e
JOIN Addresses as a
ON e.AddressID=a.AddressID
JOIN Towns as t
ON a.TownID=t.TownID
ORDER BY FirstName,LastName

