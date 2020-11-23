CREATE PROCEDURE [dbo].[GetFilmByKeyWord]
	@KeyWord varchar(500)
AS
BEGIN
	SELECT * FROM Film
	where [Description] like '%'+@KeyWord+'%'
END
