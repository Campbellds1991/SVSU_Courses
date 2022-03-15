use CIS386_HW7;
Go
Drop Procedure if exists ProcessCourses;
Go
CREATE PROCEDURE ProcessCourses AS
	Drop Table if Exists UnderEnrolledCourses;
	Drop Table if Exists CoursesToBeOverloaded;
	Drop Table if Exists CoursesThatNeedANewSection;

	Create Table UnderEnrolledCourses(
		CourseNumber varchar(5)
		);
	Create Table CoursesToBeOverloaded(
		CourseNumber varchar(5)
		);
	Create Table CoursesThatNeedANewSection(
		CourseNumber varchar(5)
		);


	Declare @Name varchar(5), @MaxSeats int, @CurrentEnrollments int;

	Declare Course_Cursor Cursor Local For 
		Select CourseName, MaxSeats, CurrentEnrollments 
		From Courses;

	Open Course_Cursor;

	FETCH NEXT FROM Course_Cursor
	INTO @Name, @MaxSeats, @CurrentEnrollments;

	While @@FETCH_STATUS = 0
	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from
		-- interfering with SELECT statements.
		SET NOCOUNT ON;
		if (@MaxSeats < @CurrentEnrollments and @CurrentEnrollments < @MaxSeats + 6) 
		Begin
			Insert into CoursesToBeOverloaded values (@Name); 
		END
		ELSE if( @MaxSeats * .5 > @CurrentEnrollments )
		BEGIN
			Insert into UnderEnrolledCourses values (@Name);
		END
		ELSE if (@CurrentEnrollments > @MaxSeats + 9)
		BEGIN
			Insert into CoursesThatNeedANewSection values (@Name);
		END

		Fetch Next From Course_Cursor INTO @Name, @MaxSeats, @CurrentEnrollments;
	END
	Close Course_Cursor;
GO
