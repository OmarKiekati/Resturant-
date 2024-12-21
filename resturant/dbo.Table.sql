CREATE TABLE Users
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [user_name] VARCHAR(10) NOT NULL, 
    [password] VARCHAR(10) NOT NULL, 
    [role] VARCHAR(20) NOT NULL CHECK (role IN ('ADMIN','EMPLOYEE'))
)

