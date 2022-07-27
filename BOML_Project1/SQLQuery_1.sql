-- Create a new table called '[acters]' in schema '[BOML]'
-- Drop the table if it already exists
IF OBJECT_ID('[BOML].[acters]', 'U') IS NOT NULL
DROP TABLE [BOML].[acters]
GO
-- Create the table in the specified schema
CREATE TABLE [BOML].[acters]
(
    [Id] INT NOT NULL IDENTITY(6000, 1) PRIMARY KEY, -- Primary Key column
    [name] NVARCHAR(50) NOT NULL,
    [hpmax] INT NOT NULL,
    [hpcurrent] INT NOT NULL,
    [attbonus] INT NOT NULL,
    [savebonus] INT NOT NULL,
    [damagedie] INT NOT NULL,
    -- Specify more columns here
);
GO

-- Create a new table called '[players]' in schema '[BOML]'
-- Drop the table if it already exists
IF OBJECT_ID('[BOML].[players]', 'U') IS NOT NULL
DROP TABLE [BOML].[players]
GO
-- Create the table in the specified schema
CREATE TABLE [BOML].[players]
(
    [Id] INT NOT NULL IDENTITY(3000, 1) PRIMARY KEY, -- Primary Key column
    [username] NVARCHAR(50) NOT NULL,
    [character] INT NOT NULL
    -- Specify more columns here
);
GO

-- Create a new table called '[rooms]' in schema '[BOML]'
-- Drop the table if it already exists
IF OBJECT_ID('[BOML].[rooms]', 'U') IS NOT NULL
DROP TABLE [BOML].[rooms]
GO
-- Create the table in the specified schema
CREATE TABLE [BOML].[rooms]
(
    [Id] INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY, -- Primary Key column
    [Xloc] INT NOT NULL,
    [Yloc] INT NOT NULL,
    [Description] NVARCHAR(MAX),
    -- Specify more columns here
);
GO

INSERT INTO BOML.acters VALUES
('Goblin', 5, 5, 2, 2, 4),
('Big Rat', 7, 7, 1, 1, 4),
('Bubba', 15, 15, 4, 1, 6)
;

INSERT INTO BOML.rooms VALUES
(0, 0, 'The Starting Point'),
(0, 1, 'Going up'),
(1, 0, 'Going right')
