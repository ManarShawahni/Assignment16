using UnityEngine;

namespace Assignment18
{
    public class Soldier : Character
    {
        public Soldier() : base() { }

        public Soldier(string name, int health, Position pos) : base(name, health, pos) { }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}
