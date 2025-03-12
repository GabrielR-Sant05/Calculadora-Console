// Código esta utilizando instruções nível superior, ao final desse arquivo tem o código com instruções classes e namespace
using se_usar_ia_se_ta_fudido;
using Spectre.Console;

//mensagem de boas vindas
//AVISO: essa classe AnsiConsole não é da linguagem padrão e sim de uma lib chamada Spectre.Console, está sendo utilizada para dar um visual mais atraente ao console
AnsiConsole.Markup("[bold red]Hello, Calculadora[/]");

//instancia da classe Calculadora, criando o objeto calculadora
var calculadora = new Calculadora();

while (true)
{
    AnsiConsole.Clear();
    var escolha = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Calculadora")
            .PageSize(10)
            .AddChoices(new[] {
                "Somar",
                "Subtrair",
                "Multiplicar",
                "Divisão",
                "Sair"
            }));

    switch (escolha)
    {
        case "Somar":
            CalculadoraSomar();
            break;
        case "Subtrair":
            CalculadoraSubtrair();
            break;
        case "Multiplicar":
            CalculadoraMultiplicar();
            break;
        case "Divisão":
            CalculadoraDivisao();
            break;
        case "Sair":
            return;
    }
}

//métodos para realizar as operações, cada método chama o método da classe Calculadora correspondente
void CalculadoraSomar()
{
    Console.WriteLine("Digite os valores separados por vírgula");
    calculadora.Valores = Console.ReadLine().Split(',').Select(double.Parse).ToList();
    calculadora.result = calculadora.Soma(calculadora.Valores, calculadora.result);
    Console.WriteLine($"Resultado: {calculadora.result}");
    Console.ReadKey();
}

void CalculadoraSubtrair()
{
    Console.WriteLine("Digite os valores separados por vírgula");
    calculadora.Valores = Console.ReadLine().Split(',').Select(double.Parse).ToList();
    calculadora.result = calculadora.Sub(calculadora.Valores, calculadora.result);
    Console.WriteLine($"Resultado: {calculadora.result}");
    Console.ReadKey();
}

void CalculadoraMultiplicar()
{
    Console.WriteLine("Digite os valores separados por vírgula");
    calculadora.Valores = Console.ReadLine().Split(',').Select(double.Parse).ToList();
    calculadora.result = calculadora.Mult(calculadora.Valores, calculadora.result);
    Console.WriteLine($"Resultado: {calculadora.result}");
    Console.ReadKey();
}

void CalculadoraDivisao()
{
    Console.WriteLine("Digite os valores separados por vírgula");
    calculadora.Valores = Console.ReadLine().Split(',').Select(double.Parse).ToList();
    calculadora.result = calculadora.Div(calculadora.Valores, calculadora.result);
    Console.WriteLine($"Resultado: {calculadora.result}");
    Console.ReadKey();
}