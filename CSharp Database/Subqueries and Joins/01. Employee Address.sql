USE SoftUni

SELECT TOP(5) 	EmployeeId,JobTitle,e.AddressId,AddressText
	FROM Employees as e
	 LEFT JOIN Addresses as a
	ON e.AddressID=a.AddressID
	ORDER BY AddressID

