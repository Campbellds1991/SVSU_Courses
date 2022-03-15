drop database if exists enrollments;
create database enrollments;
use enrollments;

CREATE TABLE Course (
  courseId char(5),
  subjectId char(4) NOT NULL,
  courseNumber integer,
  title varchar(50) NOT NULL,
  numOfCredits integer,
  PRIMARY KEY (courseId)
);

INSERT INTO Course (courseId, subjectId, courseNumber, title, numOfCredits) VALUES
('11111', 'CSCI', 1301, 'Introduction to Java I', 4),
('11112', 'CSCI', 1302, 'Introduction to Java II', 3),
('11113', 'CSCI', 3720, 'database Systems', 3),
('11114', 'CSCI', 4570, 'Rapid Java Application', 3),
('11115', 'MATH', 2750, 'Calculus I', 5),
('11116', 'MATH', 3750, 'Calculus II', 5),
('11117', 'EDUC', 1111, 'Reading', 3),
('11118', 'ITEC', 1344, 'Database Administration', 3);

CREATE TABLE Student (
  ssn char(9),
  firstName varchar(25),
  mi char(1),
  lastName varchar(25),
  phone char(11),
  birthDate date,
  street varchar(100),
  zipCode char(5),
  deptId char(4),
  PRIMARY KEY (ssn)
);

INSERT INTO Student (ssn, firstName, mi, lastName, phone, birthDate, street, zipCode, deptId) VALUES
('444111110', 'Jacob', 'R', 'Smith', NULL, '1985-04-09', '99 Kingston Street', '31435', 'BIOL'),
('444111111', 'John', 'K', 'Stevenson', '9129219434', NULL, '100 Main Street', '31411', 'BIOL'),
('444111112', 'George', 'R', 'Heintz', '9129213454', '1974-10-10', '1200 Abercorn Street', '31419', 'CS'),
('444111113', 'Frank', 'E', 'Jones', '9125919434', '1970-09-09', '100 Main Street', '31411', 'BIOL'),
('444111114', 'Jean', 'K', 'Smith', '9129219434', '1970-02-09', '100 Main Street', '31411', 'CHEM'),
('444111115', 'Josh', 'R', 'Woo', '7075989434', '1970-02-09', '555 Franklin Street', '31411', 'CHEM'),
('444111116', 'Josh', 'R', 'Smith', '9129219434', '1973-02-09', '100 Main Street', '31411', 'BIOL'),
('444111117', 'Joy', 'P', 'Kennedy', '9129229434', '1974-03-19', '103 Bay Street', '31412', 'CS'),
('444111118', 'Toni', 'R', 'Peterson', '9129229434', '1964-04-29', '103 Bay Street', '31412', 'MATH'),
('444111119', 'Patrick', 'R', 'Stoneman', NULL, '1969-04-29', '101 Washington Street', '31435', 'MATH'),
('444111120', 'Rick', 'R', 'Carter', NULL, '1986-04-09', '19 West Ford Street', '31411', 'BIOL');

CREATE TABLE Enrollment (
  ssn char(9) NOT NULL,
  courseId char(5) NOT NULL,
  dateRegistered date,
  grade char(1),
  PRIMARY KEY (ssn, courseId),
  FOREIGN KEY (courseID) REFERENCES Course (courseId),
  FOREIGN KEY (ssn) REFERENCES Student (ssn)
);

INSERT INTO Enrollment (ssn, courseId, dateRegistered, grade) VALUES
('444111110', '11111', '2016-09-14', 'A'),
('444111110', '11112', '2016-09-14', 'B'),
('444111110', '11113', '2016-09-14', 'C'),
('444111111', '11111', '2016-09-14', 'D'),
('444111111', '11112', '2016-09-14', 'F'),
('444111111', '11113', '2016-09-14', 'A'),
('444111112', '11114', '2016-09-14', 'B'),
('444111112', '11115', '2016-09-14', 'C'),
('444111112', '11116', '2016-09-14', 'D'),
('444111113', '11111', '2016-09-14', 'A'),
('444111113', '11113', '2016-09-14', 'A'),
('444111114', '11115', '2016-09-14', 'B'),
('444111115', '11115', '2016-09-14', 'F'),
('444111115', '11116', '2016-09-14', 'F'),
('444111116', '11111', '2016-09-14', 'D'),
('444111117', '11111', '2016-09-14', 'D'),
('444111118', '11111', '2016-09-14', 'A'),
('444111118', '11112', '2016-09-14', 'D'),
('444111118', '11113', '2016-09-14', 'B');
