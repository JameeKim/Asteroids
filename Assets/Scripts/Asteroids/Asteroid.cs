using Sirenix.OdinInspector;
using UnityEngine;

namespace Asteroids {
    [DisallowMultipleComponent]
    public class Asteroid : MonoBehaviour
    {
        public AsteroidSettings settings;

        public void GetDestroyed()
        {
            if (settings.spawnCount > 0)
            {
                // spawn new ones
            }

            Destroy(gameObject);
        }
    }
}
