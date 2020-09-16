using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = transform.forward * Input.GetAxis("Vertical") * velocity * Time.deltaTime;
        transform.Rotate(transform.up, Input.GetAxis("Horizontal") * velocity * Time.deltaTime);
    }
}
