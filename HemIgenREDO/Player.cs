using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HemIgenREDO
{
    public class Player
    {
        private string name;
        private int health;
        private int steps;
        private int water;
        int damage = 5;
        int thirst = 5;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Health
        {
            set { health = value; }
            get { return health; }
        }

        public int Steps
        {
            set { steps = value; }
            get { return steps; }
        }

        public int Water
        {
            set { water = value; }
            get { return Water; }
        }

        public int Thirst
        {
            set { thirst = value; }
            get { return thirst; }
        }

        public int Damage
        {
            set { damage = value; }
            get { return damage; }
        }

        public int DamageTaken()
        {
            health = health - Damage;
            return health;
        }
        public int ThirstTaken()
        {
            water = water - Thirst;
            return water;
        }
        public int StepTaken()
        {
            return ++steps;
        }
    }
}