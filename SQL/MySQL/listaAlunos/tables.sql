CREATE TABLE aluno(
    nome VARCHAR(50),
    data_nascimento DATE,
    idade INT,
    nota FLOAT
);

INSERT INTO aluno(nome, data_nascimento, idade, nota) VALUES (
    "Christian",
    "2001-07-13",
    20,
    9.0
);

INSERT INTO aluno(nome, data_nascimento, idade, nota) VALUES (
    "Deivid",
    "2002-07-17",
    19,
    10.0
);

INSERT INTO aluno(nome, data_nascimento, idade, nota) VALUES (
    "Thayná",
    "1999-01-08",
    22,
    10
);

INSERT INTO aluno(nome, data_nascimento, idade, nota) VALUES (
    "Adriana",
    "1940-07-14",
    40,
    6.0
);

INSERT INTO aluno(nome, data_nascimento, idade, nota) VALUES (
    "Valdir",
    "1950-08-08",
    34,
    5.0
);

INSERT INTO aluno(nome, data_nascimento, idade, nota) VALUES (
    "Mauricio JR",
    "2007-01-12",
    20,
    2.0
);

INSERT INTO aluno(nome, data_nascimento, idade, nota) VALUES (
    "Alicia",
    "2009-01-12",
    8,
    7.0
);

SELECT * FROM aluno;

SELECT * FROM aluno WHERE nota < 5;

SELECT * FROM aluno WHERE nota > 5;

SELECT * FROM aluno WHERE nome like "a%";

SELECT * FROM aluno WHERE idade >= 18;