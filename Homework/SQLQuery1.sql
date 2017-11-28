create table Geography(
	id int not null identity (1,1),
	name nvarchar (100),
	level nvarchar (100),
	longitude decimal (10, 5),
	latitude decimal (10,5),
	parentName nvarchar (100),
	parentID int,
	childName nvarchar (100),
	childID int
);

insert into Geography (name, level, longitude, latitude, parentName, parentID,childName, childID) Values
('Long Beach', 'City', 123.435, 23.343412, 'California', 2, null, null ),
('California', 'State', 134.535, 145.343412, 'U.S.', 3, 'Long Beach', 1 ),
('U.S', 'Country', 123.3431, 1234.3214, null, null, null, null ),
('Long Beach', 'City', 33.435, 23.423, 'New Mexico', 5, null, null ),
('New Mexico', 'State', 56.535, 14.643, 'U.S.', 3, 'Long Beach', 4 ),
('Long Beach', 'City', 313.35, 223.12, 'New York', 7, null, null ),
('New York', 'State', 31.5335, 21.312, 'U.S.', 3, 'Long Beach', 6 ),
('Mexico', 'Country', 123.3431, 34.314, null, null, null, null ),
('California', 'State', 123.435, 23.343412, 'Mexico', 8, null, null ),
('California', 'State', 134.535, 145.343412, 'Australia', 11, null, null ),
('Australia', 'Country', 123.3431, 1234.3214, null, null, null, null );

select * from Geography;

Declare @city nvarchar (100) = 'Long Beach'
Declare @state nvarchar (100)
Declare @country nvarchar (100)

Select * from Geography
Where ISNULL(@city, '') + ' ' + ISNULL(@state, '') + ' ' + ISNULL(@country, '') = state + 