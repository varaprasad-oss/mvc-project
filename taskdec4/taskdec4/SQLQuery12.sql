create function mul(@num1 int)returns int as
begin 
      declare @num2 int;
      set @num2=@num2*@num1;
      return @num2;
end
exec dbo.mul 100
declare @result int
set @result=dbo.mul(90);
select @result