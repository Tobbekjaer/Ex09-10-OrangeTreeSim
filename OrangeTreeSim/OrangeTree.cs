
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        // Fields --> private fields, has public properties below 
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        // Properties for the fields
        public int Age // Property
        {
            
            // Gets a value and returns an int value of Age
            get { return age; } // Get age 

            set
            {   // Age cannot be set to a negative number
                if (value >= 0) {
                    age = value; // Set age
                } 
            }
        }

        public int Height // Property
        {
            // Gets a value and returns an int value of Height
            get { return height; } // Get height 
            set { height = value; } // Set height
        }

        public bool TreeAlive // Property
        {
            // Gets a value and returns a boolean value of TreeAlive
            get { return treeAlive; } // Get treeAlive 
            set { treeAlive = value; } // Set treeAlive 
        }

        public int NumOranges // Property
        {
            // Returns an int value of NumOranges
            get { return numOranges; } // Get numOranges 
        }

        public int OrangesEaten // Property
        {
            // Returns an int value of OrangesEaten
            get {return orangesEaten; } // Get orangesEaten 
        }



        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}

        //public int GetAge()
        //{
        //    return age;
        //}

        //public void SetHeight(int height)
        //{
        //    this.height = height;
        //}

        //public int GetHeight()
        //{
        //    return height;
        //}

        //public void SetTreeAlive(bool treeAlive)
        //{
        //    this.treeAlive = treeAlive;
        //}

        //public bool GetTreeAlive()
        //{
        //    return treeAlive;
        //}

        //public int GetNumOranges()
        //{
        //    return numOranges;
        //}

        public int GetOrangesEaten()
        {
            return this.orangesEaten;
        }

        public void OneYearPasses()
        {
            // Hver gang metoden kører øges alderen med 1.
            age++;

            // Hver gang der går et år øges træets højde med to. Hvis alderen er over 80 dør træet.
            if (age < 80) {
                height = height + 2;
            }
            else {
                treeAlive = false;
            }

            /* Antallet af appelsiner øges med 5 per år og ganges med alderen - 1. Da appelsinerne giver 5 appelsiner sit andet år
             * og nul appelsiner sit første år. */
            if (age > 1 && treeAlive) {
                numOranges = 5 * (age - 1);
            }
            else {
                numOranges = 0;
            }

        }

        public int EatOrange(int count)
        {
            if (age > 80) {
                orangesEaten = 0;
            }
            else if (count <= numOranges) {
                // Hver gang vi spiser en appelsin bliver orangesEaten plusset til count 
                this.orangesEaten += count;
                // Hver gang vi spiser en appelsin bliver count trukket fra numOranges
                this.numOranges -= count;
            }
            else if (count == 0) {
                orangesEaten = 0;
            }

            return orangesEaten;
        }




    }
}

