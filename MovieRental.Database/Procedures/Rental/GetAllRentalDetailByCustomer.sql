CREATE PROCEDURE [dbo].[GetAllRentalDetailByCustomer]
	@CustomerId int
AS
BEGIN
	SELECT RD.*, R.RentalDate 
	FROM Rental R, RentalDetail RD, Customer C
	WHERE R.RentalId = RD.RentalId
	and R.CustomerId = C.CustomerId
	and C.CustomerId = @CustomerId
END
