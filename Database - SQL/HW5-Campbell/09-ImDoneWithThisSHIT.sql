SELECT DISTINCT Course.* FROM Course, Section
WHERE Course.CourseID = Section.CourseID;

SELECT * FROM Student
ORDER BY StudentName

SELECT Student.* FROM Student, Registration, Section
WHERE Section.Semester = 'I-2015' AND 
Registration.SectionNo = Section.SectionNo AND
Registration.StudentID = Student.StudentID
ORDER BY section.SectionNo;