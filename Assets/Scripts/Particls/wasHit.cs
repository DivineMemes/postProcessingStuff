using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasHit : MonoBehaviour
{
	void Start ()
    {
		
	}
	
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider.name);
    }

	void Update ()
    {
		
	}
}
