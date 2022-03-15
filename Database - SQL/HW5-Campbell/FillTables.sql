use cis386;

insert into course 
values 
('ISM 3113', 'Syst Analysis'),
('ISM 3112', 'Syst Design'),
('ISM 4212', 'Database'),
('ISM 4930', 'Networking');

insert into student 
values 
('38214', 'Letersky'),
('54907',	'Altvater'),
('66324', 'Aiken'),
('70542', 'Marra');

insert into faculty
values
('2143', 'Birkin'),
('3467', 'Berndt'),
('4756', 'Collins');


INSERT INTO section
VALUES 
('2712', 'I-2015', 'ISM 3113'),
('2713', 'I-2015', 'ISM 3113'),
('2714', 'II-2015', 'ISM 4212'),
('2715', 'II-2015', 'ISM 4930');

insert into registration
values
('66324', '2713'),
('38214', '2714'),
('54907', '2715'),
('54907', '2714');

insert into qualified
values
('2143', 'ISM 3112', '2005-09-01'),
('2143', 'ISM 3113', '2005-09-01'),
('3467', 'ISM 4212', '2012-09-01'),
('3467', 'ISM 4930', '2013-09-01'),
('4756', 'ISM 3112', '2008-09-01'),
('4756', 'ISM 3113', '2008-09-01');

