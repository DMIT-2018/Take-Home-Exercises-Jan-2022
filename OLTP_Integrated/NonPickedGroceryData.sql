use GroceryList
go
delete OrderList
where Orderid in (133, 134, 135)
delete Orders
where OrderId in (133,134,135)
go
SET IDENTITY_INSERT Orders ON
insert into Orders (OrderID, OrderDate, StoreID, CustomerID, PickerID, PickedDate, Delivery, SubTotal, GST)
VALUES(133,DateAdd(d,-1,GetDate()), 3, 13, null, null, 0, 0.00, 0.00)
insert into Orders (OrderID, OrderDate, StoreID, CustomerID, PickerID, PickedDate, Delivery, SubTotal, GST)
VALUES(134,DateAdd(d,-1,GetDate()), 2, 5, null, null, 0, 0.00, 0.00)
insert into Orders (OrderID, OrderDate, StoreID, CustomerID, PickerID, PickedDate, Delivery, SubTotal, GST)
VALUES(135,GetDate(), 3, 10, null, null, 0, 0.00, 0.00)
SET IDENTITY_INSERT Orders OFF
go
SET IDENTITY_INSERT OrderList ON
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6100, 133, 91, 2.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6101, 133, 177, 2.0, 0.0, 0.00, 0.00, 'kg', null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6102, 133, 60, 1.5, 0.0, 0.00, 0.00, 'kg', null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6103, 133, 18, 1.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6104, 133, 15, 3.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6105, 133, 312, 4.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6106, 133, 42, 0.45, 0.0, 0.00, 0.00, 'kg extra lean', null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6107, 133, 286, 12.0, 0.0, 0.00, 0.00, null, null)

insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6108, 134, 170, 3.0, 0.0, 0.00, 0.00, 'kg', null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6109, 134, 104, 1.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6110, 134, 318, 1.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6111, 134, 217, 0.25, 0.0, 0.00, 0.00, 'kg', null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6112, 134, 248, 2.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6113, 134, 23, 4.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6114, 134, 70, 2.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6115, 134, 192, 2.0, 0.0, 0.00, 0.00, 'kg', null)

insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6116, 135, 70, 1.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6117, 135, 323, 2.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6118, 135, 280, 6.0, 0.0, 0.00, 0.00, null, null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6119, 135, 177, 1.0, 0.0, 0.00, 0.00, 'kg', null)
insert into OrderList (OrderListID, OrderID, ProductID, QtyOrdered, QtyPicked, Price, Discount, CustomerComment, PickIssue)
VALUES(6120, 135, 42, 1.0, 0.0, 0.00, 0.00, 'kg', null)
SET IDENTITY_INSERT OrderList OFF
go