CREATE PROCEDURE [dbo].[GetActorByFilm]
	@FilmTitle varchar(255)
AS
BEGIN
	SELECT A.* FROM Actor A, FilmActor FM, Film F
	WHERE A.ActorId = FM.ActorId 
	and FM.FilmId = F.FilmId
	and F.Title = UPPER(@FilmTitle)
END
