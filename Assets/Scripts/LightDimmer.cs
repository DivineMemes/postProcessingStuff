using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDimmer : MonoBehaviour
{
    Light light;
    public float intense;
    public float time;
    float baseTime;
    float timePercent;
    public bool timeStart = false;
    float startint;
    void Start ()
    {
        light = gameObject.GetComponent<Light>();

	}

    void doDim()
    {
        if(baseTime <= time)
        {
            timePercent = baseTime / time;

            float newstuff = Mathf.Lerp(startint, intense, timePercent);
            light.intensity = newstuff;
        }
    }

    void Update ()
    {
        if (!timeStart && light.intensity != intense)
        {
            timeStart = true;
            startint = light.intensity;
        }
        if(timeStart)
        {
            baseTime += Time.deltaTime;
            doDim();
        }
        if (baseTime >= time)
        {
            baseTime = 0;
            timeStart = false;
        }
    }
}
