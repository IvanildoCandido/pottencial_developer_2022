using Lybrary.Models;
;
string[] lines = File.ReadAllLines("Files/fileModel.txt");

Queue<string> queue = new Queue<string>();
Stack<string> stack = new Stack<string>();
Dictionary<string, string> states = new Dictionary<string, string>();

foreach (string line in lines)
{
    queue.Enqueue(line);
    stack.Push(line);
}
Console.WriteLine("Implementação de um fila:");
for (int i = 0; i < lines.Length; i++)
{

    Console.WriteLine($"{i + 1}° da fila: {queue.Dequeue()}");
}

Console.WriteLine("Implementação de um pilha:");
for (int i = 0; i < lines.Length; i++)
{

    Console.WriteLine($"{i + 1}° da pilha: {stack.Pop()}");
}

states["PB"] = "Paraíba";
states["RJ"] = "Rio de Janeiro";
states["SP"] = "São Paulo";

foreach (var state in states)
{
    Console.WriteLine($"Chave = {state.Key} - Valor = {state.Value}");
}

TupleExamples tuple = new TupleExamples();

var (id, name, age) = tuple.person();

Console.WriteLine($"ID: {id} NOME: {name} IDADE: {age}");
