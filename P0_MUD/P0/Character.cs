namespace P0_mud
{
    class character
    {
        //Feilds
        private int hitPoints;
        private int attBonus;
        private int saveBonus;

        //Constructors
        public character(int hp, int att, int save)
        {
            hitPoints = hp;
            attBonus = att;
            saveBonus = save;
        }
        //Methods
        public void addHitPoints(int change)
        {
            hitPoints += change;
        }

        public int getCurrentHP()
        {
            return hitPoints;
        }

         
    }

}