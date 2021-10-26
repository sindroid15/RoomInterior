use Room_Interior
go
update [User]
set PhotoUser = (Select * from openrowset (bulk N'C:\Users\sindr\Desktop\01.09.21-30.12.21\Бастрыкина 01.02\Room Interior\photo_users\user-1.jpg', single_blob) as PhotoUser)
where IdUser = 1