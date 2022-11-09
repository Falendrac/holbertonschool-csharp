using System;

/// <summary>
/// Define a Player
/// </summary>
class Player
{
    // get or set Name of the player
    private string name { get; set; }
    // get or set MaxHp of the player
    private float maxHp { get; set; }
    // get or set hp of the player
    private float hp { get; set; }

    /// <summary>
    /// Constructor for the player
    /// </summary>
    /// <param name="name">Default value is "Player"</param>
    /// <param name="maxHp">Default value is 100f</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Print the current health of player
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
