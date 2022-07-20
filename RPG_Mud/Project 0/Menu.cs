using System;
using System.IO;



namespace P0_mud
{
    public class gameMenu
    {
        //fields
        private map map1 = new map();
        private Navigation nav = new Navigation();
        private int[] pos = new int[2];
        private bool running = true;
        private char input = '!';
        private character player = new character(5,5,5,5);


        //constructor
        


        //methods
        public void menu()
        {
            while (running)
            {
                Console.WriteLine("You awaken on a cold stone floor. You have no idea who you are or where you are from.");
                Console.WriteLine("Your mind whirls as a flood of information blinds your sences. You can only grasp so much.");
                Console.WriteLine("What visons do you hold on too?\n");
                Console.WriteLine("press W for Warrior, press M for Mage.");
                input = Console.ReadKey().KeyChar;
                Console.Clear();
                input = char.ToUpper(input);
                
                if (input == 'W')
                {   
                    player.modHitPoints(10);
                    player.modSaveBonus(-3);
                    player.modMagic(-5);
                    running = false;
                }
                else if (input == 'M')
                {
                    player.modHitPoints(2);
                    player.modAttBonus(-3);
                    running = false;    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Your incorrect decision causes you to \nblack out once again.\n\nPlease press a key to try again.\n");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
            running = true;
            Console.WriteLine("You stand up and look at your surroundings the room is a square about 20 foot across in both directions and \nhas door in each wall.");
            
            while (running)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nPlease press M to move.\nPlease press C to look at your amazing stats.\nPlease press X to exit the program. ");
                input = Console.ReadKey().KeyChar;
                Console.Clear();
                input = char.ToUpper(input);

                switch (input)
                {
                    case 'M':
                        pos = nav.Move();
                        map1.maplookup(pos[0], pos[1]);
                        break;
                    case 'C':
                        player.showStats();
                        break;
                    case 'X':
                        Console.WriteLine("Be Careful out there. I need your Business.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Did you hit your head, That wasn't an option, \nLet try this again.\nPress a key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
            Console.WriteLine("You are now leaving the Border of Many Lands");
            return;
        }


    }

}