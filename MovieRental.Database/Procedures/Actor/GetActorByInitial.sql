CREATE PROCEDURE [dbo].[GetActorByInitial]
	@LastL char
AS
BEGIN
	SELECT * FROM Actor 
	WHERE LEFT(LastName,1) = @LastL
END