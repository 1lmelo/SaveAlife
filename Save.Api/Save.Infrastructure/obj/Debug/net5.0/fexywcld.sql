IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [SearchCovid] (
    [Id] int NOT NULL IDENTITY,
    [Country] nvarchar(max) NULL,
    [Cases] int NOT NULL,
    [Confirmed] int NOT NULL,
    [Deaths] int NOT NULL,
    [Recovered] int NOT NULL,
    [Update_at] datetime2 NOT NULL,
    CONSTRAINT [PK_SearchCovid] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220523185528_initial', N'5.0.17');
GO

COMMIT;
GO

