using UnityEngine;
using UnityEngine.Events;

namespace Player {
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class PlayerShip : MonoBehaviour
    {
        public LayerMask getDestroyedLayerMask;

        public UnityEvent onHit;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if ((1 << other.gameObject.layer & getDestroyedLayerMask) > 0)
                onHit.Invoke();
        }
    }
}
