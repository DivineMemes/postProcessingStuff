using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class GettingBloom : MonoBehaviour
{
    PostProcessVolume m_Volume;
    Bloom m_Bloom;
    public float intense;

	void Start ()
    {
        m_Bloom = ScriptableObject.CreateInstance<Bloom>();
        m_Bloom.enabled.Override(true);
        m_Bloom.intensity.Override(intense);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Bloom);
	}
	
	
	void Update ()
    {
        m_Bloom.intensity.value = intense;
	}

    void OnDestroy()
    {
        RuntimeUtilities.DestroyVolume(m_Volume, true, true);
    }
}
