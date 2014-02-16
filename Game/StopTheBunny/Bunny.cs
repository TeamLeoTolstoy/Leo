using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class Bunny : IEnemy
    {
        private char symbol;
        private Color bunnyColor;
        private int health;
        private int positionRow;
        private int positionCol;
        private int entryRow;
        private int entryCol;

//<<<<<<< HEAD
        public Bunny(char symbol, Color color, int health, int entryRow, int entryCol)
        {
            this.Symbol = symbol;
            this.bunnyColor = color;
            this.Health = health;
        }
            
//=======
//        public Bunny(char symbol, Color color, int health, int entryRow, int entryCol)
//        {

////>>>>>>> 993c3ff0ee8f6cc52226eb557ce7ba8d334885d3
//        }

        public int EntryCol
        {
            get { return this.entryCol; }
            set { this.entryCol = value; }
        }
        

        public int EntryRow
        {
            get { return this.entryRow; }
            set { this.entryRow = value; }
        }
        

        public int PositionRow
        {
            get
            {
                return this.positionRow;
            }
            set
            {
                this.positionRow = value;
            }
        }

        public int PositionCol
        {
            get
            {
                return this.positionCol;
            }
            set
            {
                this.positionCol = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }


        public Color BunnyColor
        {
            get { return this.bunnyColor; }
            set { this.bunnyColor = value; }
        }


        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }


        public void Move()
        {
            
        }
    }
}
