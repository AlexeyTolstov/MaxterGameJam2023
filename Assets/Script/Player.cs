using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * speed, rb.velocity.y);
    }
}
