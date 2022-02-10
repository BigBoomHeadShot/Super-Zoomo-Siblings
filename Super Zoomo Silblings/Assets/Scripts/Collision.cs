using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float LDrag;
    private Rigidbody2D rb;
    public float dmg;
    public Rigidbody2D rbThis;
    private int i;
    public AudioClip smash; 

    private void Start()
    {
        rbThis.drag = LDrag;
        GetComponent<AudioSource>().clip = smash;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.drag = LDrag - dmg;
        i++;
        dmg = dmg + i;
        GetComponent<AudioSource>().Play();

    }
}
