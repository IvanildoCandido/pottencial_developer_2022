//Executando um debug de condicional
using pottencial_developer_2022.Models;
int inventoryAmmount = 2;
int soldAmmount = 3;

bool success = inventoryAmmount >= soldAmmount;

if (success)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Impossível realizar a venda.");
}

// Calculadora exemplo de operações

Calculator calc = new Calculator();
calc.Operation(10, 20, '+');
calc.Operation(10, 20, '-');
calc.Operation(10, 20, '*');
calc.Operation(20, 2, '/');

