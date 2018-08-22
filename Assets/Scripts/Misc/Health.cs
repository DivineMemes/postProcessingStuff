using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float StartHealth;
    public float health;
	void Start ()
    {
        health = StartHealth;
	}
	
	void Update ()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
