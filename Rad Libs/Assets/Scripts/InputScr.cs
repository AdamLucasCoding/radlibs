//right now this script takes input and puts out the last word as output
//but it still needs to load input into an array or string
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

 
public class InputScr : MonoBehaviour {
 
    InputField input;
    InputField.SubmitEvent se;
    public Text output;
	public Text outputEnd;
	
	string fullText = "";
	int currentLocation;
     
    void Start () 
	{
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
    }
	
	void Update () 
	{
		outputEnd.text = fullText;
	}
 
    private void SubmitInput(string arg0)
    {
        string newText = arg0;
        output.text = newText;
		fullText += newText + " ";
		//Debug.Log(fullText);
        input.text = "";
        input.ActivateInputField();
    }
     
 
}
