using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputGetter : MonoBehaviour {

	public InputField CommsInput;
	public GameObject OscComms;
	//public GameObject main;

	public void Start ()
	{
		InputField CommsInput = this.GetComponent<InputField> ();
		CommsInput.ActivateInputField ();
		CommsInput.onEndEdit.AddListener (delegate {newInputReceived (CommsInput);});
	}

	public void newInputReceived (InputField comms)
	{
		OscComms.GetComponent<oscComms>().sendOscMessage(comms.text);
		Debug.Log(comms.text);
		comms.text = "";
		comms.ActivateInputField ();
	}
}