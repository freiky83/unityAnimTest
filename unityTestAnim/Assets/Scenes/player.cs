using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Animator anim;
    public Rigidbody rb;

    private float inputH;
    private float inputV;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);


        float moveX = inputH * 50f * Time.deltaTime;
        float moveZ = inputV * 50f * Time.deltaTime;

        rb.velocity = new Vector3(moveX, 0, moveZ);

        /*
        if (Input.GetKey(KeyCode.Z))
        {
            
            anim.Play("Cycle_walk", -1, 0f);

            rb.velocity = new Vector3(0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.Play("Cycle_running", -1, 0f);
            rb.velocity = new Vector3(0, 0, 1.5f);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        */
    }
}
