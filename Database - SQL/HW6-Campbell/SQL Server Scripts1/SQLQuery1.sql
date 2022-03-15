alter table tutor
add Subject varchar(7) Null Check (Subject in ('Reading', 'Math' ,'ESL'));

select distinct Tutor.TutorID from MatchHistory MH, Tutor
where (MH.EndDate is Null or MH.EndDate >= '07/01/2015')
and MH.TutorID = Tutor.TutorID
and MH.MatchID Not in (Select tr.MatchID from TutorReport tr where tr.Month = '07/01/2015');

Select Sum(TR.Hours) as "Hours Worked", Sum(TR.Lessons) as "Lessons Taught" from TutorReport TR, MatchHistory MH 
where MH.TutorID = 106
and TR.MatchID = MH.MatchID;

Select distinct Tutor.TutorID from MatchHistory MH, Tutor
where MH.EndDate is Null 
and Tutor.TutorID = MH.TutorID;