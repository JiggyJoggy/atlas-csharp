using System;

class Program
{
    static void Main(string[] args)
    {
        Decoration figurine = new Decoration("Expensive Figurine", isQuestItem: true);

        Console.WriteLine(figurine.ToString());

        figurine.Interact();
        figurine.Break();
        figurine.Break();

        figurine.name = "Cheap Figurine";
        figurine.durability = 2;
        figurine.isQuestItem = false;

        figurine.Interact();
        figurine.Break();
    }
}