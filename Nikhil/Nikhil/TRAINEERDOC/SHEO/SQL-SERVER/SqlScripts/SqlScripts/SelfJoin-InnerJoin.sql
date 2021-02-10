/****** Script for SelectTopNRows command from SSMS  ******/
SELECT *  FROM [Training2020].[dbo].[Subjects]
-- Science - Physics
-- Science - Chemistry
-- Science - Math
-- Arts - History
-- Arts - Geogrphy
--SELECT Subject, SubSubject FROM Subjects S INNER JOIN SubjectId != AutoId

SELECT S.Subject, SS.SubSubject FROM Subjects S, Subjects SS WHERE S.AutoId = SS.SubjectId 	Order BY S.Subject

SELECT Subject = (SELECT TOP 1 Subject FROM Subjects WHERE AutoID = S.SubjectId), 
	S.SubSubject FROM Subjects S WHERE SubjectID  is not null
