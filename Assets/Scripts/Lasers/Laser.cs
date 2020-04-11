using UnityEngine;

namespace Lasers {
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Laser : MonoBehaviour
    {
        [Min(1.0f)]
        public float speed = 5.0f;

        private void Start()
        {
            Vector2 forward = transform.rotation * Vector3.up;
            GetComponent<Rigidbody2D>().velocity = speed * forward;
        }
    }
}
