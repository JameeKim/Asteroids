using Sirenix.OdinInspector;
using UnityEngine;
using Utils;

namespace Asteroids {
    public class AsteroidSpawner : SerializedMonoBehaviour
    {
        [ValidateInput("AllPositive")]
        public Vector2 spawnRangeMin;

        [ValidateInput("AllPositive")]
        [ValidateInput("ValidRange")]
        public Vector2 spawnRangeMax;

        public MinMax<int> spawnCount;

        public AsteroidSettings settings;

        public void SpawnAsteroids()
        {
            int count = RandomExtension.Range(spawnCount);

            for (int i = 0; i < count; i++)
            {
                GameObject prefab = settings.prefabs[Random.Range(0, settings.prefabs.Length)];
                Vector2 position = RandomPosition();
                float angle = Random.Range(0.0f, 360.0f);
                float speed = RandomExtension.Range(settings.speed);
                float moveAngle = Random.Range(0.0f, 2.0f * Mathf.PI);

                GameObject asteroid = Instantiate(prefab, Vector3.zero, Quaternion.identity);
                Rigidbody2D rigidBody = asteroid.GetComponent<Rigidbody2D>();
                rigidBody.position = position;
                rigidBody.rotation = angle;
                rigidBody.velocity = speed * new Vector2(Mathf.Cos(moveAngle), Mathf.Sin(moveAngle));
            }
        }

        private Vector2 RandomPosition()
        {
            int side = Random.Range(0, 4);
            Vector2 result;
            do // FIXME This is a really lazy way to solve the problem...
            {
                result = RandomExtension.Range(Vector2.zero, spawnRangeMax);
            } while (result.x < spawnRangeMin.x && result.y < spawnRangeMin.y);

            switch (side)
            {
                case 0:
                    break;
                case 1:
                    result.x *= -1.0f;
                    break;
                case 2:
                    result.y *= -1.0f;
                    break;
                case 3:
                    result *= -1.0f;
                    break;
            }

            Debug.Log($"Spawned at ({result.x:F2}, {result.y:F2})");
            return result;
        }

#if UNITY_EDITOR
        private bool AllPositive(Vector2 value, ref string msg)
        {
            if (value.x > 0 && value.y > 0)
                return true;

            msg = "The values should be positive numbers";
            return false;
        }

        private bool ValidRange(Vector2 maxValue, ref string msg)
        {
            if (maxValue.x > spawnRangeMin.x && maxValue.y > spawnRangeMin.y)
                return true;

            msg = "The values should be greater than their counterparts in `spawnRangeMin` field";
            return false;
        }
#endif
    }
}
