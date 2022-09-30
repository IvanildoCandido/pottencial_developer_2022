using Lybrary.Models;
using Newtonsoft.Json;

// Serializando em formato JSON

List<Sell> sells = new List<Sell>();

Sell sell1 = new Sell(1, "Impressora 3D X4", 456.80M, DateTime.Now);
Sell sell2 = new Sell(2, "Telescópio Lunar", 1200.30M, DateTime.Now);

sells.Add(sell1);
sells.Add(sell2);

string json = JsonConvert.SerializeObject(sells, Formatting.Indented);

Console.WriteLine(json);

File.WriteAllText("files/sells.json", json);

// Deserializando um JSON

string carsJson = File.ReadAllText("files/cars.json");
List<Cars> cars = JsonConvert.DeserializeObject<List<Cars>>(carsJson);

foreach (Cars car in cars)
{
    Console.WriteLine(car.Model);
}


