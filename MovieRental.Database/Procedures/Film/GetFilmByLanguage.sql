CREATE PROCEDURE [dbo].[GetFilmByLanguage]
	@Language varchar(250)
AS
BEGIN
	SELECT * FROM Film F, [Language]  L
	where F.LanguageId = L.LanguageId
	and L.[name] = @Language
End
