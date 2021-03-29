
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/29/2021 16:16:03
-- Generated from EDMX file: C:\Users\MCGC2\source\repos\TheFree-Man\Object-Orientated-Development\Individual Project\Game Database\Games.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GamesDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Games'
CREATE TABLE [dbo].[Games] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DevelopedBy] nvarchar(max)  NOT NULL,
    [MetacriticRating] nvarchar(max)  NOT NULL,
    [Genre] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Reviews'
CREATE TABLE [dbo].[Reviews] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Reviwer] nvarchar(max)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [GameId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [PK_Games]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [PK_Reviews]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GameId] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [FK_GameReview]
    FOREIGN KEY ([GameId])
    REFERENCES [dbo].[Games]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameReview'
CREATE INDEX [IX_FK_GameReview]
ON [dbo].[Reviews]
    ([GameId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------