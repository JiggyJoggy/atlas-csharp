using System;

/// <summary>
/// Setting up the Player
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

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
    }

    /// <summary>
    /// Method that prints out name of player, hp it has out of maxHp
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    public delegate float CalculateHealth(float num);

    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            hp -= 0;
            damage = 0;
        }
        else
        {
            hp -= damage;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            hp += 0;
            heal = 0;
        }
        else
        {
            hp += heal;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}