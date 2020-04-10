using UnityEngine;

namespace Teleport {
    [DisallowMultipleComponent]
    public class Sender : MonoBehaviour
    {
        public Transform receiver;

        protected virtual void Send(GameObject entity)
        {
            entity.transform.position += receiver.position - transform.position;
        }
    }
}
