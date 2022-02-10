using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualMovementPlayer2 : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(Input.GetAxisRaw("Debug Horizontal") * speed, Input.GetAxisRaw("Debug Vertical") * speed), ForceMode2D.Force);
    }
}
