create function MyFirstFunction(@Param1 as integer) returns integer
begin
	declare @result as integer;
	set @result = @Param1 * 100;
	return @result;
end;

declare @myResult as integer;
set @myResult = dbo.MyFirstFunction(60);
print cast(@myResult as varchar(5));
print @myResult;