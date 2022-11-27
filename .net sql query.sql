--create database stu_project
Use stu_project
go


--CREATE TABLE [stu_details](
--stu_id int not null primary key identity(1,1),
--stu_name varchar (255) not null,
--stu_address varchar(255) not null,
--stu_contact nvarchar(25) not null
--)
--Alter table stu_details add stu_college nvarchar(255) NULL
SET IDENTITY_INSERT stu_details ON
--INSERT INTO stu_details
--(stu_id, stu_name, stu_address, stu_contact,stu_college)
--VALUES( '1','Hawana Tamang','Gathaghar','9808691807','KIST')
 INSERT INTO stu_details
(stu_id, stu_name, stu_address, stu_contact,stu_college)
 VALUES
		( '2','Romiya Dangol','Manamaiju','9745332324','KIST') ,
		( '3','Riti Shrestha','Baneshwor','9851196592' ,'Nagarik');

	  --SELECT *
	  --FROM stu_details
	  --SELECT stu_name, stu_address from stu_detail
--example
	  -- (used in mysql) => '' (used in sql)
	  -- Update table_name set column_name = 'column_data', column_name2 = 'Column_data' WHERE id = id_num;
	  -- DELETE from stu_details Where (condition)
--End
	  SELECT * FROM stu_details WHERE stu_id >1;
	  UPDATE stu_details SET stu_name = 'Adison Giri', stu_address = 'bagbazar',stu_contact = '9863456123',stu_college ='KIST' WHERE stu_id = 3;
	  DELETE from stu_details WHERE stu_id = 1;
	  SELECT * FROM stu_details

CREATE TABLE [stu_info](
stu_faculty nvarchar (255) not null,
stu_program nvarchar (255) not null)
INSERT INTO stu_info
(stu_faculty, stu_program)
VALUES ('Science and Technology','BIT') ,
		('Science and Technology','BIT') , 
		('Faculty of Management','BIM');
		SELECT * FROM stu_info
		Update stu_info SET stu_faculty = 'Science and Technology' WHERE stu_program = 'BIM';
		DELETE from stu_info WHERE stu_program = 'BIM';