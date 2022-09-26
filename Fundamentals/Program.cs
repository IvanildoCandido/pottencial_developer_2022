//Executando um debug de condicional
using Lybrary.Models;
int inventoryAmmount = 2;
int soldAmmount = 3;
bool exit = true;
string? imput;
char? option = '0';
string display = "";

while (exit)
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine(display);
    Console.WriteLine("************************************");
    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Editar");
    Console.WriteLine("3 - Deletar");
    Console.WriteLine("4 - Buscar");
    Console.WriteLine("5 - Testar Condicional");
    Console.WriteLine("6 - Testar Calculadora");
    Console.WriteLine("7 - Exemplos Array e Listas");
    Console.WriteLine("0 - Sair");


    imput = Console.ReadLine();
    if (imput != null)
    {

        option = Convert.ToChar(imput);
    }
    switch (option)
    {
        case '1':
            {
                display = "Cadastro de clientes.";
                break;
            }
        case '2':
            {
                display = "Editar clientes.";
                break;
            }
        case '3':
            {
                display = "Deletar clientes.";
                break;
            }
        case '4':
            {
                display = "Buscar clientes.";
                break;
            }
        case '5':
            {
                // Teste condicional
                Console.Clear();
                bool success = inventoryAmmount >= soldAmmount;

                if (success)
                {
                    Console.WriteLine("Venda Realizada");
                }
                else
                {
                    Console.WriteLine("Impossível realizar a venda.");
                }
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                break;
            }
        case '6':
            {

                Console.Clear();
                // Calculadora exemplo de operações

                Calculator calc = new Calculator();
                calc.Operation(10, 20, '+');
                calc.Operation(10, 20, '-');
                calc.Operation(10, 20, '*');
                calc.Operation(20, 2, '/');
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                break;
            }
        case '7':
            {
                Console.Clear();
                ArrayAndList arrayAndList = new ArrayAndList();
                arrayAndList.setDays();
                arrayAndList.printDays();
                Console.ReadLine();
                break;
            }
        case '0':
            {
                Console.WriteLine("Programa encerrado.");
                exit = false;
                break;
            }
        default:
            {

                display = "Opção inválida.";
                break;
            }
    }
}




