namespace P0_mud
{
    class character
    {
        //Feilds
        protected int hitPoints;
        protected int attBonus;
        protected int saveBonus;
        protected int magicPool;

        //Constructors
        public character(int hp, int att, int save, int mp)
        {
            hitPoints = hp;
            attBonus = att;
            saveBonus = save;
            magicPool = mp;
        }
        
        //Methods

        //modifies the current hitpoints
        public void modHitPoints(int change)
        {
            hitPoints += change;
        }

        //returns the current hit point total
        public virtual int getCurrentHP()
        {
            return hitPoints;
        }

        //permanently modifies Attack Bonus 
        public virtual void modAttBonus(int change)
        {
            if ((attBonus + change) >= 0)
            {
                attBonus += change;
            }
            else
            {
                throw new ArgumentException("Bonus is less than 0", nameof(attBonus)); 
            }
        }

        //returns the current permanent attack bonus
        public int getAttBonus()
        {
            return attBonus;
        }

        //permanently modifies the save bonus
        public void modSaveBonus(int change)
        {
            if ((saveBonus + change) >= 0)
            {
                saveBonus += change;
            }
            else
            {
                throw new ArgumentException("Bonus is less than 0", nameof(saveBonus)); 
            }   
        }
        //returns the current permanent save bonus
        public int getSaveBonus()
        {
            return saveBonus;
        }
        public void modMagic(int change)
        {
            magicPool += change;
        }

        //returns the current hit point total
        public virtual int getCurrentMP()
        {
            return magicPool;
        }
        public void showStats()
        {
            Console.WriteLine("Hit Points = " + hitPoints + "\nAttack Bonus = " + attBonus + "\nSave Bonus = " + saveBonus + "\nMagic Pool = " + magicPool + "\n\n");
        }
    }   
}