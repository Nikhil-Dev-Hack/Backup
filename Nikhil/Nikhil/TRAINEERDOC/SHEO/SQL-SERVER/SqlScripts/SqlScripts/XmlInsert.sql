DECLARE @xmlData xml
SET @xmlData = '<MyDetails>
	<MyDetail>
		<FullName>Yamuna Shankar</FullName>
		<City>Yamuna City</City>
	</MyDetail>
	<MyDetail>
		<FullName>Manasa Dream Girl</FullName>
		<City>Dream Girl City</City>
	</MyDetail>
	</MyDetails>'

INSERT INTO MyDetails
(FullName, City)
SELECT 
	x.value('FullName[1]', 'varchar(50)') as FullName,
	x.value('City[1]', 'varchar(50)') as City
FROM @xmlData.nodes('//MyDetail') as XmlData (x)
