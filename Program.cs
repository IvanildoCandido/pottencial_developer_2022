//Executando um debug de condicional
 
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

