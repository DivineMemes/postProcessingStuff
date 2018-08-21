using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationConditions : MonoBehaviour
{
    public Animator anim;
	void Start ()
    {
        //anim = GetComponent<Animator>();
	}

    public void Reset()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        bool Pose1 = Input.GetKeyDown(KeyCode.A);
        bool Pose2 = Input.GetKeyDown(KeyCode.W);
        bool Pose3 = Input.GetKeyDown(KeyCode.D);

        if(Pose1)
        {
            anim.SetTrigger("Anim1");
        }
        if (Pose2)
        {
            anim.SetTrigger("Anim2");
        }
        if (Pose3)
        {
            anim.SetTrigger("Anim3");
        }

    }
}
