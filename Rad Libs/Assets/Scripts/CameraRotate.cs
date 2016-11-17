using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class CameraRotate : MonoBehaviour {
	private static float time;
	
	void Awake ()
	{
		time = Timer.timeLimit;
	}
	
	void Update () 
	{
		time -= Time.deltaTime;
		
		if (time < 0)
			{
				transform.position = new Vector3(5.65f, 0f, 0f);
				time = 9999;
			}
		//}
	}
}
