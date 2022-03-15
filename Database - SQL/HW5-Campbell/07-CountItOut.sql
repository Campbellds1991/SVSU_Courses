select Count(student.StudentID) from student,registration,section where
registration.SectionNo = '2714'
and section.Semester = 'I-2015'
and section.SectionNo = registration.SectionNo
and student.StudentID = registration.StudentID;

select distinct faculty.*, qualified.DateQualified from faculty, qualified 
where qualified.DateQualified <= '2008-12-31' 
and qualified.FacultyID = faculty.FacultyID;