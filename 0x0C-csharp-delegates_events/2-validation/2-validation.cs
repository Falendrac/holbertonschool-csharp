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

    private delegate void CalculateHealth(float value);

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

    /// <summary>
    /// TakeDamage method.
    /// </summary>
    /// <param name="damage">Damage taken.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;

        Console.WriteLine($"{this.name} takes {damage} damage!");

        ValidateHP(this.hp - damage);
    }

    /// <summary>
    /// HealDamage method.
    /// </summary>
    /// <param name="heal">Heal taken.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;

        Console.WriteLine($"{this.name} heals {heal} HP!");

        ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Validate the newHp that not be under than 0 or greater than maxHp
    /// </summary>
    /// <param name="newHp">The newHp calculate in TakeDamage and HealDamage</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
}
