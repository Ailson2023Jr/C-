using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Ailson",sobrenome:"Oliveira");
Pessoa p2 = new Pessoa(nome:"Beatriz",sobrenome:"Mazzucco");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();







































// Pessoa p1 = new Pessoa();

// p1.Nome = "Ailson";
// p1.Sobrenome = "Oliveira";
// p1.Idade = 34;
// p1._nome ="";

// p1.Apresentar();

