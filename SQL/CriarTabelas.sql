CREATE TABLE [dbo].[Menu] (
    [Id] [uniqueidentifier] NOT NULL,
    [ImagePath] [varchar](100),
    [Name] [varchar](80) NOT NULL,
    [Description] [varchar](150) NOT NULL,
    [Price] [varchar](10) NOT NULL,
    [RestaurantId] [uniqueidentifier] NOT NULL,
    [CascadeMode] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Menu] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Restaurant] (
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [varchar](80) NOT NULL,
    [Category] [varchar](80) NOT NULL,
    [DeliveryEstimate] [varchar](10) NOT NULL,
    [Rating] [varchar](10) NOT NULL,
    [ImagePath] [varchar](150) NOT NULL,
    [About] [varchar](150) NOT NULL,
    [Hours] [varchar](10) NOT NULL,
    [CascadeMode] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Restaurant] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Review] (
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [varchar](80) NOT NULL,
    [Date] [datetime] NOT NULL,
    [Rating] [varchar](10) NOT NULL,
    [Comments] [varchar](150) NOT NULL,
    [RestaurantId] [uniqueidentifier] NOT NULL,
    [CascadeMode] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Review] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_RestaurantId] ON [dbo].[Menu]([RestaurantId])
CREATE INDEX [IX_RestaurantId] ON [dbo].[Review]([RestaurantId])
ALTER TABLE [dbo].[Menu] ADD CONSTRAINT [FK_dbo.Menu_dbo.Restaurant_RestaurantId] FOREIGN KEY ([RestaurantId]) REFERENCES [dbo].[Restaurant] ([Id])
ALTER TABLE [dbo].[Review] ADD CONSTRAINT [FK_dbo.Review_dbo.Restaurant_RestaurantId] FOREIGN KEY ([RestaurantId]) REFERENCES [dbo].[Restaurant] ([Id])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)