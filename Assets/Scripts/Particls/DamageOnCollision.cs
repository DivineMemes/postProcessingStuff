using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public ParticleSystem particleLauncher;
    List<ParticleCollisionEvent> collisionEvents;
    void Start ()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
    }
    void OnParticleCollision(GameObject other)
    {
        ParticlePhysicsExtensions.GetCollisionEvents(particleLauncher, other, collisionEvents);
        for (int i = 0; i < collisionEvents.Count; i++)
        {
            gameObject.GetComponent<Health>().health -= .001f;
        }
    }
}
