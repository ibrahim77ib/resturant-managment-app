CREATE TABLE [dbo].[restorant] (
    [Id]        INT        NOT NULL,
    [name]      NCHAR (50) NULL,
    [price]     FLOAT (53) NULL,
    [num_sales] INT        NULL,
    [profit]    INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

