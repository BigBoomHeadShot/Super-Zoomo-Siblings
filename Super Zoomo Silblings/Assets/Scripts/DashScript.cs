using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    [SerializeField] private float chargeRate = 0f;
    [SerializeField] private float maxCharge = 0f;
    [SerializeField] private float dashPower = 0f;
    private float currentCharge;
    private Vector2 velocity;
    private bool isCharging = false;
    // Start is called before the first frame update
    void Start()
    {
        currentCharge = 0f;

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Comma) && currentCharge < maxCharge)
        {
            isCharging = true;
        }
        else
        {
            isCharging = false;
        }
        if (Input.GetKeyUp(KeyCode.Comma) && currentCharge > 0)
        {
            velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            GetComponent<Rigidbody2D>().AddForce(velocity * currentCharge * dashPower);
            Debug.Log(currentCharge);
            currentCharge = 0f;
        }
    }
    private void FixedUpdate()
    {
        if (isCharging == true)
        {
            currentCharge += chargeRate;
        }
    }
}
