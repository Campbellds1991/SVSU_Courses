Select Cust.CustomerName, Count([Order].OrderID) From Customer as Cust, [Order]
Where [Order].CustomerID = Cust.CustomerId
Group By Cust.CustomerName
Having Count([Order].OrderID) > 1 ;


Select Emp.EmployeeName, 
	Cast(Emp.EmployeeDateHired As nvarchar(max)), 
	Mgr.EmployeeName As ManagerName, 
	Case When (Emp.EmployeeDateHired > Mgr.EmployeeDateHired) 
		then Cast(Mgr.EmployeeDateHired As nvarchar(max)) 
		Else N'' 
		End As ManagerDateHired
From Employee as Emp, Employee as Mgr
where Emp.EmployeeSupervisor = Mgr.EmployeeID;

Select * From Order_V
where CustomerID = 6;


Select ProductID, 
	P.ProductDescription, 
	P.ProductStandardPrice, 	 
		(Select SUM(SubTotal.Ammount) from  (Select 
		Sum(Uses.QuantityRequired * Material.MaterialStandardPrice) as Ammount
		from Uses Left Join Material on Uses.MaterialID = Material.MaterialID		
		where P.ProductID = Uses.ProductID ) as SubTotal) as RawTotal	
from Product as P;

Select C.CustomerName, OL.OrderedQuantity From Customer C, [Order] O, OrderLine OL
Where OL.ProductID = 3
and OL.OrderedQuantity >= 1
and OL.OrderID = O.OrderID
and C.CustomerID = O.CustomerID;

Select C.CustomerName From Customer As C
where C.CustomerID IN (Select O.CustomerID from [Order] AS O, OrderLine AS OL, Product AS P 
where Month(O.OrderDate) = 3 and Year(O.OrderDate) = 2015
and P.ProductLineID = 1
and OL.OrderedQuantity > 0
and O.OrderID = OL.OrderLineID
and P.ProductID = OL.ProductID)
