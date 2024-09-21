SELECT [orderid]
      ,[requireddate]
      ,[shippeddate]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
  FROM [Sales].[Orders] 
  WHERE custid = 1