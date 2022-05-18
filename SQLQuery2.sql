UPDATE tbl_subject
SET mark1 = null,mark2 = null,mark3 = null,mark4 = null
WHERE subject_id = 1;

select * from tbl_subject


INSERT INTO tbl_subject VALUES ('4','1','2','7') WHERE subject_id=1


UPDATE tbl_subject SET mark1 =10,00,mark2 =20,00,mark3 = 10,00,mark4 = 20,00 WHERE subject_id = 1


ALTER TABLE tbl_subject 
alter column mark4 decimal(10,0);