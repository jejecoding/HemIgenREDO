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
        int level;
        int damage;
        int healing;
        EnumDifficulty difficulty;

        public Player()
        {

        }

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

        public int Level
        {
            set { level = value; }
            get { return level; }
        }

        public EnumDifficulty Difficulty
        {
            set { difficulty = value; }
            get { return difficulty; }
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

        public int DamageTaken()
        {
            health = health - Damage;
            return health;
        }

        public int LevelUp()
        {
            return ++level;
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
    }
}