﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2_1.Classes.Barriers.Dynamic_Barriers
{
    internal class Bee:DynamicBarrier,IBarrier
    {   
        enum Directions
        {
            Right=0, Left=1
        }
        private static int beeId = 1;
        private bool isTurn = false;
        public Bee(Image image): base(beeId,image,"Horizontial", 3)
        {
            beeId++;
            SetBarrierSize();
           
        }

        public int getBarrierHeight()
        {
            return (int)this.GetHeight();
        }

        public int getBarrierWidth()
        {
            return (int)this.GetWidth();
        }

        public void SetBarrierSize()
        {
            this.SetWidth(2);
            this.SetHeight(2);


        }
        public void Move()
        {
            Location location = this.getLocation();
            int x = location.getX(), y = location.getY();

            int currentmove = getCurrentMovedSize();
            if (!isTurn)
            {
                Console.WriteLine("Turn girdi");
                if (currentmove < this.getMaxMove())
                {
                    this.increaseCurrentMovedSize();
                    y++;
                }
                else isTurn = true;
            }
            else
            {
                Console.WriteLine("dış else");
                if (currentmove > (this.getMaxMove() * -1))
                {
                    this.decreaseCurrentMovedSize();
                    y--;
                }
                else isTurn = false;
            }



            this.setLocation(new Location(x, y));

        }


    }
        
    internal class summerBee:Bee
    {
        public summerBee():base(Resources.Summer_Bee)
        {
            
        }

    }
    internal class winterBee:Bee
    {
        public winterBee():base(Resources.Winter_Bee)
        {
            
        }
    }



}
