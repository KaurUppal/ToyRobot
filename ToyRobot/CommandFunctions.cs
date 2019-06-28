using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot
{
    
    public class CommandFunctions
    {
        private int tableBoundryMax = 4;
        private int tableBoundryMin = 0;
        private int xValue;
        public int XValue
        {
            get
            {
                return xValue;
            }
            set
            {
                xValue = value;
            }
        }
        private int yValue;
        public int YValue
        {
            get
            {
                return yValue;
            }
            set
            {
                yValue = value;
            }
        }
        private EnumFaces currentFace;
        public EnumFaces CurrentFace
        {
            get
            {
                return currentFace;
            }
            set
            {
                currentFace = value;
            }
        }

        public bool Place(int x, int y, EnumFaces face)
        {
            if ((x < tableBoundryMin || x > tableBoundryMax) || (y < tableBoundryMin || y > tableBoundryMax))
            {
                return false;
            }
            else
            {
                XValue = x;
                YValue = y;
                CurrentFace = face;
                return true;
            }
            //return true;
        }

        public bool Move()
        {
            var returnValue = true;
            switch (CurrentFace)
            {
                case EnumFaces.NORTH:
                    if(YValue < tableBoundryMax) YValue++;
                    break;
                case EnumFaces.SOUTH:
                    if (YValue > tableBoundryMin) YValue--;
                    break;
                case EnumFaces.WEST:
                    if (XValue > tableBoundryMin) XValue--;
                    break;
                case EnumFaces.EAST:
                    if (XValue < tableBoundryMax) XValue++;
                    break;
                default:
                    returnValue = false;
                    break;
            }
            return returnValue;
        }

        public void Turn(EnumFaces currentface, EnumTurn turn)
        {
            switch (currentFace)
            {
                case EnumFaces.NORTH:
                    if (turn == EnumTurn.LEFT) CurrentFace = EnumFaces.WEST;
                    else CurrentFace = EnumFaces.EAST;
                    break;
                case EnumFaces.EAST:
                    if (turn == EnumTurn.LEFT) CurrentFace = EnumFaces.NORTH;
                    else CurrentFace = EnumFaces.SOUTH;
                    break;
                case EnumFaces.SOUTH:
                    if (turn == EnumTurn.LEFT) CurrentFace = EnumFaces.EAST;
                    else CurrentFace = EnumFaces.WEST;
                    break;
                case EnumFaces.WEST:
                    if (turn == EnumTurn.LEFT) CurrentFace = EnumFaces.SOUTH;
                    else CurrentFace = EnumFaces.NORTH;

                    break;
            }
        }

        public void Report()
        {
            Console.WriteLine("Output: {tableBoundryMin},{1},{2}", XValue, YValue, CurrentFace);
        }      
    }
}
