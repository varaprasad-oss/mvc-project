create function GetEmpDetails2
(
@empid int
)
returns int
as 
begin
declare @num int
set @num = 2100+@empid
return @num
end

exec dbo.GetEmpDetails2 100

declare @result int
set @result= dbo.GetEmpDetails2(100)
select @result