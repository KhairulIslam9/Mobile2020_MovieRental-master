CREATE PROCEDURE [dbo].[GetAllActorByFilm]
	@IdFilm
AS
	SELECT * FROM Actor A , Film F, FilmActor FM
	where A.ActorId = FM.ActorId 
	and FM.FilmId = F.FilmId 
	and F.FilmId = @IdFilm;
RETURN 0
