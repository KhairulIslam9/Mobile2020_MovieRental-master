CREATE PROCEDURE [dbo].[GetFilmByActor]
	@LastName varchar(250)
AS
BEGIN
	SELECT * FROM Film F, Actor A, FilmActor FM
	where F.FilmId = FM.FilmId
	and A.ActorId = FM.ActorId
	and A.LastName = @LastName
END
