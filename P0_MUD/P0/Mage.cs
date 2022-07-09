namespace P0_mud
{
    class mage : character
    {
        //fields
        private int magicPool;

        //constructors
        public void build()
        {
            modHitPoints(5);
            modAttBonus(3);
            modSaveBonus(5);
            magicPool = 5;
        }

        //methods
        

    }


}