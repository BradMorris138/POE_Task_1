using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;//Allow to write to serialized file
using System.IO;

namespace Real_Time_Strategy
{
    class Game_Engine
    {
        Map map;
        private int round;
        Random r = new Random();
        GroupBox MapDisp;

        public int Round
        {
            get { return round; }
        }

        public Game_Engine(int amountUnits, TextBox txtInfo, GroupBox grpMap)
        {
            MapDisp = grpMap;
            map = new Map(amountUnits, txtInfo);
            map.GenerateUnits();
            map.Display(MapDisp);
            round = 1;
        }

        public void Update()
        {
            
            for (int i = 0; i < map.Unit.Count; i++)
            {
                if (map.Unit[i] is Melee)
                {
                    Melee mu = (Melee)map.Unit[i];
                    if (mu.health <= mu.maxhealth * 25 / 100 * 100)
                    {
                        mu.Move((Directions)r.Next(0, 4));
                    }
                    else
                    {
                        (Units closest, int dist) = mu.Closest(map.Unit);


                        if (dist <= mu.ackrange)
                        {
                            mu.Attacking = true;
                            mu.Conflict(closest);
                        }
                        else
                        {
                            if (closest is Melee closestmu)
                            {
                                Melee closestMu = (Melee)closest;
                                if (mu.xPos > closestMu.xPos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.xPos < closestMu.xPos) //South
                                {
                                    mu.Move((Directions)2);
                                }
                                else if (mu.ypos > closestMu.ypos) //West
                                {
                                    mu.Move((Directions)3);
                                }
                                else if (mu.ypos < closestMu.ypos) //East
                                {
                                    mu.Move((Directions)1);
                                }
                            }
                            else if (closest is Ranged_Unit)
                            {
                                Ranged_Unit closeRu = (Ranged_Unit)closest;
                                if (mu.xPos > closeRu.xPos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.xPos < closeRu.xPos) //South
                                {
                                    mu.Move((Directions)2);
                                }
                                else if (mu.ypos > closeRu.ypos) //West
                                {
                                    mu.Move((Directions)3);
                                }
                                else if (mu.ypos < closeRu.ypos) //East
                                {
                                    mu.Move((Directions)1);
                                }
                            }
                        }

                    }
                }
                else if (map.Unit[i] is Ranged_Unit)
                {
                    Ranged_Unit ru = (Ranged_Unit)map.Unit[i];

                    (Units closest, int distanceTo) = ru.Closest(map.Unit);

                    //Check In Range
                    if (distanceTo <= ru.ackrange)
                    {
                        ru.Attacking = true;
                        ru.Conflict(closest);
                    }
                    else //Move Towards
                    {
                        if (closest is Melee)
                        {
                            Melee closestMu = (Melee)closest;
                            if (ru.xPos > closestMu.xPos) //North
                            {
                                ru.Move(0);
                            }
                            else if (ru.xPos < closestMu.xPos) //South
                            {
                                ru.Move((Directions)2);
                            }
                            else if (ru.ypos > closestMu.ypos) //West
                            {
                                ru.Move((Directions)3);
                            }
                            else if (ru.ypos < closestMu.ypos) //East
                            {
                                ru.Move((Directions)1);
                            }
                        }
                        else if (closest is Ranged_Unit)
                        {
                            Ranged_Unit closestRu = (Ranged_Unit)closest;
                            if (ru.xPos > closestRu.xPos) //North
                            {
                                ru.Move(0);
                            }
                            else if (ru.xPos < closestRu.xPos) //South 
                            {
                                ru.Move((Directions)2);
                            }
                            else if (ru.ypos > closestRu.ypos) //West
                            {
                                ru.Move((Directions)3);
                            }
                            else if (ru.ypos < closestRu.ypos) //East
                            {
                                ru.Move((Directions)1);
                            }
                        }
                    }



                }
            }
            map.Display(MapDisp);
            round++;
        }







    }
}

