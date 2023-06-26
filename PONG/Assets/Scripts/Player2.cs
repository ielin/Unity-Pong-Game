using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float racketSpeed;
    private Vector2 racketDirection;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");
        racketDirection = new Vector2(0, directionY).normalized;

    }

    private void FixedUpdate()
    {
        rb.velocity = racketDirection * racketSpeed;
    }
}
