SELECT FirstName, 'Category' =
       CASE
             WHEN Age <= 18 THEN 'Minor'
             WHEN Age > 18 AND Age <= 30 THEN 'Major'
             ELSE 'N/A'
       END
FROM PersonalDetails