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