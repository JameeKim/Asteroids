using UnityEngine;

namespace Teleport {
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class ColliderSender : Sender
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            TeleportingEntity entity = other.GetComponent<TeleportingEntity>();
            if (entity == null)
                return;

            Send(other.gameObject);
        }

        protected override void Send(GameObject entity)
        {
            Rigidbody2D rigidBody = entity.GetComponent<Rigidbody2D>();
            if (rigidBody == null)
                return;

            rigidBody.position += (Vector2) receiver.position - (Vector2) transform.position;
        }
    }
}
