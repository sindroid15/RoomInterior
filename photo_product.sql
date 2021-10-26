use Room_Interior
go
update [Product]
set PhotoProduct=(Select *from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-1.jpg', single_blob) as PhotoProduct)
where IdProduct = 1
go
update [Product]
set PhotoProduct=(select * from openrowset (bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-2.jpg', single_blob) as PhotopProduct)
where IdProduct = 2
go
update [Product]
set PhotoProduct =(select *from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-3.jpg', single_blob)as PhotoProduct)
where IdProduct = 3
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-4.jpg', single_blob)as PhotoProduct)
where IdProduct= 4
go 
update [Product]
set PhotoProduct = (select * from openrowset (bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-5.jpg', single_blob) as PhotoProduct)
where IdProduct=5
go
update [Product]
set PhotoProduct = (select * from openrowset (bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-6.jpg', single_blob) as PhotoProduct)
where IdProduct=6
go
update [Product]
set  PhotoProduct = (select * from openrowset (bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-7.jpg', single_blob) as PhotoProduct)
where IdProduct=7
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-8.jpg', single_blob) as PhotoProduct)
where IdProduct = 8
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-9.jpg', single_blob) as PhotoProduct)
where IdProduct = 9
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-10.jpg', single_blob) as PhotoProduct)
where IdProduct = 10
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-11.jpg', single_blob) as PhotoProduct)
where IdProduct = 11
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-12.jpg', single_blob) as PhotoProduct)
where IdProduct = 12
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-13.jpg', single_blob) as PhotoProduct)
where IdProduct = 13
go
update [Product]
set PhotoProduct = (select * from openrowset(bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\product photo\product-14.jpg', single_blob) as PhotoProduct)
where IdProduct = 14