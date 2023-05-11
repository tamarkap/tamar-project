CREATE DATABASE CovidDB

    CREATE TABLE [dbo].[Member] (
    [Id]               NVARCHAR(10)          NOT NULL,
    [member_name]      NVARCHAR(50)    NOT NULL,
    [member_last_name] NVARCHAR(50)    NOT NULL,
    [city_address]     VARCHAR (50)    NOT NULL,
    [street_address]   VARCHAR (50)    NOT NULL, 
    [house_number]     BIGINT          NOT NULL,
    [date_of_birth]    DATETIME        NOT NULL,
    [phone]            BIGINT          NOT NULL,
    [mobile_phone]     BIGINT          NOT NULL,
    [image]            VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Vaccination] (
    [Id]                    INT   NOT NULL IDENTITY,
   [vaccination_date]      DATETIME NOT NULL,
    [vaccine_manufacturer]  NVARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
);


CREATE TABLE [dbo].[Corona_information] ( 
    [member_id]         NVARCHAR(10)   NOT NULL,
    [t_positive_answer] DATETIME NULL,
    [recovery_date]     DATETIME NULL,
    [id_vaccination_1] INT NULL, 
	[id_vaccination_2] INT NULL, 
	[id_vaccination_3] INT NULL, 
	[id_vaccination_4] INT NULL, 

    PRIMARY KEY CLUSTERED ([member_id]),
    FOREIGN KEY ([member_id]) REFERENCES [dbo].[Member] ([Id]),

     FOREIGN KEY ([id_vaccination_1]) REFERENCES [dbo].[Vaccination] ([Id]),
     FOREIGN KEY ([id_vaccination_2]) REFERENCES [dbo].[Vaccination] ([Id]),
     FOREIGN KEY ([id_vaccination_3]) REFERENCES [dbo].[Vaccination] ([Id]),
     FOREIGN KEY ([id_vaccination_4]) REFERENCES [dbo].[Vaccination] ([Id])

);


