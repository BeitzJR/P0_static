namespace P0_mud
{
    class warrior : character
    {
        //fields
       
        //constructors
        public warrior() 
        {
            hitPoints = 15;
            attBonus = 5;
            saveBonus = 2;    
        }

        //methods
        public void showStats()
        {
            Console.WriteLine("Hit Points = " + hitPoints + "\n Attack Bonus = " + attBonus + "\nSave Bonus = " + saveBonus + "\n\n");
        }
    }


}