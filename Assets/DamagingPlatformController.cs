using UnityEngine;

public class DamagingPlatformController : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y >= 0f)
        {
            Rigidbody2D collidingBody = collision.collider.GetComponent<Rigidbody2D>();
            if (collidingBody != null)
            {
                DeathController.Kill();
            }
        }
    }
}
