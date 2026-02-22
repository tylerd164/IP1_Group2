using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PushableBox : MonoBehaviour
{
    [SerializeField] private PlayerStateController playerState;

    [Header("Push Settings")]
    [SerializeField] private float maxPushSpeed = 6f;
    [SerializeField] private float maxFallSpeed = 6f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        LimitHorizontalSpeed();
        ApplyIdleDrag();
    }

    private void LimitHorizontalSpeed()
    {
        if (playerState.movingObject)
        {
            Debug.Log("MovingOb");
            float clampedX = Mathf.Clamp(rb.linearVelocity.x, -maxPushSpeed, maxPushSpeed);
            float clampedY = Mathf.Clamp(rb.linearVelocity.y, -maxFallSpeed, maxFallSpeed);
            rb.linearVelocity = new Vector2(clampedX, clampedY);
        }
    }

    private void ApplyIdleDrag()
    {
        // If object is barely moving horizontally, stop completely
        if (Mathf.Abs(rb.linearVelocity.x) < 0.05f)
        {
            rb.linearVelocity = new Vector2(0f, rb.linearVelocity.y);
        }
    }
}