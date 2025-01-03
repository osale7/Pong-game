using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;


    private void OnCollisionEnter2D(Collision2D collision)

    {
        ball ball = collision.gameObject.GetComponent<ball>();

        if (ball != null)

        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }

    }
}




   