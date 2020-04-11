using UnityEngine;

namespace Utils
{
    public static class RandomExtension
    {
        public static Vector2 Range(Vector2 a, Vector2 b)
        {
            return new Vector2(Random.Range(a.x, b.x), Random.Range(a.y, b.y));
        }

        public static int Range(MinMax<int> minMax) => Random.Range(minMax.min, minMax.max + 1);

        public static float Range(MinMax<float> minMax) => Random.Range(minMax.min, minMax.max);
    }
}
