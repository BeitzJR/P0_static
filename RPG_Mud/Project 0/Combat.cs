using System.Collections.Generic;

namespace P0_mud
{

    public class combat
    {
        //fields
        private int round;
        private int charID;
        private Queue<int> initative = new Queue<int>();
        private int participants;
        private Queue<string> Identifier = new Queue<string>();

        //constructors
        public combat(int part, string[] names)
        {
            round = 1;
            charID = 0;
            participants = part;
                        for (int i = 0; i < part; i++)
            {
            Identifier.Enqueue(names[i]);                      
            }
        }


        //methods
       


        
        

    }



}