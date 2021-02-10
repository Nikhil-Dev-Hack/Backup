SELECT s.Salesman_Name ,c.Customer_name FROM SalesMan s inner join Customers c ON  s.Salesman_Id=c.Salesman_Id
--question 2
SELECT o.Order_No,o.Purchase_amount,c.Customer_name,c.city FROM OrdersOfTheCustomers o join Customers c on o.Salesman_Id=c.Salesman_Id
 WHERE o.Purchase_amount between 3000 and 6000
 --question 1
 SELECT s.Salesman_Name,s.Salesman_city,c.Customer_name,c.City FROM SalesMan s inner join Customers c on s.Salesman_Id=c.Salesman_id
 where c.City='Hyd' and s.Salesman_City = 'Mumbai';
 -- quesation 1
 SELECT s.Salesman_Name,s.Salesman_city,c.Customer_name,c.City FROM SalesMan s , Customers c 
 WHERE s.Salesman_City=c.City