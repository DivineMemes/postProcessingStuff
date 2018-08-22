using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Mesh mesh = gameObject.GetComponent<MeshFilter>().sharedMesh;
        foreach(var vert in mesh.vertices)
        {
            Gizmos.DrawSphere(transform.TransformPoint(vert), 0.1f);
        }
    }

}
