using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventPoint : MonoBehaviour {


    void OnCollisionEnter(Collision other)
    {
        //GetComponent<Rigidbody>().isKinematic = true;
        Debug.Log("eventPointに接触！");
        GameObject msg = GameObject.Find("DirectorUI");
        msg.GetComponent<cliAdireUI>().enterRoom();
        //msg.GetComponent<clientBUI>().enterRoom();

    }
    void OnCollisionExit(Collision other)
    {
        //GetComponent<Rigidbody>().isKinematic = false;
        Debug.Log("eventPointから離れる");
        GameObject nullmsg = GameObject.Find("DirectorUI");
        nullmsg.GetComponent<cliAdireUI>().leaveRoom();
        //nullmsg.GetComponent<clientBUI>().leaveRoom();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
