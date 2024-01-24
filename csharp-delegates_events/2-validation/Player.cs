﻿using System;

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

        ValidateHP(hp - damage);

        Console.WriteLine($"{name} takes {damage} damage!");
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

        ValidateHP(hp + heal);

        Console.WriteLine($"{name} heals {heal} HP!");
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
    }
}