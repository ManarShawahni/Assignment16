using UnityEngine;

namespace Assignment18
{
    public class Officer : Character
    {
        public Officer(string name, int health, Position pos) : base(name, health, pos) { }

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
