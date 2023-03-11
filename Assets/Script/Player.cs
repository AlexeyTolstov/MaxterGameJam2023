using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    [SerializeField] float speed;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * speed, rb.velocity.y);
        sr.flipX = hor > 0;
    }
}
