using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(maxHp: -727f);

        player.PrintHealth();
    }
}