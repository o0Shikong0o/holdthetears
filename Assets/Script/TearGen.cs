using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearGen : MonoBehaviour {

    public GameObject tear;
    float timeCount = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeCount += 0.01f;
        if (timeCount >= 1)
        {
            timeCount = 0;
            Instantiate(tear, transform.position, Quaternion.identity);
        }

    }
}
