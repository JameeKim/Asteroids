using UnityEngine;
using UnityEngine.Events;

namespace Asteroids {
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class Asteroid : MonoBehaviour
    {
        public AsteroidSettings settings;

        public UnityEvent onCompletelyDestroyed;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Laser"))
            {
                GetDestroyed();
            }
        }

        public void GetDestroyed()
        {
            if (settings.spawnCount > 0)
            {
                // spawn new ones
            }
            else
            {
                onCompletelyDestroyed.Invoke();
            }

            Destroy(gameObject);
        }
    }
}
