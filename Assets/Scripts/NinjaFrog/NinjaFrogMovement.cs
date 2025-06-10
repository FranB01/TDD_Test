using UnityEngine;

namespace NinjaFrog
{
    public class NinjaFrogMovement : MonoBehaviour
    {
        private Rigidbody2D rb;
        private bool isGrounded = false;
        public NinjaFrogStats stats = new();

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
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Coin"))
            {
                stats.coins += 1;
                Destroy(collision.gameObject);
            }
        }


    }
}