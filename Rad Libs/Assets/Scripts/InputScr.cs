//right now this script takes input and puts out the last word as output
//but it still needs to load input into an array or string
using UnityEngine;
using System.Collections;
using UnityEngine.UI;using System;
using System.Collections.Generic;

 
public class InputScr : MonoBehaviour {
 
    InputField input;
    InputField.SubmitEvent se;
    public Text output;
	string fullText = "";
     
    void Start () {
        input = gameObject.GetComponent<InputField>();//input is what goes in the input box
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
    }
 
    private void SubmitInput(string arg0)
    {
        string newText = arg0;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
    }
     
 
}
