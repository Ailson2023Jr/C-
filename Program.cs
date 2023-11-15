using System.Globalization;
using ExemploExplorando.Models;



// Formatando Datas

string dataString = "2023-03-12 12:22";

bool sucesso =   DateTime.TryParseExact(dataString,
                      "yyyy-MM-dd HH:mm", 
                      CultureInfo.InvariantCulture, 
                      DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}                        
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}


// DateTime data = DateTime.Parse(dataString);

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortTimeString());

// Console.WriteLine(data);





























// Exibindo valor monetário e config moeda

// CultureInfo.DefaultThreadCurrentCulture =new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// Exibindo porcentagem e valor personalisado
// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 151123;

// Console.WriteLine(numero.ToString("##-##-##"));





































// int numero1 = "10";
// int numero2 = "20";


// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);



















// Pessoa p1 = new Pessoa(nome:"Ailson",sobrenome:"Oliveira");
// Pessoa p2 = new Pessoa(nome:"Beatriz",sobrenome:"Mazzucco");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();







































// Pessoa p1 = new Pessoa();

// p1.Nome = "Ailson";
// p1.Sobrenome = "Oliveira";
// p1.Idade = 34;
// p1._nome ="";

// p1.Apresentar();

