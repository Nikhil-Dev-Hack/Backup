SELECT *, IsActive =
       CASE Active
              WHEN 1 THEN 'Yes'
              WHEN 0 THEN 'No'
              ELSE 'N/A'
       END
FROM PersonalDetails