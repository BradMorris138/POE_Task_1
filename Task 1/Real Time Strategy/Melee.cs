using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Strategy
{
    class Melee : Units
    {
        

        public override/*Overrides Conflict in unit class*/ void Conflict(Units Attacking)//Calculating Attack Damage. Accessing actual damage in unit class.
        {
            if(Attacking is Melee)
            {
                health = health - ((Melee)Attacking).attack;
            }
            else if(Attacking is Ranged_Unit)
            {
                Ranged_Unit r = (Ranged_Unit)Attacking;
                health = health - (r.attack - r.ackrange);
            }
            
        }

        public override/*Overrides AckRange in unit class*/ bool ConflictRange(Units other)//Calculating the range the weapon can go 
        {
            int distance = 0;
            int otherX = 0;
            int otherY = 0;
            if (other is Melee)
            {
                otherX = ((Melee)other).xPos;
                otherY = ((Melee)other).ypos;
            }
            else if (other is Ranged_Unit)
            {
                otherX = ((Ranged_Unit)other).xPos;
                otherY = ((Ranged_Unit)other).ypos;
            }


            if (distance <= ackrange)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override (Units,int)Closest(List<Units> units)//Calculating where the players will return to Accessing actual damage in  unit class
        {
            int nearest = 50;
            Units closest = this; //These indicate the closest unit and its distance

            foreach (Units u in units)
            {
                if (u is Melee)
                {
                    Melee diffMu = (Melee)u;
                    int dist = Math.Abs(this.xPos - diffMu.xPos) + (this.ypos - diffMu.ypos);

                    if (dist < nearest)
                    {
                        nearest = dist;
                        closest = diffMu;
                    }


                }

                else if (u is Ranged_Unit)
                {
                    Ranged_Unit diffRu = (Ranged_Unit)u;
                    int dist = Math.Abs(this.xPos - diffRu.xPos) + (this.ypos - diffRu.ypos);

                    if (dist < nearest)
                    {
                        nearest = dist;
                        closest = diffRu;
                    }
                }

            }
            return (closest, nearest);
        }

        public override/*Overrides  Destroy in unit class*/ void Destroy()//Calculating damage 
        {
            
        }

        public Melee(int posx, int posy, int health, int rspeed,int attack, int ackrange, string team, string symbol, bool atck)//Declaring constructor
        {
            XPos = posx;
            YPos = posy;
            Health = health;
            RSpeed = rspeed;
            Attack = attack;
            AckRange = ackrange;
            Team = team;
            Symbol = symbol;
        }
        Random r = new Random();

        

        public int xPos
        {
            get { return base.XPos; }
            set { XPos = value; }
        }

       

        public int ypos
        {
            get { return base.YPos; }
            set { YPos = value; }
        }

        

      

        public int health
        {
            get { return base.Health; }
            set { Health = value; }
        }

        

        public int maxhealth//Max Health
        {
            get { return base.MaxHealth; }
        }

        

        public int rspeed
        {
            get { return base.RSpeed; }
            set { RSpeed = value; }
        }

        

        public int attack
        {
            get { return base.Attack; }
            set { Attack = value; }
        }

        

        public int ackrange
        {
            get { return base.AckRange; }
            set { AckRange = value; }
        }

        

        public string team
        {
            get { return base.Team; }
            set { Team = value; }
        }

        public string symbol
        {
            get { return base.Symbol; }
            set { Symbol = value; }
        }

        public bool Attacking
        {
            get { return base.attacking; }
            set { attacking = value; }
        }

        public override void Move(Directions d)//Actual coding of movement
        {
            int directions = r.Next(0, 4);
            switch (d)
            {
                case Directions.North:
                    YPos--;
                    break;
                case Directions.East:
                    XPos++;
                    break;
                case Directions.South:
                    YPos++;
                    break;
                case Directions.West:
                    XPos--;
                    break;
                default:
                    break;
            }
        }








    }
}
