SELECT * FROM Customer_Info
SELECT * FROM Customer_Order_info
SELECT * FROM Products
SELECT C.Customer_Name,C.Customer_Mobile_Number,C.Customer_Email,P.Product_Name,P.Product_Seller,P.Product_Price
	FROM Customer_Info as C LEFT OUTER JOIN Customer_Order_info as OI ON C.Customer_ID = OI.Customer_ID LEFT OUTER JOIN Products as P
	ON P.Product_ID=OI.Product_ID