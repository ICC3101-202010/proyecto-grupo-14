CREATE TABLE [dbo].[Usuarios] (
    [UserId]         INT           NOT NULL,
    [Email]      VARCHAR (100) NULL,
    [Usuario]    VARCHAR (100) NULL,
    [Contraseña] VARCHAR (50)  NULL,
    [Sexo]       VARCHAR(50)           NULL,
    [Cuenta]     INT           NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

