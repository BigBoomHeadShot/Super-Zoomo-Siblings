using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private GameObject otherPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.up = otherPlayer.transform.position - transform.position;
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed), ForceMode2D.Force);
    }
}
