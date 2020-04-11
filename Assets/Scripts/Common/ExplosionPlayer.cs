using Sirenix.OdinInspector;
using UnityEngine;

namespace Common {
    public class ExplosionPlayer : MonoBehaviour
    {
        [AssetsOnly]
        public GameObject explosionPrefab;

        public void PlayExplosion()
        {
            PlayExplosion(transform.position);
        }

        public void PlayExplosion(float scale)
        {
            PlayExplosion(transform.position, scale);
        }

        public void PlayExplosion(Vector2 position)
        {
            Instantiate(explosionPrefab, position, Quaternion.identity);
        }

        public void PlayExplosion(Vector2 position, float scale)
        {
            GameObject explosion = Instantiate(explosionPrefab, position, Quaternion.identity);
            explosion.transform.localScale = Vector3.one * scale;
        }
    }
}
