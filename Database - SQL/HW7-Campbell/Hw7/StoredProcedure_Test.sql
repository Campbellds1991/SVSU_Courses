Create Table Courses(
	CourseName varchar(5),
	Title varchar(max),
	MaxSeats int,
	CurrentEnrollments int)

insert into Courses Values
	('CS160', 'Microcomputer Software', 30, 16),
('CS146'	, 'Visual Basic .NET Programming'	,25,	35),
('CS116'	, 'Computer Programming I'		,30,	32),
('CS216'	, 'Computer Programming II'	,30,	34),
('CS233'	, 'Cyber Crime'				,30,	25),
('CS331'	, 'Computer Organization'		,30,	35),
('CS401'	, 'Computer Networks'			,30,	8);


EXEC ProcessCourses

Select * from UnderEnrolledCourses;
Select * from CoursesToBeOverloaded;
Select * from CoursesThatNeedANewSection;