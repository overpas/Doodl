using UnityEngine;

public class PlatformController : MonoBehaviour {

    private float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D collidingBody = collision.collider.GetComponent<Rigidbody2D>();
            if (collidingBody != null)
            {
                Vector2 velocity = collidingBody.velocity;
                velocity.y = jumpForce;
                collidingBody.velocity = velocity;
            }
        }
    }
}
