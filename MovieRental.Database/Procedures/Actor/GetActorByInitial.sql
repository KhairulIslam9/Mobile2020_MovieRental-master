CREATE PROCEDURE [dbo].[GetActorByInitial]
	@FirstL char,
	@LastL char
AS
BEGIN
	SELECT * FROM Actor 
	WHERE LEFT(FirstName,1) = @FirstL
	and LEFT(LastName,1) = @LastL
END