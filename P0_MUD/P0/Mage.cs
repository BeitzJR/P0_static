namespace P0_mud
{
    class mage : character
    {
        //fields
        private int magicPool;
        //constructors
        public mage() 
        {
            hitPoints = 5;
            attBonus = 3;
            saveBonus = 5;
            magicPool = 5;
        }

        //methods
        public void modMP(int change)
        {
            magicPool += change;
        }

        public int getMP()
        {
            return magicPool;
        }

    }


}