namespace P0_mud
{
    class character
    {
        //Feilds
        private int hitPoints;
        private int attBonus;
        private int saveBonus;

        //Constructors
        public virtual void build(int hp, int att, int save)
        {
            hitPoints = hp;
            attBonus = att;
            saveBonus = save;
        }
        //Methods

        //modifies the current hitpoints
        public virtual void modHitPoints(int change)
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
        public virtual int getAttBonus()
        {
            return attBonus;
        }

        //permanently modifies the save bonus
        public virtual void modSaveBonus(int change)
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
        public virtual int getSaveBonus()
        {
            return saveBonus;
        }
    }   



}