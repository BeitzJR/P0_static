using System;

namespace P0_mud
{

    class Program
    {

        static void Main(string[] args)
        {      

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Borderlands");
        Console.WriteLine("");
        warrior character2 = new warrior();
        Console.WriteLine("Warrior");
        Console.WriteLine("Hit Points " + character2.getCurrentHP());
        Console.WriteLine("Attack Bonus " + character2.getAttBonus());
        Console.WriteLine("Save Bonus " + character2.getSaveBonus());

        Console.WriteLine("");

        mage character3 = new mage();

        Console.WriteLine("Mage");
        Console.WriteLine("Hit Points " + character3.getCurrentHP());
        Console.WriteLine("Attack Bonus " + character3.getAttBonus());
        Console.WriteLine("Save Bonus " + character3.getSaveBonus());
        }

    }

}
