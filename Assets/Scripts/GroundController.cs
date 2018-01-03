using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {
    public GameObject element;

	// Use this for initialization
	void Start () {
        //產生草原
        if(element != null)
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    GameObject extendGrassLand = Instantiate(element);
                    extendGrassLand.transform.localPosition = transform.localPosition + 200 * i * Vector3.forward + 200 * j * Vector3.right;
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
