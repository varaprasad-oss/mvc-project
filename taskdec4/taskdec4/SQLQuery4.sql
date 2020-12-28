select * from Employees
select * from Employees where region is null
select * from Employees group by Country
select* from Categories
select * from Products
select * from Employees where region is null
select *from Employees where country='usa';

select c.CategoryId,c.CategoryName,p.ProductId,p.ProductName,p. UnitPrice from
Categories c join Products p on c.CategoryID=p.CategoryID

