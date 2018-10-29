using UnityEngine;

public class Platform : MonoBehaviour {

    private float jumpForce = 10f;
    private bool alreadyScored = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            if (!alreadyScored)
            {
                ScoreHelper.GetInstance().IncrementScore();
                alreadyScored = true;
            }
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
