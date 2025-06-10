using UnityEngine;

namespace NinjaFrog
{
    public class NinjaFrogMovement : MonoBehaviour
    {
        private Rigidbody2D rb;
        private bool isGrounded = false;
        private NinjaFrogStats stats = new();

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
            else if (collision.gameObject.CompareTag("Coin"))
            {
                stats.coins += 1;
                Destroy(collision.gameObject);
            }
        }


    }
}