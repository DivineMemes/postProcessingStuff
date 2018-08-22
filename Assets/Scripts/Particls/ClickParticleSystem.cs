using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickParticleSystem : MonoBehaviour
{
    public ParticleSystem particleLauncher;
    public Gradient particleColorGradient;
    public Vector3 ScreenPoint;

    //List<ParticleCollisionEvent> collisionEvents;

    void Start ()
    {
        //collisionEvents = new List<ParticleCollisionEvent>();
	}

    //void OnParticleCollision(GameObject other)
    //{
    //    ParticlePhysicsExtensions.GetCollisionEvents(particleLauncher, other, collisionEvents);
    //    for(int i = 0; i < collisionEvents.Count; i++)
    //    {
    //        other.gameObject.GetComponent<Health>().health -= .001f;

    //    }
    //}

    void Awake()
    {
        //new ParticleSystem
    }
	void Update ()
    {
        ScreenPoint = Input.mousePosition;
        ScreenPoint.z = 10.0f;
        Vector3 pPoint = transform.position = Camera.main.ScreenToWorldPoint(ScreenPoint);

        if (Input.GetButton("Fire1"))
        {
            ParticleSystem.MainModule psMain = particleLauncher.main;
            psMain.startColor = particleColorGradient.Evaluate(Random.Range(0, 1));
            particleLauncher.transform.position = pPoint;
            particleLauncher.Emit(5);
        }
	}
}
