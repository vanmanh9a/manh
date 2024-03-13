using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    public Animator anima;
    private Rigidbody rb;
    public LayerMask layerMask;
    public bool grounded;
    public float moveForce = 0.5f; // Adjust this value to control the movement force
    public float maxSpeed = 2f;   // Adjust this value to control the maximum speed of the player

    //public float rotationSpeed = 1000f;


    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    //private void FixedUpdate()
    //{
    //    Grounded();
    //    Jump();
    //    Move();
    //}
    public void Update()
    {
        Grounded();
        Jump();
        Move();
        

    }
    // Update is called once per frame
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.grounded)
        {
            this.rb.AddForce(Vector3.up * 3, ForceMode.Impulse);
            this.anima.SetBool("jump", true);

        }

    }

    private void Grounded()
    {
        if (Physics.CheckSphere(this.transform.position + Vector3.down, 0.2f, layerMask) ) 
        {
            this.grounded = true;
            this.anima.SetBool("jump", false);
        }
        else
        {
            this.grounded = false;
            //this.anima.SetBool("jump", true);
        }

        
    }
    private void Move()
    {
        

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply force to the Rigidbody
        rb.AddForce(movement * moveForce);

        // Limiting the maximum velocity to maintain control
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        anima.SetFloat("vertical", moveVertical);
        anima.SetFloat("horizontal", moveHorizontal);
    }


}
