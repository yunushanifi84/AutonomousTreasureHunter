﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2_1.Classes
{
    enum Directions
    {
        Left,Right,
        Top,Bottom
    }
    public class Character
    {
        


        private int Id;
        private string Name;
        private List<Location> VisitedLocations= new List<Location>();
        private Location CurrentLocation;
        private List<Chest> Collected_Chests = new List<Chest>();


        public Character(int id, string name,Location CurrentLocation)
        {
            Id = id;
            Name = name;
            this.CurrentLocation = CurrentLocation;
        }



        public void updateFogRemoveArea(Quad[,] quads)
        {
            int x=CurrentLocation.getX();
            int y=CurrentLocation.getY();
            int width = quads.GetLength(0);
            int height = quads.GetLength(1);
            for (int i = (x+3); i >=(x-3); i--)
            {

                for (int j = (y+3); j >=(y-3); j--)
                {
                    if(i<0 || j<0 || i>=width || j >= height) continue;
                    quads[i, j].removeFog();
                }
            }
            
            
        }
        
        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }

        public void AddVisitedLocation()
        {
            VisitedLocations.Add(new Location(CurrentLocation.getX(),CurrentLocation.getY()));
        }
        public List<Location> GetVisitedLocations()
        {
            return VisitedLocations;
        }
        public Location GetCurrentLocation()
        {
            return CurrentLocation;
        }
        public void CollectChest(Chest chest)
        {
            Collected_Chests.Add(chest);
        }

        public List<Chest> GetCollectedChests()
        {
            return Collected_Chests;
        }

        private int Direction;

        public void automaticallyMove(Quad[,] quads)
        {
            int x = CurrentLocation.getX(),y = CurrentLocation.getY();
            getDirection(quads, x, y);
            updateFogRemoveArea(quads);

            
        }
        public int getDirection(Quad[,] quads,int x,int y)
        {
            int L=-1, R=-1, T=-1, B=-1;

            if(!checkLocation(Directions.Left,quads))
            {
                L = 1;
            }
            if (!checkLocation(Directions.Right, quads))
            {
                R = 2;
            }
            if (!checkLocation(Directions.Top, quads))
            {
                T = 3;
            }
            if (!checkLocation(Directions.Bottom, quads))
            {
                B = 4;
            }

            Random random = new Random();
            int tempDirect = random.Next(1, 5);
            switch(tempDirect)
            {
                case 1:
                    if (tempDirect != L)
                        break;
                    move(tempDirect);
                    Direction = tempDirect;
                    break;
                case 2:
                    if (tempDirect != R)
                        break;
                    move(tempDirect);
                    Direction = tempDirect;
                    break;
                case 3:
                    if (tempDirect != T)
                        break;
                    move(tempDirect);
                    Direction = tempDirect;
                    break;
                case 4:
                    if (tempDirect != B)
                        break;
                    move(tempDirect);
                    Direction = tempDirect;

                    break;
            }
            



            return 0;
        }
        private bool checkLocation(Directions direction, Quad[,] quads)
        {
            int x = CurrentLocation.getX(),y = CurrentLocation.getY();
            bool barrierDetected = false;
            switch(direction)
            {
                case Directions.Left:
                    for(int i =x;i>=x-3;i--)
                    {
                        if (quads[i,y].GetIsBarrier()) barrierDetected=true;
                    }
                    break;
                case Directions.Right:
                    for (int i = x; i <= x + 3; i++)
                    {
                        if (quads[i, y].GetIsBarrier()) barrierDetected = true;
                    }
                    break;
                case Directions.Top:
                    for (int i = y; i >= y - 3; i--)
                    {
                        if (quads[x, i].GetIsBarrier()) barrierDetected = true;
                    }
                    break;
                case Directions.Bottom:
                    for (int i = y; i <= y - 3; i++)
                    {
                        if (quads[x, i].GetIsBarrier()) barrierDetected = true;
                    }
                    break;
            }

            return barrierDetected;

        }



        private void move(int direction, Quad[,] quads)
        {
            int x=CurrentLocation.getX(),y=CurrentLocation.getY();
            AddVisitedLocation();
            
            switch(direction)
            {
                case 1:
                    x--;
                    break;
                case 2:
                    x++;
                    break;
                case 3:
                    y--;
                    break;
                case 4:
                    y++;
                    break;
            }
            CurrentLocation = new Location(x,y);
        }




    }
}
