namespace P0_mud
{
    class mage : character
    {
        //fields
        private int magicPool;
        private int hp = 5;
        private int att = 3;
        private int save = 5;
        //constructors
        public mage() 
        {
            hitPoints = hp;
            attBonus = att;
            saveBonus = save;
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