using System.Text.Json;

Weapon w = new();

string weapon = JsonSerializer.Serialize(w);

File.WriteAllText("Weapon.json",weapon);