Create View Order_V AS 
Select O.CustomerID, O.OrderID, O.OrderDate, P.ProductDescription, OL.OrderedQuantity 
from [Order] as O
Left Join OrderLine As OL on O.OrderID = OL.OrderID
Left Join Product as P on OL.ProductID = P.ProductID
