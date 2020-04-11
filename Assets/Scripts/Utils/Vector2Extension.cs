using UnityEngine;

namespace Utils
{
    public static class Vector2Extension
    {
        public static Vector2 FromAngle(float angle) => new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        public static Vector2 Rotated(this Vector2 vector, float angle)
        {
            Vector2 rotation = FromAngle(angle);
            return new Vector2(
                vector.x * rotation.x - vector.y * rotation.y,
                vector.y * rotation.x + vector.x * rotation.y);
        }
    }
}
