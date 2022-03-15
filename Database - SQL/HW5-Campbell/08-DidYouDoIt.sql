Select Student.* FROM Student, Registration 
where Registration.SectionNo IN ('2714', '2715') 
AND Student.StudentID = Registration.StudentID;



SELECT FacultyID, FacultyName FROM Faculty
WHERE FacultyID = (SELECT FacultyID FROM Qualified 
WHERE FacultyID NOT IN (
SELECT FacultyID FROM Qualified
WHERE CourseNo IN ('ISM 3112', 'ISM 3113'))
GROUP BY FacultyID);
