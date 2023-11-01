USE [ExamsAppDb]
GO

/****** Object: Table [dbo].[Users] Script Date: 17/10/2023 12:26:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [UserName]      NVARCHAR (MAX) NULL,
    [Password]      NVARCHAR (MAX) NULL,
    [PhoneNum]      NVARCHAR (MAX) NULL,
    [IsAdmin]       BIT            NOT NULL,
    [FullName]      NVARCHAR (MAX) NULL,
    [Discriminator] NVARCHAR (MAX) NOT NULL,
    [GradeAvg]      REAL           NULL,
    [TeacherId]     INT            NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Users_TeacherId]
    ON [dbo].[Users]([TeacherId] ASC);


GO
ALTER TABLE [dbo].[Users]
    ADD CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Users]
    ADD CONSTRAINT [FK_Users_Users_TeacherId] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Users] ([Id]);

GO
DELETE  FROM Users_1;

