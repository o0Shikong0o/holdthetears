using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHead : MonoBehaviour {
	public Transform neck;
	private Vector3 currentNeckAngle;
	// Use this for initialization
	void Start () {
		currentNeckAngle = new Vector3 (0,0,0);
		Cursor.lockState = CursorLockMode.Locked;
	}

	// LateUpdate is called once per frame, right before the camera draws
	void LateUpdate () {
        
		currentNeckAngle.x += Input.GetAxis("Mouse X"); //mousex goes from -1 to 1
		currentNeckAngle.z -= Input.GetAxis("Mouse Y"); //mousex goes from -1 to 1

        if (currentNeckAngle.x >= 30)
        {
            currentNeckAngle.x = 30;
        }
        else if (currentNeckAngle.x <= -30)
        {
            currentNeckAngle.x = -30;
        }

        if (currentNeckAngle.z >= 10)
        {
            currentNeckAngle.z = 10;
        }
        else if (currentNeckAngle.z <= -60)
        {
            currentNeckAngle.z = -60;
        }

        neck.localEulerAngles = currentNeckAngle; //copy it back to the transform
	}
}
