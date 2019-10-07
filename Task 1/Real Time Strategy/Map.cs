using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Real_Time_Strategy
{
    class Map
    {
        List<Units> unit;
        List<Units> rangedunits = new List<Units>();
        List<Units> meleeunits = new List<Units>();
        Random r = new Random();
        int unitNumbers;
        
        public List<Units> Unit
        {
           get{ return unit;}
           set{ unit = value; }
        }

        public Map(int t, TextBox txt)
        {
            Unit = new List<Units>();
            unitNumbers = t;
            // The amount of units being created
        }


        public void GenerateUnits()
        {
            for (int i = 0; i < unitNumbers; i++)
            {
                Melee r = new Melee(10, 10, 100, 50, 80, 200, "M", "$", true); //Assigning values to melee unit

                
                meleeunits.Add(r);
            }
            for (int j = 0; j < unitNumbers; j++)
            {
                Ranged_Unit ru = new Ranged_Unit(20, 20, 150, 200, 90, 150, 200, "", "^", true );//Creating a new ranged unit. Adding values to ranged unit
                

                rangedunits.Add(ru);//Knows what to add to the list
                
            }
        }

        

        public void Display(GroupBox gbxMax)
        {

            foreach (Ranged_Unit ru in rangedunits)
            {
                Label lblRange = new Label();
                lblRange.Width = 200;
                lblRange.Height = 200;
                lblRange.Location = new System.Drawing.Point(ru.xPos * 20, ru.ypos * 20);
                lblRange.Text = ru.symbol;

                gbxMax.Controls.Add(lblRange);
            }

            foreach (Melee m in meleeunits)
            {
                Label lblMelee = new Label();
                lblMelee.Width = 200;
                lblMelee.Height = 200;
                lblMelee.Location = new System.Drawing.Point(m.xPos * 20, m.ypos * 20);//How much the positions change
                lblMelee.Text = m.symbol;

                gbxMax.Controls.Add(lblMelee);
            }
        }
    }
}
