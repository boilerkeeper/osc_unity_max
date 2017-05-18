using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SharpOSC;

public class oscComms : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var message = new SharpOSC.OscMessage ("/note", 60, 100, 1000);
		var sender = new SharpOSC.UDPSender ("127.0.0.1", 9000);
		sender.Send (message);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void sendOscMessage (string mess){
		Debug.Log ("sendOscMessage");
		var message = new SharpOSC.OscMessage (mess);
		var sender = new SharpOSC.UDPSender ("127.0.0.1", 9000);
		sender.Send (message);
	}
}