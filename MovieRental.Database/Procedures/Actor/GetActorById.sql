CREATE PROCEDURE [dbo].[GetActorById]
	@Id int
AS
BEGIN
	SELECT * FROM Actor WHERE ActorId = @Id
END
