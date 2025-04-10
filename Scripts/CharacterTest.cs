using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            var s = new Soldier();
            var o = new Officer("Manarr", 88, new Position(1, 2, 3));

            Character[] group = { s, o };

            foreach (var character in group)
            {
                character.DisplayInfo();
            }

            Debug.Log("Before attack, soldier health: " + s.Health);
            o.Attack(25, s, "shoot");
            Debug.Log("After attack, soldier health: " + s.Health);
        }
    }
}
