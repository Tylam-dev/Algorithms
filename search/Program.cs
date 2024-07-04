// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text.Json;
using search;

string jsonFilePath = "../MOCK_DATA.json";
string jsonString = File.ReadAllText(jsonFilePath);
List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Searcher search = new Searcher();

search.LinealSearchByName(users, "Huey");

stopwatch.Stop();
Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");