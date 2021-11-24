select * from Estudar.Alunos;

insert into Estudar.Alunos ( Nome, Idade, [Matricula do aluno]) values ('Christian', 21, 898989898);

insert into Estudar.Alunos ( Nome, Idade, [Matricula do aluno]) values ('Thayná', 23, 7363767);

insert into Estudar.Alunos ( Nome, Idade, [Matricula do aluno]) values ('Deivid', 20, 89898);

select * from Estudar.Alunos where id_aluno = 2;

select * from Estudar.Alunos where Idade > 20;

select * from Estudar.Alunos where Idade < 21;

select * from Estudar.Alunos where Nome <> 'Deivid';

select * from Estudar.Alunos where Idade >= 20;

select * from Estudar.Alunos where Idade <= 21;

select * from Estudar.Alunos where Idade = 25;

select * from Estudar.Alunos where Idade like 20;

select * from Estudar.Alunos where Idade like '%0'; 

select * from Estudar.Alunos where Nome like '%C%';

select * from Estudar.Alunos where Nome like 'Chri_tian';

select * from Estudar.Alunos where [Matricula do aluno] like '898_8';

select * from Estudar.Alunos where Nome not like '%n%' and Nome not like 'C%';

select * from Estudar.Alunos where Nome like '%n%' and Nome like 'C%';

select * from Estudar.Alunos where Nome like '%n%' or Nome like 'C%';

insert into Estudar.Alunos ( Nome, [Matricula do aluno]) values ('Valdir', 898989898);

insert into Estudar.Alunos ( Nome, [Matricula do aluno]) values ('Adriana', 78436367);

select * from Estudar.Alunos where Idade is not null ;

insert into Estudar.Alunos (Nome, Idade, [Matricula do aluno]) 
	values ('Igor', 25, 7878787), ('Daniel', 23, 785787), ('José', 40, 74788787), 
	('Richardson', 17, 78787437);

delete from Estudar.Alunos where id_aluno = 1006;

update Estudar.Alunos set Idade = 40 where id_aluno is Null or Idade like 23;

update Estudar.Alunos set Idade = 23 where Idade is NULL or Idade like 40;

update Estudar.Alunos set Idade = 18, [Matricula do aluno]=635368 where Nome = 'Daniel'; 

delete Estudar.Alunos where id_aluno like 1005 or id_aluno like 1007 or id_aluno like 1004;

