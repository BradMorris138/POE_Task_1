using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Strategy
{
    public enum Directions
    {
        North,
        South,
        East,
        West
    }
    public abstract class Units// Base class
     {
        protected int XPos, YPos;
        protected int Health;
        protected int MaxHealth;
        protected int RSpeed; //Round speed
        protected  int Attack;
        protected int AckRange;
        protected string Team;
        protected string Symbol;
        protected bool attacking;

      public abstract void Move(Directions d);//Actual method which moves it around. Directions d is the update.



        public abstract void Conflict(Units attacker);

        public abstract bool ConflictRange(Units other);

        public abstract (Units, int)Closest(List<Units> unit);

        public abstract void Destroy();

        public override string ToString()//Overriding the ToString() Method
        {
            return "Units" + "(" + XPos + " ," + YPos + ")" + Health + "," + MaxHealth + "," + RSpeed + "," + AckRange + ","+ Symbol;       
        }

        
     }
}
