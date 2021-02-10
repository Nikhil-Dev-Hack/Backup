DECLARE @count int = 10
WHILE (@count < 15)
	BEGIN
		IF (@count = 13)
			BEGIN
				-- BREAK;
				SET @count = @count + 1
				Continue
				--SELECT @count as Thirteen
				
			END
		ELSE
			BEGIN
				SELECT @count AS thisCounter
				SET @count = @count + 1
				--CONTINUE;
			END
END