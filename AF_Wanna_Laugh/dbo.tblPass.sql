CREATE TABLE [dbo].[tblPass] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Application] VARCHAR (50) NULL,
    [Username]    VARCHAR (50) NULL,
    [Password]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

