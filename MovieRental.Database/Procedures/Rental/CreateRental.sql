CREATE PROCEDURE [dbo].[CreateRental]
	@CustomerId INT,
	@FilmIds FilmIds READONLY

AS
BEGIN
INSERT INTO [Rental] ([CustomerId])
VALUES (@CustomerId);

DECLARE @RentalId INT = SCOPE_IDENTITY();

INSERT INTO [RentalDetail] ([RentalId], [FilmId], [RentalPrice])
SELECT @RentalId, FI.[FilmId], F.[RentalPrice]
FROM @FilmIds FI , Film F 
where FI.[FilmId] = F.[FilmId];
END
