CREATE PROCEDURE [dbo].[GetFilmByCategory]
	@Cat varchar(250)
AS
BEGIN
	SELECT * FROM Film F, FilmCategory FC, Category C
	where F.FilmId = FC.FilmId 
	and FC.CategoryId = C.CategoryId
	and C.[Name] = @Cat
END
