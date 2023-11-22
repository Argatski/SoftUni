/*3.Update*/
UPDATE Invoices
SET DueDate = '2023-04-01'
WHERE Year(IssueDate)= 2022 AND Month(IssueDate) =11

UPDATE Clients
SET AddressId= 3
WHERE [Name] LIKE '%CO%'