using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        public float X, Y, Z;

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void printPosition()
        {
            Debug.Log(X + ", " + Y + ", " + Z);
        }
    }
}
