use ProjectHandler;

--User info table
select * from UserInfo;

select * from UserInfo where u_id='b010' and pass='b1234';

select u_id, uname, joiningDate, activeStatus from UserInfo where u_id like 'm%';

select u_id, activeStatus from UserInfo where u_id like 'm%';

delete from UserInfo where u_id='m022';

insert into UserInfo values ('m022', 'Bob', '44444', 'Male', 'something', 'dummmy', '5', '1999-4-11', 'manager', 'manager', '2020-2-1', 'true', '11');

insert into UserInfo values ('k085', 'Josh', '44544', 'Male', 'something', 'dummmy', '5', '1999-4-11', 'sysemp', 'sysemp', '2020-2-1', 'true', '11');

update UserInfo set uname='ken', pass='66666', gender='Male', image='user', phone='dummy', address_id='3', dob='1988-2-1', designation='admin', rank='sysemp', joiningDate='2018-9-1', activeStatus='true', department_no='11' where u_id='a085'; 

delete from UserInfo where u_id='p085';

--User info Project Details
select * from ProjectDetails;

select project_id, project_name, description, deadline, u_id_manager from ProjectDetails;

select project_id, project_name, description, deadline, u_id_manager from ProjectDetails where project_id='0011';

insert into  ProjectDetails (project_id, project_name, description, deadline, u_id_manager) values ('0072', 'Generator store', 'dummy text', '2022-1-2', 'm020');

update ProjectDetails set rating='' where project_id = '0011';

delete from ProjectDetails where project_id = '0082'


--User info Rank Details
select * from Rank;

--User info Submission Details
select * from SubmissionDetails;

--User info Deal Details
select * from DealDetails;

--User info Project Details
select * from Address;

--User info Comment Details
select * from CommentDetails;

select * from CommentDetails where project_id = '0014';

insert into CommentDetails values('404', '0011', 'e030', 'safhshe')

--User info Log Record
select * from LogRecord;

--User info Log Record
select * from SalesDetails;