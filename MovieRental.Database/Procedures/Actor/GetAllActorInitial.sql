CREATE PROCEDURE [dbo].[GetAllActorInitial]
	
AS
BEGIN
	SELECT ActorId, SUBSTRING(LastName,1,1) as LastName, FirstName
	FROM Actor
End
