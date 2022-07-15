using System;

namespace P0_mud
{

    class Navigation
    {
        //Feilds
        private int[] Location = new int[] {2,2};
        private char choice = ' ';
        bool valid = false;
        //Constructor
        //  Currently using default 
        //not sure if needs a different constructor


        //Methods

        public int[] Move()
        {
                      
            do
            {
                if (Location[1] != 3){
                    Console.WriteLine("Press N to go North");}
                if (Location[0] != 3){
                    Console.WriteLine("Press E to go East");}
                if (Location[1] != 0){
                    Console.WriteLine("Press S to go South");}
                if (Location[0] != 0){
                    Console.WriteLine("Press W to go West");}
                Console.WriteLine("");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine(choice);
                choice = char.ToUpper(choice);
                Console.WriteLine(choice);

                if (choice == 'N'){
                    Location[1]++;
                    valid = true;
                    Console.WriteLine("\n" + valid);
                    }
                if (choice == 'S'){
                    Location[1]--;
                    valid = true;
                }
                if (choice == 'E'){
                    Location[0]++;
                    valid = true;
                    }
                if (choice == 'W'){
                    Location[0]--;
                    valid = true;
                }
                
        
                
            }while (!valid);
            valid = false;
            return Location;

        }   


        
    }



}