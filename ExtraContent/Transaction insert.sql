USE [BookListRazor]
GO

DECLARE @BookGenreId INT
DECLARE @BookId INT
DECLARE @AuthorId INT

BEGIN TRY
	BEGIN TRAN

		--SELECT @BookGenreId = Id from BookGenre where Genre = 'Computer Programming'

		--SELECT @AuthorId = Id from Author where FirstName = 'Adam' and LastName = 'Freeman'

		--SELECT @BookId = Id from Book where Name = 'Pro ASP.NET Core 3'

		--INSERT INTO [dbo].[BookAuthor] ([BookId] ,[AuthorId]) VALUES (@BookId ,@AuthorId)

		SELECT @BookGenreId = Id from BookGenre where Genre = '.NET Core'

		SELECT @AuthorId = Id from Author where FirstName = 'Adam' and LastName = 'Freeman'

		SELECT @BookId = Id from Book where Name = 'Essential Angular for ASP.NET Core MVC 3'

		INSERT INTO [dbo].[BookAuthor] ([BookId] ,[AuthorId]) VALUES (@BookId ,@AuthorId)

	COMMIT TRAN
END TRY

BEGIN CATCH  
      SELECT 
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_SEVERITY() AS ErrorSeverity,
        ERROR_STATE() as ErrorState,
        ERROR_PROCEDURE() as ErrorProcedure,
        ERROR_LINE() as ErrorLine,
        ERROR_MESSAGE() as ErrorMessage;

    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION
END CATCH 
GO

------------------------
USE [BookListRazor]
GO

INSERT INTO [dbo].[Author]
           ([CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[FirstName]
           ,[LastName]
           ,[MiddleName])
     VALUES
           ('Muoneke'
           ,GetDate()
           ,'Muoneke'
           ,NULL
           ,'Adam'
           ,'Freeman'
           ,NULL)
GO

select * from Book
select * from Author
select * from BookAuthor


-----

USE [BookListRazor]
GO

INSERT INTO [dbo].[BookGenre]
           ([CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[Genre])
     VALUES
           ('Muoneke'
           ,GetDate()
           ,'Muoneke'
           ,null
           ,'Computer Programming')
GO

INSERT INTO [dbo].[BookGenre]
           ([CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[Genre])
     VALUES
           ('Muoneke'
           ,GetDate()
           ,'Muoneke'
           ,null
           ,'Sql Server')
GO
INSERT INTO [dbo].[BookGenre]
           ([CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[Genre])
     VALUES
           ('Muoneke'
           ,GetDate()
           ,'Muoneke'
           ,null
           ,'Angular')
GO

INSERT INTO [dbo].[BookGenre]
           ([CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[Genre])
     VALUES
           ('Muoneke'
           ,GetDate()
           ,'Muoneke'
           ,null
           ,'MongoDb')
GO
INSERT INTO [dbo].[BookGenre]
           ([CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[Genre])
     VALUES
           ('Muoneke'
           ,GetDate()
           ,'Muoneke'
           ,null
           ,'.NET Core')
GO
select * from BookGenre
-----
USE [BookListRazor]
GO

INSERT INTO [dbo].[Book]
           ([Name]
           ,[Author]
           ,[CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[ISBN]
           ,[Year]
           ,[Description]
           ,[Edition]
           ,[Genre]
           ,[PageCount]
           ,[Photo]
           ,[Price]
           ,[Publisher]
           ,[SubTitle]
           ,[BookGenreId])
     VALUES
           ('Pro ASP.NET Core 3'
           ,null
           ,'Maurice'
           ,GetDate()
           ,null
           ,null
           ,'1234567891'
           ,'2020'
           ,'Description'
           ,'Eigth'
           ,'Computer programming'
           ,1080
           ,null
           ,12.33
           ,'Apress'
           ,'.NET'
           ,(SELECT ID From BookGenre where Genre = 'Computer Programming'))
GO


INSERT INTO [dbo].[Book]
           ([Name]
           ,[Author]
           ,[CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate]
           ,[ISBN]
           ,[Year]
           ,[Description]
           ,[Edition]
           ,[Genre]
           ,[PageCount]
           ,[Photo]
           ,[Price]
           ,[Publisher]
           ,[SubTitle]
           ,[BookGenreId])
     VALUES
           ('Essential Angular for ASP.NET Core MVC 3'
           ,null
           ,'Maurice'
           ,GetDate()
           ,null
           ,null
           ,'1484252837'
           ,'2020'
           ,'Essential Angular for ASP.NET Core MVC 3: A Practical Guide to Successfully Using Both in Your Projects'
           ,'Second'
           ,'.NET Core'
           ,351
           ,null
           ,59.99
           ,'Apress'
           ,'A practical guide to successfully using Both in your projects'
           ,(SELECT ID From BookGenre where Genre = 'Angular'))
GO



-----


                                                      
