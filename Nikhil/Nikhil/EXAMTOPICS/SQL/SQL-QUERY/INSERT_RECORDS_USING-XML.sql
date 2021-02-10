USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployeeDetailsFromXML]    Script Date: 12/10/2020 12:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[InsertEmployeeDetailsFromXML]
	-- Add the parameters for the stored procedure here
	@xmlData XML
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO employees
				(first_name,last_name,gender,birth_date,hire_date)
	SELECT 
			x.value('first_name[1]','varchar(14)') AS FIRSTNAME,
			x.value('last_name[1]','varchar(16)') AS LASTNAME,
			x.value('gender[1]','varchar(50)') AS GENDER,
			x.value('birth_date[1]','date') AS BIRTHDATE,
			x.value('hire_date[1]','date') AS HIREDATE
	FROM @xmlData.nodes('//employees') AS XmlData(x)
END


SELECT * FROM employees FOR XML RAW

SELECT * FROM employees FOR XML AUTO


SELECT * FROM employees FOR XML PATH('employee'),
ROOT('employees')

DECLARE @xmlData xml
SET @xmlData = '<employees>
  <employee>
	<emp_no></emp_no>
    <birth_date>1998-08-29</birth_date>
    <first_name>NARENDRA</first_name>
    <last_name>G</last_name>
    <gender>MALE</gender>
    <hire_date>2020-10-19</hire_date>
  </employee>
 </employees> '

EXEC InsertEmployeeDetailsFromXML @xmlData