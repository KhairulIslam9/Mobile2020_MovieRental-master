CREATE PROCEDURE [dbo].[GetFilmByTitle]
	@Title varchar(250)
AS
BEGIN
	SELECT * FROM Film
	where Title = @Title
END
