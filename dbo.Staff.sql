CREATE TABLE [dbo].[Staff] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (50) NULL,
    [Surname] VARCHAR (50) NULL,
    [Job]     VARCHAR (50) NULL,
    [Working Day] DATETIME2 NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

