// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text.Json;
using Algorithms;

string jsonFilePath = "./MOCK_DATA.json";
string jsonString = File.ReadAllText(jsonFilePath);
List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);

Stopwatch linealSearchClock = new Stopwatch();
Stopwatch binarySearchClock = new Stopwatch();

Searcher search = new Searcher();

// linealSearchClock.Start();

// search.LinealSearchById(users, 1);

// linealSearchClock.Stop();
// Console.WriteLine($"Tiempo de ejecución: {linealSearchClock.ElapsedMilliseconds} ms");

binarySearchClock.Start();
search.BinarySearchById(users, 850);
binarySearchClock.Stop();
Console.WriteLine($"Tiempo de ejecución: {binarySearchClock.ElapsedMilliseconds} ms");