using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Min(1.0f)]
    public float linearAcceleration = 10.0f;

    [Min(0.01f)]
    public float angularAcceleration = 5.0f;

    private Rigidbody2D rigidBody;
    private float rotation;
    private float thrust;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rotation = -Input.GetAxisRaw("Horizontal");
        thrust = Mathf.Max(0.0f, Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        rigidBody.AddTorque(rotation * angularAcceleration, ForceMode2D.Force);
        rigidBody.AddRelativeForce(Vector2.up * (thrust * linearAcceleration), ForceMode2D.Force);
    }
}
