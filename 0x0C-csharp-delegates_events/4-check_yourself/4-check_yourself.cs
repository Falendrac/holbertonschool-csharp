using System;


/// <summary>
/// Player class.
/// </summary>
class Player
{
    /// <summary>Gets or sets name.</summary>
    private string name { get; set; }

    /// <summary>Gets or sets maxHp.</summary>
    private float maxHp { get; set; }

    /// <summary>Gets or sets hp.</summary>
    private float hp { get; set; }

    /// <summary>Gets or sets status.</summary>
    private string status { get; set; }

    /// <summary>
    /// CalculateHealth delegate.
    /// </summary>
    /// <param name="value"></param>
    private delegate void CalculateHealth(float value);

    /// <summary>EventHandler HPCheck.</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>Initializes a new instance of the <see cref="Player"/> class.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;

        this.status = $"{this.name} is ready to go!";

        // Calling event on CheckStatus method
        this.HPCheck += CheckStatus;
    }

    /// <summary>
    /// PrintHealth method.
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

        this.hp -= damage;
        ValidateHP(this.hp);
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

        this.hp += heal;
        ValidateHP(this.hp);
    }

    /// <summary>
    /// ValdateHP if damage or heal is too big.
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;

        // When ValidateHp is used, trigger this event
        HPCheck?.Invoke(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// ApplyModifier method.
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue /= 2f;
            case Modifier.Strong:
                return baseValue *= 1.5f;
        }

        return baseValue;
    }

    /// <summary>
    /// Check Player status.
    /// </summary>
    /// <param name="sender">Publisher</param>
    /// <param name="e">Event</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {

        if (e.currentHp == maxHp)
            status = $"{this.name} is in perfect health!";

        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
            status = $"{this.name} is doing well!";

        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
            status = $"{this.name} isn't doing too great...";

        else if (e.currentHp > 0 && e.currentHp < maxHp / 2)
            status = $"{this.name} needs help!";

        else
            status = $"{this.name} is knocked out!";

        Console.WriteLine(this.status);
    }
}

/// <summary>
/// Enum Modifier.
/// </summary>
public enum Modifier
{
    /// <summary>Weak modifier.</summary>
    Weak,
    /// <summary>Base modifier.</summary>
    Base,
    /// <summary>Strong modifier.</summary>
    Strong
}

/// <summary>
/// CalculateModifier delegate.
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns>Float value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>
/// CurrentHP event.
/// </summary>
class CurrentHPArgs : EventArgs
{
    /// <summary>Gets currentHp.</summary>
    public float currentHp { get; }

    /// <summary>Initializes a new instance of the <see cref="CurrentHPArgs"/> class.</summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
