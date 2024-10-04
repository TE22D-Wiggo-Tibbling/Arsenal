using System.Text.Json.Serialization;

class Weapon
{

    [JsonInclude]
    public string Name = "olof";

    [JsonInclude]
    public int DamageMin = 10;

    [JsonInclude]
    public int DamageMax = 20;

    public void Attack()
    {

    }

}