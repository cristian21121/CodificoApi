DECLARE @EmpId INT = 1;
DECLARE @ShipperId INT = 1;
DECLARE @ShipName NVARCHAR(100) = 'Nombre del Envío';
DECLARE @ShipAddress NVARCHAR(255) = 'Direccion de envio';
DECLARE @ShipCity NVARCHAR(100) = 'Ciudad de envio';
DECLARE @OrderDate DATETIME = GETDATE();
DECLARE @RequiredDate DATETIME = DATEADD(DAY, 7, GETDATE());
DECLARE @ShippedDate DATETIME = NULL;
DECLARE @Freight DECIMAL(10, 2) = 0.00;
DECLARE @ShipCountry NVARCHAR(100) = 'Pais de envio';

DECLARE @OrderId INT;
DECLARE @ProductId INT = 1;
DECLARE @UnitPrice DECIMAL(10, 2) = 10.00;
DECLARE @Qty INT = 2;
DECLARE @Discount DECIMAL(5, 2) = 0.05;

INSERT INTO [Sales].[Orders] (EmpId, ShipperId, ShipName, ShipAddress, ShipCity, OrderDate, RequiredDate, ShippedDate, Freight, ShipCountry)
VALUES (@EmpId, @ShipperId, @ShipName, @ShipAddress, @ShipCity, @OrderDate, @RequiredDate, @ShippedDate, @Freight, @ShipCountry);

SET @OrderId = SCOPE_IDENTITY();

INSERT INTO [Sales].[OrderDetails] (OrderId, ProductId, UnitPrice, Qty, Discount)
VALUES (@OrderId, @ProductId, @UnitPrice, @Qty, @Discount);