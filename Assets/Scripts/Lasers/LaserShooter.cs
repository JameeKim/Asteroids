using Sirenix.OdinInspector;
using UnityEngine;

namespace Lasers {
    public class LaserShooter : MonoBehaviour
    {
        [Min(0.01f)]
        public float shootInterval = 0.1f;

        [AssetsOnly]
        public GameObject laserPrefab;

        private Transform transformCache;

        private float coolDown;

        private void Awake()
        {
            transformCache = transform;
        }

        private void Update()
        {
            if (coolDown > 0.0f)
                coolDown -= Time.deltaTime;

            if (Input.GetButton("Jump") && coolDown <= 0.0f)
                Shoot();
        }

        private void Shoot()
        {
            Instantiate(laserPrefab, transformCache.position, transformCache.rotation);
            coolDown = shootInterval;
        }
    }
}
