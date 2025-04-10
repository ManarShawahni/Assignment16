using UnityEngine;

namespace Assignment18
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0) health = 0;
                else if (value > 100) health = 100;
                else health = value;
            }
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }


        public Character(string n, int h, Position pos)
        {
            name = n;
            Health = h;
            position = pos;
        }

        public virtual void DisplayInfo()
        {
            Debug.Log("Character: " + name);
            Debug.Log("Health: " + Health);
            position.printPosition();
        }

        public void Attack(int amount, Character target)
        {
            DoDamage(amount, target);
        }


        public void Attack(int amount, Character target, string kind)
        {
            DoDamage(amount, target);
            Debug.Log("Attack Type: " + kind);
        }

        void DoDamage(int amount, Character target)
        {
            target.Health -= amount;
        }
    }
}
