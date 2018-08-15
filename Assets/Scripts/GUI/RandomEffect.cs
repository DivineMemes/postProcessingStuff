using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine;

public class RandomEffect : MonoBehaviour
{
    //public Button btn;
    public GameObject thing;
    float r;
    float g;
    float b;
    public UnityEvent randCol;
	void Start ()
    {
        thing = GameObject.FindGameObjectWithTag("aye");
        Button btn = gameObject.GetComponent<Button>();

       

       int val = Random.Range(0, 2);
        if(val == 0)
        {
            btn.onClick.AddListener(RandCol);
        }
        else if(val == 1)    
        {
            btn.onClick.AddListener(pushBack);
        }
	}
	void Update()
    {
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);

        if(Input.GetKeyDown(KeyCode.R))
        {
            if(randCol != null)
            {
                randCol.Invoke();
            }
        }
    }

    void RandCol()
    {
        MeshRenderer rend = thing.GetComponent<MeshRenderer>();
        rend.material.color = new Color(r, g, b);
    }
    void pushBack()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        rb.AddExplosionForce(10, this.gameObject.transform.position, 0);
    }
	//void Update ()
 //   {
		
	//}
}
