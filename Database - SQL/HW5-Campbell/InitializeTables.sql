CREATE TABLE Student (
    StudentID   CHAR (5)  NOT NULL,
    StudentName VARCHAR (25) NULL,
    CONSTRAINT PK_Student PRIMARY KEY (StudentID ASC)
);
CREATE TABLE Faculty (
    FacultyID   CHAR (4)  NOT NULL,
    FacultyName VARCHAR (25) NULL,
    CONSTRAINT PK_Faculty PRIMARY KEY (FacultyID ASC)
);
CREATE TABLE Course (
    CourseID   CHAR (8)  NOT NULL,
    CourseName VARCHAR (15) NULL,
    CONSTRAINT PK_Course PRIMARY KEY (CourseID ASC)
);
CREATE TABLE Section (
    SectionNo       INT NOT NULL,
    Semester        CHAR (7) NULL,
    CourseID 	CHAR (8) NULL,
    CONSTRAINT PK_Section PRIMARY KEY (SectionNo ASC),
    CONSTRAINT FK_Sections_Courses FOREIGN KEY (CourseID) REFERENCES Course (CourseID)
);
CREATE TABLE Registration (
    StudentID CHAR (5) NOT NULL,
    SectionNo INT        NOT NULL,
    CONSTRAINT PK_Registration PRIMARY KEY (StudentID ASC, SectionNo ASC),
    CONSTRAINT FK_Registrations_Sections_SectionNo FOREIGN KEY (SectionNo) REFERENCES Section (SectionNo),
    CONSTRAINT FK_Registrations_Students_StudentID FOREIGN KEY (StudentID) REFERENCES Student (StudentID)
);
CREATE TABLE Qualified (
    FacultyID     CHAR (4) NOT NULL,
    CourseNo      CHAR (8) NOT NULL,
    DateQualified DATETIME     NOT NULL,
    CONSTRAINT PK_Qualified PRIMARY KEY (FacultyID ASC, CourseNo ASC),
    CONSTRAINT FK_Qualifieds_Courses_CourseNo FOREIGN KEY (CourseNo) REFERENCES Course (CourseID),
    CONSTRAINT FK_Qualifieds_Faculties_FacultyID FOREIGN KEY (FacultyID) REFERENCES Faculty (FacultyID)
);

