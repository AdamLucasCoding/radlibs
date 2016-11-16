using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class CameraRotate : MonoBehaviour {
	private static float time = Timer.timeLimit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//while (over < 1)
		//{
			time -= Time.deltaTime;
			if (time < 0)
				{
					transform.position = new Vector3(5.65f, 0f, 0f);
					time = 999;
				}
		//}
	}
}
