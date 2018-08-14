using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
{
     void Start()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();

        filter.mesh = mesh;

        var verts = new Vector3[6];
        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(1, 0, 0);
        verts[2] = new Vector3(0, 1, 0);
        verts[3] = new Vector3(1, 1, 0);
        verts[4] = new Vector3(1, 0, 0);
        verts[5] = new Vector3(0, 1, 0);
        mesh.vertices = verts;

        var indices = new int[6];

        indices[0] = 0;
        indices[1] = 2;
        indices[2] = 1;
        indices[3] = 3;
        indices[4] = 4;
        indices[5] = 5;
        mesh.triangles = indices;

    }
}
