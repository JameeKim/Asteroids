using UnityEngine;

namespace Common {
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class DestroyOnCollide : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            Destroy(gameObject);
        }
    }
}
