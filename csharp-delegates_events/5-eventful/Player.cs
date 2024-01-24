using System;

/// <summary>
/// Setting up the Player
/// </summary>
public class Player
{
    /// <summary>
    /// name is to Player's name
    /// </summary>
    public string name;

    /// <summary>
    /// maxHp to Player's health
    /// </summary>
    public float maxHp;

    /// <summary>
    /// Player hitpoints
    /// </summary>
    public float hp;

    /// <summary>
    /// Sends a message in the start
    /// depending on Player's health
    /// Default message saying it's ready
    /// </summary>
    private string status;

    /// <summary>
    /// Setting up player's name and maxHp
    /// hp is set to maxHp at the start
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp < 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.name = name;
        this.status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Method that prints out name of player, hp it has out of maxHp
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    /// <summary>
    /// Delegate that calculates heals and damagae
    /// takes an arg of a float num
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public delegate float CalculateHealth(float num);

    /// <summary>
    /// Calculates damage to
    /// name of player
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            damage = 0;
        }

        Console.WriteLine($"{name} takes {damage} damage!");

        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Calculates healing to
    /// name of player
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            heal = 0;
        }

        Console.WriteLine($"{name} heals {heal} HP!");

        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates the Player's HP
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }

        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies modifiers based off of:
    /// Weak, Base, and Strong
    /// This goes with either healing or damage
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else if (modifier == Modifier.Strong)
        {
            return (float)(baseValue * 1.5);
        }
        return baseValue;
    }

    /// <summary>
    /// Sends a message depending on Player's current health
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            Console.WriteLine($"{name} is in perfect health!");
        }
        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
        {
            Console.WriteLine($"{name} is doing well!");
        }
        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
        {
            Console.WriteLine($"{name} isn't doing too great...");
        }
        else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
        {
            Console.WriteLine($"{name} needs help!");
        }
        else if (e.currentHp == 0)
        {
            Console.WriteLine($"{name} is knocked out!");
        }
    }

    /// <summary>
    /// Event listener for healthpoints
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Sends messages if player's health is low
    /// or reached zero
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        
        Console.WriteLine("Health is low!");
    }

    /// <summary>
    /// Checking Player's health
    /// Sends a message if current health is less than 1/4 of maxHP
    /// </summary>
    /// <param name="e"></param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
        {
            HPCheck += HPValueWarning;
        }
        HPCheck(this, e);
    }
}

/// <summary>
/// Modifier for healing and damage
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Divides baseValue by half
    /// </summary>
    Weak,
    /// <summary>
    /// Base value is same
    /// </summary>
    Base,
    /// <summary>
    /// 1.5 times the baseValue
    /// </summary>
    Strong
}

/// <summary>
/// Calculator for Modifier
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Current HP for event listener
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Gets current hp
    /// </summary>
    public float currentHp { get; }

    /// <summary>
    /// Sets current hp to new hp
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}