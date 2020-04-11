using Sirenix.OdinInspector;
using UnityEngine;
using Utils;

namespace Asteroids {
    [CreateAssetMenu(fileName = "AsteroidSettings", menuName = "New Asteroid Settings", order = 0)]
    public class AsteroidSettings : SerializedScriptableObject
    {
        public AsteroidSize size;

        public MinMax<float> speed;

        [Space(10.0f)]
        [AssetsOnly]
        [ListDrawerSettings(Expanded = true)]
        public GameObject[] prefabs;

        [Title("Spawn Settings")]
        public int spawnCount;

        [ShowIf("@spawnCount > 0")]
        public AsteroidSettings spawnedAsteroidSettings;
    }
}
