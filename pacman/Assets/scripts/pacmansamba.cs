using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacmansamba : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.MovePosition(transform.position + Vector3.left * speed *Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
        }
    }
}
