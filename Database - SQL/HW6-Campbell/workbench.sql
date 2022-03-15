-- 2a
Select course.CourseID, course.CourseName from course, qualified
where qualified.FacultyID = 4756
and qualified.CourseNo = course.CourseID;

-- 2b
Select student.StudentName from student, registration
where registration.SectionNo = 2714
and student.StudentID = registration.StudentID;

-- 3
Select faculty.FacultyName from qualified, faculty
where qualified.CourseNo = 'ISM 3113'
and qualified.FacultyID = faculty.FacultyID;

-- 4
Select faculty.FacultyName from qualified, faculty
where qualified.CourseNo = 'ISM 3113'
and qualified.FacultyID = faculty.FacultyID
and faculty.FacultyID Not In (
	Select faculty.FacultyName from qualified, faculty
    where qualified.CourseNo = 'ISM 4930'
    and qualified.FacultyID = faculty.FacultyID);
    
-- 5
Select course.CourseName from course, registration, section
where registration.StudentID = 54907
and registration.SectionNo = section.SectionNo
and course.CourseID = section.courseID;

-- 6
Select Distinct student.StudentName from student, registration, section
Where section.CourseID in (
	Select CourseID from qualified
    where facultyID = 2143)
and registration.SectionNo = section.SectionNo
and student.StudentID = registration.StudentID;

-- 7
Select count(distinct student.StudentID) From student, registration, section
where section.CourseID in (
	Select qualified.CourseNo from qualified
    where facultyID = 4856)
and registration.SectionNo = section.SectionNo
and student.StudentID = registration.StudentID;

-- 8
Select distinct StudentID, StudentName from student
where StudentID Not in
	(Select distinct student.StudentID from student, section, registration
    where section.Semester = 'I-2015'
    and registration.SectionNo = section.SectionNo
    and registration.StudentID = student.StudentID);