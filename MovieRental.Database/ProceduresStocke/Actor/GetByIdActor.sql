CREATE PROCEDURE [dbo].[GetByIdActor]
	@Id int 
AS
	SELECT * FROM Actor where ActorId = @Id;
RETURN 0
