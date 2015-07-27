using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainInput : MonoBehaviour {
    public bool canInput;
    public InputField textInput;
    public MainParser parser;

	// Use this for initialization
	void Start () {
        textInput.Select();
    }
	
	// Update is called once per frame
	void Update () {
        if (canInput && !textInput.isActiveAndEnabled)
        {
            textInput.gameObject.SetActive(true);
            textInput.Select();
        }
        else if (!canInput && textInput.isActiveAndEnabled)
        {
            textInput.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SubmitText();
        }
        //debug
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            if (canInput)
            {
                canInput = false;
            }
            else
            {
                canInput = true;
            }
        }
	}

    void SubmitText() 
    {
        //parse the string
        string lowerString = textInput.text.ToLower();
        string[] textString = lowerString.Split(' ', '.', '!', '?', ';');
        textInput.text = "";
        parser.Parse(textString);
        //textInput.Select();
        canInput = false;
    }
}
