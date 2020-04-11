using UnityEngine;

namespace Common {
    public class SelfDestroyer : MonoBehaviour
    {
        public void DestroySelf()
        {
            Destroy(gameObject);
        }
    }
}
