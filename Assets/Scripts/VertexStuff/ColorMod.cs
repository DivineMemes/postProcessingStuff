using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ColorMod : MonoBehaviour
{
    MeshRenderer mesh;
    public Color Collor;
	void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();
    }
    void Update()
    {
        mesh.material.color = Collor;
    }
}
