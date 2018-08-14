using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagon : MonoBehaviour
{
    void Start()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();

        filter.mesh = mesh;

        var verts = new Vector3[6];
        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(1, 0, 0);
        verts[2] = new Vector3(1.4f, 1f, 0);
        verts[3] = new Vector3(0.5f, 1.7f, 0);
        verts[4] = new Vector3(-0.4f, 1f, 0);

        verts[5] = new Vector3(0.5f, 1, 0);
        mesh.vertices = verts;

        var indices = new int[15];

        indices[0] = 0;
        indices[1] = 5;
        indices[2] = 1;

        indices[3] = 1;
        indices[4] = 5;
        indices[5] = 2;

        indices[6] = 2;
        indices[7] = 5;
        indices[8] = 3;

        indices[9] = 3;
        indices[10] = 5;
        indices[11] = 4;

        indices[12] = 4;
        indices[13] = 5;
        indices[14] = 0;

        mesh.triangles = indices;

        //var norms = new Vector3[3];


        //mesh.normals = norms;

        var UVs = new Vector2[6];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(1, 0);
        UVs[2] = new Vector2(1.4f, 1);
        UVs[3] = new Vector2(0.5f, 1.7f);
        UVs[4] = new Vector2(-0.4f, 1f);
        UVs[5] = new Vector2(0.5f, 1);
        mesh.uv = UVs;
    }
	
}
