CREATE VIEW RegisteredStudents AS
Select Student.StudentId, Student.StudentName 
From registration,student where student.StudentID = registration.StudentID;
