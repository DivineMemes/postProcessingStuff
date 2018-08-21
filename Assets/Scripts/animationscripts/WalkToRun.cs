using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkToRun : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rb;
    public float speed;
    
	void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody>();
	}

	void Update ()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 Movement = new Vector3(x, 0, y);
        rb.AddForce(Movement * speed);
        float rbSpeed = rb.velocity.magnitude;
        Debug.Log(x + "this is the X" + y + "this is the Y");
        Debug.Log(rbSpeed);

        if(rbSpeed > 0)
        {
            anim.SetTrigger("Walking");
        }
        if(rbSpeed == 0)
        {
            anim.SetTrigger("Idle");
        }
        if(rbSpeed >= 5)
        {
            anim.SetTrigger("Running");
        }
	}
}
