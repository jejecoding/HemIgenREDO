using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HemIgenREDO
{
    public class Player
    {
        string name;

        int health;
        int steps;
        int water;
        int damage;
        int thirst;
        int healing;
        int hydration;


        public Map gameMap = new Map();

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
            get { return water; }
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

        public int Healing
        {
            set { healing = value; }
            get { return healing; }
        }

        public int Hydration
        {
            set { hydration = value; }
            get { return hydration; }
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

        public int Hydrate()
        {
            water = water + hydration;
            return water;
        }

        public int Heal()
        {
            health = health + healing;
            return health;
        }

        public int StepTaken()
        {
            return ++steps;
        }

        public void SpecifyMap(TableLayoutPanel container,Control initialControl)
        {
            gameMap.LastControl = initialControl;
            gameMap.PlayerPosX = container.GetCellPosition(initialControl).Column;
            gameMap.PlayerPosY = container.GetCellPosition(initialControl).Row;
        }
    }
}